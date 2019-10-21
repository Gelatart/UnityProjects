using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Collection : ScriptableObject
{

   public List<FloatData> CollectionList;
   
   public void Collect(FloatData obj)
   {
       CollectionList.Add(obj);
   }
   
   public void CollectionInfo() 
   {
       foreach (var obj in CollectionList)
       {
           Debug.Log(obj);
       }
   }

   /*public void AmmoInfo()
   {
       foreach (var obj in CollectionList)
       {
           if(obj.name == "Ammo")
           {
               //Debug.Log("We have ammo");
               Debug.Log("We have " + obj.Value + " ammo.");
               //Debug.Log("We have " + obj.GetType().GetProperty("Count").GetValue(obj) + " ammo."); //Testing? Make sure to list Ammo as "Count" in the object
               //AFTER TESTING: Change "We have ammo" to "We Have " + obj.Value + " ammo."
               //REFERENCE: https://stackoverflow.com/questions/45630389/how-to-iterate-through-a-list-of-anonymous-objects
           }
          
       }
   }*/

   /*public void MultipleAmmoInfo()
   {
       float TotalAmmo = 0;
       for (var i = 0; i < CollectionList.Count; i++)
       {
           if (CollectionList[i].name == "Ammo" || CollectionList[i].name == "Ammo+" || CollectionList[i].name == "Ammo++")
           {
               TotalAmmo = TotalAmmo + CollectionList[i].Value;
           }
       }
       Debug.Log("We have " + TotalAmmo + " ammo.");
   }*/

   /*public void FuelInfo()
   {
       for (var i = 0; i < CollectionList.Count; i++)
       //AFTER TESTING: change "i < 10" to "i < CollectionList.Count"
       {
           //Debug.Log(i);
           if (CollectionList[i].name == "Fuel")
           {
               Debug.Log(CollectionList[i]);
           }
          
           //AFTER TESTING: Change the debug log to "Debug.Log(CollectionList[i]);"
           //Then put debug log inside "if(CollectionList[i].name == "Fuel") {}"
       }
   }*/

   public void CollectableInfo()
   {
       int c = 0;
       int value = 0;
       for (var i = 0; i < CollectionList.Count; i++)
       {
           if (CollectionList[i].name == "Collectable")
           {
               Debug.Log("We have a collectable!");
               c++;
               //Insert code for grabbing value of the collectable
           }
       }

       Debug.Log("We have " + c + " collectables, worth " + value + ".");
   }
   /*public void ScoreInfo()
   {
       float TotalValue = 0;
       foreach (var obj in CollectionList)
       {
           if (obj.name == "NutScore" || obj.name == "CoinScore" || obj.name == "JewelScore" ||
               obj.name == "GemScore" || obj.name == "EmeraldScore")
           {
               TotalValue = TotalValue + obj.Value;
           }
       }

       Debug.Log("We have " + TotalValue + " score.");
   }*/
}
//Taken from script from DGM 1610 project