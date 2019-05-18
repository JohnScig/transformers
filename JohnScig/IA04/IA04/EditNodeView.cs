﻿using Support;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IA04
{
    public partial class EditNodeView : Form
    {

        #region Field
        private EditNodeViewModel _editNodeViewModel;
        #endregion

        #region Constructor
        public EditNodeView(int nodeID)
        {
            InitializeComponent();
            _editNodeViewModel = new EditNodeViewModel(nodeID);
            LoadInfo();
        }

        public EditNodeView(HierarchyLevel hierarchyLevel, int? parentNodeID)
        {
            InitializeComponent();
            _editNodeViewModel = new EditNodeViewModel(hierarchyLevel, parentNodeID);
        }
        #endregion

        #region Loading Function
        private void LoadInfo()
        {
            tb_name.Text = _editNodeViewModel.Node.Name;
            tb_code.Text = _editNodeViewModel.Node.Code;
        }
        #endregion

        #region Button Handling Function
        private void btn_OK_Click(object sender, EventArgs e)
        {
            _editNodeViewModel.HandleClick(tb_name.Text, tb_code.Text);
            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

    }
}
