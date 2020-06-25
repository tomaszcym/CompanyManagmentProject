namespace CompanyManagmentProject
{
    partial class TaskForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.taskLabel3 = new System.Windows.Forms.Label();
            this.taskPhoneNumber = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.taskLabel5 = new System.Windows.Forms.Label();
            this.taskDataTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.taskDateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.taskLabel6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.taskSave = new System.Windows.Forms.Button();
            this.taskExit = new System.Windows.Forms.Button();
            this.taskDelete = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.taskEmployee = new System.Windows.Forms.Label();
            this.taskEmployeeSelect = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.taskName = new System.Windows.Forms.TextBox();
            this.taskDescription = new System.Windows.Forms.TextBox();
            this.taskFinished = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.AutoSize = true;
            this.flowLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel4.Controls.Add(this.label1);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(800, 33);
            this.flowLayoutPanel4.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dodawanie nowego zadania";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 102);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(424, 57);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.AutoSize = true;
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.Controls.Add(this.taskLabel3, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.taskPhoneNumber, 0, 1);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(206, 48);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // taskLabel3
            // 
            this.taskLabel3.AutoSize = true;
            this.taskLabel3.Location = new System.Drawing.Point(3, 0);
            this.taskLabel3.Name = "taskLabel3";
            this.taskLabel3.Padding = new System.Windows.Forms.Padding(3);
            this.taskLabel3.Size = new System.Drawing.Size(85, 19);
            this.taskLabel3.TabIndex = 0;
            this.taskLabel3.Text = "Numer telefonu";
            // 
            // taskPhoneNumber
            // 
            this.taskPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.taskPhoneNumber.Location = new System.Drawing.Point(3, 22);
            this.taskPhoneNumber.Name = "taskPhoneNumber";
            this.taskPhoneNumber.Size = new System.Drawing.Size(200, 23);
            this.taskPhoneNumber.TabIndex = 1;
            this.taskPhoneNumber.Text = " ";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.AutoSize = true;
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel7.Location = new System.Drawing.Point(7, 165);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.Size = new System.Drawing.Size(0, 0);
            this.tableLayoutPanel7.TabIndex = 16;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.tableLayoutPanel11);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(7, 171);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(424, 73);
            this.flowLayoutPanel2.TabIndex = 19;
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 3;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.04762F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.95238F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel11.Controls.Add(this.taskLabel5, 0, 0);
            this.tableLayoutPanel11.Controls.Add(this.taskDataTimePickerEnd, 1, 1);
            this.tableLayoutPanel11.Controls.Add(this.taskDateTimePickerStart, 0, 1);
            this.tableLayoutPanel11.Controls.Add(this.taskLabel6, 1, 0);
            this.tableLayoutPanel11.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 2;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.28571F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.71429F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(429, 70);
            this.tableLayoutPanel11.TabIndex = 0;
            // 
            // taskLabel5
            // 
            this.taskLabel5.AutoSize = true;
            this.taskLabel5.Location = new System.Drawing.Point(3, 0);
            this.taskLabel5.Name = "taskLabel5";
            this.taskLabel5.Padding = new System.Windows.Forms.Padding(3);
            this.taskLabel5.Size = new System.Drawing.Size(125, 19);
            this.taskLabel5.TabIndex = 0;
            this.taskLabel5.Text = "Data rozpoczęcia pracy";
            // 
            // taskDataTimePickerEnd
            // 
            this.taskDataTimePickerEnd.Location = new System.Drawing.Point(205, 33);
            this.taskDataTimePickerEnd.Name = "taskDataTimePickerEnd";
            this.taskDataTimePickerEnd.Size = new System.Drawing.Size(203, 20);
            this.taskDataTimePickerEnd.TabIndex = 8;
            // 
            // taskDateTimePickerStart
            // 
            this.taskDateTimePickerStart.Location = new System.Drawing.Point(3, 33);
            this.taskDateTimePickerStart.Name = "taskDateTimePickerStart";
            this.taskDateTimePickerStart.Size = new System.Drawing.Size(196, 20);
            this.taskDateTimePickerStart.TabIndex = 12;
            // 
            // taskLabel6
            // 
            this.taskLabel6.AutoSize = true;
            this.taskLabel6.Location = new System.Drawing.Point(205, 0);
            this.taskLabel6.Name = "taskLabel6";
            this.taskLabel6.Padding = new System.Windows.Forms.Padding(3);
            this.taskLabel6.Size = new System.Drawing.Size(197, 19);
            this.taskLabel6.TabIndex = 11;
            this.taskLabel6.Text = "Przewidywana data zakończenia pracy";
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.AutoSize = true;
            this.tableLayoutPanel10.ColumnCount = 1;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel10.Location = new System.Drawing.Point(7, 250);
            this.tableLayoutPanel10.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 2;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(0, 0);
            this.tableLayoutPanel10.TabIndex = 17;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel3.Controls.Add(this.taskSave);
            this.flowLayoutPanel3.Controls.Add(this.taskExit);
            this.flowLayoutPanel3.Controls.Add(this.taskDelete);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 421);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(800, 29);
            this.flowLayoutPanel3.TabIndex = 20;
            // 
            // taskSave
            // 
            this.taskSave.Location = new System.Drawing.Point(722, 3);
            this.taskSave.Name = "taskSave";
            this.taskSave.Size = new System.Drawing.Size(75, 23);
            this.taskSave.TabIndex = 0;
            this.taskSave.Text = "Zapisz";
            this.taskSave.UseVisualStyleBackColor = true;
            this.taskSave.Click += new System.EventHandler(this.taskSave_Click);
            // 
            // taskExit
            // 
            this.taskExit.Location = new System.Drawing.Point(641, 3);
            this.taskExit.Name = "taskExit";
            this.taskExit.Size = new System.Drawing.Size(75, 23);
            this.taskExit.TabIndex = 14;
            this.taskExit.Text = "Anuluj";
            this.taskExit.UseVisualStyleBackColor = true;
            this.taskExit.Click += new System.EventHandler(this.taskExit_Click);
            // 
            // taskDelete
            // 
            this.taskDelete.Location = new System.Drawing.Point(560, 3);
            this.taskDelete.Name = "taskDelete";
            this.taskDelete.Size = new System.Drawing.Size(75, 23);
            this.taskDelete.TabIndex = 15;
            this.taskDelete.Text = "Usuń";
            this.taskDelete.UseVisualStyleBackColor = true;
            this.taskDelete.Click += new System.EventHandler(this.taskDelete_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 51);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(0, 0);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.taskEmployee, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(69, 19);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // taskEmployee
            // 
            this.taskEmployee.AutoSize = true;
            this.taskEmployee.Location = new System.Drawing.Point(3, 0);
            this.taskEmployee.Name = "taskEmployee";
            this.taskEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.taskEmployee.Size = new System.Drawing.Size(63, 19);
            this.taskEmployee.TabIndex = 0;
            this.taskEmployee.Text = "Pracownik";
            // 
            // taskEmployeeSelect
            // 
            this.taskEmployeeSelect.FormattingEnabled = true;
            this.taskEmployeeSelect.Location = new System.Drawing.Point(3, 31);
            this.taskEmployeeSelect.Name = "taskEmployeeSelect";
            this.taskEmployeeSelect.Size = new System.Drawing.Size(185, 21);
            this.taskEmployeeSelect.TabIndex = 21;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.taskEmployeeSelect, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.taskName, 1, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(7, 39);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(424, 68);
            this.tableLayoutPanel4.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Nazwa Zadania";
            // 
            // taskName
            // 
            this.taskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.taskName.Location = new System.Drawing.Point(215, 31);
            this.taskName.Name = "taskName";
            this.taskName.Size = new System.Drawing.Size(200, 23);
            this.taskName.TabIndex = 23;
            this.taskName.Text = " ";
            // 
            // taskDescription
            // 
            this.taskDescription.Location = new System.Drawing.Point(12, 290);
            this.taskDescription.Multiline = true;
            this.taskDescription.Name = "taskDescription";
            this.taskDescription.Size = new System.Drawing.Size(765, 47);
            this.taskDescription.TabIndex = 21;
            // 
            // taskFinished
            // 
            this.taskFinished.AutoSize = true;
            this.taskFinished.Location = new System.Drawing.Point(50, 267);
            this.taskFinished.Name = "taskFinished";
            this.taskFinished.Size = new System.Drawing.Size(86, 17);
            this.taskFinished.TabIndex = 22;
            this.taskFinished.Text = "Zakończone";
            this.taskFinished.UseVisualStyleBackColor = true;
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.taskFinished);
            this.Controls.Add(this.taskDescription);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel7);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel10);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Name = "TaskForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nowe zadanie";
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel11.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label taskLabel3;
        private System.Windows.Forms.TextBox taskPhoneNumber;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.Label taskLabel5;
        private System.Windows.Forms.DateTimePicker taskDataTimePickerEnd;
        private System.Windows.Forms.DateTimePicker taskDateTimePickerStart;
        private System.Windows.Forms.Label taskLabel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button taskSave;
        private System.Windows.Forms.Button taskExit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label taskEmployee;
        private System.Windows.Forms.ComboBox taskEmployeeSelect;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox taskName;
        private System.Windows.Forms.TextBox taskDescription;
        private System.Windows.Forms.CheckBox taskFinished;
        private System.Windows.Forms.Button taskDelete;
    }
}