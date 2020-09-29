/*********************************************************************************
 <copyright file="frmMain.cs">

 {one line to give the program's name and a brief idea of what it does.}
 Copyright (C) 2015 Ted Lee

 This program is free software: you can redistribute it and/or modify
 it under the +terms of the GNU General Public License as published by
 the Free Software Foundation, either version 3 of the License, or
 (at your option) any later version.

 This program is distributed in the hope that it will be useful,
 but WITHOUT ANY WARRANTY; without even the implied warranty of
 MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 GNU General Public License for more details.

 You should have received a copy of the GNU General Public License
 along with this program.  If not, see http://www.gnu.org/licenses/. 
 </copyright>
 <summary>
 Email: leebolea@hotmail.com
 </summary>
 *********************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace UniqueWebSite_XML {
    public partial class frmMain : Form {

        private KeyValueList _lstList = new KeyValueList();                         //variable to store the list of key value pair
        private Regex _regExInputVal = new Regex(@"^[A-Za-z0-9]+=[A-Za-z0-9]+$");   //regular expression to validate user input value
        private string _strCurrentFile = "";                                        //to store current working file name
        private string _strTitle = "Key-Value Pair Entry Program";                  //to represent the title of the window
        private bool _bIsNewFile = true;                                            //flag to indicate whether working file is new file or existed file
        private SortOrder _soSortByKey = SortOrder.None;                            //current sorting condition for Sort By Name
        private SortOrder _soSortByValue = SortOrder.None;                          //current sorting condition for Sort By Name

        public frmMain() {
            InitializeComponent();
            this._strCurrentFile = "Untitled.xml";
            this.Text = string.Format("{0} - {1}", this._strTitle, Path.GetFileName(this._strCurrentFile));
            
            this.chklstList.DisplayMember = "Display";
            this.chklstList.ItemCheck += chklstList_ItemCheck;
        }

        /// <summary>
        /// when one of the check box was clicked 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chklstList_ItemCheck(object sender, ItemCheckEventArgs e) {
            this._lstList[e.Index].Selected = (e.NewValue == CheckState.Checked);
        }

        /// <summary>
        /// [sort by name] button was clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSortByName_Click(object sender, EventArgs e) {
            if (this._soSortByKey == SortOrder.None || this._soSortByKey == SortOrder.Descending) {
                this.SetSortByKey_SortOrder(SortOrder.Ascending);
            } else {
                this.SetSortByKey_SortOrder(SortOrder.Descending);
            }
            this.chklstList.Items.Clear();
            this.chklstList.Items.AddRange(this._lstList.ToArray());
        }

        /// <summary>
        /// [Sort by Value] button was clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSortByValue_Click(object sender, EventArgs e) {
            if (this._soSortByValue == SortOrder.None || this._soSortByValue == SortOrder.Descending) {
                this.SetSortByValue_SortOrder(SortOrder.Ascending);
            } else {
                this.SetSortByValue_SortOrder(SortOrder.Descending);
            }
            this.chklstList.Items.Clear();
            this.chklstList.Items.AddRange(this._lstList.ToArray());

        }

        /// <summary>
        /// [check all] button was clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCheckAll_Click(object sender, EventArgs e) {
            for (int i = 0; i < this.chklstList.Items.Count; i++) {
                this.chklstList.SetItemChecked(i, true);
                this._lstList[i].Selected = true;
            }
        }

        /// <summary>
        /// [uncheck all] button was clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUncheckAll_Click(object sender, EventArgs e) {
            for (int i = 0; i < this.chklstList.Items.Count; i++) {
                this.chklstList.SetItemChecked(i, false);
                this._lstList[i].Selected = false;
            }
        }

        /// <summary>
        /// [add to list] button was clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e) {
            //check whether the input was empty or not
            if (string.IsNullOrEmpty(this.txtInput.Text)) {
                MessageBox.Show("Invalid value");
                this.txtInput.Focus();
                return;
            }

            //validate the input value by regular expression
            if (!_regExInputVal.IsMatch(this.txtInput.Text)) {
                MessageBox.Show("Invalid value. Only accept alphabet or number. Example: Key91=Value123",
                    "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtInput.Focus();
                return;

            }

            //split the input value into key and value
            string[] _arrTemp = this.txtInput.Text.Split(new char[] { '=' });

            this._lstList.Add(new KeyValuePair<string, string>(_arrTemp[0], _arrTemp[1]));

            //add the input value into checkedboxlist
            this.chklstList.Items.Add(this._lstList[this._lstList.Count - 1]);
            
            //scroll to end of the checkedbox list
            this.chklstList.TopIndex = this.chklstList.Items.Count - 1;

            //empty the input value
            this.txtInput.Text = "";

            if (this.Text.Substring(this.Text.Length - 1, 1) != "*") {
                //to indicate the current work file was change
                this.Text += " *";
            }
        }

        /// <summary>
        /// [Delete selected] button was clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e) {
            //check is any item was selected
            if (this.chklstList.CheckedIndices.Count <= 0)
                return;

            //obtain the current scroll position of the checkedboxlist
            int iCurrentPosition = this.chklstList.TopIndex;
            
            //remove the checked item from the local variable 1 by 1 
            foreach (int index in this.chklstList.CheckedIndices) {
                KeyValuePair<string, string> obj = (KeyValuePair<string, string>)this.chklstList.Items[index];
                this._lstList.Remove(obj);
            }

            //rebind the local variable into checkedboxlist
            this.chklstList.Items.Clear();
            this.chklstList.Items.AddRange(this._lstList.ToArray());

            if (iCurrentPosition > this.chklstList.Items.Count - 1) {
                //scroll to end since the previous position was bigger than existing checkedboxlist's item count.
                this.chklstList.TopIndex = this.chklstList.Items.Count - 1;
            } else {
                //scroll to the previous position
                this.chklstList.TopIndex = iCurrentPosition;
            }

            if (this.Text.Substring(this.Text.Length - 1, 1) != "*") {
                //to indicate the current work file was change
                this.Text += " *";
            }
        }

        /// <summary>
        /// [Save] menu item was click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiSave_Click(object sender, EventArgs e) {
            string _strFilePath = "";
            if (!this._bIsNewFile) {
                //this is existed file
                //get the current working file path.
                _strFilePath = this._strCurrentFile;
            } else {
                //this is new file
                //ask where the user want to save the current information.
                using (SaveFileDialog saveDialog = new SaveFileDialog()) {
                    saveDialog.DefaultExt = "xml";
                    saveDialog.Filter = "XML|*.xml";
                    saveDialog.AddExtension = true;
                    if (saveDialog.ShowDialog() != System.Windows.Forms.DialogResult.OK) {
                        return;
                    }
                    _strFilePath = saveDialog.FileName;
                }
            }

            XmlSerializer SerializerObj = new XmlSerializer(typeof(KeyValueList));
            
            using (TextWriter WriteFileStream = new StreamWriter(_strFilePath)) {
                //write to file
                SerializerObj.Serialize(WriteFileStream, this._lstList);
            }
            this.Text = string.Format("{0} - {1}", this._strTitle, Path.GetFileName(this._strCurrentFile));
        }

        /// <summary>
        /// [Open] Menu was click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiOpen_Click(object sender, EventArgs e) {
            //ask which file user want the open.
            using (OpenFileDialog openDialog = new OpenFileDialog()) {
                openDialog.DefaultExt = "xml";
                openDialog.Filter = "XML|*.xml";
                openDialog.AddExtension = true;
                if (openDialog.ShowDialog() != System.Windows.Forms.DialogResult.OK) {
                    return;
                }
                this._strCurrentFile = openDialog.FileName;
            }

            //get the schema so we can validate the user selected xml is valid or not.
            XmlSchemaSet schemas = new XmlSchemaSet();
            schemas.Add(null, "KeyValuePairXml.xsd");

            //start validate the selected xml file
            bool _bIsValid = true;
            XDocument doc = XDocument.Load(this._strCurrentFile);            
            doc.Validate(schemas, (o, e1) => {
                _bIsValid = false;
                MessageBox.Show("Sorry. The selected file was contain invalid content that i can't continue to the following step.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            });

            if (!_bIsValid) {
                //do nothing, since its invalid xml file
                return;
            }

            XmlSerializer SerializerObj = new XmlSerializer(typeof(KeyValueList));
            using (StreamReader reader = new StreamReader(this._strCurrentFile)) {
                //read xml content and serialize into object.
                this._lstList = (KeyValueList)SerializerObj.Deserialize(reader);

            }

            //rebind the local variable into checkedboxlist
            this.chklstList.Items.Clear();
            this.chklstList.Items.AddRange(this._lstList.ToArray());
            this._bIsNewFile = false;
            this.Text = string.Format("{0} - {1}", this._strTitle, Path.GetFileName(this._strCurrentFile));
        }

        /// <summary>
        /// [Exit] menu item was clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        /// <summary>
        /// [Close] menu item was clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeFileToolStripMenuItem_Click(object sender, EventArgs e) {
            this._lstList = new KeyValueList();
            this.chklstList.Items.Clear();
            this._strCurrentFile = "Untitled.xml";
            this._bIsNewFile = true;
            this.Text = string.Format("{0} - {1}", this._strTitle, Path.GetFileName(this._strCurrentFile));
        }

        private void SetSortByKey_SortOrder(SortOrder sortOrder) {
            this.btnSortByName.Text = "Sort By &Name";
            if (sortOrder == SortOrder.Ascending) {
                this._lstList.Sort((x, y) => x.Key.CompareTo(y.Key));
                this._soSortByKey = SortOrder.Ascending;
                this.btnSortByName.Text += "[ASC]";

            } else if (sortOrder == SortOrder.Descending) {
                this._lstList.Sort((x, y) => y.Key.CompareTo(x.Key));
                this._soSortByKey = SortOrder.Descending;
                this.btnSortByName.Text += "[DESC]";

            }
            this.btnSortByValue.Text = "Sort By &Value";
        }

        private void SetSortByValue_SortOrder(SortOrder sortOrder) {
            this.btnSortByValue.Text = "Sort By &Value";
            if (sortOrder == SortOrder.Ascending) {
                this._lstList.Sort((x, y) => x.Value.CompareTo(y.Value));
                this._soSortByValue = SortOrder.Ascending;
                this.btnSortByValue.Text += "[ASC]";

            } else if (sortOrder == SortOrder.Descending) {
                this._lstList.Sort((x, y) => y.Value.CompareTo(x.Value));
                this._soSortByValue = SortOrder.Descending;
                this.btnSortByValue.Text += "[DESC]";

            }
            this.btnSortByName.Text = "Sort By &Name";
        }
    }
}