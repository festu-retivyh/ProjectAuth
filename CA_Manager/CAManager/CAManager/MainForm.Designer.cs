namespace CAManager
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainMenuPanel = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.btnAddServerMasterOpen = new System.Windows.Forms.Button();
            this.btnCertificateMasterOpen = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnLogs = new System.Windows.Forms.Button();
            this.btnServers = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnStatistic = new System.Windows.Forms.Button();
            this.mainTabsControl = new System.Windows.Forms.TabControl();
            this.tabStatistic = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabOnlineUsers = new System.Windows.Forms.TabPage();
            this.dgvOnlineUsers = new System.Windows.Forms.DataGridView();
            this.login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.onlineClientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myFWDataSet = new CAManager.myFWDataSet();
            this.onlineUserPanel = new System.Windows.Forms.Panel();
            this.btnSelectUserOnline = new System.Windows.Forms.Button();
            this.btnBlockUserOnline = new System.Windows.Forms.Button();
            this.btnStopSession = new System.Windows.Forms.Button();
            this.tabAllUsers = new System.Windows.Forms.TabPage();
            this.dgvAllUsers = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIODataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientsLastStatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBlockUserAll = new System.Windows.Forms.Button();
            this.btnSelectUser = new System.Windows.Forms.Button();
            this.tabBlockUsers = new System.Windows.Forms.TabPage();
            this.dgvBlockClients = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDeblockUser = new System.Windows.Forms.Button();
            this.btnSelectUserBlocked = new System.Windows.Forms.Button();
            this.tabServers = new System.Windows.Forms.TabPage();
            this.dgvServers = new System.Windows.Forms.DataGridView();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDelServer = new System.Windows.Forms.Button();
            this.btnBlockServer = new System.Windows.Forms.Button();
            this.btnDeblockServer = new System.Windows.Forms.Button();
            this.tabLogs = new System.Windows.Forms.TabPage();
            this.tabBlockedCerificates = new System.Windows.Forms.TabPage();
            this.tabGeneralSettings = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.tabSecuritySettings = new System.Windows.Forms.TabPage();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.tbxNewPass2 = new System.Windows.Forms.TextBox();
            this.tbxNewPass1 = new System.Windows.Forms.TextBox();
            this.tbxOldPass = new System.Windows.Forms.TextBox();
            this.certificateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.onlineClientsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clientsLastStatesTableAdapter = new CAManager.myFWDataSetTableAdapters.ClientsLastStatesTableAdapter();
            this.onlineClientsTableAdapter = new CAManager.myFWDataSetTableAdapters.OnlineClientsTableAdapter();
            this.clientTableAdapter = new CAManager.myFWDataSetTableAdapters.ClientTableAdapter();
            this.tableAdapterManager = new CAManager.myFWDataSetTableAdapters.TableAdapterManager();
            this.certificateTableAdapter = new CAManager.myFWDataSetTableAdapters.CertificateTableAdapter();
            this.mainMenuPanel.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.mainTabsControl.SuspendLayout();
            this.tabStatistic.SuspendLayout();
            this.tabOnlineUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOnlineUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlineClientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myFWDataSet)).BeginInit();
            this.onlineUserPanel.SuspendLayout();
            this.tabAllUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsLastStatesBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabBlockUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBlockClients)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabServers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServers)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabGeneralSettings.SuspendLayout();
            this.tabSecuritySettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.certificateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlineClientsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenuPanel
            // 
            this.mainMenuPanel.Controls.Add(this.statusStrip1);
            this.mainMenuPanel.Controls.Add(this.btnAddServerMasterOpen);
            this.mainMenuPanel.Controls.Add(this.btnCertificateMasterOpen);
            this.mainMenuPanel.Controls.Add(this.btnSettings);
            this.mainMenuPanel.Controls.Add(this.btnLogs);
            this.mainMenuPanel.Controls.Add(this.btnServers);
            this.mainMenuPanel.Controls.Add(this.btnUsers);
            this.mainMenuPanel.Controls.Add(this.btnStatistic);
            this.mainMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.mainMenuPanel.Name = "mainMenuPanel";
            this.mainMenuPanel.Size = new System.Drawing.Size(199, 566);
            this.mainMenuPanel.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 544);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip1.Size = new System.Drawing.Size(199, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(150, 16);
            // 
            // btnAddServerMasterOpen
            // 
            this.btnAddServerMasterOpen.BackColor = System.Drawing.Color.LightGray;
            this.btnAddServerMasterOpen.Location = new System.Drawing.Point(3, 312);
            this.btnAddServerMasterOpen.Name = "btnAddServerMasterOpen";
            this.btnAddServerMasterOpen.Size = new System.Drawing.Size(194, 32);
            this.btnAddServerMasterOpen.TabIndex = 4;
            this.btnAddServerMasterOpen.Text = "Мастер добавления сервера";
            this.btnAddServerMasterOpen.UseVisualStyleBackColor = false;
            this.btnAddServerMasterOpen.Click += new System.EventHandler(this.btnAddServerMasterOpen_Click);
            // 
            // btnCertificateMasterOpen
            // 
            this.btnCertificateMasterOpen.BackColor = System.Drawing.Color.LightGray;
            this.btnCertificateMasterOpen.Location = new System.Drawing.Point(3, 274);
            this.btnCertificateMasterOpen.Name = "btnCertificateMasterOpen";
            this.btnCertificateMasterOpen.Size = new System.Drawing.Size(194, 32);
            this.btnCertificateMasterOpen.TabIndex = 4;
            this.btnCertificateMasterOpen.Text = "Мастер создания сертификата";
            this.btnCertificateMasterOpen.UseVisualStyleBackColor = false;
            this.btnCertificateMasterOpen.Click += new System.EventHandler(this.btnCertificateMasterOpen_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.LightGray;
            this.btnSettings.Location = new System.Drawing.Point(3, 155);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(194, 32);
            this.btnSettings.TabIndex = 4;
            this.btnSettings.Text = "Настройки";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnLogs
            // 
            this.btnLogs.BackColor = System.Drawing.Color.LightGray;
            this.btnLogs.Location = new System.Drawing.Point(3, 117);
            this.btnLogs.Name = "btnLogs";
            this.btnLogs.Size = new System.Drawing.Size(194, 32);
            this.btnLogs.TabIndex = 3;
            this.btnLogs.Text = "Логи";
            this.btnLogs.UseVisualStyleBackColor = false;
            this.btnLogs.Click += new System.EventHandler(this.btnLogs_Click);
            // 
            // btnServers
            // 
            this.btnServers.BackColor = System.Drawing.Color.LightGray;
            this.btnServers.Location = new System.Drawing.Point(3, 79);
            this.btnServers.Name = "btnServers";
            this.btnServers.Size = new System.Drawing.Size(194, 32);
            this.btnServers.TabIndex = 2;
            this.btnServers.Text = "Сервера";
            this.btnServers.UseVisualStyleBackColor = false;
            this.btnServers.Click += new System.EventHandler(this.btnServers_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.LightGray;
            this.btnUsers.Location = new System.Drawing.Point(3, 41);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(194, 32);
            this.btnUsers.TabIndex = 1;
            this.btnUsers.Text = "Пользователи";
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnStatistic
            // 
            this.btnStatistic.BackColor = System.Drawing.Color.LightGray;
            this.btnStatistic.Location = new System.Drawing.Point(3, 3);
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.Size = new System.Drawing.Size(194, 32);
            this.btnStatistic.TabIndex = 0;
            this.btnStatistic.Text = "Статистика";
            this.btnStatistic.UseVisualStyleBackColor = false;
            this.btnStatistic.Click += new System.EventHandler(this.btnStatistic_Click);
            // 
            // mainTabsControl
            // 
            this.mainTabsControl.Controls.Add(this.tabStatistic);
            this.mainTabsControl.Controls.Add(this.tabOnlineUsers);
            this.mainTabsControl.Controls.Add(this.tabAllUsers);
            this.mainTabsControl.Controls.Add(this.tabBlockUsers);
            this.mainTabsControl.Controls.Add(this.tabServers);
            this.mainTabsControl.Controls.Add(this.tabLogs);
            this.mainTabsControl.Controls.Add(this.tabBlockedCerificates);
            this.mainTabsControl.Controls.Add(this.tabGeneralSettings);
            this.mainTabsControl.Controls.Add(this.tabSecuritySettings);
            this.mainTabsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabsControl.Location = new System.Drawing.Point(199, 0);
            this.mainTabsControl.Name = "mainTabsControl";
            this.mainTabsControl.SelectedIndex = 0;
            this.mainTabsControl.Size = new System.Drawing.Size(776, 566);
            this.mainTabsControl.TabIndex = 1;
            // 
            // tabStatistic
            // 
            this.tabStatistic.AutoScroll = true;
            this.tabStatistic.Controls.Add(this.label2);
            this.tabStatistic.Controls.Add(this.label1);
            this.tabStatistic.Location = new System.Drawing.Point(4, 22);
            this.tabStatistic.Name = "tabStatistic";
            this.tabStatistic.Padding = new System.Windows.Forms.Padding(3);
            this.tabStatistic.Size = new System.Drawing.Size(768, 540);
            this.tabStatistic.TabIndex = 0;
            this.tabStatistic.Text = "Статистика";
            this.tabStatistic.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Возможно вывод какой то статистики.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добро пожаловть в программу";
            // 
            // tabOnlineUsers
            // 
            this.tabOnlineUsers.Controls.Add(this.dgvOnlineUsers);
            this.tabOnlineUsers.Controls.Add(this.onlineUserPanel);
            this.tabOnlineUsers.Location = new System.Drawing.Point(4, 22);
            this.tabOnlineUsers.Name = "tabOnlineUsers";
            this.tabOnlineUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabOnlineUsers.Size = new System.Drawing.Size(768, 540);
            this.tabOnlineUsers.TabIndex = 1;
            this.tabOnlineUsers.Text = "Подключенные";
            this.tabOnlineUsers.UseVisualStyleBackColor = true;
            // 
            // dgvOnlineUsers
            // 
            this.dgvOnlineUsers.AutoGenerateColumns = false;
            this.dgvOnlineUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOnlineUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.login,
            this.ip,
            this.idDataGridViewTextBoxColumn,
            this.fIODataGridViewTextBoxColumn,
            this.stateIdDataGridViewTextBoxColumn,
            this.stateNameDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn1});
            this.dgvOnlineUsers.DataSource = this.onlineClientsBindingSource;
            this.dgvOnlineUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOnlineUsers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvOnlineUsers.Location = new System.Drawing.Point(3, 33);
            this.dgvOnlineUsers.Name = "dgvOnlineUsers";
            this.dgvOnlineUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOnlineUsers.Size = new System.Drawing.Size(762, 504);
            this.dgvOnlineUsers.TabIndex = 1;
            // 
            // login
            // 
            this.login.DataPropertyName = "login";
            this.login.HeaderText = "Логин";
            this.login.Name = "login";
            // 
            // ip
            // 
            this.ip.HeaderText = "ip";
            this.ip.Name = "ip";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // fIODataGridViewTextBoxColumn
            // 
            this.fIODataGridViewTextBoxColumn.DataPropertyName = "FIO";
            this.fIODataGridViewTextBoxColumn.HeaderText = "FIO";
            this.fIODataGridViewTextBoxColumn.Name = "fIODataGridViewTextBoxColumn";
            this.fIODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stateIdDataGridViewTextBoxColumn
            // 
            this.stateIdDataGridViewTextBoxColumn.DataPropertyName = "StateId";
            this.stateIdDataGridViewTextBoxColumn.HeaderText = "StateId";
            this.stateIdDataGridViewTextBoxColumn.Name = "stateIdDataGridViewTextBoxColumn";
            // 
            // stateNameDataGridViewTextBoxColumn
            // 
            this.stateNameDataGridViewTextBoxColumn.DataPropertyName = "StateName";
            this.stateNameDataGridViewTextBoxColumn.HeaderText = "StateName";
            this.stateNameDataGridViewTextBoxColumn.Name = "stateNameDataGridViewTextBoxColumn";
            // 
            // loginDataGridViewTextBoxColumn1
            // 
            this.loginDataGridViewTextBoxColumn1.DataPropertyName = "login";
            this.loginDataGridViewTextBoxColumn1.HeaderText = "login";
            this.loginDataGridViewTextBoxColumn1.Name = "loginDataGridViewTextBoxColumn1";
            // 
            // onlineClientsBindingSource
            // 
            this.onlineClientsBindingSource.DataMember = "OnlineClients";
            this.onlineClientsBindingSource.DataSource = this.myFWDataSet;
            // 
            // myFWDataSet
            // 
            this.myFWDataSet.DataSetName = "myFWDataSet";
            this.myFWDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // onlineUserPanel
            // 
            this.onlineUserPanel.Controls.Add(this.btnSelectUserOnline);
            this.onlineUserPanel.Controls.Add(this.btnBlockUserOnline);
            this.onlineUserPanel.Controls.Add(this.btnStopSession);
            this.onlineUserPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.onlineUserPanel.Location = new System.Drawing.Point(3, 3);
            this.onlineUserPanel.Name = "onlineUserPanel";
            this.onlineUserPanel.Size = new System.Drawing.Size(762, 30);
            this.onlineUserPanel.TabIndex = 0;
            // 
            // btnSelectUserOnline
            // 
            this.btnSelectUserOnline.Location = new System.Drawing.Point(3, 3);
            this.btnSelectUserOnline.Name = "btnSelectUserOnline";
            this.btnSelectUserOnline.Size = new System.Drawing.Size(120, 25);
            this.btnSelectUserOnline.TabIndex = 2;
            this.btnSelectUserOnline.Text = "Подробнее";
            this.btnSelectUserOnline.UseVisualStyleBackColor = true;
            this.btnSelectUserOnline.Click += new System.EventHandler(this.btnSelectUserOnline_Click);
            // 
            // btnBlockUserOnline
            // 
            this.btnBlockUserOnline.Location = new System.Drawing.Point(255, 3);
            this.btnBlockUserOnline.Name = "btnBlockUserOnline";
            this.btnBlockUserOnline.Size = new System.Drawing.Size(120, 25);
            this.btnBlockUserOnline.TabIndex = 1;
            this.btnBlockUserOnline.Text = "Заблокировать";
            this.btnBlockUserOnline.UseVisualStyleBackColor = true;
            this.btnBlockUserOnline.Click += new System.EventHandler(this.btnBlockUserOnline_Click);
            // 
            // btnStopSession
            // 
            this.btnStopSession.Location = new System.Drawing.Point(129, 3);
            this.btnStopSession.Name = "btnStopSession";
            this.btnStopSession.Size = new System.Drawing.Size(120, 25);
            this.btnStopSession.TabIndex = 0;
            this.btnStopSession.Text = "Остановить сеанс";
            this.btnStopSession.UseVisualStyleBackColor = true;
            this.btnStopSession.Click += new System.EventHandler(this.btnStopSession_Click);
            // 
            // tabAllUsers
            // 
            this.tabAllUsers.Controls.Add(this.dgvAllUsers);
            this.tabAllUsers.Controls.Add(this.panel1);
            this.tabAllUsers.Location = new System.Drawing.Point(4, 22);
            this.tabAllUsers.Name = "tabAllUsers";
            this.tabAllUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabAllUsers.Size = new System.Drawing.Size(768, 540);
            this.tabAllUsers.TabIndex = 2;
            this.tabAllUsers.Text = "Все";
            this.tabAllUsers.UseVisualStyleBackColor = true;
            // 
            // dgvAllUsers
            // 
            this.dgvAllUsers.AutoGenerateColumns = false;
            this.dgvAllUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.fIODataGridViewTextBoxColumn1,
            this.stateIdDataGridViewTextBoxColumn1,
            this.stateNameDataGridViewTextBoxColumn1,
            this.loginDataGridViewTextBoxColumn,
            this.Column4});
            this.dgvAllUsers.DataSource = this.clientsLastStatesBindingSource;
            this.dgvAllUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAllUsers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvAllUsers.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvAllUsers.Location = new System.Drawing.Point(3, 33);
            this.dgvAllUsers.MultiSelect = false;
            this.dgvAllUsers.Name = "dgvAllUsers";
            this.dgvAllUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllUsers.Size = new System.Drawing.Size(762, 504);
            this.dgvAllUsers.TabIndex = 1;
            this.dgvAllUsers.DoubleClick += new System.EventHandler(this.dgvAllUsers_DoubleClick);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // fIODataGridViewTextBoxColumn1
            // 
            this.fIODataGridViewTextBoxColumn1.DataPropertyName = "FIO";
            this.fIODataGridViewTextBoxColumn1.HeaderText = "FIO";
            this.fIODataGridViewTextBoxColumn1.Name = "fIODataGridViewTextBoxColumn1";
            this.fIODataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // stateIdDataGridViewTextBoxColumn1
            // 
            this.stateIdDataGridViewTextBoxColumn1.DataPropertyName = "StateId";
            this.stateIdDataGridViewTextBoxColumn1.HeaderText = "StateId";
            this.stateIdDataGridViewTextBoxColumn1.Name = "stateIdDataGridViewTextBoxColumn1";
            // 
            // stateNameDataGridViewTextBoxColumn1
            // 
            this.stateNameDataGridViewTextBoxColumn1.DataPropertyName = "StateName";
            this.stateNameDataGridViewTextBoxColumn1.HeaderText = "StateName";
            this.stateNameDataGridViewTextBoxColumn1.Name = "stateNameDataGridViewTextBoxColumn1";
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "login";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "ip";
            this.Column4.Name = "Column4";
            // 
            // clientsLastStatesBindingSource
            // 
            this.clientsLastStatesBindingSource.DataMember = "ClientsLastStates";
            this.clientsLastStatesBindingSource.DataSource = this.myFWDataSet;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBlockUserAll);
            this.panel1.Controls.Add(this.btnSelectUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(762, 30);
            this.panel1.TabIndex = 0;
            // 
            // btnBlockUserAll
            // 
            this.btnBlockUserAll.Location = new System.Drawing.Point(129, 3);
            this.btnBlockUserAll.Name = "btnBlockUserAll";
            this.btnBlockUserAll.Size = new System.Drawing.Size(120, 25);
            this.btnBlockUserAll.TabIndex = 2;
            this.btnBlockUserAll.Text = "Заблокировать";
            this.btnBlockUserAll.UseVisualStyleBackColor = true;
            this.btnBlockUserAll.Click += new System.EventHandler(this.btnBlockUserAll_Click);
            // 
            // btnSelectUser
            // 
            this.btnSelectUser.Location = new System.Drawing.Point(3, 3);
            this.btnSelectUser.Name = "btnSelectUser";
            this.btnSelectUser.Size = new System.Drawing.Size(120, 25);
            this.btnSelectUser.TabIndex = 0;
            this.btnSelectUser.Text = "Подробнее";
            this.btnSelectUser.UseVisualStyleBackColor = true;
            this.btnSelectUser.Click += new System.EventHandler(this.btnSelectUser_Click);
            // 
            // tabBlockUsers
            // 
            this.tabBlockUsers.Controls.Add(this.dgvBlockClients);
            this.tabBlockUsers.Controls.Add(this.panel2);
            this.tabBlockUsers.Location = new System.Drawing.Point(4, 22);
            this.tabBlockUsers.Name = "tabBlockUsers";
            this.tabBlockUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabBlockUsers.Size = new System.Drawing.Size(768, 540);
            this.tabBlockUsers.TabIndex = 3;
            this.tabBlockUsers.Text = "Заблокированные";
            this.tabBlockUsers.UseVisualStyleBackColor = true;
            // 
            // dgvBlockClients
            // 
            this.dgvBlockClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBlockClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgvBlockClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBlockClients.Location = new System.Drawing.Point(3, 33);
            this.dgvBlockClients.Name = "dgvBlockClients";
            this.dgvBlockClients.Size = new System.Drawing.Size(762, 504);
            this.dgvBlockClients.TabIndex = 1;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Логин";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "ФИО";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Состояние";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "ip";
            this.Column8.Name = "Column8";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDeblockUser);
            this.panel2.Controls.Add(this.btnSelectUserBlocked);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(762, 30);
            this.panel2.TabIndex = 0;
            // 
            // btnDeblockUser
            // 
            this.btnDeblockUser.Location = new System.Drawing.Point(129, 3);
            this.btnDeblockUser.Name = "btnDeblockUser";
            this.btnDeblockUser.Size = new System.Drawing.Size(120, 25);
            this.btnDeblockUser.TabIndex = 3;
            this.btnDeblockUser.Text = "Разблокировать";
            this.btnDeblockUser.UseVisualStyleBackColor = true;
            this.btnDeblockUser.Click += new System.EventHandler(this.btnDeblockUser_Click);
            // 
            // btnSelectUserBlocked
            // 
            this.btnSelectUserBlocked.Location = new System.Drawing.Point(3, 3);
            this.btnSelectUserBlocked.Name = "btnSelectUserBlocked";
            this.btnSelectUserBlocked.Size = new System.Drawing.Size(120, 25);
            this.btnSelectUserBlocked.TabIndex = 1;
            this.btnSelectUserBlocked.Text = "Подробнее";
            this.btnSelectUserBlocked.UseVisualStyleBackColor = true;
            this.btnSelectUserBlocked.Click += new System.EventHandler(this.btnSelectUserBlocked_Click);
            // 
            // tabServers
            // 
            this.tabServers.Controls.Add(this.dgvServers);
            this.tabServers.Controls.Add(this.panel3);
            this.tabServers.Location = new System.Drawing.Point(4, 22);
            this.tabServers.Name = "tabServers";
            this.tabServers.Padding = new System.Windows.Forms.Padding(3);
            this.tabServers.Size = new System.Drawing.Size(768, 540);
            this.tabServers.TabIndex = 4;
            this.tabServers.Text = "Сервера";
            this.tabServers.UseVisualStyleBackColor = true;
            // 
            // dgvServers
            // 
            this.dgvServers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12});
            this.dgvServers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvServers.Location = new System.Drawing.Point(3, 33);
            this.dgvServers.Name = "dgvServers";
            this.dgvServers.Size = new System.Drawing.Size(762, 504);
            this.dgvServers.TabIndex = 1;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Наименование";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "ip";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Состояние";
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Подключений";
            this.Column12.Name = "Column12";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnDelServer);
            this.panel3.Controls.Add(this.btnBlockServer);
            this.panel3.Controls.Add(this.btnDeblockServer);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(762, 30);
            this.panel3.TabIndex = 0;
            // 
            // btnDelServer
            // 
            this.btnDelServer.Location = new System.Drawing.Point(255, 3);
            this.btnDelServer.Name = "btnDelServer";
            this.btnDelServer.Size = new System.Drawing.Size(120, 25);
            this.btnDelServer.TabIndex = 0;
            this.btnDelServer.Text = "Удалить";
            this.btnDelServer.UseVisualStyleBackColor = true;
            // 
            // btnBlockServer
            // 
            this.btnBlockServer.Location = new System.Drawing.Point(129, 3);
            this.btnBlockServer.Name = "btnBlockServer";
            this.btnBlockServer.Size = new System.Drawing.Size(120, 25);
            this.btnBlockServer.TabIndex = 0;
            this.btnBlockServer.Text = "Заблокировать";
            this.btnBlockServer.UseVisualStyleBackColor = true;
            // 
            // btnDeblockServer
            // 
            this.btnDeblockServer.Location = new System.Drawing.Point(3, 3);
            this.btnDeblockServer.Name = "btnDeblockServer";
            this.btnDeblockServer.Size = new System.Drawing.Size(120, 25);
            this.btnDeblockServer.TabIndex = 0;
            this.btnDeblockServer.Text = "Разблокировать";
            this.btnDeblockServer.UseVisualStyleBackColor = true;
            // 
            // tabLogs
            // 
            this.tabLogs.Location = new System.Drawing.Point(4, 22);
            this.tabLogs.Name = "tabLogs";
            this.tabLogs.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogs.Size = new System.Drawing.Size(768, 540);
            this.tabLogs.TabIndex = 5;
            this.tabLogs.Text = "Активные";
            this.tabLogs.UseVisualStyleBackColor = true;
            // 
            // tabBlockedCerificates
            // 
            this.tabBlockedCerificates.Location = new System.Drawing.Point(4, 22);
            this.tabBlockedCerificates.Name = "tabBlockedCerificates";
            this.tabBlockedCerificates.Size = new System.Drawing.Size(768, 540);
            this.tabBlockedCerificates.TabIndex = 6;
            this.tabBlockedCerificates.Text = "Заблокированные";
            this.tabBlockedCerificates.UseVisualStyleBackColor = true;
            // 
            // tabGeneralSettings
            // 
            this.tabGeneralSettings.Controls.Add(this.label3);
            this.tabGeneralSettings.Location = new System.Drawing.Point(4, 22);
            this.tabGeneralSettings.Name = "tabGeneralSettings";
            this.tabGeneralSettings.Size = new System.Drawing.Size(768, 540);
            this.tabGeneralSettings.TabIndex = 7;
            this.tabGeneralSettings.Text = "Общие";
            this.tabGeneralSettings.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Общие настройки";
            // 
            // tabSecuritySettings
            // 
            this.tabSecuritySettings.Controls.Add(this.btnChangePassword);
            this.tabSecuritySettings.Controls.Add(this.tbxNewPass2);
            this.tabSecuritySettings.Controls.Add(this.tbxNewPass1);
            this.tabSecuritySettings.Controls.Add(this.tbxOldPass);
            this.tabSecuritySettings.Location = new System.Drawing.Point(4, 22);
            this.tabSecuritySettings.Name = "tabSecuritySettings";
            this.tabSecuritySettings.Size = new System.Drawing.Size(768, 540);
            this.tabSecuritySettings.TabIndex = 8;
            this.tabSecuritySettings.Text = "Безопасность";
            this.tabSecuritySettings.UseVisualStyleBackColor = true;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(298, 96);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(155, 31);
            this.btnChangePassword.TabIndex = 3;
            this.btnChangePassword.Text = "Сохранить новый пароль";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // tbxNewPass2
            // 
            this.tbxNewPass2.Location = new System.Drawing.Point(298, 70);
            this.tbxNewPass2.Name = "tbxNewPass2";
            this.tbxNewPass2.Size = new System.Drawing.Size(155, 20);
            this.tbxNewPass2.TabIndex = 2;
            // 
            // tbxNewPass1
            // 
            this.tbxNewPass1.Location = new System.Drawing.Point(298, 44);
            this.tbxNewPass1.Name = "tbxNewPass1";
            this.tbxNewPass1.Size = new System.Drawing.Size(155, 20);
            this.tbxNewPass1.TabIndex = 1;
            // 
            // tbxOldPass
            // 
            this.tbxOldPass.Location = new System.Drawing.Point(298, 18);
            this.tbxOldPass.Name = "tbxOldPass";
            this.tbxOldPass.Size = new System.Drawing.Size(155, 20);
            this.tbxOldPass.TabIndex = 0;
            // 
            // certificateBindingSource
            // 
            this.certificateBindingSource.DataMember = "Certificate";
            this.certificateBindingSource.DataSource = this.myFWDataSet;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.myFWDataSet;
            // 
            // onlineClientsBindingSource1
            // 
            this.onlineClientsBindingSource1.DataMember = "OnlineClients";
            this.onlineClientsBindingSource1.DataSource = this.myFWDataSet;
            // 
            // clientsLastStatesTableAdapter
            // 
            this.clientsLastStatesTableAdapter.ClearBeforeFill = true;
            // 
            // onlineClientsTableAdapter
            // 
            this.onlineClientsTableAdapter.ClearBeforeFill = true;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CertificateStatusTableAdapter = null;
            this.tableAdapterManager.CertificateTableAdapter = this.certificateTableAdapter;
            //this.tableAdapterManager.ClientServerTableAdapter = null;
            this.tableAdapterManager.ClientStateTableAdapter = null;
            this.tableAdapterManager.ClientTableAdapter = this.clientTableAdapter;
            this.tableAdapterManager.LogTableAdapter = null;
            this.tableAdapterManager.ServerTableAdapter = null;
            //this.tableAdapterManager.ServerTypeClientTableAdapter = null;
            this.tableAdapterManager.StateTableAdapter = null;
            this.tableAdapterManager.StatusTableAdapter = null;
            this.tableAdapterManager.TempGuidTableAdapter = null;
            this.tableAdapterManager.TypeCertificateTableAdapter = null;
            //this.tableAdapterManager.typeClientTableAdapter = null;
            this.tableAdapterManager.TypeLogTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CAManager.myFWDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsbTableAdapter = null;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // certificateTableAdapter
            // 
            this.certificateTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 566);
            this.Controls.Add(this.mainTabsControl);
            this.Controls.Add(this.mainMenuPanel);
            this.Name = "MainForm";
            this.Text = " ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainMenuPanel.ResumeLayout(false);
            this.mainMenuPanel.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.mainTabsControl.ResumeLayout(false);
            this.tabStatistic.ResumeLayout(false);
            this.tabStatistic.PerformLayout();
            this.tabOnlineUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOnlineUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlineClientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myFWDataSet)).EndInit();
            this.onlineUserPanel.ResumeLayout(false);
            this.tabAllUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsLastStatesBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabBlockUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBlockClients)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tabServers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServers)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tabGeneralSettings.ResumeLayout(false);
            this.tabGeneralSettings.PerformLayout();
            this.tabSecuritySettings.ResumeLayout(false);
            this.tabSecuritySettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.certificateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlineClientsBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainMenuPanel;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnLogs;
        private System.Windows.Forms.Button btnServers;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnStatistic;
        private System.Windows.Forms.TabControl mainTabsControl;
        private System.Windows.Forms.TabPage tabStatistic;
        private System.Windows.Forms.TabPage tabOnlineUsers;
        private System.Windows.Forms.TabPage tabAllUsers;
        private System.Windows.Forms.TabPage tabBlockUsers;
        private System.Windows.Forms.TabPage tabServers;
        private System.Windows.Forms.TabPage tabLogs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel onlineUserPanel;
        private System.Windows.Forms.Button btnStopSession;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.DataGridView dgvOnlineUsers;
        private System.Windows.Forms.TabPage tabBlockedCerificates;
        private System.Windows.Forms.TabPage tabGeneralSettings;
        private System.Windows.Forms.TabPage tabSecuritySettings;
        private System.Windows.Forms.Button btnBlockUserOnline;
        private System.Windows.Forms.DataGridView dgvAllUsers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBlockUserAll;
        private System.Windows.Forms.Button btnSelectUser;
        private System.Windows.Forms.Button btnSelectUserOnline;
        private System.Windows.Forms.DataGridView dgvBlockClients;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDeblockUser;
        private System.Windows.Forms.Button btnSelectUserBlocked;
        private System.Windows.Forms.DataGridView dgvServers;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDelServer;
        private System.Windows.Forms.Button btnBlockServer;
        private System.Windows.Forms.Button btnDeblockServer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.TextBox tbxNewPass2;
        private System.Windows.Forms.TextBox tbxNewPass1;
        private System.Windows.Forms.TextBox tbxOldPass;
        private System.Windows.Forms.Button btnAddServerMasterOpen;
        private System.Windows.Forms.Button btnCertificateMasterOpen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private myFWDataSet myFWDataSet;
        private System.Windows.Forms.BindingSource clientsLastStatesBindingSource;
        private myFWDataSetTableAdapters.ClientsLastStatesTableAdapter clientsLastStatesTableAdapter;
        private System.Windows.Forms.BindingSource onlineClientsBindingSource;
        private myFWDataSetTableAdapters.OnlineClientsTableAdapter onlineClientsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn login;
        private System.Windows.Forms.DataGridViewTextBoxColumn ip;
        private System.Windows.Forms.BindingSource onlineClientsBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private myFWDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private myFWDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource certificateBindingSource;
        private myFWDataSetTableAdapters.CertificateTableAdapter certificateTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn1;
    }
}

