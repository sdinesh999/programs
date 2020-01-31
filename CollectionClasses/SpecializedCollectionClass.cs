using System;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SpecializedCollection
{
    class SpecializedCollectionClass
    {
        // ListDictionary=> Implements IDictionary using a singly linked list. Recommended for collections that typically include fewer than 10 items.
        ListDictionary myList = new ListDictionary();

        HybridDictionary myHD = new HybridDictionary();

        OrderedDictionary myOrderedDictionary = new OrderedDictionary();

        NameValueCollection myCol = new NameValueCollection();

        public SpecializedCollectionClass()
        {
            // Adding elements into the listdictionary
            myList.Add("Braeburn Apples", "1.49");
            myList.Add("Fuji Apples", "1.29");
            myList.Add("Gala Apples", "1.49");
            myList.Add("Golden Delicious Apples", "1.29");
            myList.Add("Granny Smith Apples", "0.89");
            myList.Add("Red Delicious Apples", "0.99");

            Console.WriteLine("Retrieving elements from myList . . .");

            foreach (DictionaryEntry v in myList)
            {
                Console.WriteLine("Key  =  {0}  and Value = {1}", v.Key, v.Value);
            }

            //Adding elements into HybridDictionary
            for (int i = 1; i < 5; i++)
            {
                myHD.Add(i, i * 255);
            }
            //Retrieving data from HybridDictionary

            foreach (DictionaryEntry hd in myHD)
            {
                Console.WriteLine(hd.Key + " " + hd.Value);
            }

            Console.WriteLine("Adding elements into OrderedDictionary");
            myOrderedDictionary.Add("testKey1", "testValue1");
            myOrderedDictionary.Add("testKey2", "testValue2");
            myOrderedDictionary.Add("keyToDelete", "valueToDelete");
            myOrderedDictionary.Add("testKey3", "testValue3");

            Console.WriteLine("Retrieving elements from the Dictionary");
            foreach (DictionaryEntry moe in myOrderedDictionary)
            {
                Console.WriteLine(moe.Key + " " + moe.Value);
            }

            myCol.Add("red", "rojo");
            myCol.Add("green", "verde");
            myCol.Add("blue", "azul");
            myCol.Add("red", "rouge");

            //Console.WriteLine("Retrieving data from NameValueCollections");
            Console.WriteLine("Total entries in NameValueCollections is {0}", myCol.Count);



        }
    }
}

