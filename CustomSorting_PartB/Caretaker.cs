

using System.Collections.Generic;

namespace CustomSorting
{
    class Caretaker
    {
        //Originator
        private MementoListBox mlstbxObjects;
        //History
        private Stack<MementoListBox.Memento> history 
            = new Stack<MementoListBox.Memento>(); 
        public int CountStates => history.Count;

        //Constructor
        public Caretaker(MementoListBox mlstbxObjects) 
        {
            this.mlstbxObjects = mlstbxObjects; 
        } //ctor

        //Operations
        public void ChangeState(List<Item> items)
        {
            history.Push(mlstbxObjects.SaveToMemento()); 
            mlstbxObjects.Items.Clear();
            foreach (Item item in items)
                mlstbxObjects.Items.Add(item);           
        } //ChangeState

        //Restore
        public void Restore(int steps)
        {
            for (int step = 1; step <= steps; step++) 
                if (history.Count > 0)                
                    mlstbxObjects
                        .RestoreFromMemento(history.Pop()); 
        }

    } //class Caretaker
} //namespace
