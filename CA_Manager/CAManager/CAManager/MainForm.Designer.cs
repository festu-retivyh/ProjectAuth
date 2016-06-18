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
            this.NameUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.onlientClientsStateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myFWDataSet = new CAManager.myFWDataSet();
            this.onlineUserPanel = new System.Windows.Forms.Panel();
            this.btnSelectUserOnline = new System.Windows.Forms.Button();
            this.btnBlockUserOnline = new System.Windows.Forms.Button();
            this.btnStopSession = new System.Windows.Forms.Button();
            this.tabAllUsers = new System.Windows.Forms.TabPage();
            this.dgvAllUsers = new System.Windows.Forms.DataGridView();
            this.clientIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastClientsStatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.serverBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDelServer = new System.Windows.Forms.Button();
            this.btnBlockServer = new System.Windows.Forms.Button();
            this.btnDeblockServer = new System.Windows.Forms.Button();
            this.tabLogs = new System.Windows.Forms.TabPage();
            this.tabBlockedCerificates = new System.Windows.Forms.TabPage();
            this.tabGeneralSettings = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSpr = new System.Windows.Forms.Label();
            this.btnProgram = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnGroup = new System.Windows.Forms.Button();
            this.btnCert = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.btnSrv = new System.Windows.Forms.Button();
            this.tabSecuritySettings = new System.Windows.Forms.TabPage();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.tbxNewPass2 = new System.Windows.Forms.TextBox();
            this.tbxNewPass1 = new System.Windows.Forms.TextBox();
            this.tbxOldPass = new System.Windows.Forms.TextBox();
            this.certificateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new CAManager.myFWDataSetTableAdapters.ClientTableAdapter();
            this.tableAdapterManager = new CAManager.myFWDataSetTableAdapters.TableAdapterManager();
            this.certificateTableAdapter = new CAManager.myFWDataSetTableAdapters.CertificateTableAdapter();
            this.lastClientsStatesTableAdapter = new CAManager.myFWDataSetTableAdapters.LastClientsStatesTableAdapter();
            this.onlineClientStateTableAdapter = new CAManager.myFWDataSetTableAdapters.OnlineClientStateTableAdapter();
            this.serverTableAdapter = new CAManager.myFWDataSetTableAdapters.ServerTableAdapter();
            this.idDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.certificateIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainMenuPanel.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.mainTabsControl.SuspendLayout();
            this.tabStatistic.SuspendLayout();
            this.tabOnlineUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOnlineUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlientClientsStateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myFWDataSet)).BeginInit();
            this.onlineUserPanel.SuspendLayout();
            this.tabAllUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastClientsStatesBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabBlockUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBlockClients)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabServers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serverBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabGeneralSettings.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tabSecuritySettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.certificateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
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
            this.dgvOnlineUsers.AllowUserToAddRows = false;
            this.dgvOnlineUsers.AllowUserToDeleteRows = false;
            this.dgvOnlineUsers.AutoGenerateColumns = false;
            this.dgvOnlineUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOnlineUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.login,
            this.ip,
            this.NameUser,
            this.idDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn1,
            this.clientIdDataGridViewTextBoxColumn1,
            this.stateIdDataGridViewTextBoxColumn});
            this.dgvOnlineUsers.DataSource = this.onlientClientsStateBindingSource;
            this.dgvOnlineUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOnlineUsers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvOnlineUsers.Location = new System.Drawing.Point(3, 33);
            this.dgvOnlineUsers.Name = "dgvOnlineUsers";
            this.dgvOnlineUsers.ReadOnly = true;
            this.dgvOnlineUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOnlineUsers.Size = new System.Drawing.Size(762, 504);
            this.dgvOnlineUsers.TabIndex = 1;
            // 
            // login
            // 
            this.login.DataPropertyName = "login";
            this.login.HeaderText = "Логин";
            this.login.Name = "login";
            this.login.ReadOnly = true;
            // 
            // ip
            // 
            this.ip.DataPropertyName = "address";
            this.ip.HeaderText = "ip";
            this.ip.Name = "ip";
            this.ip.ReadOnly = true;
            // 
            // NameUser
            // 
            this.NameUser.DataPropertyName = "NameUser";
            this.NameUser.HeaderText = "Пользователь";
            this.NameUser.Name = "NameUser";
            this.NameUser.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn1
            // 
            this.dateDataGridViewTextBoxColumn1.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn1.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn1.Name = "dateDataGridViewTextBoxColumn1";
            this.dateDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // clientIdDataGridViewTextBoxColumn1
            // 
            this.clientIdDataGridViewTextBoxColumn1.DataPropertyName = "clientId";
            this.clientIdDataGridViewTextBoxColumn1.HeaderText = "clientId";
            this.clientIdDataGridViewTextBoxColumn1.Name = "clientIdDataGridViewTextBoxColumn1";
            this.clientIdDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // stateIdDataGridViewTextBoxColumn
            // 
            this.stateIdDataGridViewTextBoxColumn.DataPropertyName = "stateId";
            this.stateIdDataGridViewTextBoxColumn.HeaderText = "stateId";
            this.stateIdDataGridViewTextBoxColumn.Name = "stateIdDataGridViewTextBoxColumn";
            this.stateIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // onlientClientsStateBindingSource
            // 
            this.onlientClientsStateBindingSource.DataMember = "OnlientClientsState";
            this.onlientClientsStateBindingSource.DataSource = this.myFWDataSet;
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
            this.dgvAllUsers.AllowUserToAddRows = false;
            this.dgvAllUsers.AllowUserToDeleteRows = false;
            this.dgvAllUsers.AutoGenerateColumns = false;
            this.dgvAllUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientIdDataGridViewTextBoxColumn,
            this.nameUserDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.addressDataGridViewTextBoxColumn,
            this.State,
            this.idDataGridViewTextBoxColumn2,
            this.dateDataGridViewTextBoxColumn,
            this.stateIdDataGridViewTextBoxColumn1});
            this.dgvAllUsers.DataSource = this.lastClientsStatesBindingSource;
            this.dgvAllUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAllUsers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvAllUsers.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvAllUsers.Location = new System.Drawing.Point(3, 33);
            this.dgvAllUsers.MultiSelect = false;
            this.dgvAllUsers.Name = "dgvAllUsers";
            this.dgvAllUsers.ReadOnly = true;
            this.dgvAllUsers.RowHeadersVisible = false;
            this.dgvAllUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllUsers.Size = new System.Drawing.Size(762, 504);
            this.dgvAllUsers.TabIndex = 1;
            this.dgvAllUsers.DoubleClick += new System.EventHandler(this.dgvAllUsers_DoubleClick);
            // 
            // clientIdDataGridViewTextBoxColumn
            // 
            this.clientIdDataGridViewTextBoxColumn.DataPropertyName = "clientId";
            this.clientIdDataGridViewTextBoxColumn.HeaderText = "clientId";
            this.clientIdDataGridViewTextBoxColumn.Name = "clientIdDataGridViewTextBoxColumn";
            this.clientIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.clientIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameUserDataGridViewTextBoxColumn
            // 
            this.nameUserDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameUserDataGridViewTextBoxColumn.DataPropertyName = "NameUser";
            this.nameUserDataGridViewTextBoxColumn.HeaderText = "NameUser";
            this.nameUserDataGridViewTextBoxColumn.Name = "nameUserDataGridViewTextBoxColumn";
            this.nameUserDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "login";
            this.dataGridViewTextBoxColumn1.HeaderText = "login";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // State
            // 
            this.State.DataPropertyName = "stateId";
            this.State.HeaderText = "Статус";
            this.State.Name = "State";
            this.State.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "id";
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            this.idDataGridViewTextBoxColumn2.ReadOnly = true;
            this.idDataGridViewTextBoxColumn2.Visible = false;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stateIdDataGridViewTextBoxColumn1
            // 
            this.stateIdDataGridViewTextBoxColumn1.DataPropertyName = "stateId";
            this.stateIdDataGridViewTextBoxColumn1.HeaderText = "stateId";
            this.stateIdDataGridViewTextBoxColumn1.Name = "stateIdDataGridViewTextBoxColumn1";
            this.stateIdDataGridViewTextBoxColumn1.ReadOnly = true;
            this.stateIdDataGridViewTextBoxColumn1.Visible = false;
            // 
            // lastClientsStatesBindingSource
            // 
            this.lastClientsStatesBindingSource.DataMember = "LastClientsStates";
            this.lastClientsStatesBindingSource.DataSource = this.myFWDataSet;
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
            this.dgvServers.AllowUserToAddRows = false;
            this.dgvServers.AllowUserToDeleteRows = false;
            this.dgvServers.AutoGenerateColumns = false;
            this.dgvServers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn3,
            this.nameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn1,
            this.dateDataGridViewTextBoxColumn2,
            this.guidDataGridViewTextBoxColumn,
            this.certificateIdDataGridViewTextBoxColumn});
            this.dgvServers.DataSource = this.serverBindingSource;
            this.dgvServers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvServers.Location = new System.Drawing.Point(3, 33);
            this.dgvServers.Name = "dgvServers";
            this.dgvServers.ReadOnly = true;
            this.dgvServers.RowHeadersVisible = false;
            this.dgvServers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServers.Size = new System.Drawing.Size(762, 504);
            this.dgvServers.TabIndex = 1;
            this.dgvServers.DoubleClick += new System.EventHandler(this.dgvServers_DoubleClick);
            // 
            // serverBindingSource
            // 
            this.serverBindingSource.DataMember = "Server";
            this.serverBindingSource.DataSource = this.myFWDataSet;
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
            this.tabGeneralSettings.Controls.Add(this.flowLayoutPanel1);
            this.tabGeneralSettings.Location = new System.Drawing.Point(4, 22);
            this.tabGeneralSettings.Name = "tabGeneralSettings";
            this.tabGeneralSettings.Size = new System.Drawing.Size(768, 540);
            this.tabGeneralSettings.TabIndex = 7;
            this.tabGeneralSettings.Text = "Общие";
            this.tabGeneralSettings.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(768, 540);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Общие настройки";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.lblSpr);
            this.flowLayoutPanel2.Controls.Add(this.btnProgram);
            this.flowLayoutPanel2.Controls.Add(this.btnProfile);
            this.flowLayoutPanel2.Controls.Add(this.btnGroup);
            this.flowLayoutPanel2.Controls.Add(this.btnCert);
            this.flowLayoutPanel2.Controls.Add(this.btnClient);
            this.flowLayoutPanel2.Controls.Add(this.btnSrv);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(107, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(142, 248);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // lblSpr
            // 
            this.lblSpr.AutoSize = true;
            this.lblSpr.Location = new System.Drawing.Point(3, 0);
            this.lblSpr.Name = "lblSpr";
            this.lblSpr.Size = new System.Drawing.Size(73, 13);
            this.lblSpr.TabIndex = 0;
            this.lblSpr.Text = "Справочники";
            // 
            // btnProgram
            // 
            this.btnProgram.Location = new System.Drawing.Point(3, 16);
            this.btnProgram.Name = "btnProgram";
            this.btnProgram.Size = new System.Drawing.Size(139, 31);
            this.btnProgram.TabIndex = 1;
            this.btnProgram.Text = "Программы и службы";
            this.btnProgram.UseVisualStyleBackColor = true;
            this.btnProgram.Click += new System.EventHandler(this.btnProgram_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(3, 53);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(139, 31);
            this.btnProfile.TabIndex = 1;
            this.btnProfile.Text = "Профили";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnGroup
            // 
            this.btnGroup.Location = new System.Drawing.Point(3, 90);
            this.btnGroup.Name = "btnGroup";
            this.btnGroup.Size = new System.Drawing.Size(139, 31);
            this.btnGroup.TabIndex = 1;
            this.btnGroup.Text = "Группы";
            this.btnGroup.UseVisualStyleBackColor = true;
            this.btnGroup.Click += new System.EventHandler(this.btnGroup_Click);
            // 
            // btnCert
            // 
            this.btnCert.Location = new System.Drawing.Point(3, 127);
            this.btnCert.Name = "btnCert";
            this.btnCert.Size = new System.Drawing.Size(139, 31);
            this.btnCert.TabIndex = 1;
            this.btnCert.Text = "Сертификаты";
            this.btnCert.UseVisualStyleBackColor = true;
            this.btnCert.Click += new System.EventHandler(this.btnCert_Click);
            // 
            // btnClient
            // 
            this.btnClient.Location = new System.Drawing.Point(3, 164);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(139, 31);
            this.btnClient.TabIndex = 1;
            this.btnClient.Text = "Пользователи";
            this.btnClient.UseVisualStyleBackColor = true;
            // 
            // btnSrv
            // 
            this.btnSrv.Location = new System.Drawing.Point(3, 201);
            this.btnSrv.Name = "btnSrv";
            this.btnSrv.Size = new System.Drawing.Size(139, 31);
            this.btnSrv.TabIndex = 1;
            this.btnSrv.Text = "Сервера";
            this.btnSrv.UseVisualStyleBackColor = true;
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
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CertificateStatusTableAdapter = null;
            this.tableAdapterManager.CertificateTableAdapter = this.certificateTableAdapter;
            this.tableAdapterManager.ClientProfileTableAdapter = null;
            this.tableAdapterManager.ClientStateTableAdapter = null;
            this.tableAdapterManager.ClientTableAdapter = this.clientTableAdapter;
            this.tableAdapterManager.GroupProfileTableAdapter = null;
            this.tableAdapterManager.GroupTableAdapter = null;
            this.tableAdapterManager.LogTableAdapter = null;
            this.tableAdapterManager.ParametrsTableAdapter = null;
            this.tableAdapterManager.ProfileTableAdapter = null;
            this.tableAdapterManager.ProgramTableAdapter = null;
            this.tableAdapterManager.ServerTableAdapter = null;
            this.tableAdapterManager.StateTableAdapter = null;
            this.tableAdapterManager.StatusTableAdapter = null;
            this.tableAdapterManager.TempGuidTableAdapter = null;
            this.tableAdapterManager.TypeCertificateTableAdapter = null;
            this.tableAdapterManager.TypeLogTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CAManager.myFWDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsbTableAdapter = null;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // certificateTableAdapter
            // 
            this.certificateTableAdapter.ClearBeforeFill = true;
            // 
            // lastClientsStatesTableAdapter
            // 
            this.lastClientsStatesTableAdapter.ClearBeforeFill = true;
            // 
            // onlineClientStateTableAdapter
            // 
            this.onlineClientStateTableAdapter.ClearBeforeFill = true;
            // 
            // serverTableAdapter
            // 
            this.serverTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn3
            // 
            this.idDataGridViewTextBoxColumn3.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn3.HeaderText = "id";
            this.idDataGridViewTextBoxColumn3.Name = "idDataGridViewTextBoxColumn3";
            this.idDataGridViewTextBoxColumn3.ReadOnly = true;
            this.idDataGridViewTextBoxColumn3.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn1
            // 
            this.addressDataGridViewTextBoxColumn1.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn1.HeaderText = "ip-адрес";
            this.addressDataGridViewTextBoxColumn1.Name = "addressDataGridViewTextBoxColumn1";
            this.addressDataGridViewTextBoxColumn1.ReadOnly = true;
            this.addressDataGridViewTextBoxColumn1.Width = 120;
            // 
            // dateDataGridViewTextBoxColumn2
            // 
            this.dateDataGridViewTextBoxColumn2.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn2.HeaderText = "Дата создания";
            this.dateDataGridViewTextBoxColumn2.Name = "dateDataGridViewTextBoxColumn2";
            this.dateDataGridViewTextBoxColumn2.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn2.Width = 150;
            // 
            // guidDataGridViewTextBoxColumn
            // 
            this.guidDataGridViewTextBoxColumn.DataPropertyName = "guid";
            this.guidDataGridViewTextBoxColumn.HeaderText = "guid";
            this.guidDataGridViewTextBoxColumn.Name = "guidDataGridViewTextBoxColumn";
            this.guidDataGridViewTextBoxColumn.ReadOnly = true;
            this.guidDataGridViewTextBoxColumn.Visible = false;
            // 
            // certificateIdDataGridViewTextBoxColumn
            // 
            this.certificateIdDataGridViewTextBoxColumn.DataPropertyName = "certificateId";
            this.certificateIdDataGridViewTextBoxColumn.HeaderText = "certificateId";
            this.certificateIdDataGridViewTextBoxColumn.Name = "certificateIdDataGridViewTextBoxColumn";
            this.certificateIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.certificateIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 566);
            this.Controls.Add(this.mainTabsControl);
            this.Controls.Add(this.mainMenuPanel);
            this.Name = "MainForm";
            this.Text = " Менеджер Центра сертификации";
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
            ((System.ComponentModel.ISupportInitialize)(this.onlientClientsStateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myFWDataSet)).EndInit();
            this.onlineUserPanel.ResumeLayout(false);
            this.tabAllUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastClientsStatesBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabBlockUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBlockClients)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tabServers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serverBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tabGeneralSettings.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.tabSecuritySettings.ResumeLayout(false);
            this.tabSecuritySettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.certificateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
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
        private myFWDataSet myFWDataSet;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private myFWDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private myFWDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource certificateBindingSource;
        private myFWDataSetTableAdapters.CertificateTableAdapter certificateTableAdapter;
        private System.Windows.Forms.BindingSource lastClientsStatesBindingSource;
        private myFWDataSetTableAdapters.LastClientsStatesTableAdapter lastClientsStatesTableAdapter;
        private System.Windows.Forms.BindingSource onlientClientsStateBindingSource;
        private myFWDataSetTableAdapters.OnlineClientStateTableAdapter onlineClientStateTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn login;
        private System.Windows.Forms.DataGridViewTextBoxColumn ip;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource serverBindingSource;
        private myFWDataSetTableAdapters.ServerTableAdapter serverTableAdapter;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label lblSpr;
        private System.Windows.Forms.Button btnProgram;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnGroup;
        private System.Windows.Forms.Button btnCert;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnSrv;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn guidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn certificateIdDataGridViewTextBoxColumn;
    }
}

