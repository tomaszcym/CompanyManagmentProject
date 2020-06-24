namespace CompanyManagmentProject
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.dashboard = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.NumberOfEmployeesCounter = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.activeTaskCounter = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.overviewCounterEmployee = new System.Windows.Forms.Label();
            this.overviewCounterActiveTask = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.overviewCounterFinishTask = new System.Windows.Forms.Label();
            this.companyDetails = new System.Windows.Forms.TabPage();
            this.panel27 = new System.Windows.Forms.Panel();
            this.companyDetailsSaveButton = new System.Windows.Forms.Button();
            this.panel25 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.companyNIP = new System.Windows.Forms.TextBox();
            this.panel26 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.companyCountry = new System.Windows.Forms.TextBox();
            this.panel23 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.companyPostcode = new System.Windows.Forms.TextBox();
            this.panel24 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.companyCity = new System.Windows.Forms.TextBox();
            this.panel22 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.companyAddress = new System.Windows.Forms.TextBox();
            this.panel21 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.companyName = new System.Windows.Forms.TextBox();
            this.panel20 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel19 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.employees = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.employeeListView = new System.Windows.Forms.ListView();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.newEmployee = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tasks = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.iconlist = new System.Windows.Forms.ImageList(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.employeeRepositoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.overviewCompanyDetails = new System.Windows.Forms.Label();
            this.overviewCompanyNIP = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.overviewCompanyPostcode = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.overviewCompanyCity = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.overviewCompanyAddres = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.overviewCompanyName = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newTaskButton = new System.Windows.Forms.Button();
            this.DeleteTaskButton = new System.Windows.Forms.Button();
            this.mainTabControl.SuspendLayout();
            this.dashboard.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel17.SuspendLayout();
            this.companyDetails.SuspendLayout();
            this.panel27.SuspendLayout();
            this.panel25.SuspendLayout();
            this.panel26.SuspendLayout();
            this.panel23.SuspendLayout();
            this.panel24.SuspendLayout();
            this.panel22.SuspendLayout();
            this.panel21.SuspendLayout();
            this.panel20.SuspendLayout();
            this.employees.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.tasks.SuspendLayout();
            this.flowLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeRepositoryBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.mainTabControl.Controls.Add(this.dashboard);
            this.mainTabControl.Controls.Add(this.companyDetails);
            this.mainTabControl.Controls.Add(this.employees);
            this.mainTabControl.Controls.Add(this.tasks);
            this.mainTabControl.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.mainTabControl.ImageList = this.imageList2;
            this.mainTabControl.Location = new System.Drawing.Point(419, 0);
            this.mainTabControl.Margin = new System.Windows.Forms.Padding(4);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.Padding = new System.Drawing.Point(6, 4);
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1075, 683);
            this.mainTabControl.TabIndex = 1;
            this.mainTabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.mainTabControl_Selected);
            // 
            // dashboard
            // 
            this.dashboard.Controls.Add(this.panel2);
            this.dashboard.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.dashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.dashboard.ImageIndex = 0;
            this.dashboard.Location = new System.Drawing.Point(4, 44);
            this.dashboard.Margin = new System.Windows.Forms.Padding(4);
            this.dashboard.Name = "dashboard";
            this.dashboard.Padding = new System.Windows.Forms.Padding(4);
            this.dashboard.Size = new System.Drawing.Size(1067, 635);
            this.dashboard.TabIndex = 0;
            this.dashboard.Text = "       Przegląd          ";
            this.dashboard.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.panel2.Controls.Add(this.panel14);
            this.panel2.Controls.Add(this.panel11);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(2, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1062, 628);
            this.panel2.TabIndex = 0;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.NumberOfEmployeesCounter);
            this.panel14.Controls.Add(this.panel15);
            this.panel14.Controls.Add(this.panel16);
            this.panel14.Location = new System.Drawing.Point(0, 424);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(800, 212);
            this.panel14.TabIndex = 3;
            // 
            // NumberOfEmployeesCounter
            // 
            this.NumberOfEmployeesCounter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NumberOfEmployeesCounter.Font = new System.Drawing.Font("Century Gothic", 25.8F);
            this.NumberOfEmployeesCounter.ForeColor = System.Drawing.Color.White;
            this.NumberOfEmployeesCounter.Location = new System.Drawing.Point(0, 0);
            this.NumberOfEmployeesCounter.Name = "NumberOfEmployeesCounter";
            this.NumberOfEmployeesCounter.Size = new System.Drawing.Size(800, 212);
            this.NumberOfEmployeesCounter.TabIndex = 4;
            this.NumberOfEmployeesCounter.Text = "ILOŚĆ PRACOWNIKÓW:";
            this.NumberOfEmployeesCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel15
            // 
            this.panel15.Location = new System.Drawing.Point(8, 208);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(800, 216);
            this.panel15.TabIndex = 3;
            // 
            // panel16
            // 
            this.panel16.Location = new System.Drawing.Point(0, 216);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(800, 216);
            this.panel16.TabIndex = 2;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.label11);
            this.panel11.Controls.Add(this.panel12);
            this.panel11.Controls.Add(this.panel13);
            this.panel11.Location = new System.Drawing.Point(0, 212);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(800, 212);
            this.panel11.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 25.8F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(800, 212);
            this.label11.TabIndex = 5;
            this.label11.Text = "ZAKOŃCZONE ZADANIA:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel12
            // 
            this.panel12.Location = new System.Drawing.Point(8, 208);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(800, 216);
            this.panel12.TabIndex = 3;
            // 
            // panel13
            // 
            this.panel13.Location = new System.Drawing.Point(0, 216);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(800, 216);
            this.panel13.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.activeTaskCounter);
            this.panel8.Controls.Add(this.panel10);
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(800, 212);
            this.panel8.TabIndex = 1;
            // 
            // activeTaskCounter
            // 
            this.activeTaskCounter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.activeTaskCounter.Font = new System.Drawing.Font("Century Gothic", 25.8F);
            this.activeTaskCounter.ForeColor = System.Drawing.Color.White;
            this.activeTaskCounter.Location = new System.Drawing.Point(0, 0);
            this.activeTaskCounter.Name = "activeTaskCounter";
            this.activeTaskCounter.Size = new System.Drawing.Size(800, 212);
            this.activeTaskCounter.TabIndex = 4;
            this.activeTaskCounter.Text = "AKTYWNE ZADANIA:";
            this.activeTaskCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel10
            // 
            this.panel10.Location = new System.Drawing.Point(8, 208);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(800, 216);
            this.panel10.TabIndex = 3;
            // 
            // panel9
            // 
            this.panel9.Location = new System.Drawing.Point(0, 216);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(800, 216);
            this.panel9.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.overviewCounterEmployee);
            this.panel3.Controls.Add(this.overviewCounterActiveTask);
            this.panel3.Controls.Add(this.panel17);
            this.panel3.Location = new System.Drawing.Point(754, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(274, 650);
            this.panel3.TabIndex = 0;
            // 
            // overviewCounterEmployee
            // 
            this.overviewCounterEmployee.Font = new System.Drawing.Font("Century Gothic", 45.8F, System.Drawing.FontStyle.Bold);
            this.overviewCounterEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(7)))), ((int)(((byte)(63)))));
            this.overviewCounterEmployee.Location = new System.Drawing.Point(7, 411);
            this.overviewCounterEmployee.Name = "overviewCounterEmployee";
            this.overviewCounterEmployee.Size = new System.Drawing.Size(255, 228);
            this.overviewCounterEmployee.TabIndex = 2;
            this.overviewCounterEmployee.Text = "11";
            this.overviewCounterEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // overviewCounterActiveTask
            // 
            this.overviewCounterActiveTask.Font = new System.Drawing.Font("Century Gothic", 45.8F, System.Drawing.FontStyle.Bold);
            this.overviewCounterActiveTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(7)))), ((int)(((byte)(63)))));
            this.overviewCounterActiveTask.Location = new System.Drawing.Point(3, 0);
            this.overviewCounterActiveTask.Name = "overviewCounterActiveTask";
            this.overviewCounterActiveTask.Size = new System.Drawing.Size(255, 207);
            this.overviewCounterActiveTask.TabIndex = 0;
            this.overviewCounterActiveTask.Text = "11";
            this.overviewCounterActiveTask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.overviewCounterFinishTask);
            this.panel17.Location = new System.Drawing.Point(0, 222);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(262, 207);
            this.panel17.TabIndex = 1;
            // 
            // overviewCounterFinishTask
            // 
            this.overviewCounterFinishTask.Font = new System.Drawing.Font("Century Gothic", 45.8F, System.Drawing.FontStyle.Bold);
            this.overviewCounterFinishTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(7)))), ((int)(((byte)(63)))));
            this.overviewCounterFinishTask.Location = new System.Drawing.Point(3, -13);
            this.overviewCounterFinishTask.Name = "overviewCounterFinishTask";
            this.overviewCounterFinishTask.Size = new System.Drawing.Size(259, 202);
            this.overviewCounterFinishTask.TabIndex = 2;
            this.overviewCounterFinishTask.Text = "11";
            this.overviewCounterFinishTask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // companyDetails
            // 
            this.companyDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.companyDetails.Controls.Add(this.panel27);
            this.companyDetails.Controls.Add(this.panel25);
            this.companyDetails.Controls.Add(this.panel26);
            this.companyDetails.Controls.Add(this.panel23);
            this.companyDetails.Controls.Add(this.panel24);
            this.companyDetails.Controls.Add(this.panel22);
            this.companyDetails.Controls.Add(this.panel21);
            this.companyDetails.Controls.Add(this.panel20);
            this.companyDetails.Controls.Add(this.panel19);
            this.companyDetails.Controls.Add(this.panel18);
            this.companyDetails.Controls.Add(this.flowLayoutPanel3);
            this.companyDetails.Controls.Add(this.flowLayoutPanel2);
            this.companyDetails.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.companyDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.companyDetails.ImageIndex = 1;
            this.companyDetails.Location = new System.Drawing.Point(4, 44);
            this.companyDetails.Margin = new System.Windows.Forms.Padding(4);
            this.companyDetails.Name = "companyDetails";
            this.companyDetails.Padding = new System.Windows.Forms.Padding(4);
            this.companyDetails.Size = new System.Drawing.Size(1067, 635);
            this.companyDetails.TabIndex = 1;
            this.companyDetails.Text = "      Edytuj dane firmy          ";
            // 
            // panel27
            // 
            this.panel27.Controls.Add(this.companyDetailsSaveButton);
            this.panel27.Location = new System.Drawing.Point(108, 450);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(850, 175);
            this.panel27.TabIndex = 13;
            // 
            // companyDetailsSaveButton
            // 
            this.companyDetailsSaveButton.FlatAppearance.BorderSize = 3;
            this.companyDetailsSaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.companyDetailsSaveButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.companyDetailsSaveButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(7)))), ((int)(((byte)(63)))));
            this.companyDetailsSaveButton.Location = new System.Drawing.Point(355, 65);
            this.companyDetailsSaveButton.Name = "companyDetailsSaveButton";
            this.companyDetailsSaveButton.Size = new System.Drawing.Size(140, 45);
            this.companyDetailsSaveButton.TabIndex = 0;
            this.companyDetailsSaveButton.Text = "ZAPISZ";
            this.companyDetailsSaveButton.UseVisualStyleBackColor = true;
            this.companyDetailsSaveButton.Click += new System.EventHandler(this.companyDetailsSaveButton_Click);
            // 
            // panel25
            // 
            this.panel25.Controls.Add(this.label5);
            this.panel25.Controls.Add(this.companyNIP);
            this.panel25.Location = new System.Drawing.Point(533, 350);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(425, 100);
            this.panel25.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12.2F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(100, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 31);
            this.label5.TabIndex = 3;
            this.label5.Text = "NIP";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // companyNIP
            // 
            this.companyNIP.Location = new System.Drawing.Point(100, 46);
            this.companyNIP.Name = "companyNIP";
            this.companyNIP.Size = new System.Drawing.Size(225, 28);
            this.companyNIP.TabIndex = 1;
            // 
            // panel26
            // 
            this.panel26.Controls.Add(this.label6);
            this.panel26.Controls.Add(this.companyCountry);
            this.panel26.Location = new System.Drawing.Point(108, 350);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(425, 100);
            this.panel26.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12.2F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(100, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(225, 31);
            this.label6.TabIndex = 3;
            this.label6.Text = "PAŃSTWO";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // companyCountry
            // 
            this.companyCountry.Location = new System.Drawing.Point(100, 46);
            this.companyCountry.Name = "companyCountry";
            this.companyCountry.Size = new System.Drawing.Size(225, 28);
            this.companyCountry.TabIndex = 1;
            // 
            // panel23
            // 
            this.panel23.Controls.Add(this.label4);
            this.panel23.Controls.Add(this.companyPostcode);
            this.panel23.Location = new System.Drawing.Point(533, 250);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(425, 100);
            this.panel23.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12.2F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(100, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "KOD POCZTOWY";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // companyPostcode
            // 
            this.companyPostcode.Location = new System.Drawing.Point(100, 46);
            this.companyPostcode.Name = "companyPostcode";
            this.companyPostcode.Size = new System.Drawing.Size(225, 28);
            this.companyPostcode.TabIndex = 1;
            // 
            // panel24
            // 
            this.panel24.Controls.Add(this.label3);
            this.panel24.Controls.Add(this.companyCity);
            this.panel24.Location = new System.Drawing.Point(108, 250);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(425, 100);
            this.panel24.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12.2F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(100, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "MIASTO";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // companyCity
            // 
            this.companyCity.Location = new System.Drawing.Point(100, 46);
            this.companyCity.Name = "companyCity";
            this.companyCity.Size = new System.Drawing.Size(225, 28);
            this.companyCity.TabIndex = 1;
            // 
            // panel22
            // 
            this.panel22.Controls.Add(this.label2);
            this.panel22.Controls.Add(this.companyAddress);
            this.panel22.Location = new System.Drawing.Point(533, 150);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(425, 100);
            this.panel22.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12.2F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(100, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "ADRES";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // companyAddress
            // 
            this.companyAddress.Location = new System.Drawing.Point(100, 46);
            this.companyAddress.Name = "companyAddress";
            this.companyAddress.Size = new System.Drawing.Size(225, 28);
            this.companyAddress.TabIndex = 1;
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.label1);
            this.panel21.Controls.Add(this.companyName);
            this.panel21.Location = new System.Drawing.Point(108, 150);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(425, 100);
            this.panel21.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12.2F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(100, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "NAZWA FIRMY";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // companyName
            // 
            this.companyName.Location = new System.Drawing.Point(100, 46);
            this.companyName.Name = "companyName";
            this.companyName.Size = new System.Drawing.Size(225, 28);
            this.companyName.TabIndex = 0;
            // 
            // panel20
            // 
            this.panel20.Controls.Add(this.label9);
            this.panel20.Location = new System.Drawing.Point(108, 0);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(850, 150);
            this.panel20.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(7)))), ((int)(((byte)(63)))));
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(850, 150);
            this.label9.TabIndex = 0;
            this.label9.Text = "Wprowadź dane firmy";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // panel19
            // 
            this.panel19.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel19.Location = new System.Drawing.Point(954, 4);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(109, 627);
            this.panel19.TabIndex = 5;
            // 
            // panel18
            // 
            this.panel18.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel18.Location = new System.Drawing.Point(4, 4);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(108, 627);
            this.panel18.TabIndex = 4;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(4, 631);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(1059, 0);
            this.flowLayoutPanel3.TabIndex = 3;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1059, 0);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // employees
            // 
            this.employees.Controls.Add(this.flowLayoutPanel7);
            this.employees.Controls.Add(this.flowLayoutPanel5);
            this.employees.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.employees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.employees.ImageIndex = 2;
            this.employees.Location = new System.Drawing.Point(4, 44);
            this.employees.Margin = new System.Windows.Forms.Padding(4);
            this.employees.Name = "employees";
            this.employees.Size = new System.Drawing.Size(1067, 635);
            this.employees.TabIndex = 2;
            this.employees.Text = "       Pracownicy          ";
            this.employees.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.AutoSize = true;
            this.flowLayoutPanel7.Controls.Add(this.employeeListView);
            this.flowLayoutPanel7.Controls.Add(this.checkedListBox1);
            this.flowLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel7.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel7.Location = new System.Drawing.Point(0, 52);
            this.flowLayoutPanel7.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(1067, 583);
            this.flowLayoutPanel7.TabIndex = 7;
            // 
            // employeeListView
            // 
            this.employeeListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.employeeListView.ForeColor = System.Drawing.Color.White;
            this.employeeListView.HideSelection = false;
            this.employeeListView.Location = new System.Drawing.Point(4, 4);
            this.employeeListView.Margin = new System.Windows.Forms.Padding(4);
            this.employeeListView.Name = "employeeListView";
            this.employeeListView.Size = new System.Drawing.Size(1059, 570);
            this.employeeListView.TabIndex = 0;
            this.employeeListView.UseCompatibleStateImageBehavior = false;
            this.employeeListView.Click += new System.EventHandler(this.employeeListView_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(1071, 4);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(159, 96);
            this.checkedListBox1.TabIndex = 1;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.AutoSize = true;
            this.flowLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel5.BackColor = System.Drawing.Color.Black;
            this.flowLayoutPanel5.Controls.Add(this.newEmployee);
            this.flowLayoutPanel5.Controls.Add(this.button1);
            this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel5.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel5.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(1067, 52);
            this.flowLayoutPanel5.TabIndex = 5;
            // 
            // newEmployee
            // 
            this.newEmployee.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.newEmployee.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.newEmployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.newEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.newEmployee.Font = new System.Drawing.Font("Junegull", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(7)))), ((int)(((byte)(63)))));
            this.newEmployee.Location = new System.Drawing.Point(987, 1);
            this.newEmployee.Margin = new System.Windows.Forms.Padding(1, 1, 30, 1);
            this.newEmployee.Name = "newEmployee";
            this.newEmployee.Size = new System.Drawing.Size(50, 50);
            this.newEmployee.TabIndex = 2;
            this.newEmployee.Text = "+";
            this.newEmployee.UseVisualStyleBackColor = true;
            this.newEmployee.Click += new System.EventHandler(this.newEmployee_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(7)))), ((int)(((byte)(63)))));
            this.button1.Location = new System.Drawing.Point(817, 1);
            this.button1.Margin = new System.Windows.Forms.Padding(1, 1, 30, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "Zapisz";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tasks
            // 
            this.tasks.Controls.Add(this.listView1);
            this.tasks.Controls.Add(this.flowLayoutPanel8);
            this.tasks.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.tasks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.tasks.ImageIndex = 3;
            this.tasks.Location = new System.Drawing.Point(4, 44);
            this.tasks.Margin = new System.Windows.Forms.Padding(4);
            this.tasks.Name = "tasks";
            this.tasks.Size = new System.Drawing.Size(1067, 635);
            this.tasks.TabIndex = 4;
            this.tasks.Text = "       Zadania          ";
            this.tasks.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.listView1.ForeColor = System.Drawing.Color.White;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(-4, 56);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1067, 579);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // flowLayoutPanel8
            // 
            this.flowLayoutPanel8.AutoSize = true;
            this.flowLayoutPanel8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel8.BackColor = System.Drawing.Color.Black;
            this.flowLayoutPanel8.Controls.Add(this.newTaskButton);
            this.flowLayoutPanel8.Controls.Add(this.DeleteTaskButton);
            this.flowLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel8.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel8.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel8.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel8.Name = "flowLayoutPanel8";
            this.flowLayoutPanel8.Size = new System.Drawing.Size(1067, 52);
            this.flowLayoutPanel8.TabIndex = 6;
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "icon1.png");
            this.imageList2.Images.SetKeyName(1, "icon2.png");
            this.imageList2.Images.SetKeyName(2, "icon3.png");
            this.imageList2.Images.SetKeyName(3, "icon4.png");
            // 
            // iconlist
            // 
            this.iconlist.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.iconlist.ImageSize = new System.Drawing.Size(16, 16);
            this.iconlist.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.panel1.Controls.Add(this.overviewCompanyDetails);
            this.panel1.Controls.Add(this.overviewCompanyNIP);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 670);
            this.panel1.TabIndex = 2;
            // 
            // overviewCompanyDetails
            // 
            this.overviewCompanyDetails.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.overviewCompanyDetails.ForeColor = System.Drawing.Color.White;
            this.overviewCompanyDetails.Location = new System.Drawing.Point(0, 455);
            this.overviewCompanyDetails.Name = "overviewCompanyDetails";
            this.overviewCompanyDetails.Size = new System.Drawing.Size(412, 85);
            this.overviewCompanyDetails.TabIndex = 11;
            this.overviewCompanyDetails.Text = "Państwo";
            this.overviewCompanyDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // overviewCompanyNIP
            // 
            this.overviewCompanyNIP.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.overviewCompanyNIP.ForeColor = System.Drawing.Color.White;
            this.overviewCompanyNIP.Location = new System.Drawing.Point(3, 540);
            this.overviewCompanyNIP.Name = "overviewCompanyNIP";
            this.overviewCompanyNIP.Size = new System.Drawing.Size(412, 81);
            this.overviewCompanyNIP.TabIndex = 10;
            this.overviewCompanyNIP.Text = "NIP";
            this.overviewCompanyNIP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.Location = new System.Drawing.Point(13, 620);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(389, 40);
            this.label12.TabIndex = 9;
            this.label12.Text = "Tomasz Cymerys, Arkadiusz Wójcik, Mariusz Kardaś";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.overviewCompanyPostcode);
            this.panel7.Location = new System.Drawing.Point(0, 367);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(415, 85);
            this.panel7.TabIndex = 5;
            // 
            // overviewCompanyPostcode
            // 
            this.overviewCompanyPostcode.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.overviewCompanyPostcode.ForeColor = System.Drawing.Color.White;
            this.overviewCompanyPostcode.Location = new System.Drawing.Point(7, 0);
            this.overviewCompanyPostcode.Name = "overviewCompanyPostcode";
            this.overviewCompanyPostcode.Size = new System.Drawing.Size(408, 82);
            this.overviewCompanyPostcode.TabIndex = 8;
            this.overviewCompanyPostcode.Text = "Kod pocztowy";
            this.overviewCompanyPostcode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.overviewCompanyCity);
            this.panel6.Location = new System.Drawing.Point(0, 282);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(415, 85);
            this.panel6.TabIndex = 4;
            // 
            // overviewCompanyCity
            // 
            this.overviewCompanyCity.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.overviewCompanyCity.ForeColor = System.Drawing.Color.White;
            this.overviewCompanyCity.Location = new System.Drawing.Point(3, 0);
            this.overviewCompanyCity.Name = "overviewCompanyCity";
            this.overviewCompanyCity.Size = new System.Drawing.Size(412, 85);
            this.overviewCompanyCity.TabIndex = 9;
            this.overviewCompanyCity.Text = "Miasto";
            this.overviewCompanyCity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.overviewCompanyAddres);
            this.panel5.Location = new System.Drawing.Point(0, 197);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(415, 85);
            this.panel5.TabIndex = 3;
            // 
            // overviewCompanyAddres
            // 
            this.overviewCompanyAddres.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.overviewCompanyAddres.ForeColor = System.Drawing.Color.White;
            this.overviewCompanyAddres.Location = new System.Drawing.Point(3, 0);
            this.overviewCompanyAddres.Name = "overviewCompanyAddres";
            this.overviewCompanyAddres.Size = new System.Drawing.Size(412, 85);
            this.overviewCompanyAddres.TabIndex = 7;
            this.overviewCompanyAddres.Text = "Adres";
            this.overviewCompanyAddres.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.overviewCompanyName);
            this.panel4.Location = new System.Drawing.Point(0, 52);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(415, 145);
            this.panel4.TabIndex = 3;
            // 
            // overviewCompanyName
            // 
            this.overviewCompanyName.Font = new System.Drawing.Font("Century Gothic", 21.8F, System.Drawing.FontStyle.Bold);
            this.overviewCompanyName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(7)))), ((int)(((byte)(63)))));
            this.overviewCompanyName.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.overviewCompanyName.Location = new System.Drawing.Point(3, 0);
            this.overviewCompanyName.Name = "overviewCompanyName";
            this.overviewCompanyName.Size = new System.Drawing.Size(409, 145);
            this.overviewCompanyName.TabIndex = 7;
            this.overviewCompanyName.Text = "NAZWA FIRMY";
            this.overviewCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label17.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label17.Location = new System.Drawing.Point(10, 3);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(404, 49);
            this.label17.TabIndex = 2;
            this.label17.Text = "Company Managment";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // newTaskButton
            // 
            this.newTaskButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.newTaskButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.newTaskButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.newTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.newTaskButton.Font = new System.Drawing.Font("Junegull", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newTaskButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(7)))), ((int)(((byte)(63)))));
            this.newTaskButton.Location = new System.Drawing.Point(987, 1);
            this.newTaskButton.Margin = new System.Windows.Forms.Padding(1, 1, 30, 1);
            this.newTaskButton.Name = "newTaskButton";
            this.newTaskButton.Size = new System.Drawing.Size(50, 50);
            this.newTaskButton.TabIndex = 4;
            this.newTaskButton.Text = "+";
            this.newTaskButton.UseVisualStyleBackColor = true;
            // 
            // DeleteTaskButton
            // 
            this.DeleteTaskButton.FlatAppearance.BorderSize = 3;
            this.DeleteTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteTaskButton.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DeleteTaskButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(7)))), ((int)(((byte)(63)))));
            this.DeleteTaskButton.Location = new System.Drawing.Point(817, 1);
            this.DeleteTaskButton.Margin = new System.Windows.Forms.Padding(1, 1, 30, 1);
            this.DeleteTaskButton.Name = "DeleteTaskButton";
            this.DeleteTaskButton.Size = new System.Drawing.Size(139, 50);
            this.DeleteTaskButton.TabIndex = 5;
            this.DeleteTaskButton.Text = "Usuń";
            this.DeleteTaskButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1482, 670);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1500, 717);
            this.MinimumSize = new System.Drawing.Size(1500, 717);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Company Managment";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainTabControl.ResumeLayout(false);
            this.dashboard.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            this.companyDetails.ResumeLayout(false);
            this.companyDetails.PerformLayout();
            this.panel27.ResumeLayout(false);
            this.panel25.ResumeLayout(false);
            this.panel25.PerformLayout();
            this.panel26.ResumeLayout(false);
            this.panel26.PerformLayout();
            this.panel23.ResumeLayout(false);
            this.panel23.PerformLayout();
            this.panel24.ResumeLayout(false);
            this.panel24.PerformLayout();
            this.panel22.ResumeLayout(false);
            this.panel22.PerformLayout();
            this.panel21.ResumeLayout(false);
            this.panel21.PerformLayout();
            this.panel20.ResumeLayout(false);
            this.employees.ResumeLayout(false);
            this.employees.PerformLayout();
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel5.ResumeLayout(false);
            this.tasks.ResumeLayout(false);
            this.tasks.PerformLayout();
            this.flowLayoutPanel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeeRepositoryBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage dashboard;
        private System.Windows.Forms.TabPage employees;
        private System.Windows.Forms.TabPage tasks;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel8;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.BindingSource employeeRepositoryBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label overviewCompanyDetails;
        private System.Windows.Forms.Label overviewCompanyNIP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label overviewCompanyPostcode;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label overviewCompanyCity;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label overviewCompanyAddres;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label overviewCompanyName;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label NumberOfEmployeesCounter;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label activeTaskCounter;
        private System.Windows.Forms.Label overviewCounterEmployee;
        private System.Windows.Forms.Label overviewCounterActiveTask;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Label overviewCounterFinishTask;
        private System.Windows.Forms.ImageList iconlist;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.TabPage companyDetails;
        private System.Windows.Forms.Panel panel27;
        private System.Windows.Forms.Panel panel25;
        private System.Windows.Forms.TextBox companyNIP;
        private System.Windows.Forms.Panel panel26;
        private System.Windows.Forms.TextBox companyCountry;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.TextBox companyPostcode;
        private System.Windows.Forms.Panel panel24;
        private System.Windows.Forms.TextBox companyCity;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.TextBox companyAddress;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox companyName;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button companyDetailsSaveButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.ListView employeeListView;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Button newEmployee;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button newTaskButton;
        private System.Windows.Forms.Button DeleteTaskButton;
    }
}

