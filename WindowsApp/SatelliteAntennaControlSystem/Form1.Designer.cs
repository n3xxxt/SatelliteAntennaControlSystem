namespace SatelliteAntennaControlSystem
{
    partial class MainControlPanel
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            выбратьСпутникИзФайлаToolStripMenuItem = new ToolStripMenuItem();
            удалитьСпутникToolStripMenuItem = new ToolStripMenuItem();
            добавитьСпутникToolStripMenuItem = new ToolStripMenuItem();
            refreshDataToolStripMenuItem = new ToolStripMenuItem();
            ActivatingSystemToolStripMenuItem = new ToolStripMenuItem();
            connectionStatusToolStripMenuItem = new ToolStripMenuItem();
            UpAngleButton = new Button();
            DownAngleButton = new Button();
            DownHorizontButton = new Button();
            UpHorizontButton = new Button();
            PointControlPanelGroup = new GroupBox();
            StepDegreesLabel = new Label();
            PointControllerNumericUpDown = new NumericUpDown();
            StepPointControlLabel = new Label();
            SemiAutomaticControlGroup = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            SemiAutomaticSetPositionButton = new Button();
            SemiAutoHorizontNumericUpDown = new NumericUpDown();
            SemiAutoAngleNumericUpDown = new NumericUpDown();
            SemiAutomaticReadingHorizontLabel = new Label();
            SemiAutomaticReadingAngleLabel = new Label();
            CurrentSatelliteGroup = new GroupBox();
            SystemStatusLabel = new Label();
            IsSystemActivatedLabel = new Label();
            ActualHorizontValue = new Label();
            ActualHorizontLabel = new Label();
            ActualAngleValue = new Label();
            ActualAngleLabel = new Label();
            AutomaticControlGroup = new GroupBox();
            AutomaticSetPositionButton = new Button();
            SelectSatelliteLabel = new Label();
            SelectSatelliteComboBox = new ComboBox();
            backgroundWorker = new System.ComponentModel.BackgroundWorker();
            menuStrip1.SuspendLayout();
            PointControlPanelGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PointControllerNumericUpDown).BeginInit();
            SemiAutomaticControlGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SemiAutoHorizontNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SemiAutoAngleNumericUpDown).BeginInit();
            CurrentSatelliteGroup.SuspendLayout();
            AutomaticControlGroup.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, refreshDataToolStripMenuItem, ActivatingSystemToolStripMenuItem, connectionStatusToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(906, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { выбратьСпутникИзФайлаToolStripMenuItem, удалитьСпутникToolStripMenuItem, добавитьСпутникToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(59, 24);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // выбратьСпутникИзФайлаToolStripMenuItem
            // 
            выбратьСпутникИзФайлаToolStripMenuItem.Name = "выбратьСпутникИзФайлаToolStripMenuItem";
            выбратьСпутникИзФайлаToolStripMenuItem.Size = new Size(277, 26);
            выбратьСпутникИзФайлаToolStripMenuItem.Text = "Выбрать спутник из файла";
            // 
            // удалитьСпутникToolStripMenuItem
            // 
            удалитьСпутникToolStripMenuItem.Name = "удалитьСпутникToolStripMenuItem";
            удалитьСпутникToolStripMenuItem.Size = new Size(277, 26);
            удалитьСпутникToolStripMenuItem.Text = "Удалить спутник";
            // 
            // добавитьСпутникToolStripMenuItem
            // 
            добавитьСпутникToolStripMenuItem.Name = "добавитьСпутникToolStripMenuItem";
            добавитьСпутникToolStripMenuItem.Size = new Size(277, 26);
            добавитьСпутникToolStripMenuItem.Text = "Добавить спутник";
            // 
            // refreshDataToolStripMenuItem
            // 
            refreshDataToolStripMenuItem.Name = "refreshDataToolStripMenuItem";
            refreshDataToolStripMenuItem.Size = new Size(149, 24);
            refreshDataToolStripMenuItem.Text = "Обновить данные";
            refreshDataToolStripMenuItem.Click += refreshDataToolStripMenuItem_Click;
            // 
            // ActivatingSystemToolStripMenuItem
            // 
            ActivatingSystemToolStripMenuItem.Name = "ActivatingSystemToolStripMenuItem";
            ActivatingSystemToolStripMenuItem.Size = new Size(88, 24);
            ActivatingSystemToolStripMenuItem.Text = "Вкл/Выкл";
            ActivatingSystemToolStripMenuItem.Click += ActivatingSystemToolStripMenuItem_Click;
            // 
            // connectionStatusToolStripMenuItem
            // 
            connectionStatusToolStripMenuItem.Name = "connectionStatusToolStripMenuItem";
            connectionStatusToolStripMenuItem.Size = new Size(120, 24);
            connectionStatusToolStripMenuItem.Text = "Подключение";
            connectionStatusToolStripMenuItem.Click += connectionStatusToolStripMenuItem_Click;
            // 
            // UpAngleButton
            // 
            UpAngleButton.Font = new Font("Segoe UI", 12F);
            UpAngleButton.Location = new Point(167, 100);
            UpAngleButton.Margin = new Padding(3, 4, 3, 4);
            UpAngleButton.Name = "UpAngleButton";
            UpAngleButton.Size = new Size(111, 67);
            UpAngleButton.TabIndex = 1;
            UpAngleButton.Text = "Вверх (Угол 90)";
            UpAngleButton.UseVisualStyleBackColor = true;
            UpAngleButton.Click += UpAngleButton_Click;
            // 
            // DownAngleButton
            // 
            DownAngleButton.Font = new Font("Segoe UI", 12F);
            DownAngleButton.Location = new Point(167, 219);
            DownAngleButton.Margin = new Padding(3, 4, 3, 4);
            DownAngleButton.Name = "DownAngleButton";
            DownAngleButton.Size = new Size(111, 67);
            DownAngleButton.TabIndex = 2;
            DownAngleButton.Text = "Вниз \r\n(Угол 0)";
            DownAngleButton.UseVisualStyleBackColor = true;
            DownAngleButton.Click += DownAngleButton_Click;
            // 
            // DownHorizontButton
            // 
            DownHorizontButton.Font = new Font("Segoe UI", 12F);
            DownHorizontButton.Location = new Point(15, 152);
            DownHorizontButton.Margin = new Padding(3, 4, 3, 4);
            DownHorizontButton.Name = "DownHorizontButton";
            DownHorizontButton.Size = new Size(137, 85);
            DownHorizontButton.TabIndex = 3;
            DownHorizontButton.Text = "Влево (Азимут 0)";
            DownHorizontButton.UseVisualStyleBackColor = true;
            DownHorizontButton.Click += DownHorizontButton_Click;
            // 
            // UpHorizontButton
            // 
            UpHorizontButton.Font = new Font("Segoe UI", 12F);
            UpHorizontButton.Location = new Point(291, 152);
            UpHorizontButton.Margin = new Padding(3, 4, 3, 4);
            UpHorizontButton.Name = "UpHorizontButton";
            UpHorizontButton.Size = new Size(137, 85);
            UpHorizontButton.TabIndex = 4;
            UpHorizontButton.Text = "Вправо (Азимут 180)";
            UpHorizontButton.UseVisualStyleBackColor = true;
            UpHorizontButton.Click += UpHorizontButton_Click;
            // 
            // PointControlPanelGroup
            // 
            PointControlPanelGroup.Controls.Add(StepDegreesLabel);
            PointControlPanelGroup.Controls.Add(PointControllerNumericUpDown);
            PointControlPanelGroup.Controls.Add(StepPointControlLabel);
            PointControlPanelGroup.Controls.Add(DownHorizontButton);
            PointControlPanelGroup.Controls.Add(UpHorizontButton);
            PointControlPanelGroup.Controls.Add(UpAngleButton);
            PointControlPanelGroup.Controls.Add(DownAngleButton);
            PointControlPanelGroup.Font = new Font("Segoe UI", 10F);
            PointControlPanelGroup.Location = new Point(448, 285);
            PointControlPanelGroup.Margin = new Padding(3, 4, 3, 4);
            PointControlPanelGroup.Name = "PointControlPanelGroup";
            PointControlPanelGroup.Padding = new Padding(3, 4, 3, 4);
            PointControlPanelGroup.Size = new Size(442, 321);
            PointControlPanelGroup.TabIndex = 6;
            PointControlPanelGroup.TabStop = false;
            PointControlPanelGroup.Text = "Точечное управление";
            // 
            // StepDegreesLabel
            // 
            StepDegreesLabel.AutoSize = true;
            StepDegreesLabel.Font = new Font("Segoe UI", 12F);
            StepDegreesLabel.Location = new Point(341, 37);
            StepDegreesLabel.Name = "StepDegreesLabel";
            StepDegreesLabel.Size = new Size(95, 28);
            StepDegreesLabel.TabIndex = 7;
            StepDegreesLabel.Text = "градусов";
            // 
            // PointControllerNumericUpDown
            // 
            PointControllerNumericUpDown.DecimalPlaces = 3;
            PointControllerNumericUpDown.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            PointControllerNumericUpDown.Location = new Point(198, 40);
            PointControllerNumericUpDown.Margin = new Padding(3, 4, 3, 4);
            PointControllerNumericUpDown.Maximum = new decimal(new int[] { 90, 0, 0, 0 });
            PointControllerNumericUpDown.Name = "PointControllerNumericUpDown";
            PointControllerNumericUpDown.Size = new Size(137, 30);
            PointControllerNumericUpDown.TabIndex = 6;
            // 
            // StepPointControlLabel
            // 
            StepPointControlLabel.AutoSize = true;
            StepPointControlLabel.Font = new Font("Segoe UI", 12F);
            StepPointControlLabel.Location = new Point(26, 37);
            StepPointControlLabel.Name = "StepPointControlLabel";
            StepPointControlLabel.Size = new Size(168, 28);
            StepPointControlLabel.TabIndex = 5;
            StepPointControlLabel.Text = "Шаг управления:";
            // 
            // SemiAutomaticControlGroup
            // 
            SemiAutomaticControlGroup.Controls.Add(label2);
            SemiAutomaticControlGroup.Controls.Add(label1);
            SemiAutomaticControlGroup.Controls.Add(SemiAutomaticSetPositionButton);
            SemiAutomaticControlGroup.Controls.Add(SemiAutoHorizontNumericUpDown);
            SemiAutomaticControlGroup.Controls.Add(SemiAutoAngleNumericUpDown);
            SemiAutomaticControlGroup.Controls.Add(SemiAutomaticReadingHorizontLabel);
            SemiAutomaticControlGroup.Controls.Add(SemiAutomaticReadingAngleLabel);
            SemiAutomaticControlGroup.Font = new Font("Segoe UI", 10F);
            SemiAutomaticControlGroup.Location = new Point(14, 184);
            SemiAutomaticControlGroup.Margin = new Padding(3, 4, 3, 4);
            SemiAutomaticControlGroup.Name = "SemiAutomaticControlGroup";
            SemiAutomaticControlGroup.Padding = new Padding(3, 4, 3, 4);
            SemiAutomaticControlGroup.Size = new Size(427, 423);
            SemiAutomaticControlGroup.TabIndex = 7;
            SemiAutomaticControlGroup.TabStop = false;
            SemiAutomaticControlGroup.Text = "Полуавтоматическое управление";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(267, 155);
            label2.Name = "label2";
            label2.Size = new Size(95, 28);
            label2.TabIndex = 11;
            label2.Text = "градусов";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(267, 76);
            label1.Name = "label1";
            label1.Size = new Size(95, 28);
            label1.TabIndex = 10;
            label1.Text = "градусов";
            // 
            // SemiAutomaticSetPositionButton
            // 
            SemiAutomaticSetPositionButton.Location = new Point(66, 267);
            SemiAutomaticSetPositionButton.Margin = new Padding(3, 4, 3, 4);
            SemiAutomaticSetPositionButton.Name = "SemiAutomaticSetPositionButton";
            SemiAutomaticSetPositionButton.Size = new Size(255, 103);
            SemiAutomaticSetPositionButton.TabIndex = 9;
            SemiAutomaticSetPositionButton.Text = "Установить положение антенны";
            SemiAutomaticSetPositionButton.UseVisualStyleBackColor = true;
            SemiAutomaticSetPositionButton.Click += SemiAutomaticSetPositionButton_Click;
            // 
            // SemiAutoHorizontNumericUpDown
            // 
            SemiAutoHorizontNumericUpDown.DecimalPlaces = 3;
            SemiAutoHorizontNumericUpDown.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            SemiAutoHorizontNumericUpDown.Location = new Point(113, 156);
            SemiAutoHorizontNumericUpDown.Margin = new Padding(3, 4, 3, 4);
            SemiAutoHorizontNumericUpDown.Maximum = new decimal(new int[] { 270, 0, 0, 0 });
            SemiAutoHorizontNumericUpDown.Minimum = new decimal(new int[] { 90, 0, 0, 0 });
            SemiAutoHorizontNumericUpDown.Name = "SemiAutoHorizontNumericUpDown";
            SemiAutoHorizontNumericUpDown.Size = new Size(137, 30);
            SemiAutoHorizontNumericUpDown.TabIndex = 8;
            SemiAutoHorizontNumericUpDown.Value = new decimal(new int[] { 90, 0, 0, 0 });
            // 
            // SemiAutoAngleNumericUpDown
            // 
            SemiAutoAngleNumericUpDown.DecimalPlaces = 3;
            SemiAutoAngleNumericUpDown.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            SemiAutoAngleNumericUpDown.Location = new Point(113, 77);
            SemiAutoAngleNumericUpDown.Margin = new Padding(3, 4, 3, 4);
            SemiAutoAngleNumericUpDown.Maximum = new decimal(new int[] { 90, 0, 0, 0 });
            SemiAutoAngleNumericUpDown.Name = "SemiAutoAngleNumericUpDown";
            SemiAutoAngleNumericUpDown.Size = new Size(137, 30);
            SemiAutoAngleNumericUpDown.TabIndex = 7;
            // 
            // SemiAutomaticReadingHorizontLabel
            // 
            SemiAutomaticReadingHorizontLabel.AutoSize = true;
            SemiAutomaticReadingHorizontLabel.Font = new Font("Segoe UI", 12F);
            SemiAutomaticReadingHorizontLabel.Location = new Point(21, 155);
            SemiAutomaticReadingHorizontLabel.Name = "SemiAutomaticReadingHorizontLabel";
            SemiAutomaticReadingHorizontLabel.Size = new Size(82, 28);
            SemiAutomaticReadingHorizontLabel.TabIndex = 1;
            SemiAutomaticReadingHorizontLabel.Text = "Азимут:";
            // 
            // SemiAutomaticReadingAngleLabel
            // 
            SemiAutomaticReadingAngleLabel.AutoSize = true;
            SemiAutomaticReadingAngleLabel.Font = new Font("Segoe UI", 12F);
            SemiAutomaticReadingAngleLabel.Location = new Point(43, 76);
            SemiAutomaticReadingAngleLabel.Name = "SemiAutomaticReadingAngleLabel";
            SemiAutomaticReadingAngleLabel.Size = new Size(58, 28);
            SemiAutomaticReadingAngleLabel.TabIndex = 0;
            SemiAutomaticReadingAngleLabel.Text = "Угол:";
            // 
            // CurrentSatelliteGroup
            // 
            CurrentSatelliteGroup.Controls.Add(SystemStatusLabel);
            CurrentSatelliteGroup.Controls.Add(IsSystemActivatedLabel);
            CurrentSatelliteGroup.Controls.Add(ActualHorizontValue);
            CurrentSatelliteGroup.Controls.Add(ActualHorizontLabel);
            CurrentSatelliteGroup.Controls.Add(ActualAngleValue);
            CurrentSatelliteGroup.Controls.Add(ActualAngleLabel);
            CurrentSatelliteGroup.Font = new Font("Segoe UI", 10F);
            CurrentSatelliteGroup.Location = new Point(14, 43);
            CurrentSatelliteGroup.Margin = new Padding(3, 4, 3, 4);
            CurrentSatelliteGroup.Name = "CurrentSatelliteGroup";
            CurrentSatelliteGroup.Padding = new Padding(3, 4, 3, 4);
            CurrentSatelliteGroup.Size = new Size(427, 133);
            CurrentSatelliteGroup.TabIndex = 8;
            CurrentSatelliteGroup.TabStop = false;
            CurrentSatelliteGroup.Text = "Информация о системе в данный момент";
            // 
            // SystemStatusLabel
            // 
            SystemStatusLabel.AutoSize = true;
            SystemStatusLabel.Font = new Font("Segoe UI", 12F);
            SystemStatusLabel.Location = new Point(229, 84);
            SystemStatusLabel.Name = "SystemStatusLabel";
            SystemStatusLabel.Size = new Size(21, 28);
            SystemStatusLabel.TabIndex = 5;
            SystemStatusLabel.Text = "?";
            // 
            // IsSystemActivatedLabel
            // 
            IsSystemActivatedLabel.AutoSize = true;
            IsSystemActivatedLabel.Font = new Font("Segoe UI", 12F);
            IsSystemActivatedLabel.Location = new Point(22, 84);
            IsSystemActivatedLabel.Name = "IsSystemActivatedLabel";
            IsSystemActivatedLabel.Size = new Size(154, 28);
            IsSystemActivatedLabel.TabIndex = 4;
            IsSystemActivatedLabel.Text = "Статус системы:";
            // 
            // ActualHorizontValue
            // 
            ActualHorizontValue.AutoSize = true;
            ActualHorizontValue.Font = new Font("Segoe UI", 12F);
            ActualHorizontValue.Location = new Point(257, 40);
            ActualHorizontValue.Name = "ActualHorizontValue";
            ActualHorizontValue.Size = new Size(21, 28);
            ActualHorizontValue.TabIndex = 3;
            ActualHorizontValue.Text = "?";
            // 
            // ActualHorizontLabel
            // 
            ActualHorizontLabel.AutoSize = true;
            ActualHorizontLabel.Font = new Font("Segoe UI", 12F);
            ActualHorizontLabel.Location = new Point(176, 40);
            ActualHorizontLabel.Name = "ActualHorizontLabel";
            ActualHorizontLabel.Size = new Size(82, 28);
            ActualHorizontLabel.TabIndex = 2;
            ActualHorizontLabel.Text = "Азимут:";
            // 
            // ActualAngleValue
            // 
            ActualAngleValue.AutoSize = true;
            ActualAngleValue.Font = new Font("Segoe UI", 12F);
            ActualAngleValue.Location = new Point(80, 40);
            ActualAngleValue.Name = "ActualAngleValue";
            ActualAngleValue.Size = new Size(21, 28);
            ActualAngleValue.TabIndex = 1;
            ActualAngleValue.Text = "?";
            // 
            // ActualAngleLabel
            // 
            ActualAngleLabel.AutoSize = true;
            ActualAngleLabel.Font = new Font("Segoe UI", 12F);
            ActualAngleLabel.Location = new Point(22, 40);
            ActualAngleLabel.Name = "ActualAngleLabel";
            ActualAngleLabel.Size = new Size(58, 28);
            ActualAngleLabel.TabIndex = 0;
            ActualAngleLabel.Text = "Угол:";
            // 
            // AutomaticControlGroup
            // 
            AutomaticControlGroup.Controls.Add(AutomaticSetPositionButton);
            AutomaticControlGroup.Controls.Add(SelectSatelliteLabel);
            AutomaticControlGroup.Controls.Add(SelectSatelliteComboBox);
            AutomaticControlGroup.Font = new Font("Segoe UI", 10F);
            AutomaticControlGroup.Location = new Point(448, 43);
            AutomaticControlGroup.Margin = new Padding(3, 4, 3, 4);
            AutomaticControlGroup.Name = "AutomaticControlGroup";
            AutomaticControlGroup.Padding = new Padding(3, 4, 3, 4);
            AutomaticControlGroup.Size = new Size(442, 235);
            AutomaticControlGroup.TabIndex = 9;
            AutomaticControlGroup.TabStop = false;
            AutomaticControlGroup.Text = "Автоматическое управление";
            // 
            // AutomaticSetPositionButton
            // 
            AutomaticSetPositionButton.Location = new Point(118, 127);
            AutomaticSetPositionButton.Margin = new Padding(3, 4, 3, 4);
            AutomaticSetPositionButton.Name = "AutomaticSetPositionButton";
            AutomaticSetPositionButton.Size = new Size(225, 69);
            AutomaticSetPositionButton.TabIndex = 10;
            AutomaticSetPositionButton.Text = "Установить положение антенны";
            AutomaticSetPositionButton.UseVisualStyleBackColor = true;
            // 
            // SelectSatelliteLabel
            // 
            SelectSatelliteLabel.AutoSize = true;
            SelectSatelliteLabel.Location = new Point(38, 63);
            SelectSatelliteLabel.Name = "SelectSatelliteLabel";
            SelectSatelliteLabel.Size = new Size(147, 23);
            SelectSatelliteLabel.TabIndex = 1;
            SelectSatelliteLabel.Text = "Выбрать спутник:";
            // 
            // SelectSatelliteComboBox
            // 
            SelectSatelliteComboBox.FormattingEnabled = true;
            SelectSatelliteComboBox.Location = new Point(206, 59);
            SelectSatelliteComboBox.Margin = new Padding(3, 4, 3, 4);
            SelectSatelliteComboBox.Name = "SelectSatelliteComboBox";
            SelectSatelliteComboBox.Size = new Size(204, 31);
            SelectSatelliteComboBox.TabIndex = 0;
            // 
            // MainControlPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 617);
            Controls.Add(AutomaticControlGroup);
            Controls.Add(CurrentSatelliteGroup);
            Controls.Add(SemiAutomaticControlGroup);
            Controls.Add(PointControlPanelGroup);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainControlPanel";
            Text = "Пульт управления";
            FormClosed += MainControlPanel_FormClosed;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            PointControlPanelGroup.ResumeLayout(false);
            PointControlPanelGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PointControllerNumericUpDown).EndInit();
            SemiAutomaticControlGroup.ResumeLayout(false);
            SemiAutomaticControlGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SemiAutoHorizontNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)SemiAutoAngleNumericUpDown).EndInit();
            CurrentSatelliteGroup.ResumeLayout(false);
            CurrentSatelliteGroup.PerformLayout();
            AutomaticControlGroup.ResumeLayout(false);
            AutomaticControlGroup.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem выбратьСпутникИзФайлаToolStripMenuItem;
        private Button UpAngleButton;
        private Button DownAngleButton;
        private Button DownHorizontButton;
        private Button UpHorizontButton;
        private GroupBox PointControlPanelGroup;
        private NumericUpDown PointControllerNumericUpDown;
        private Label StepPointControlLabel;
        private Label StepDegreesLabel;
        private GroupBox SemiAutomaticControlGroup;
        private ToolStripMenuItem удалитьСпутникToolStripMenuItem;
        private ToolStripMenuItem добавитьСпутникToolStripMenuItem;
        private GroupBox CurrentSatelliteGroup;
        private Label ActualHorizontValue;
        private Label ActualHorizontLabel;
        private Label ActualAngleValue;
        private Label ActualAngleLabel;
        private Label SemiAutomaticReadingHorizontLabel;
        private Label SemiAutomaticReadingAngleLabel;
        private Button SemiAutomaticSetPositionButton;
        private NumericUpDown SemiAutoHorizontNumericUpDown;
        private NumericUpDown SemiAutoAngleNumericUpDown;
        private Label label2;
        private Label label1;
        private GroupBox AutomaticControlGroup;
        private ComboBox SelectSatelliteComboBox;
        private Label SelectSatelliteLabel;
        private Button AutomaticSetPositionButton;
        private Label IsSystemActivatedLabel;
        private Label SystemStatusLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private ToolStripMenuItem ActivatingSystemToolStripMenuItem;
        private ToolStripMenuItem refreshDataToolStripMenuItem;
        private ToolStripMenuItem connectionStatusToolStripMenuItem;
    }
}
