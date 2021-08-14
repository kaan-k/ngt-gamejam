using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class objectAttributes
{
   public float objectHealt;
   public objectType objType;
   public float durability;
   public resourceType resType;
   public float objectSize;
   public itemType itmType;
   public npcType NpcType;


   public bool shouldDie()
   {
       return(objectHealt<=0);
   }

   public void gatherLoot()
   {
     switch(resType)
     {
        case resourceType.Wood:
           Debug.Log("Loot Wood");
           break;


        case resourceType.Stone:
           Debug.Log("Loot Stone");
           break;
     }
   }

   public bool shouldDisappear()
   {
      return(durability<=0);
   }

   public enum objectType
   {
      Resource,
      Item,
      Npc
   }
   public enum resourceType
   {
      nar,
      Wood,
      Stone,
      Fuel
   }
   public enum itemType
   {
      nai,
      wooden,
      stone,
      iron
   }
   public enum npcType
   {
      nan,
      enemy,
      friendly
   }
}
