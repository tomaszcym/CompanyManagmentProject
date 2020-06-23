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
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.dashboard = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.overviewCompanyName = new System.Windows.Forms.Label();
            this.activeTaskCounter = new System.Windows.Forms.Label();
            this.finishTaskCounter = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.overviewTime = new System.Windows.Forms.Label();
            this.overviewCounterActiveTask = new System.Windows.Forms.Label();
            this.overviewCounterFinishTask = new System.Windows.Forms.Label();
            this.overviewCounterEmployee = new System.Windows.Forms.Label();
            this.companyDetails = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.companyName = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.companyAddress = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.companyCity = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.companyPostcode = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.companyCountry = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.companyNIP = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.companyDetailsSaveButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.employees = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.employeeListView = new System.Windows.Forms.ListView();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.newEmployee = new System.Windows.Forms.Button();
            this.tasks = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.newTaskButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.employeeRepositoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainTabControl.SuspendLayout();
            this.dashboard.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.companyDetails.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.employees.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.tasks.SuspendLayout();
            this.flowLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeRepositoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.dashboard);
            this.mainTabControl.Controls.Add(this.companyDetails);
            this.mainTabControl.Controls.Add(this.employees);
            this.mainTabControl.Controls.Add(this.tasks);
            this.mainTabControl.Location = new System.Drawing.Point(0, 1);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(990, 529);
            this.mainTabControl.TabIndex = 1;
            this.mainTabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.mainTabControl_Selected);
            // 
            // dashboard
            // 
            this.dashboard.Controls.Add(this.tableLayoutPanel8);
            this.dashboard.Location = new System.Drawing.Point(4, 22);
            this.dashboard.Name = "dashboard";
            this.dashboard.Padding = new System.Windows.Forms.Padding(3);
            this.dashboard.Size = new System.Drawing.Size(982, 503);
            this.dashboard.TabIndex = 0;
            this.dashboard.Text = "Przegląd";
            this.dashboard.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 3;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.85714F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.14286F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 679F));
            this.tableLayoutPanel8.Controls.Add(this.overviewCompanyName, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.activeTaskCounter, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.finishTaskCounter, 0, 2);
            this.tableLayoutPanel8.Controls.Add(this.label11, 0, 3);
            this.tableLayoutPanel8.Controls.Add(this.overviewTime, 2, 4);
            this.tableLayoutPanel8.Controls.Add(this.overviewCounterActiveTask, 1, 1);
            this.tableLayoutPanel8.Controls.Add(this.overviewCounterFinishTask, 1, 2);
            this.tableLayoutPanel8.Controls.Add(this.overviewCounterEmployee, 1, 3);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 5;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(982, 503);
            this.tableLayoutPanel8.TabIndex = 0;
            // 
            // overviewCompanyName
            // 
            this.overviewCompanyName.AutoSize = true;
            this.overviewCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.overviewCompanyName.Location = new System.Drawing.Point(3, 0);
            this.overviewCompanyName.Name = "overviewCompanyName";
            this.overviewCompanyName.Size = new System.Drawing.Size(159, 83);
            this.overviewCompanyName.TabIndex = 0;
            this.overviewCompanyName.Text = "Nazwa firmy";
            // 
            // activeTaskCounter
            // 
            this.activeTaskCounter.AutoSize = true;
            this.activeTaskCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.activeTaskCounter.Location = new System.Drawing.Point(3, 98);
            this.activeTaskCounter.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.activeTaskCounter.Name = "activeTaskCounter";
            this.activeTaskCounter.Size = new System.Drawing.Size(197, 25);
            this.activeTaskCounter.TabIndex = 1;
            this.activeTaskCounter.Text = "Aktywne zadania:";
            // 
            // finishTaskCounter
            // 
            this.finishTaskCounter.AutoSize = true;
            this.finishTaskCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.finishTaskCounter.Location = new System.Drawing.Point(3, 181);
            this.finishTaskCounter.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.finishTaskCounter.Name = "finishTaskCounter";
            this.finishTaskCounter.Size = new System.Drawing.Size(147, 50);
            this.finishTaskCounter.TabIndex = 2;
            this.finishTaskCounter.Text = "Zakończone zadania:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(3, 264);
            this.label11.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(210, 25);
            this.label11.TabIndex = 3;
            this.label11.Text = "Ilość pracowników:";
            // 
            // overviewTime
            // 
            this.overviewTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.overviewTime.AutoSize = true;
            this.overviewTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.overviewTime.Location = new System.Drawing.Point(682, 463);
            this.overviewTime.Margin = new System.Windows.Forms.Padding(15, 0, 25, 15);
            this.overviewTime.Name = "overviewTime";
            this.overviewTime.Size = new System.Drawing.Size(275, 25);
            this.overviewTime.TabIndex = 4;
            this.overviewTime.Text = "Tego nie będzie kurwa mać";
            // 
            // overviewCounterActiveTask
            // 
            this.overviewCounterActiveTask.AutoSize = true;
            this.overviewCounterActiveTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.overviewCounterActiveTask.Location = new System.Drawing.Point(229, 98);
            this.overviewCounterActiveTask.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.overviewCounterActiveTask.Name = "overviewCounterActiveTask";
            this.overviewCounterActiveTask.Size = new System.Drawing.Size(38, 25);
            this.overviewCounterActiveTask.TabIndex = 5;
            this.overviewCounterActiveTask.Text = "10";
            // 
            // overviewCounterFinishTask
            // 
            this.overviewCounterFinishTask.AutoSize = true;
            this.overviewCounterFinishTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.overviewCounterFinishTask.Location = new System.Drawing.Point(229, 181);
            this.overviewCounterFinishTask.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.overviewCounterFinishTask.Name = "overviewCounterFinishTask";
            this.overviewCounterFinishTask.Size = new System.Drawing.Size(38, 25);
            this.overviewCounterFinishTask.TabIndex = 6;
            this.overviewCounterFinishTask.Text = "13";
            // 
            // overviewCounterEmployee
            // 
            this.overviewCounterEmployee.AutoSize = true;
            this.overviewCounterEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.overviewCounterEmployee.Location = new System.Drawing.Point(229, 264);
            this.overviewCounterEmployee.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.overviewCounterEmployee.Name = "overviewCounterEmployee";
            this.overviewCounterEmployee.Size = new System.Drawing.Size(38, 25);
            this.overviewCounterEmployee.TabIndex = 7;
            this.overviewCounterEmployee.Text = "14";
            // 
            // companyDetails
            // 
            this.companyDetails.Controls.Add(this.flowLayoutPanel1);
            this.companyDetails.Controls.Add(this.flowLayoutPanel4);
            this.companyDetails.Controls.Add(this.flowLayoutPanel3);
            this.companyDetails.Controls.Add(this.flowLayoutPanel2);
            this.companyDetails.Location = new System.Drawing.Point(4, 22);
            this.companyDetails.Name = "companyDetails";
            this.companyDetails.Padding = new System.Windows.Forms.Padding(3);
            this.companyDetails.Size = new System.Drawing.Size(982, 503);
            this.companyDetails.TabIndex = 1;
            this.companyDetails.Text = "Dane firmy";
            this.companyDetails.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel4);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel5);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel7);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel6);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 36);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(976, 435);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.companyName, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(206, 48);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(3);
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nazwa firmy";
            // 
            // companyName
            // 
            this.companyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.companyName.Location = new System.Drawing.Point(3, 22);
            this.companyName.Name = "companyName";
            this.companyName.Size = new System.Drawing.Size(200, 23);
            this.companyName.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 60);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(424, 57);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.companyAddress, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(206, 48);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(3);
            this.label3.Size = new System.Drawing.Size(40, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Adres";
            // 
            // companyAddress
            // 
            this.companyAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.companyAddress.Location = new System.Drawing.Point(3, 22);
            this.companyAddress.Name = "companyAddress";
            this.companyAddress.Size = new System.Drawing.Size(200, 23);
            this.companyAddress.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.companyCity, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(215, 3);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(206, 48);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(3);
            this.label4.Size = new System.Drawing.Size(44, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Miasto";
            // 
            // companyCity
            // 
            this.companyCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.companyCity.Location = new System.Drawing.Point(3, 22);
            this.companyCity.Name = "companyCity";
            this.companyCity.Size = new System.Drawing.Size(200, 23);
            this.companyCity.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.AutoSize = true;
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.companyPostcode, 0, 1);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 123);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(206, 68);
            this.tableLayoutPanel5.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(3);
            this.label5.Size = new System.Drawing.Size(80, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Kod pocztowy";
            // 
            // companyPostcode
            // 
            this.companyPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.companyPostcode.Location = new System.Drawing.Point(3, 22);
            this.companyPostcode.Name = "companyPostcode";
            this.companyPostcode.Size = new System.Drawing.Size(200, 23);
            this.companyPostcode.TabIndex = 1;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.AutoSize = true;
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel7.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.companyCountry, 0, 1);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 200);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(206, 48);
            this.tableLayoutPanel7.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(3);
            this.label9.Size = new System.Drawing.Size(54, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "Państwo";
            // 
            // companyCountry
            // 
            this.companyCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.companyCountry.Location = new System.Drawing.Point(3, 22);
            this.companyCountry.Name = "companyCountry";
            this.companyCountry.Size = new System.Drawing.Size(200, 23);
            this.companyCountry.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.AutoSize = true;
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.companyNIP, 0, 1);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 257);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(206, 48);
            this.tableLayoutPanel6.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(3);
            this.label6.Size = new System.Drawing.Size(31, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "NIP";
            // 
            // companyNIP
            // 
            this.companyNIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.companyNIP.Location = new System.Drawing.Point(3, 22);
            this.companyNIP.Name = "companyNIP";
            this.companyNIP.Size = new System.Drawing.Size(200, 23);
            this.companyNIP.TabIndex = 1;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.AutoSize = true;
            this.flowLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel4.Controls.Add(this.label1);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(976, 33);
            this.flowLayoutPanel4.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dane firmy";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel3.Controls.Add(this.companyDetailsSaveButton);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 471);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(976, 29);
            this.flowLayoutPanel3.TabIndex = 3;
            // 
            // companyDetailsSaveButton
            // 
            this.companyDetailsSaveButton.Location = new System.Drawing.Point(898, 3);
            this.companyDetailsSaveButton.Name = "companyDetailsSaveButton";
            this.companyDetailsSaveButton.Size = new System.Drawing.Size(75, 23);
            this.companyDetailsSaveButton.TabIndex = 0;
            this.companyDetailsSaveButton.Text = "Zapisz";
            this.companyDetailsSaveButton.UseVisualStyleBackColor = true;
            this.companyDetailsSaveButton.Click += new System.EventHandler(this.companyDetailsSaveButton_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(976, 0);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // employees
            // 
            this.employees.Controls.Add(this.flowLayoutPanel7);
            this.employees.Controls.Add(this.flowLayoutPanel6);
            this.employees.Controls.Add(this.flowLayoutPanel5);
            this.employees.Location = new System.Drawing.Point(4, 22);
            this.employees.Name = "employees";
            this.employees.Size = new System.Drawing.Size(982, 503);
            this.employees.TabIndex = 2;
            this.employees.Text = "Pracownicy";
            this.employees.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.AutoSize = true;
            this.flowLayoutPanel7.Controls.Add(this.employeeListView);
            this.flowLayoutPanel7.Controls.Add(this.checkedListBox1);
            this.flowLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel7.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel7.Location = new System.Drawing.Point(0, 33);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(982, 441);
            this.flowLayoutPanel7.TabIndex = 7;
            // 
            // employeeListView
            // 
            this.employeeListView.HideSelection = false;
            this.employeeListView.Location = new System.Drawing.Point(3, 3);
            this.employeeListView.Name = "employeeListView";
            this.employeeListView.Size = new System.Drawing.Size(969, 432);
            this.employeeListView.TabIndex = 0;
            this.employeeListView.UseCompatibleStateImageBehavior = false;
            this.employeeListView.Click += new System.EventHandler(this.employeeListView_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(978, 3);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox1.TabIndex = 1;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.AutoSize = true;
            this.flowLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel6.Controls.Add(this.button1);
            this.flowLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel6.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel6.Location = new System.Drawing.Point(0, 474);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(982, 29);
            this.flowLayoutPanel6.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(904, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Zapisz";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.AutoSize = true;
            this.flowLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel5.Controls.Add(this.label7);
            this.flowLayoutPanel5.Controls.Add(this.newEmployee);
            this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(982, 33);
            this.flowLayoutPanel5.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label7.Location = new System.Drawing.Point(3, 3);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Pracownicy";
            // 
            // newEmployee
            // 
            this.newEmployee.Location = new System.Drawing.Point(104, 3);
            this.newEmployee.Name = "newEmployee";
            this.newEmployee.Size = new System.Drawing.Size(164, 23);
            this.newEmployee.TabIndex = 2;
            this.newEmployee.Text = "Nowy pracownik";
            this.newEmployee.UseVisualStyleBackColor = true;
            this.newEmployee.Click += new System.EventHandler(this.newEmployee_Click);
            // 
            // tasks
            // 
            this.tasks.Controls.Add(this.listView1);
            this.tasks.Controls.Add(this.flowLayoutPanel8);
            this.tasks.Location = new System.Drawing.Point(4, 22);
            this.tasks.Name = "tasks";
            this.tasks.Size = new System.Drawing.Size(982, 503);
            this.tasks.TabIndex = 4;
            this.tasks.Text = "Zadania";
            this.tasks.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 32);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(982, 468);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // flowLayoutPanel8
            // 
            this.flowLayoutPanel8.AutoSize = true;
            this.flowLayoutPanel8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel8.Controls.Add(this.label8);
            this.flowLayoutPanel8.Controls.Add(this.newTaskButton);
            this.flowLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel8.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel8.Name = "flowLayoutPanel8";
            this.flowLayoutPanel8.Size = new System.Drawing.Size(982, 33);
            this.flowLayoutPanel8.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label8.Location = new System.Drawing.Point(3, 3);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Zadania\r\n";
            // 
            // newTaskButton
            // 
            this.newTaskButton.Location = new System.Drawing.Point(76, 3);
            this.newTaskButton.Name = "newTaskButton";
            this.newTaskButton.Size = new System.Drawing.Size(164, 23);
            this.newTaskButton.TabIndex = 2;
            this.newTaskButton.Text = "Nowe zadanie\r\n";
            this.newTaskButton.UseVisualStyleBackColor = true;
            // 
            // employeeRepositoryBindingSource
            // 
            this.employeeRepositoryBindingSource.DataSource = typeof(CompanyManagmentProject.Repo.EmployeeRepository);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 528);
            this.Controls.Add(this.mainTabControl);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.mainTabControl.ResumeLayout(false);
            this.dashboard.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.companyDetails.ResumeLayout(false);
            this.companyDetails.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.employees.ResumeLayout(false);
            this.employees.PerformLayout();
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.tasks.ResumeLayout(false);
            this.tasks.PerformLayout();
            this.flowLayoutPanel8.ResumeLayout(false);
            this.flowLayoutPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeRepositoryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage dashboard;
        private System.Windows.Forms.TabPage companyDetails;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox companyName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox companyAddress;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox companyCity;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox companyPostcode;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox companyNIP;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button companyDetailsSaveButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TabPage employees;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.ListView employeeListView;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button newEmployee;
        private System.Windows.Forms.TabPage tasks;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button newTaskButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox companyCountry;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label overviewCompanyName;
        private System.Windows.Forms.Label activeTaskCounter;
        private System.Windows.Forms.Label finishTaskCounter;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label overviewTime;
        private System.Windows.Forms.Label overviewCounterActiveTask;
        private System.Windows.Forms.Label overviewCounterFinishTask;
        private System.Windows.Forms.Label overviewCounterEmployee;
        private System.Windows.Forms.BindingSource employeeRepositoryBindingSource;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}

