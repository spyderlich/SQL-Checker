using System;
using System.Windows.Forms;
using System.Management;
using System.Runtime.InteropServices;
using System.DirectoryServices.AccountManagement;
using System.Threading;
using System.Threading.Tasks;
using System.Drawing;

namespace SQL_Checker
{
    public partial class Form1 : Form
    {
        public string verification = string.Empty;

        public string retry = "\uE10D";
        public string retry2 = "\uE14A";
        public string retry3 = "\uE1CD";

        public Form1()
        {
            InitializeComponent();

            // Unicode Escape Character Sequence
            string retry = "\uE10D";
            button_mssql34.Text = retry;
            button_mssql35.Text = retry;
            button_mssql36.Text = retry;
            button_mssql38.Text = retry;
            button_mssql39.Text = retry;
            button_mssql40.Text = retry;
            button_mssql41.Text = retry;
            button_mssql42.Text = retry;
            button_mssql45.Text = retry;
            button_mssql131.Text = retry;
            button_mssql132.Text = retry;
            button_mssql133.Text = retry;
            button_mssql137.Text = retry;
            button_mssql139.Text = retry;
            button_mssql146.Text = retry;

            //Unicode Escape Character Sequence
            string checkmark = "\uE10B";
            button_check_mssql34.Text = checkmark;
            button_check_mssql34.Visible = false;
            button_check_mssql35.Text = checkmark;
            button_check_mssql35.Visible = false;
            button_check_mssql36.Text = checkmark;
            button_check_mssql36.Visible = false;
            button_check_mssql38.Text = checkmark;
            button_check_mssql38.Visible = false;
            button_check_mssql39.Text = checkmark;
            button_check_mssql39.Visible = false;
            button_check_mssql40.Text = checkmark;
            button_check_mssql40.Visible = false;
            button_check_mssql41.Text = checkmark;
            button_check_mssql41.Visible = false;
            button_check_mssql42.Text = checkmark;
            button_check_mssql42.Visible = false;
            button_check_mssql45.Text = checkmark;
            button_check_mssql45.Visible = false;
            button_check_mssql131.Text = checkmark;
            button_check_mssql131.Visible = false;
            button_check_mssql132.Text = checkmark;
            button_check_mssql132.Visible = false;
            button_check_mssql133.Text = checkmark;
            button_check_mssql133.Visible = false;
            button_check_mssql137.Text = checkmark;
            button_check_mssql137.Visible = false;
            button_check_mssql139.Text = checkmark;
            button_check_mssql139.Visible = false;
            button_check_mssql146.Text = checkmark;
            button_check_mssql146.Visible = false;

            button_cred_check.Visible = false;
    }

        private async void button_checker_Click(object sender, EventArgs e)
        {
            try
            {
                await runAll();
            }
            catch (Exception)
            {

            }
        }
        private void credCheck()
        {
            int cred = UserValidation.CheckUserLogon(textBox_username.Text, textBox_password.Text, "teleflora.net");
            if (cred == 0)
            {
                verification = "valid";
                string checkmark = "\uE10B";
                button_cred_check.Text = checkmark;
                button_cred_check.BackColor = Color.LawnGreen;
                button_cred_check.Font = new Font("Segoe UI Symbol", 6f);
                button_cred_check.Visible = true;

            }
            else
            {
                verification = string.Empty;
                button_cred_check.Text = "X";
                button_cred_check.BackColor = Color.Red;
                button_cred_check.Font = new Font("Microsoft Sans Serif", 7.8f);
                button_cred_check.Visible = true;
                //MessageBox.Show("Check username/password and try again.");
                try
                {
                    Application.Run(new Form1());
                }
                catch
                {

                }

            }
        }


        private async Task<int> runAll()
        {
            if (verification == "valid")
            {
                
            }
            else
            {
                credCheck();
            }

            Task<int> task1 = Task.Run(() => mssql34());
            Task<int> task2 = Task.Run(() => mssql35());
            Task<int> task3 = Task.Run(() => mssql36());
            Task<int> task4 = Task.Run(() => mssql38());
            Task<int> task5 = Task.Run(() => mssql39());
            Task<int> task6 = Task.Run(() => mssql40());
            Task<int> task7 = Task.Run(() => mssql41());
            Task<int> task8 = Task.Run(() => mssql42());
            Task<int> task9 = Task.Run(() => mssql45());
            Task<int> task10 = Task.Run(() => mssql131());
            Task<int> task11 = Task.Run(() => mssql132());
            Task<int> task12 = Task.Run(() => mssql133());
            Task<int> task13 = Task.Run(() => mssql137());
            Task<int> task14 = Task.Run(() => mssql139());
            Task<int> task15 = Task.Run(() => mssql146());


            int[] result = await Task.WhenAll(task2, task1, task3, task4, task5, task6, task7, task8, task9, task10, task11, task12, task13, task14, task15);
            

            

            return 0;
        }

        //public void DoProgress(IProgress<int> progess)
        //{
        //    for (int i = 0; i !=100; i++)
        //    {
        //        Thread.Sleep(100);
        //        if (progess != null)
        //        {
        //            progess.Report(i);
        //        }

        //    }
        //}

            private async Task<int> mssql34()
            {
                label_currentCluster_MSSQL34.Invoke((MethodInvoker)(() => label_currentCluster_MSSQL34.Text = string.Empty));
                label_lastReboot_MSSQL34.Invoke((MethodInvoker)(() => label_lastReboot_MSSQL34.Text = string.Empty));
                button_check_mssql34.Invoke((MethodInvoker)(() => button_check_mssql34.Visible = false));

            //var progress = new Progress<int>(percent =>
            //{
            //    button_mssql34.Invoke((MethodInvoker)(() => button_mssql34.Text = retry2));
            //    Thread.Sleep(1000);
            //    button_mssql34.Invoke((MethodInvoker)(() => button_mssql34.Text = retry3));
            //    Thread.Sleep(1000);
            //    if (label_lastReboot_MSSQL34.Text != "")
            //    {
            //        button_mssql34.Invoke((MethodInvoker)(() => button_mssql34.Text = retry));
            //        return;
            //    }
            //});

            //    await Task.Run(() => DoProgress(progress));

            ConnectionOptions connection = new ConnectionOptions();
                connection.Username = textBox_username.Text;
                connection.Password = textBox_password.Text;
                connection.Authority = "ntlmdomain:teleflora.net";

                ManagementScope scope = new ManagementScope(
                    "\\\\eprodsql34\\root\\CIMV2", connection);
                scope.Connect();

                ObjectQuery query = new ObjectQuery("SELECT * FROM Win32_NTDomain");
                ObjectQuery query2 = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");

                ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query);
                ManagementObjectSearcher searcher2 = new ManagementObjectSearcher(scope, query2);

                foreach (ManagementObject queryObj in searcher.Get())
                {

                    label_currentCluster_MSSQL34.Invoke((MethodInvoker)(() => label_currentCluster_MSSQL34.Text = Convert.ToString(queryObj["Caption"])));
                    break;
                }

                foreach (ManagementObject queryObj in searcher2.Get())
                {

                    string unparsedDateTime = Convert.ToString(queryObj["LastBootUpTime"]);
                    string parsedDateTime = Convert.ToString(ParseCIM_DATETIME(unparsedDateTime));
                    label_lastReboot_MSSQL34.Invoke((MethodInvoker)(() => label_lastReboot_MSSQL34.Text = parsedDateTime));
                    break;
                }


                if (label_currentCluster_MSSQL34.Text == label_defaultCluster_MSSQL34.Text)
                {
                    button_check_mssql34.Invoke((MethodInvoker)(() => button_check_mssql34.Visible = true));
                }
                else
                {
                    button_check_mssql34.Invoke((MethodInvoker)(() => button_check_mssql34.Visible = false));
                }
            //button_mssql34.Invoke((MethodInvoker)(() => button_mssql34.Text = retry));
            return 0;
            }

        private async void button_mssql34_Click(object sender, EventArgs e)
        {
            if (verification == "valid")
            {
                try
                {
                    Task<int> task1 = Task.Run(() => mssql34());
                }
                catch (ManagementException err)
                {
                    MessageBox.Show("An error occurred while querying for WMI data: " + err.Message);
                }
                catch (System.UnauthorizedAccessException unauthorizedErr)
                {
                    MessageBox.Show("Connection error (user name or password might be incorrect): " + unauthorizedErr.Message);
                }
                catch (Exception)
                {
                    label_currentCluster_MSSQL34.Invoke((MethodInvoker)(() => label_currentCluster_MSSQL34.Text = "TRY AGAIN"));
                }
            }
            else
            {
                credCheck();
                if (verification == "valid")
                {
                    button_mssql34_Click(sender, null);
                }
            }
        }

        private async Task<int> mssql35()
        {
            label_currentCluster_MSSQL35.Invoke((MethodInvoker)(() => label_currentCluster_MSSQL35.Text = string.Empty));
            label_lastReboot_MSSQL35.Invoke((MethodInvoker)(() => label_lastReboot_MSSQL35.Text = string.Empty));
            button_check_mssql35.Invoke((MethodInvoker)(() => button_check_mssql35.Visible = false));

            //var progress = new Progress<int>(percent =>
            //{
            //    button_mssql35.Invoke((MethodInvoker)(() => button_mssql35.Text = retry2));
            //    Thread.Sleep(500);

            //    button_mssql35.Invoke((MethodInvoker)(() => button_mssql35.Text = retry3));
            //    Thread.Sleep(500);

            //    if (label_lastReboot_MSSQL35.Text != "")
            //    {
            //        return;
            //    }
            //});

            //await Task.Run(() => DoProgress(progress));
            //button_mssql35.Invoke((MethodInvoker)(() => button_mssql35.Text = retry));
            ConnectionOptions connection = new ConnectionOptions();
            connection.Username = textBox_username.Text;
            connection.Password = textBox_password.Text;
            connection.Authority = "ntlmdomain:teleflora.net";

            ManagementScope scope = new ManagementScope(
                "\\\\eprodsql35\\root\\CIMV2", connection);
            scope.Connect();

            ObjectQuery query = new ObjectQuery("SELECT * FROM Win32_NTDomain");
            ObjectQuery query2 = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");

            ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query);
            ManagementObjectSearcher searcher2 = new ManagementObjectSearcher(scope, query2);

            foreach (ManagementObject queryObj in searcher.Get())
            {
                label_currentCluster_MSSQL35.Invoke((MethodInvoker)(() => label_currentCluster_MSSQL35.Text = Convert.ToString(queryObj["Caption"])));
                break;
            }

            foreach (ManagementObject queryObj in searcher2.Get())
            {
                string unparsedDateTime = Convert.ToString(queryObj["LastBootUpTime"]);
                string parsedDateTime = Convert.ToString(ParseCIM_DATETIME(unparsedDateTime));
                label_lastReboot_MSSQL35.Invoke((MethodInvoker)(() => label_lastReboot_MSSQL35.Text = parsedDateTime));
                break;
            }

            if (label_currentCluster_MSSQL35.Text == label_defaultCluster_MSSQL35.Text)
            {
                button_check_mssql35.Invoke((MethodInvoker)(() => button_check_mssql35.Visible = true));
            }
            else
            {
                button_check_mssql35.Invoke((MethodInvoker)(() => button_check_mssql35.Visible = false));
            }
            //button_mssql35.Invoke((MethodInvoker)(() => button_mssql35.Text = retry));
            return 0;
        }

        private async void button_mssql35_Click(object sender, EventArgs e)
        {
            if (verification == "valid")
            {
                try
                {
                    Task<int> task2 = Task.Run(() => mssql35());
                }
                catch (ManagementException err)
                {
                    MessageBox.Show("An error occurred while querying for WMI data: " + err.Message);
                }
                catch (System.UnauthorizedAccessException unauthorizedErr)
                {
                    MessageBox.Show("Connection error (user name or password might be incorrect): " + unauthorizedErr.Message);
                }
                catch (Exception)
                {
                    label_currentCluster_MSSQL35.Invoke((MethodInvoker)(() => label_currentCluster_MSSQL35.Text = "TRY AGAIN"));
                }
            }
            else
            {
                credCheck();
                if (verification == "valid")
                {
                    button_mssql35_Click(sender, null);
                }
            }
        }

        private async Task <int> mssql36()
        {
            label_currentCluster_MSSQL36.Invoke((MethodInvoker)(() => label_currentCluster_MSSQL36.Text = string.Empty));
            label_lastReboot_MSSQL36.Invoke((MethodInvoker)(() => label_lastReboot_MSSQL36.Text = string.Empty));
            button_check_mssql36.Invoke((MethodInvoker)(() => button_check_mssql36.Visible = false));

            ConnectionOptions connection = new ConnectionOptions();
                connection.Username = textBox_username.Text;
                connection.Password = textBox_password.Text;
                connection.Authority = "ntlmdomain:teleflora.net";

                ManagementScope scope = new ManagementScope(
                    "\\\\eprodsql36\\root\\CIMV2", connection);
                scope.Connect();

                ObjectQuery query = new ObjectQuery("SELECT * FROM Win32_NTDomain");
                ObjectQuery query2 = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");

                ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query);
                ManagementObjectSearcher searcher2 = new ManagementObjectSearcher(scope, query2);

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    label_currentCluster_MSSQL36.Invoke((MethodInvoker)(() => label_currentCluster_MSSQL36.Text = Convert.ToString(queryObj["Caption"])));
                    break;
                }

                foreach (ManagementObject queryObj in searcher2.Get())
                {
                    string unparsedDateTime = Convert.ToString(queryObj["LastBootUpTime"]);
                    string parsedDateTime = Convert.ToString(ParseCIM_DATETIME(unparsedDateTime));
                    label_currentCluster_MSSQL36.Invoke((MethodInvoker)(() => label_lastReboot_MSSQL36.Text = parsedDateTime));
                    break;
                }

            if (label_currentCluster_MSSQL36.Text == label_defaultCluster_MSSQL36.Text)
            {
                button_check_mssql36.Invoke((MethodInvoker)(() => button_check_mssql36.Visible = true));
            }
            else
            {
                button_check_mssql36.Invoke((MethodInvoker)(() => button_check_mssql36.Visible = false));
            }
            button_mssql36.Invoke((MethodInvoker)(() => button_mssql36.Text = retry));
            return 0;
        }

        private async void button_mssql36_Click(object sender, EventArgs e)
        {
            if (verification == "valid")
            {
                try
                {
                    Task<int> task3 = Task.Run(() => mssql36());
                }
                catch (ManagementException err)
                {
                    MessageBox.Show("An error occurred while querying for WMI data: " + err.Message);
                }
                catch (System.UnauthorizedAccessException unauthorizedErr)
                {
                    MessageBox.Show("Connection error (user name or password might be incorrect): " + unauthorizedErr.Message);
                }
                catch (Exception)
                {
                    label_currentCluster_MSSQL36.Invoke((MethodInvoker)(() => label_currentCluster_MSSQL36.Text = "TRY AGAIN"));
                }
            }
            else
            {
                credCheck();
                if (verification == "valid")
                {
                    button_mssql36_Click(sender, null);
                }
            }
        }
        private async Task<int> mssql38()
        {
            label_currentCluster_MSSQL38.Invoke((MethodInvoker)(() => label_currentCluster_MSSQL38.Text = string.Empty));
            label_lastReboot_MSSQL38.Invoke((MethodInvoker)(() => label_lastReboot_MSSQL38.Text = string.Empty));
            button_check_mssql38.Invoke((MethodInvoker)(() => button_check_mssql38.Visible = false));

            ConnectionOptions connection = new ConnectionOptions();
            connection.Username = textBox_username.Text;
            connection.Password = textBox_password.Text;
            connection.Authority = "ntlmdomain:teleflora.net";

            ManagementScope scope = new ManagementScope(
                "\\\\eprodsql38\\root\\CIMV2", connection);
            scope.Connect();

            ObjectQuery query = new ObjectQuery("SELECT * FROM Win32_NTDomain");
            ObjectQuery query2 = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");

            ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query);
            ManagementObjectSearcher searcher2 = new ManagementObjectSearcher(scope, query2);

            foreach (ManagementObject queryObj in searcher.Get())
            {
                label_currentCluster_MSSQL38.Invoke((MethodInvoker)(() => label_currentCluster_MSSQL38.Text = Convert.ToString(queryObj["Caption"])));
                break;
            }

            foreach (ManagementObject queryObj in searcher2.Get())
            {
                string unparsedDateTime = Convert.ToString(queryObj["LastBootUpTime"]);
                string parsedDateTime = Convert.ToString(ParseCIM_DATETIME(unparsedDateTime));
                label_currentCluster_MSSQL38.Invoke((MethodInvoker)(() => label_lastReboot_MSSQL38.Text = parsedDateTime));
                break;
            }

            if (label_currentCluster_MSSQL38.Text == label_defaultCluster_MSSQL38.Text)
            {
                button_check_mssql38.Invoke((MethodInvoker)(() => button_check_mssql38.Visible = true));
            }
            else
            {
                button_check_mssql38.Invoke((MethodInvoker)(() => button_check_mssql38.Visible = false));
            }
            button_mssql38.Invoke((MethodInvoker)(() => button_mssql38.Text = retry));
            return 0;
        }


        private async void button_mssql38_Click(object sender, EventArgs e)
        {
            if (verification == "valid")
            {
                try
                {
                    Task<int> task4 = Task.Run(() => mssql38());
                }
                catch (ManagementException err)
                {
                    MessageBox.Show("An error occurred while querying for WMI data: " + err.Message);
                }
                catch (System.UnauthorizedAccessException unauthorizedErr)
                {
                    MessageBox.Show("Connection error (user name or password might be incorrect): " + unauthorizedErr.Message);
                }
                catch (Exception)
                {
                    label_currentCluster_MSSQL38.Invoke((MethodInvoker)(() => label_currentCluster_MSSQL38.Text = "TRY AGAIN"));
                }
            }
            else
            {
                credCheck();
                if (verification == "valid")
                {
                    button_mssql38_Click(sender, null);
                }
            }
        }
        private async Task<int> mssql39()
        {
            label_currentCluster_MSSQL39.Invoke((MethodInvoker)(() => label_currentCluster_MSSQL39.Text = string.Empty));
            label_lastReboot_MSSQL39.Invoke((MethodInvoker)(() => label_lastReboot_MSSQL39.Text = string.Empty));
            button_check_mssql39.Invoke((MethodInvoker)(() => button_check_mssql39.Visible = false));

            ConnectionOptions connection = new ConnectionOptions();
            connection.Username = textBox_username.Text;
            connection.Password = textBox_password.Text;
            connection.Authority = "ntlmdomain:teleflora.net";

            ManagementScope scope = new ManagementScope(
                "\\\\eprodsql39\\root\\CIMV2", connection);
            scope.Connect();

            ObjectQuery query = new ObjectQuery("SELECT * FROM Win32_NTDomain");
            ObjectQuery query2 = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");

            ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query);
            ManagementObjectSearcher searcher2 = new ManagementObjectSearcher(scope, query2);

            foreach (ManagementObject queryObj in searcher.Get())
            {
                label_currentCluster_MSSQL39.Invoke((MethodInvoker)(() => label_currentCluster_MSSQL39.Text = Convert.ToString(queryObj["Caption"])));
                break;
            }

            foreach (ManagementObject queryObj in searcher2.Get())
            {
                string unparsedDateTime = Convert.ToString(queryObj["LastBootUpTime"]);
                string parsedDateTime = Convert.ToString(ParseCIM_DATETIME(unparsedDateTime));
                label_currentCluster_MSSQL39.Invoke((MethodInvoker)(() => label_lastReboot_MSSQL39.Text = parsedDateTime));
                break;
            }

            if (label_currentCluster_MSSQL39.Text == label_defaultCluster_MSSQL39.Text)
            {
                button_check_mssql39.Invoke((MethodInvoker)(() => button_check_mssql39.Visible = true));
            }
            else
            {
                button_check_mssql39.Invoke((MethodInvoker)(() => button_check_mssql39.Visible = false));
            }
            button_mssql39.Invoke((MethodInvoker)(() => button_mssql39.Text = retry));
            return 0;
        }


        private async void button_mssql39_Click(object sender, EventArgs e)
        {
            if (verification == "valid")
            {
                try
                {
                    Task<int> task5 = Task.Run(() => mssql39());
                }
                catch (ManagementException err)
                {
                    MessageBox.Show("An error occurred while querying for WMI data: " + err.Message);
                }
                catch (System.UnauthorizedAccessException unauthorizedErr)
                {
                    MessageBox.Show("Connection error (user name or password might be incorrect): " + unauthorizedErr.Message);
                }
                catch (Exception)
                {
                    label_currentCluster_MSSQL39.Invoke((MethodInvoker)(() => label_currentCluster_MSSQL39.Text = "TRY AGAIN"));
                }
            }
            else
            {
                credCheck();
                if (verification == "valid")
                {
                    button_mssql39_Click(sender, null);
                }
            }
        }

        private async Task<int> mssql40()
        {
            label_currentCluster_MSSQL40.Invoke((MethodInvoker)(() => label_currentCluster_MSSQL40.Text = string.Empty));
            label_lastReboot_MSSQL40.Invoke((MethodInvoker)(() => label_lastReboot_MSSQL40.Text = string.Empty));
            button_check_mssql40.Invoke((MethodInvoker)(() => button_check_mssql40.Visible = false));

            ConnectionOptions connection = new ConnectionOptions();
            connection.Username = textBox_username.Text;
            connection.Password = textBox_password.Text;
            connection.Authority = "ntlmdomain:teleflora.net";

            ManagementScope scope = new ManagementScope(
                "\\\\eprodsql40\\root\\CIMV2", connection);
            scope.Connect();

            ObjectQuery query = new ObjectQuery("SELECT * FROM Win32_NTDomain");
            ObjectQuery query2 = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");

            ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query);
            ManagementObjectSearcher searcher2 = new ManagementObjectSearcher(scope, query2);

            foreach (ManagementObject queryObj in searcher.Get())
            {
                label_currentCluster_MSSQL40.Invoke((MethodInvoker)(() => label_currentCluster_MSSQL40.Text = Convert.ToString(queryObj["Caption"])));
                break;
            }

            foreach (ManagementObject queryObj in searcher2.Get())
            {
                string unparsedDateTime = Convert.ToString(queryObj["LastBootUpTime"]);
                string parsedDateTime = Convert.ToString(ParseCIM_DATETIME(unparsedDateTime));
                label_currentCluster_MSSQL40.Invoke((MethodInvoker)(() => label_lastReboot_MSSQL40.Text = parsedDateTime));
                break;
            }

            if (label_currentCluster_MSSQL40.Text == label_defaultCluster_MSSQL40.Text)
            {
                button_check_mssql40.Invoke((MethodInvoker)(() => button_check_mssql40.Visible = true));
            }
            else
            {
                button_check_mssql40.Invoke((MethodInvoker)(() => button_check_mssql40.Visible = false));
            }
            button_mssql40.Invoke((MethodInvoker)(() => button_mssql40.Text = retry));
            return 0;
        }

        private async void button_mssql40_Click(object sender, EventArgs e)
        {
            if (verification == "valid")
            {
                try
                {
                    Task<int> task6 = Task.Run(() => mssql40());
                }
                catch (ManagementException err)
                {
                    MessageBox.Show("An error occurred while querying for WMI data: " + err.Message);
                }
                catch (System.UnauthorizedAccessException unauthorizedErr)
                {
                    MessageBox.Show("Connection error (user name or password might be incorrect): " + unauthorizedErr.Message);
                }
                catch (Exception)
                {
                    label_currentCluster_MSSQL40.Invoke((MethodInvoker)(() => label_currentCluster_MSSQL40.Text = "TRY AGAIN"));
                }
            }
            else
            {
                credCheck();
                if (verification == "valid")
                {
                    button_mssql40_Click(sender, null);
                }
            }
        }

        private async Task<int> mssql41()
        {
            label_currentCluster_MSSQL41.Invoke((MethodInvoker)(() => label_currentCluster_MSSQL41.Text = string.Empty));
            label_lastReboot_MSSQL41.Invoke((MethodInvoker)(() => label_lastReboot_MSSQL41.Text = string.Empty));
            button_check_mssql41.Invoke((MethodInvoker)(() => button_check_mssql41.Visible = false));

            ConnectionOptions connection = new ConnectionOptions();
            connection.Username = textBox_username.Text;
            connection.Password = textBox_password.Text;
            connection.Authority = "ntlmdomain:teleflora.net";

            ManagementScope scope = new ManagementScope(
                "\\\\eprodsql41\\root\\CIMV2", connection);
            scope.Connect();

            ObjectQuery query = new ObjectQuery("SELECT * FROM Win32_NTDomain");
            ObjectQuery query2 = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");

            ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query);
            ManagementObjectSearcher searcher2 = new ManagementObjectSearcher(scope, query2);

            foreach (ManagementObject queryObj in searcher.Get())
            {
                label_currentCluster_MSSQL41.Invoke((MethodInvoker)(() => label_currentCluster_MSSQL41.Text = Convert.ToString(queryObj["Caption"])));
                break;
            }

            foreach (ManagementObject queryObj in searcher2.Get())
            {
                string unparsedDateTime = Convert.ToString(queryObj["LastBootUpTime"]);
                string parsedDateTime = Convert.ToString(ParseCIM_DATETIME(unparsedDateTime));
                label_currentCluster_MSSQL41.Invoke((MethodInvoker)(() => label_lastReboot_MSSQL41.Text = parsedDateTime));
                break;
            }

            if (label_currentCluster_MSSQL41.Text == label_defaultCluster_MSSQL41.Text)
            {
                button_check_mssql41.Invoke((MethodInvoker)(() => button_check_mssql41.Visible = true));
            }
            else
            {
                button_check_mssql41.Invoke((MethodInvoker)(() => button_check_mssql41.Visible = false));
            }
            button_mssql41.Invoke((MethodInvoker)(() => button_mssql41.Text = retry));
            return 0;
        }

        private async void button_mssql41_Click(object sender, EventArgs e)
        {
            if (verification == "valid")
            {
                try
                {
                    Task<int> task7 = Task.Run(() => mssql41());
                }
                catch (ManagementException err)
                {
                    MessageBox.Show("An error occurred while querying for WMI data: " + err.Message);
                }
                catch (System.UnauthorizedAccessException unauthorizedErr)
                {
                    MessageBox.Show("Connection error (user name or password might be incorrect): " + unauthorizedErr.Message);
                }
                catch (Exception)
                {
                    label_currentCluster_MSSQL41.Invoke((MethodInvoker)(() => label_currentCluster_MSSQL41.Text = "TRY AGAIN"));
                }
            }
            else
            {
                credCheck();
                if (verification == "valid")
                {
                    button_mssql41_Click(sender, null);
                }
            }
        }

        private async Task<int> mssql42()
        {
            label_currentCluster_MSSQL42.Invoke((MethodInvoker)(() => label_currentCluster_MSSQL42.Text = string.Empty));
            label_lastReboot_MSSQL42.Invoke((MethodInvoker)(() => label_lastReboot_MSSQL42.Text = string.Empty));
            button_check_mssql42.Invoke((MethodInvoker)(() => button_check_mssql42.Visible = false));

            ConnectionOptions connection = new ConnectionOptions();
            connection.Username = textBox_username.Text;
            connection.Password = textBox_password.Text;
            connection.Authority = "ntlmdomain:teleflora.net";

            ManagementScope scope = new ManagementScope(
                "\\\\eprodsql42\\root\\CIMV2", connection);
            scope.Connect();

            ObjectQuery query = new ObjectQuery("SELECT * FROM Win32_NTDomain");
            ObjectQuery query2 = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");

            ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query);
            ManagementObjectSearcher searcher2 = new ManagementObjectSearcher(scope, query2);

            foreach (ManagementObject queryObj in searcher.Get())
            {
                label_currentCluster_MSSQL42.Invoke((MethodInvoker)(() => label_currentCluster_MSSQL42.Text = Convert.ToString(queryObj["Caption"])));
                break;
            }

            foreach (ManagementObject queryObj in searcher2.Get())
            {
                string unparsedDateTime = Convert.ToString(queryObj["LastBootUpTime"]);
                string parsedDateTime = Convert.ToString(ParseCIM_DATETIME(unparsedDateTime));
                label_currentCluster_MSSQL42.Invoke((MethodInvoker)(() => label_lastReboot_MSSQL42.Text = parsedDateTime));
                break;
            }

            if (label_currentCluster_MSSQL42.Text == label_defaultCluster_MSSQL42.Text)
            {
                button_check_mssql42.Invoke((MethodInvoker)(() => button_check_mssql42.Visible = true));
            }
            else
            {
                button_check_mssql42.Invoke((MethodInvoker)(() => button_check_mssql42.Visible = false));
            }
            button_mssql42.Invoke((MethodInvoker)(() => button_mssql42.Text = retry));
            return 0;
        }

        private async void button_mssql42_Click(object sender, EventArgs e)
        {
            if (verification == "valid")
            {
                try
                {
                    Task<int> task8 = Task.Run(() => mssql42());
                }
                catch (ManagementException err)
                {
                    MessageBox.Show("An error occurred while querying for WMI data: " + err.Message);
                }
                catch (System.UnauthorizedAccessException unauthorizedErr)
                {
                    MessageBox.Show("Connection error (user name or password might be incorrect): " + unauthorizedErr.Message);
                }
                catch (Exception)
                {
                    label_currentCluster_MSSQL42.Invoke((MethodInvoker)(() => label_currentCluster_MSSQL42.Text = "TRY AGAIN"));
                }
            }
            else
            {
                credCheck();
                if (verification == "valid")
                {
                    button_mssql42_Click(sender, null);
                }
            }
        }

        private async Task<int> mssql45()
        {
            label_currentCluster_MSSQL45.Invoke((MethodInvoker)(() => label_currentCluster_MSSQL45.Text = string.Empty));
            label_lastReboot_MSSQL45.Invoke((MethodInvoker)(() => label_lastReboot_MSSQL45.Text = string.Empty));
            button_check_mssql45.Invoke((MethodInvoker)(() => button_check_mssql45.Visible = false));

            ConnectionOptions connection = new ConnectionOptions();
            connection.Username = textBox_username.Text;
            connection.Password = textBox_password.Text;
            connection.Authority = "ntlmdomain:teleflora.net";

            ManagementScope scope = new ManagementScope(
                "\\\\eprodsql45\\root\\CIMV2", connection);
            scope.Connect();

            ObjectQuery query = new ObjectQuery("SELECT * FROM Win32_NTDomain");
            ObjectQuery query2 = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");

            ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query);
            ManagementObjectSearcher searcher2 = new ManagementObjectSearcher(scope, query2);

            foreach (ManagementObject queryObj in searcher.Get())
            {
                label_currentCluster_MSSQL45.Invoke((MethodInvoker)(() => label_currentCluster_MSSQL45.Text = Convert.ToString(queryObj["Caption"])));
                break;
            }

            foreach (ManagementObject queryObj in searcher2.Get())
            {
                string unparsedDateTime = Convert.ToString(queryObj["LastBootUpTime"]);
                string parsedDateTime = Convert.ToString(ParseCIM_DATETIME(unparsedDateTime));
                label_currentCluster_MSSQL45.Invoke((MethodInvoker)(() => label_lastReboot_MSSQL45.Text = parsedDateTime));
                break;
            }

            if (label_currentCluster_MSSQL45.Text == label_defaultCluster_MSSQL45.Text)
            {
                button_check_mssql45.Invoke((MethodInvoker)(() => button_check_mssql45.Visible = true));
            }
            else
            {
                button_check_mssql45.Invoke((MethodInvoker)(() => button_check_mssql45.Visible = false));
            }
            button_mssql45.Invoke((MethodInvoker)(() => button_mssql45.Text = retry));
            return 0;
        }

        private async void button_mssql45_Click(object sender, EventArgs e)
        {
            if (verification == "valid")
            {
                try
                {
                    Task<int> task9 = Task.Run(() => mssql45());
                }
                catch (ManagementException err)
                {
                    MessageBox.Show("An error occurred while querying for WMI data: " + err.Message);
                }
                catch (System.UnauthorizedAccessException unauthorizedErr)
                {
                    MessageBox.Show("Connection error (user name or password might be incorrect): " + unauthorizedErr.Message);
                }
                catch (Exception)
                {
                    label_currentCluster_MSSQL45.Invoke((MethodInvoker)(() => label_currentCluster_MSSQL45.Text = "TRY AGAIN"));
                }
            }
            else
            {
                credCheck();
                if (verification == "valid")
                {
                    button_mssql45_Click(sender, null);
                }
            }
        }

        private async Task<int> mssql131()
        {
            label_currentCluster_MSSQL131.Invoke((MethodInvoker)(() => label_currentCluster_MSSQL131.Text = string.Empty));
            label_lastReboot_MSSQL131.Invoke((MethodInvoker)(() => label_lastReboot_MSSQL131.Text = string.Empty));
            button_check_mssql131.Invoke((MethodInvoker)(() => button_check_mssql131.Visible = false));

            ConnectionOptions connection = new ConnectionOptions();
            connection.Username = textBox_username.Text;
            connection.Password = textBox_password.Text;
            connection.Authority = "ntlmdomain:teleflora.net";

            ManagementScope scope = new ManagementScope(
                "\\\\eprodsql131\\root\\CIMV2", connection);
            scope.Connect();

            ObjectQuery query = new ObjectQuery("SELECT * FROM Win32_NTDomain");
            ObjectQuery query2 = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");

            ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query);
            ManagementObjectSearcher searcher2 = new ManagementObjectSearcher(scope, query2);

            foreach (ManagementObject queryObj in searcher.Get())
            {
                label_currentCluster_MSSQL131.Invoke((MethodInvoker)(() => label_currentCluster_MSSQL131.Text = Convert.ToString(queryObj["Caption"])));
                break;
            }

            foreach (ManagementObject queryObj in searcher2.Get())
            {
                string unparsedDateTime = Convert.ToString(queryObj["LastBootUpTime"]);
                string parsedDateTime = Convert.ToString(ParseCIM_DATETIME(unparsedDateTime));
                label_currentCluster_MSSQL131.Invoke((MethodInvoker)(() => label_lastReboot_MSSQL131.Text = parsedDateTime));
                break;
            }

            if (label_currentCluster_MSSQL131.Text == label_defaultCluster_MSSQL131.Text)
            {
                button_check_mssql131.Invoke((MethodInvoker)(() => button_check_mssql131.Visible = true));
            }
            else
            {
                button_check_mssql131.Invoke((MethodInvoker)(() => button_check_mssql131.Visible = false));
            }
            button_mssql131.Invoke((MethodInvoker)(() => button_mssql131.Text = retry));
            return 0;
        }

        private async void button_mssql131_Click(object sender, EventArgs e)
        {
            if (verification == "valid")
            {
                try
                {
                    Task<int> task10 = Task.Run(() => mssql131());
                }
                catch (ManagementException err)
                {
                    MessageBox.Show("An error occurred while querying for WMI data: " + err.Message);
                }
                catch (System.UnauthorizedAccessException unauthorizedErr)
                {
                    MessageBox.Show("Connection error (user name or password might be incorrect): " + unauthorizedErr.Message);
                }
                catch (Exception)
                {
                    label_currentCluster_MSSQL131.Invoke((MethodInvoker)(() => label_currentCluster_MSSQL131.Text = "TRY AGAIN"));
                }
            }
            else
            {
                credCheck();
                if (verification == "valid")
                {
                    button_mssql131_Click(sender, null);
                }
            }
        }

        private async Task<int> mssql132()
        {
            label_currentCluster_MSSQL132.Invoke((MethodInvoker)(() => label_currentCluster_MSSQL132.Text = string.Empty));
            label_lastReboot_MSSQL132.Invoke((MethodInvoker)(() => label_lastReboot_MSSQL132.Text = string.Empty));
            button_check_mssql132.Invoke((MethodInvoker)(() => button_check_mssql132.Visible = false));

            ConnectionOptions connection = new ConnectionOptions();
            connection.Username = textBox_username.Text;
            connection.Password = textBox_password.Text;
            connection.Authority = "ntlmdomain:teleflora.net";

            ManagementScope scope = new ManagementScope(
                "\\\\eprodsql132\\root\\CIMV2", connection);
            scope.Connect();

            ObjectQuery query = new ObjectQuery("SELECT * FROM Win32_NTDomain");
            ObjectQuery query2 = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");

            ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query);
            ManagementObjectSearcher searcher2 = new ManagementObjectSearcher(scope, query2);

            foreach (ManagementObject queryObj in searcher.Get())
            {
                label_currentCluster_MSSQL132.Invoke((MethodInvoker)(() => label_currentCluster_MSSQL132.Text = Convert.ToString(queryObj["Caption"])));
                break;
            }

            foreach (ManagementObject queryObj in searcher2.Get())
            {
                string unparsedDateTime = Convert.ToString(queryObj["LastBootUpTime"]);
                string parsedDateTime = Convert.ToString(ParseCIM_DATETIME(unparsedDateTime));
                label_currentCluster_MSSQL132.Invoke((MethodInvoker)(() => label_lastReboot_MSSQL132.Text = parsedDateTime));
                break;
            }

            if (label_currentCluster_MSSQL132.Text == label_defaultCluster_MSSQL132.Text)
            {
                button_check_mssql132.Invoke((MethodInvoker)(() => button_check_mssql132.Visible = true));
            }
            else
            {
                button_check_mssql132.Invoke((MethodInvoker)(() => button_check_mssql132.Visible = false));
            }
            button_mssql132.Invoke((MethodInvoker)(() => button_mssql132.Text = retry));
            return 0;
        }

        private async void button_mssql132_Click(object sender, EventArgs e)
        {
            if (verification == "valid")
            {
                try
                {
                    Task<int> task11 = Task.Run(() => mssql132());
                }
                catch (ManagementException err)
                {
                    MessageBox.Show("An error occurred while querying for WMI data: " + err.Message);
                }
                catch (System.UnauthorizedAccessException unauthorizedErr)
                {
                    MessageBox.Show("Connection error (user name or password might be incorrect): " + unauthorizedErr.Message);
                }
                catch (Exception)
                {
                    label_currentCluster_MSSQL132.Invoke((MethodInvoker)(() => label_currentCluster_MSSQL132.Text = "TRY AGAIN"));
                }
            }
            else
            {
                credCheck();
                if (verification == "valid")
                {
                    button_mssql132_Click(sender, null);
                }
            }
        }

        private async Task<int> mssql133()
        {
            label_currentCluster_MSSQL133.Invoke((MethodInvoker)(() => label_currentCluster_MSSQL133.Text = string.Empty));
            label_lastReboot_MSSQL133.Invoke((MethodInvoker)(() => label_lastReboot_MSSQL133.Text = string.Empty));
            button_check_mssql133.Invoke((MethodInvoker)(() => button_check_mssql133.Visible = false));

            ConnectionOptions connection = new ConnectionOptions();
            connection.Username = textBox_username.Text;
            connection.Password = textBox_password.Text;
            connection.Authority = "ntlmdomain:teleflora.net";

            ManagementScope scope = new ManagementScope(
                "\\\\eprodsql133\\root\\CIMV2", connection);
            scope.Connect();

            ObjectQuery query = new ObjectQuery("SELECT * FROM Win32_NTDomain");
            ObjectQuery query2 = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");

            ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query);
            ManagementObjectSearcher searcher2 = new ManagementObjectSearcher(scope, query2);

            foreach (ManagementObject queryObj in searcher.Get())
            {
                label_currentCluster_MSSQL133.Invoke((MethodInvoker)(() => label_currentCluster_MSSQL133.Text = Convert.ToString(queryObj["Caption"])));
                break;
            }

            foreach (ManagementObject queryObj in searcher2.Get())
            {
                string unparsedDateTime = Convert.ToString(queryObj["LastBootUpTime"]);
                string parsedDateTime = Convert.ToString(ParseCIM_DATETIME(unparsedDateTime));
                label_currentCluster_MSSQL133.Invoke((MethodInvoker)(() => label_lastReboot_MSSQL133.Text = parsedDateTime));
                break;
            }
 
            if (label_currentCluster_MSSQL133.Text == label_defaultCluster_MSSQL133.Text)
            {
                button_check_mssql133.Invoke((MethodInvoker)(() => button_check_mssql133.Visible = true));
            }
            else
            {
                button_check_mssql133.Invoke((MethodInvoker)(() => button_check_mssql133.Visible = false));
            }
            button_mssql133.Invoke((MethodInvoker)(() => button_mssql133.Text = retry));
            return 0;
        }

        private async void button_mssql133_Click(object sender, EventArgs e)
        {
            if (verification == "valid")
            {
                try
                {
                    Task<int> task12 = Task.Run(() => mssql133()); ;
                }
                catch (ManagementException err)
                {
                    MessageBox.Show("An error occurred while querying for WMI data: " + err.Message);
                }
                catch (System.UnauthorizedAccessException unauthorizedErr)
                {
                    MessageBox.Show("Connection error (user name or password might be incorrect): " + unauthorizedErr.Message);
                }
                catch (Exception)
                {
                    label_currentCluster_MSSQL133.Invoke((MethodInvoker)(() => label_currentCluster_MSSQL133.Text = "TRY AGAIN"));
                }
            }
            else
            {
                credCheck();
                if (verification == "valid")
                {
                    button_mssql133_Click(sender, null);
                }
            }
        }

        private async Task<int> mssql137()
        {
            label_currentCluster_MSSQL137.Invoke((MethodInvoker)(() => label_currentCluster_MSSQL137.Text = string.Empty));
            label_lastReboot_MSSQL137.Invoke((MethodInvoker)(() => label_lastReboot_MSSQL137.Text = string.Empty));
            button_check_mssql137.Invoke((MethodInvoker)(() => button_check_mssql137.Visible = false));

            ConnectionOptions connection = new ConnectionOptions();
            connection.Username = textBox_username.Text;
            connection.Password = textBox_password.Text;
            connection.Authority = "ntlmdomain:teleflora.net";

            ManagementScope scope = new ManagementScope(
                "\\\\eprodsql137\\root\\CIMV2", connection);
            scope.Connect();

            ObjectQuery query = new ObjectQuery("SELECT * FROM Win32_NTDomain");
            ObjectQuery query2 = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");

            ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query);
            ManagementObjectSearcher searcher2 = new ManagementObjectSearcher(scope, query2);

            foreach (ManagementObject queryObj in searcher.Get())
            {
                label_currentCluster_MSSQL137.Invoke((MethodInvoker)(() => label_currentCluster_MSSQL137.Text = Convert.ToString(queryObj["Caption"])));
                break;
            }

            foreach (ManagementObject queryObj in searcher2.Get())
            {
                string unparsedDateTime = Convert.ToString(queryObj["LastBootUpTime"]);
                string parsedDateTime = Convert.ToString(ParseCIM_DATETIME(unparsedDateTime));
                label_currentCluster_MSSQL137.Invoke((MethodInvoker)(() => label_lastReboot_MSSQL137.Text = parsedDateTime));
                break;
            }

            if (label_currentCluster_MSSQL137.Text == label_defaultCluster_MSSQL137.Text)
            {
                button_check_mssql137.Invoke((MethodInvoker)(() => button_check_mssql137.Visible = true));
            }
            else
            {
                button_check_mssql137.Invoke((MethodInvoker)(() => button_check_mssql137.Visible = false));
            }
            button_mssql137.Invoke((MethodInvoker)(() => button_mssql137.Text = retry));
            return 0;
        }

        private async void button_mssql137_Click(object sender, EventArgs e)
        {
            if (verification == "valid")
            {
                try
                {
                    Task<int> task13 = Task.Run(() => mssql137());
                }
                catch (ManagementException err)
                {
                    MessageBox.Show("An error occurred while querying for WMI data: " + err.Message);
                }
                catch (System.UnauthorizedAccessException unauthorizedErr)
                {
                    MessageBox.Show("Connection error (user name or password might be incorrect): " + unauthorizedErr.Message);
                }
                catch (Exception)
                {
                    label_currentCluster_MSSQL137.Invoke((MethodInvoker)(() => label_currentCluster_MSSQL137.Text = "TRY AGAIN"));
                }
            }
            else
            {
                credCheck();
                if (verification == "valid")
                {
                    button_mssql137_Click(sender, null);
                }
            }
        }

        private async Task<int> mssql139()
        {
            label_currentCluster_MSSQL139.Invoke((MethodInvoker)(() => label_currentCluster_MSSQL139.Text = string.Empty));
            label_lastReboot_MSSQL139.Invoke((MethodInvoker)(() => label_lastReboot_MSSQL139.Text = string.Empty));
            button_check_mssql139.Invoke((MethodInvoker)(() => button_check_mssql139.Visible = false));

            ConnectionOptions connection = new ConnectionOptions();
            connection.Username = textBox_username.Text;
            connection.Password = textBox_password.Text;
            connection.Authority = "ntlmdomain:teleflora.net";

            ManagementScope scope = new ManagementScope(
                "\\\\prodsql139-20\\root\\CIMV2", connection);
            scope.Connect();

            ObjectQuery query = new ObjectQuery("SELECT * FROM Win32_NTDomain");
            ObjectQuery query2 = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");

            ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query);
            ManagementObjectSearcher searcher2 = new ManagementObjectSearcher(scope, query2);

            foreach (ManagementObject queryObj in searcher.Get())
            {
                label_currentCluster_MSSQL139.Invoke((MethodInvoker)(() => label_currentCluster_MSSQL139.Text = Convert.ToString(queryObj["Caption"])));
                break;
            }

            foreach (ManagementObject queryObj in searcher2.Get())
            {
                string unparsedDateTime = Convert.ToString(queryObj["LastBootUpTime"]);
                string parsedDateTime = Convert.ToString(ParseCIM_DATETIME(unparsedDateTime));
                label_currentCluster_MSSQL139.Invoke((MethodInvoker)(() => label_lastReboot_MSSQL139.Text = parsedDateTime));
                break;
            }

            if (label_currentCluster_MSSQL139.Text == label_defaultCluster_MSSQL139.Text)
            {
                button_check_mssql139.Invoke((MethodInvoker)(() => button_check_mssql139.Visible = true));
            }
            else
            {
                button_check_mssql139.Invoke((MethodInvoker)(() => button_check_mssql139.Visible = false));
            }
            button_mssql139.Invoke((MethodInvoker)(() => button_mssql139.Text = retry));
            return 0;
        }

        private async void button_mssql139_Click(object sender, EventArgs e)
        {
            if (verification == "valid")
            {
                try
                {
                    Task<int> task14 = Task.Run(() => mssql139());
                }
                catch (ManagementException err)
                {
                    MessageBox.Show("An error occurred while querying for WMI data: " + err.Message);
                }
                catch (System.UnauthorizedAccessException unauthorizedErr)
                {
                    MessageBox.Show("Connection error (user name or password might be incorrect): " + unauthorizedErr.Message);
                }
                catch (Exception)
                {
                    label_currentCluster_MSSQL139.Invoke((MethodInvoker)(() => label_currentCluster_MSSQL139.Text = "TRY AGAIN"));
                }
            }
            else
            {
                credCheck();
                if (verification == "valid")
                {
                    button_mssql139_Click(sender, null);
                }
            }
        }

        private async Task<int> mssql146()
        {
            label_currentCluster_MSSQL146.Invoke((MethodInvoker)(() => label_currentCluster_MSSQL146.Text = string.Empty));
            label_lastReboot_MSSQL146.Invoke((MethodInvoker)(() => label_lastReboot_MSSQL146.Text = string.Empty));
            button_check_mssql146.Invoke((MethodInvoker)(() => button_check_mssql146.Visible = false));

            ConnectionOptions connection = new ConnectionOptions();
            connection.Username = textBox_username.Text;
            connection.Password = textBox_password.Text;
            connection.Authority = "ntlmdomain:teleflora.net";

            ManagementScope scope = new ManagementScope(
                "\\\\eprodsql146\\root\\CIMV2", connection);
            scope.Connect();

            ObjectQuery query = new ObjectQuery("SELECT * FROM Win32_NTDomain");
            ObjectQuery query2 = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");

            ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query);
            ManagementObjectSearcher searcher2 = new ManagementObjectSearcher(scope, query2);

            foreach (ManagementObject queryObj in searcher.Get())
            {

                label_currentCluster_MSSQL146.Invoke((MethodInvoker)(() => label_currentCluster_MSSQL146.Text = Convert.ToString(queryObj["Caption"])));
                break;
            }

            foreach (ManagementObject queryObj in searcher2.Get())
            {
                string unparsedDateTime = Convert.ToString(queryObj["LastBootUpTime"]);
                string parsedDateTime = Convert.ToString(ParseCIM_DATETIME(unparsedDateTime));
                label_currentCluster_MSSQL146.Invoke((MethodInvoker)(() => label_lastReboot_MSSQL146.Text = parsedDateTime));
                break;
            }

            if (label_currentCluster_MSSQL146.Text == label_defaultCluster_MSSQL146.Text)
            {
                button_check_mssql146.Invoke((MethodInvoker)(() => button_check_mssql146.Visible = true));
            }
            else
            {
                button_check_mssql146.Invoke((MethodInvoker)(() => button_check_mssql146.Visible = false));
            }
            button_mssql146.Invoke((MethodInvoker)(() => button_mssql146.Text = retry));
            return 0;
        }

        private async void button_mssql146_Click(object sender, EventArgs e)
        {
            if (verification == "valid")
            {
                try
                {
                    Task<int> task15 = Task.Run(() => mssql146());
                }
                catch (ManagementException err)
                {
                    MessageBox.Show("An error occurred while querying for WMI data: " + err.Message);
                }
                catch (System.UnauthorizedAccessException unauthorizedErr)
                {
                    MessageBox.Show("Connection error (user name or password might be incorrect): " + unauthorizedErr.Message);
                }
                catch (Exception)
                {
                    label_currentCluster_MSSQL146.Invoke((MethodInvoker)(() => label_currentCluster_MSSQL146.Text = "TRY AGAIN"));
                }
            }
            else
            {
                credCheck();
                if (verification == "valid")
                {
                    button_mssql146_Click(sender, null);
                }
            }
        }

        /// <summary>
        /// method used to parse the datetime returned from a WMI call. The date format
        /// that WMI works well with is CIM_DATETIME. The date is stored as a humany readable
        /// format, such as 20100101161959.115081+060 (This represents 01/01/2010 16:19:59) This
        /// method converts CIM_DATETIME values into .Net readable DateTime object
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        private DateTime ParseCIM_DATETIME(string date)
        {
            //datetime object to store the return value
            DateTime parsed = DateTime.MinValue;

            //check date integrity
            if (date != null && date.IndexOf('.') != -1)
            {
                //obtain the date with miliseconds
                string newDate = date.Substring(0, date.IndexOf('.') + 4);
 
                //check the lenght
                if (newDate.Length == 18)
                {
                    //extract each date component
                    int y = Convert.ToInt32(newDate.Substring(0, 4));
                    int m = Convert.ToInt32(newDate.Substring(4, 2));
                    int d = Convert.ToInt32(newDate.Substring(6, 2));
                    int h = Convert.ToInt32(newDate.Substring(8, 2));
                    int mm = Convert.ToInt32(newDate.Substring(10, 2));
                    int s = Convert.ToInt32(newDate.Substring(12, 2));
                    int ms = Convert.ToInt32(newDate.Substring(15, 3));
 
                    //compose the new datetime object
                    parsed = new DateTime(y, m, d, h, mm, s, ms);
                }
            }
 
            //return datetime
            return parsed;
        }

        private void textBox_username_TextChanged(object sender, EventArgs e)
        {
            verification = string.Empty;
            button_cred_check.Text = "X";
            button_cred_check.BackColor = Color.Red;
            button_cred_check.Font = new Font("Microsoft Sans Serif", 7.8f);
            button_cred_check.Visible = true;
        }

        private void textBox_password_TextChanged(object sender, EventArgs e)
        {
            verification = string.Empty;
            button_cred_check.Text = "X";
            button_cred_check.BackColor = Color.Red;
            button_cred_check.Font = new Font("Microsoft Sans Serif", 7.8f);
            button_cred_check.Visible = true;
        }
    }

    public static class UserValidation
    {
        [DllImport("advapi32.dll", SetLastError = true)]
        static extern bool LogonUser(string principal, string authority, string password, LogonTypes logonType, LogonProviders logonProvider, out IntPtr token);
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool CloseHandle(IntPtr handle);
        enum LogonProviders : uint
        {
            Default = 0, // default for platform (use this!)
            WinNT35,     // sends smoke signals to authority
            WinNT40,     // uses NTLM
            WinNT50      // negotiates Kerb or NTLM
        }
        enum LogonTypes : uint
        {
            Interactive = 2,
            Network = 3,
            Batch = 4,
            Service = 5,
            Unlock = 7,
            NetworkCleartext = 8,
            NewCredentials = 9
        }
        public const int ERROR_PASSWORD_MUST_CHANGE = 1907;
        public const int ERROR_LOGON_FAILURE = 1326;
        public const int ERROR_ACCOUNT_RESTRICTION = 1327;
        public const int ERROR_ACCOUNT_DISABLED = 1331;
        public const int ERROR_INVALID_LOGON_HOURS = 1328;
        public const int ERROR_NO_LOGON_SERVERS = 1311;
        public const int ERROR_INVALID_WORKSTATION = 1329;
        public const int ERROR_ACCOUNT_LOCKED_OUT = 1909;      //It gives this error if the account is locked, REGARDLESS OF WHETHER VALID CREDENTIALS WERE PROVIDED!!!
        public const int ERROR_ACCOUNT_EXPIRED = 1793;
        public const int ERROR_PASSWORD_EXPIRED = 1330;

        public static int CheckUserLogon(string username, string password, string domain_fqdn)
        {
            int errorCode = 0;
            using (PrincipalContext pc = new PrincipalContext(ContextType.Domain, domain_fqdn, "ADMIN_USER", "PASSWORD"))
            {
                if (!pc.ValidateCredentials(username, password))
                {
                    IntPtr token = new IntPtr();
                    try
                    {
                        if (!LogonUser(username, domain_fqdn, password, LogonTypes.Network, LogonProviders.Default, out token))
                        {
                            errorCode = Marshal.GetLastWin32Error();
                        }
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                    finally
                    {
                        CloseHandle(token);
                    }
                }
            }

            if (errorCode == 0)
            {
                
            }
            else if (errorCode == 1907)
            {
                MessageBox.Show("ERROR_PASSWORD_MUST_CHANGE = 1907");
            }
            else if (errorCode == 1326)
            {
                MessageBox.Show("ERROR_LOGON_FAILURE = 1326;");
            }
            else if (errorCode == 1327)
            {
                MessageBox.Show("ERROR_ACCOUNT_RESTRICTION = 1327");
            }
            else if (errorCode == 1331)
            {
                MessageBox.Show("ERROR_ACCOUNT_DISABLED = 1331");
            }
            else if (errorCode == 1328)
            {
                MessageBox.Show("ERROR_INVALID_LOGON_HOURS = 1328");
            }
            else if (errorCode == 1311)
            {
                MessageBox.Show("ERROR_NO_LOGON_SERVERS = 1311");
            }
            else if (errorCode == 1329)
            {
                MessageBox.Show("ERROR_INVALID_WORKSTATION = 1329");
            }
            else if (errorCode == 1909)
            {
                MessageBox.Show("ERROR_ACCOUNT_LOCKED_OUT = 1909");
            }
            else if (errorCode == 1793)
            {
                MessageBox.Show("ERROR_ACCOUNT_EXPIRED = 1793");
            }
            else if (errorCode == 1330)
            {
                MessageBox.Show("ERROR_PASSWORD_EXPIRED = 1330");
            }
            else
            {

            }

            return errorCode;
        }
    }
}
