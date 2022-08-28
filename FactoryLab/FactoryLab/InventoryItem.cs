using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLab
{
    public abstract class InventoryItem
    {
        //TODO: The other common properties go here!
        public float Price { get; }//Can only be assigned to in a constructor in this class

        public virtual void DisplayItem()
        {
            //TODO: Implement the DisplayItem method
            throw new NotImplementedException();
        }

        public static InventoryItem? Create(ProductTypes productType, String brand, String title, int quantityOnHand, float price, List<String> miscAttributes)
        {
            //TODO: Implement the factory method
            return null;
        }
    }
}
