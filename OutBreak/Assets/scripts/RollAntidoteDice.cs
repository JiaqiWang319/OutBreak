using UnityEngine;
using System.Collections;



public class RollAntidoteDice : MonoBehaviour
{
   public random random1;
   public random random2;
   public random random3;
   public random random4;
   public random random5;
   public random random6;

   static public int totalNumberOfA = 0;

    void start()
    {
       
        totalNumberOfA = random1.result + random2.result + random3.result + random4.result + random5.result + random6.result;
      
    }
    static public int rollAntidoteDice()
    {
        return totalNumberOfA;
    }
}

public class random : MonoBehaviour
{
    public int randomNumber = 0;
    public int result = 0;

    void strat()
    {
        randomNumber = Random.Range(0, 2);
        if (randomNumber < 1)
        {
            result = 0;
        }
        if (randomNumber >= 1)
        {
            result = 1;
        }
    }

}
