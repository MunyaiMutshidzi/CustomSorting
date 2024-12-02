
using System.Collections.Generic;
using System.Linq;

namespace CustomSorting
{
    class MementoListBox : System.Windows.Forms.ListBox
    {
        public class Memento
        {
            public List<Item> lstItems { get; private set; }

            public Memento(List<Item> lstItems)
            {
                this.lstItems = new List<Item>(lstItems);
            } //ctor
        } //class Memento

        public Memento SaveToMemento()
        {
            Memento memento = new Memento(this.Items.Cast<Item>().ToList());
            return memento;
        } //SaveToMemento

        public void RestoreFromMemento(Memento memento)
        {
            this.Items.Clear();
            foreach (Item item in memento.lstItems)
                this.Items.Add(item);
        }//RestoreFromMemento


    } //class MementoListBox
} //namespace
