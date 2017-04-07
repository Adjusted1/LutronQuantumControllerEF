using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LutronControl.Controllers;
using LutronControl.Extensions;
using LutronControl.Models;
using SkyWallGUI.Wizards;
using System.IO;
using System.Threading;
//using Lutron.Gulliver.DomainObjects;

namespace SkyWallGUI
{
    public partial class formMain : Form
    {
        LutronControlModelsContainer _dbContext;

        IBatlethController _batlethController;
        IFixtureController _fixtureController;

        private static int _actionsQueued { get; set; }
        private static int delay = 1;

        SkyWallFadeWorker _skywallFadeWorker;

        private static ushort level = 1;
        private volatile bool stopThread = false;
        private Thread workThread;

        public formMain()
        {
            InitializeComponent();
            //stop = false;
            trackBar1.Enabled = false;
            trackBar1.Visible = false;
            trackBar2.Enabled = false;
            trackBar2.Visible = false;
            trackBar3.Enabled = false;
            trackBar3.Visible = false;
            trackBar4.Enabled = false;
            trackBar4.Visible = false;
            trackBar5.Enabled = false;
            trackBar5.Visible = false;
            _actionsQueued = 0;
            //setup db context
            try
            {
                _dbContext = new LutronControlModelsContainer();
            }
            catch (Exception)
            {
                throw;
            }

            //setup sensor/batleth controllers
            try
            {
                _batlethController = new BatlethController(_dbContext);
            }
            catch (Exception)
            {
                this.tabControl.TabPages.Remove(this.tabBatleth);
            }
            finally
            {
                if (_batlethController != null)
                {
                    _batlethController.OnSensorReadingsTaken += batlethController_OnSensorReadingsTaken;
                    timerSensors.Enabled = true;
                }
            }

            try
            {
                _fixtureController = new FixtureController();
            }
            catch(Exception)
            {
                this.tabControl.TabPages.Remove(this.tabSkyWall);
            }
            finally
            {

            }
            ///
            /// calibration worker not impl.
            /// 
            //try
            //{
            //    calibrationWorker = new CalibrationWorker(fixtureController, batlethController);
            //}
            //catch (Exception)
            //{ }
            //finally
            //{
            //}
        }

        #region batleth tab
        delegate void UpdateSensorReadings(object sender, IEnumerable<SensorReading> readings);
        void batlethController_OnSensorReadingsTaken(object sender, IEnumerable<SensorReading> e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new UpdateSensorReadings(batlethController_OnSensorReadingsTaken), new object[] {sender, e});
            }
            else
            {
                sensorReadingBindingSource.Clear();
                e.ToList().ForEach(r => sensorReadingBindingSource.Add(r));
            }
        }

        private void btnCollection_Click(object sender, EventArgs e)
        {
            using (var wizard = new SkyCollectionWizard(_batlethController, _dbContext))
            {
                wizard.ShowDialog();
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            using (var wizard = new DataExportWizard(_dbContext))
            {
                wizard.ShowDialog();
            }
        }

        private void timerSensors_Tick(object sender, EventArgs e)
        {
            //take readings
            _batlethController.getSensorReadings();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (timerSensors.Enabled)
            {
                timerSensors.Enabled = false;
                btnPause.Text = "Unpause";
            }
            else
            {
                timerSensors.Enabled = true;
                btnPause.Text = "Pause";
            }
        }
        #endregion


        //
        //
        //
        private void cloudy()
        {
            while (!stopThread)
            {
                try
                {
                    for (int i = 0; i < 5; i++)
                    {
                        // if we returned after a pause here level will be remembered
                        _fixtureController.setWallLevelByPanel(level, i);
                        level = (ushort)IntUtil.Random(1, 100);

                        //this.Invoke((MethodInvoker)delegate
                        //{
                        //    label7.Text = level.ToString() + "%";
                        //});
                    }
                    //System.Threading.Thread.Sleep(delay);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(@"problem during transmission of command to lutron panel/area: " + ex.ToString());
                    //break;
                }
                finally
                {
                    // update progress graphic?
                }
            }
            #region old clouds based upon schedules
            //_fixtureController.turnOffWall();

            //var panels = _fixtureController.getAreas().ToArray();
            //var area1 = panels[0];
            //var area2 = panels[1];
            //var area3 = panels[2];
            //var area4 = panels[3];

            //var fixtures1 = _fixtureController.getFixturesForArea(area1).OrderBy(f => f.IntegrationId).Skip(4);
            //var fixtures2 = _fixtureController.getFixturesForArea(area2).OrderBy(f => f.IntegrationId);
            //var fixtures3 = _fixtureController.getFixturesForArea(area3).OrderBy(f => f.IntegrationId);
            //var fixtures4 = _fixtureController.getFixturesForArea(area4).OrderBy(f => f.IntegrationId).Take(20);

            //var levels = new List<int>();
            //levels.AddRange(new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 });
            //levels.AddRange(new List<int> { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50, 55, 60, 65, 70, 75, 80, 85, 90, 95, 100 });
            //levels.AddRange(new List<int> { 95, 90, 85, 80, 75, 70, 65, 60, 55, 50, 45, 40, 35, 30, 25, 20, 15, 10, 5 });

            //var schedules = new List<FixtureSchedule>();

            //schedules.AddRange(MakeRotatingLevel(fixtures1, levels));
            //schedules.AddRange(MakeRotatingLevel(fixtures2, levels));
            //schedules.AddRange(MakeRotatingLevel(fixtures3, levels));
            //schedules.AddRange(MakeRotatingLevel(fixtures4, levels));

            //_skywallFadeWorker = new SkyWallFadeWorker(schedules, _fixtureController);
            //_skywallFadeWorker.StartSkyWall();
            #endregion
        }
        private void sunset()
        {
            ushort level = 100;
            while (!stopThread)
            {
                while (level > 0)
                {
                    try
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            _fixtureController.setWallLevelByPanel(level, i);
                            this.Invoke((MethodInvoker)delegate
                            {
                                label7.Text = level.ToString() + "%";
                            });
                        }
                        System.Threading.Thread.Sleep(delay);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(@"problem during transmission of command to lutron panel/area: " + ex.ToString());
                        break;
                    }
                    finally
                    {
                        // update progress graphic?
                    }
                    if (level == 0)
                    {
                        break;
                    }
                    else
                    {
                        level--;
                    }
                    level--;
                }
            }
            //_fixtureController.turnOffWall();
            //label7.Text = "";
        }
        private void sunrise()
        {
            //label7.Text = "";
            ushort level = 0;
            while (!stopThread)
            {
                while (level < 101)
                {
                    try
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            _fixtureController.setWallLevelByPanel((ushort)(level), i);
                            this.Invoke((MethodInvoker)delegate
                            {
                                label7.Text = level.ToString() + "%";
                            });
                        }
                        System.Threading.Thread.Sleep(delay);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(@"problem during transmission of command to lutron panel/area: " + ex.ToString());
                        break;
                    }
                    finally
                    {
                        // update progress graphic?
                    }
                    if (level == 0)
                    {
                        break;
                    }
                    else
                    {
                        level++;
                    }
                    level++;
                }
            }
            //_fixtureController.turnOffWall();
            //label7.Text = level.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            stopThread = false;
            currentThread.action = cloudy;
            StartThread(currentThread.action);
        }
        private void btnDemo_Click(object sender, EventArgs e)
        {
            stopThread = false;
            currentThread.action = sunset;
            StartThread(currentThread.action);
        }
        private void btnDemo2_Click(object sender, EventArgs e)
        {
            stopThread = false;
            currentThread.action = sunrise;
            StartThread(currentThread.action);
        }
        //
        //
        //
        private void btnDemo3_Click(object sender, EventArgs e)
        {
            _fixtureController.turnOffWall();

            var panels = _fixtureController.getAreas().ToArray();
            var area1 = panels[0];
            var area2 = panels[1];
            var area3 = panels[2];
            var area4 = panels[3];

            var fixtures1 = _fixtureController.getFixturesForArea(area1).OrderBy(f => f.IntegrationId).Skip(4);
            var fixtures2 = _fixtureController.getFixturesForArea(area2).OrderBy(f => f.IntegrationId);
            var fixtures3 = _fixtureController.getFixturesForArea(area3).OrderBy(f => f.IntegrationId);
            var fixtures4 = _fixtureController.getFixturesForArea(area4).OrderBy(f => f.IntegrationId).Take(20);

            var levels = new List<int>();
            levels.AddRange(new List<int>{ 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0});
            levels.AddRange(new List<int>{ 5, 10, 15, 20, 25, 30, 35, 40, 45, 50, 55, 60, 65, 70, 75, 80, 85, 90, 95, 100 });
            levels.AddRange(new List<int> { 95, 90, 85, 80, 75, 70, 65, 60, 55, 50, 45, 40, 35, 30, 25, 20, 15, 10, 5 });

            var schedules = new List<FixtureSchedule>();

            schedules.AddRange(MakeRotatingLevel(fixtures1, levels));
            schedules.AddRange(MakeRotatingLevel(fixtures2, levels));
            schedules.AddRange(MakeRotatingLevel(fixtures3, levels));
            schedules.AddRange(MakeRotatingLevel(fixtures4, levels));

            _skywallFadeWorker = new SkyWallFadeWorker(schedules, _fixtureController);
            _skywallFadeWorker.StartSkyWall();
        }
        private List<FixtureSchedule> MakeRotatingLevel(IEnumerable<Fixture> fixtures, IEnumerable<int> levels)
        {
            fixtures = fixtures.Reverse();

            var schedules = new List<FixtureSchedule>();

            int fixtureCount = fixtures.Count();
            int levelCount = levels.Count();

            //check what happens if fixturecount > levelcount

            for (int i = 0; i < fixtureCount; i++)
            {
                var fixture = fixtures.ElementAt(i);
                
                var adjustedLevels = new List<int>();
                adjustedLevels.AddRange(levels.Skip(i));
                adjustedLevels.AddRange(levels.Take(i));

                schedules.Add(MakeSchedule(fixture, adjustedLevels));
            }

            return schedules;
        }
        private FixtureSchedule MakeSchedule(Fixture fixture, IEnumerable<int> levels)
        {
            var duration = new TimeSpan(0, 0, 3);

            var fixtureSchedule = new FixtureSchedule();
            fixtureSchedule.fixture = fixture;
            fixtureSchedule.levels = levels.ToList();
            fixtureSchedule.step = duration;

            return fixtureSchedule;
        }
        private void FadeVertical(FixtureController controller, IEnumerable<Fixture> fixtures)
        {
            var fixture_array = fixtures.ToArray();
            ushort count = (ushort)fixtures.Count();

            for (ushort i = 0; i < count; i++)
            {
                int level = 100 * (count - i) / count;
                var fixture = fixture_array[i];

                controller.setFixtureLevel(fixture, (ushort)level);
            }
        }
        private async void SlideFixture(IFixtureController controller, IOrderedEnumerable<Fixture> fixtures, int panelNum)
        {

            int level = 0;
            if (panelNum == 0)
            {
                this.Invoke((MethodInvoker)delegate { // runs on UI thread
                    level = int.Parse(textBox3.Text); 
                });
                try
                {
                    await Task.Run(() => controller.setWallLevelByPanel((ushort)level, panelNum));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(@"problem during transmission of command to lutron panel/area: " + ex.ToString());
                }
                finally
                {
                    this.Invoke((MethodInvoker)delegate {
                        label1.Text = level.ToString() + "%"; 
                    });
                    
                }
            }
            if (panelNum == 1)
            {
                this.Invoke((MethodInvoker)delegate { 
                    level = int.Parse(textBox4.Text);
                });
                try
                {
                    await Task.Run(() => controller.setWallLevelByPanel((ushort)level, panelNum));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(@"problem during transmission of command to lutron panel/area: " + ex.ToString());
                }
                finally
                {
                    this.Invoke((MethodInvoker)delegate {
                        label2.Text = level.ToString() + "%";
                    });

                }
            }
            if (panelNum == 2)
            {
                this.Invoke((MethodInvoker)delegate { // runs on UI thread
                    level = int.Parse(textBox5.Text); ;
                });
                try
                {
                    await Task.Run(() => controller.setWallLevelByPanel((ushort)level, panelNum));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(@"problem during transmission of command to lutron panel/area: " + ex.ToString());
                }
                finally
                {
                    this.Invoke((MethodInvoker)delegate {
                        label3.Text = level.ToString() + "%";
                    });

                }
            }
            if (panelNum == 3)
            {
                this.Invoke((MethodInvoker)delegate { // runs on UI thread
                    level = int.Parse(textBox6.Text);
                });
                try
                {
                    await Task.Run(() => controller.setWallLevelByPanel((ushort)level, panelNum));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(@"problem during transmission of command to lutron panel/area: " + ex.ToString());
                }
                finally
                {
                    this.Invoke((MethodInvoker)delegate {
                        label4.Text = level.ToString() + "%";
                    });

                }
            }
            if (panelNum == 4)
            {
                this.Invoke((MethodInvoker)delegate { // runs on UI thread
                    level = int.Parse(textBox7.Text);
                });
                try
                {
                    await Task.Run(() => controller.setWallLevelByPanel((ushort)level, panelNum));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(@"problem during transmission of command to lutron panel/area: " + ex.ToString());
                }
                finally
                {
                    this.Invoke((MethodInvoker)delegate {
                        label5.Text = level.ToString() + "%";
                    });

                }
            }
        }
        private void btnFlash_Click(object sender, EventArgs e)
        {
            Fixture fixture = cboFixture.SelectedItem as Fixture;
            if (fixture == null)
            {
                return;
            }

            _fixtureController.startFlash(fixture);
        }
        private void btnWallOn_Click(object sender, EventArgs e)
        {
            label7.Text = "";
            _fixtureController.turnOnWall();
        }
        private void btnWallOff_Click(object sender, EventArgs e)
        {
            _fixtureController.turnOffWall();
            label7.Text = "";
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            trackBar1.Scroll -= new System.EventHandler(this.trackBar1_Scroll);
            var panels = _fixtureController.getAreas().ToArray();
            var area = panels[0];            
            var fixtures = _fixtureController.getFixturesForArea(area).OrderBy(f => f.IntegrationId);
            SlideFixture(_fixtureController, fixtures , 0); // all fixtures are going in => whole area
            trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
        }
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            trackBar2.Scroll -= new System.EventHandler(this.trackBar2_Scroll);
            var panels = _fixtureController.getAreas().ToArray();
            var area = panels[1];
            var fixtures = _fixtureController.getFixturesForArea(area).OrderBy(f => f.IntegrationId);
            SlideFixture(_fixtureController, fixtures, 1); // all fixtures are going in => whole area
            trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
        }
        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            trackBar3.Scroll -= new System.EventHandler(this.trackBar3_Scroll);
            var panels = _fixtureController.getAreas().ToArray();
            var area = panels[2];
            var fixtures = _fixtureController.getFixturesForArea(area).OrderBy(f => f.IntegrationId);
            SlideFixture(_fixtureController, fixtures, 2); // all fixtures are going in => whole area
            trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
        }
        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            trackBar4.Scroll -= new System.EventHandler(this.trackBar4_Scroll);
            var panels = _fixtureController.getAreas().ToArray();
            var area = panels[3];
            var fixtures = _fixtureController.getFixturesForArea(area).OrderBy(f => f.IntegrationId);
            SlideFixture(_fixtureController, fixtures, 3); // all fixtures are going in => whole area
            trackBar4.Scroll += new System.EventHandler(this.trackBar4_Scroll);
        }
        private void trackBar5_Scroll(object sender, EventArgs e)
        {
            trackBar5.Scroll -= new System.EventHandler(this.trackBar5_Scroll);
            var panels = _fixtureController.getAreas().ToArray();
            var area = panels[4];
            var fixtures = _fixtureController.getFixturesForArea(area).OrderBy(f => f.IntegrationId);
            SlideFixture(_fixtureController, fixtures, 4); // all fixtures are going in => whole area
            trackBar5.Scroll += new System.EventHandler(this.trackBar5_Scroll);
        }
        private void tabSkyWall_Click(object sender, EventArgs e)
        {

        }
        private void StartThread(Action paramaterLessMethodName)
        {
            if (workThread == null)
            {
                stopThread = false;
                workThread = new Thread(new ThreadStart(paramaterLessMethodName));
                workThread.Start();
            }
        }
        private void StopThread()
        {
            if (workThread != null)
            {
                stopThread = true;
                workThread.Join(); // This makes the code here pause until the Thread exits.
                workThread = null;
            }
        }
        public static class currentThread
        {
            public static Action action { get; set; }
        }                
        private void button2_Click(object sender, EventArgs e)
        {
            stopThread = !stopThread;
            if (stopThread)
            {
                label7.Text = "paused";
                if (currentThread.action != null)
                {
                    StopThread();
                }
            }
            else
            {
                if (currentThread.action != null)
                {
                    StartThread(currentThread.action);
                }
                label7.Text = "";
            }
        }        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox2.Text,out delay))
            {
                
                MessageBox.Show("Please enter an integer value");
                
            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox3.Text, out delay))
            {
                MessageBox.Show("Please enter an integer value");
            }
            else
            {
                var panels = _fixtureController.getAreas().ToArray();
                var area = panels[0];
                var fixtures = _fixtureController.getFixturesForArea(area).OrderBy(f => f.IntegrationId);
                SlideFixture(_fixtureController, fixtures, 0); // all fixtures are going in => whole area
            }
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

            if (!int.TryParse(textBox4.Text, out delay))
            {
                MessageBox.Show("Please enter an integer value");
            }
            else
            {
                var panels = _fixtureController.getAreas().ToArray();
                var area = panels[1];
                var fixtures = _fixtureController.getFixturesForArea(area).OrderBy(f => f.IntegrationId);
                SlideFixture(_fixtureController, fixtures, 1); // all fixtures are going in => whole area
            }
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

            if (!int.TryParse(textBox5.Text, out delay))
            {
                MessageBox.Show("Please enter an integer value");
            }
            else
            {
                var panels = _fixtureController.getAreas().ToArray();
                var area = panels[2];
                var fixtures = _fixtureController.getFixturesForArea(area).OrderBy(f => f.IntegrationId);
                SlideFixture(_fixtureController, fixtures, 2); // all fixtures are going in => whole area
            }
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

            if (!int.TryParse(textBox6.Text, out delay))
            {
                MessageBox.Show("Please enter an integer value");
            }
            else
            {
                var panels = _fixtureController.getAreas().ToArray();
                var area = panels[3];
                var fixtures = _fixtureController.getFixturesForArea(area).OrderBy(f => f.IntegrationId);
                SlideFixture(_fixtureController, fixtures, 3); // all fixtures are going in => whole area
            }
        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {

            if (!int.TryParse(textBox7.Text, out delay))
            {
                MessageBox.Show("Please enter an integer value");
            }
            else
            {
                var panels = _fixtureController.getAreas().ToArray();
                var area = panels[4];
                var fixtures = _fixtureController.getFixturesForArea(area).OrderBy(f => f.IntegrationId);
                SlideFixture(_fixtureController, fixtures, 4); // all fixtures are going in => whole area
            }
        }
        public static class IntUtil
        {
            private static Random random;

            private static void Init()
            {
                if (random == null) random = new Random();
            }

            public static int Random(int min, int max)
            {
                Init();
                return random.Next(min, max);
            }
        }
    }
    /// <summary>
    /// pass in a function of (light) level to condition output parameter
    /// to use as you wish (eg delay, etc).
    /// TODO add symbolic algebra lib to handle string
    /// </summary>
    public static class conditionOutput
    {
        public static int scalar(string funcOfLevel, int level)
        {
            return int.Parse(funcOfLevel) * level;
        }
    }
}
