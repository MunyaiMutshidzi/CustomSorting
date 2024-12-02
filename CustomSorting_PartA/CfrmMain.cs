/* CSIS2664
 * Project 8, Part A
 * P Blignaut
 * August 2023
 */ 

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CustomSorting
{
    //https://stackoverflow.com/questions/805165/reorder-a-winforms-listbox-using-drag-and-drop

    public partial class CfrmMain : Form
    {
        //Declare and instantiate history
        Stack<MementoListBox.Memento> history 
            = new Stack<MementoListBox.Memento>(); //2

        //Constructor
        public CfrmMain()
        {
            InitializeComponent();

            //InitialiseListBox();
            InitialiseMListBox();
        } //Ctor

        #region MListbox

        private void InitialiseMListBox()
        {
            mlstbxObjects.AllowDrop = true;
            mlstbxObjects.DisplayMember = "Key";

            mlstbxObjects.Items.Add(new Item { Key = "A", Values = new int[] { 101, 102, 103 } });
            mlstbxObjects.Items.Add(new Item { Key = "B", Values = new int[] { 201, 202, 203 } });
            mlstbxObjects.Items.Add(new Item { Key = "C", Values = new int[] { 301, 302, 303 } });
            mlstbxObjects.Items.Add(new Item { Key = "D", Values = new int[] { 401, 402, 403 } });
            mlstbxObjects.Items.Add(new Item { Key = "E", Values = new int[] { 501, 502, 503 } });
            mlstbxObjects.Items.Add(new Item { Key = "F", Values = new int[] { 601, 602, 603 } });

        } //InitialiseMListbox

        private void mlstbxObjects_MouseDown(object sender, MouseEventArgs e)
        {
            int i = mlstbxObjects.SelectedIndex;
            if (i >= 0)
            {
                //Hold item
                Item selectedItem = (Item)mlstbxObjects.SelectedItem;

                //Drag-drop
                mlstbxObjects.DoDragDrop(mlstbxObjects.SelectedItem, DragDropEffects.Move);

                //SelectedIndex must change since the item could have been moved to another index
                mlstbxObjects.SelectedIndex = mlstbxObjects.Items.IndexOf(selectedItem);

                //Display values
                lblValue.Text = string.Join(",", selectedItem.Values);

            } //if (i >= 0)
        } //mlstbxObjects_MouseDown

        private void mlstbxObjects_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        } //lstbxObjects_DragOver

        private void mlstbxObjects_DragDrop(object sender, DragEventArgs e)
        {            
            //Get the index of the insert position
            Point point = mlstbxObjects.PointToClient(new Point(e.X, e.Y));
            int index = mlstbxObjects.IndexFromPoint(point);

            //If the insert position is above the first item
            if (index < 0)
                index = mlstbxObjects.Items.Count - 1;

            //Check if the order will be changed
            if (index != mlstbxObjects.SelectedIndex)
            {
                history.Push(mlstbxObjects.SaveToMemento());  //2
                lblStackCount.Text = history.Count.ToString(); //1
            }         

            //Get the data
            object data = e.Data.GetData(typeof(Item));

            //Remove the data and insert in the new position
            mlstbxObjects.Items.Remove(data);
            mlstbxObjects.Items.Insert(index, data);
        } //mlstbxObjects_DragDrop

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (history.Count > 0) //1
            {
                mlstbxObjects.RestoreFromMemento(history.Pop()); //2
                mlstbxObjects.Invalidate();
                lblStackCount.Text = history.Count.ToString();   //1
            }
        } //btnUndo_Click

        #endregion MListBox
    } //class
} //namespace




