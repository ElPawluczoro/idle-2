using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Xml.Serialization;
using UnityEngine;

public class Bananas
{
    private int bananas1;
    private int bananasK;
    private int bananasM;
    private int bananasG;
    private int bananasT;
    private int bananasP;
    private int bananasE;
    private int bananasZ;
    private int bananasY;

    public Bananas()
    {

    }

    public Bananas(int bananas1, int bananasK, int bananasM, int bananasG, int bananasT, int bananasP, int bananasE, int bananasZ, int bananasY)
    {
        this.bananas1 = bananas1;
        this.bananasK = bananasK;
        this.bananasM = bananasM;
        this.bananasG = bananasG;
        this.bananasT = bananasT;
        this.bananasP = bananasP;
        this.bananasE = bananasE;
        this.bananasZ = bananasZ;
        this.bananasY = bananasY;
    }

    public static int Compare(Bananas bananas1, Bananas bananas2)
    {
        if (bananas2.bananasY > 0)
        {
            if ((bananas1.bananasY > bananas2.bananasY) || ((bananas1.bananasY == bananas2.bananasY) && (bananas1.bananasZ > bananas2.bananasZ))) return 1;
            else if ((bananas1.bananasY < bananas2.bananasY) || ((bananas1.bananasY == bananas2.bananasY) && (bananas1.bananasZ < bananas2.bananasZ))) return -1;
            //else if ((bananas1.bananasY == bananas2.bananasY) && (bananas1.bananasZ == bananas2.bananasZ)) return 0;
            else return 0;
        }
        else if (bananas2.bananasZ > 0)
        {
            if ((bananas1.bananasZ > bananas2.bananasZ) || ((bananas1.bananasZ == bananas2.bananasZ) && (bananas1.bananasE > bananas2.bananasE))
                || bananas1.bananasY > 0) return 1;
            else if ((bananas1.bananasZ < bananas2.bananasZ) || ((bananas1.bananasZ == bananas2.bananasZ) && (bananas1.bananasE < bananas2.bananasE))) return -1;
            //else if ((bananas1.bananasZ == bananas2.bananasZ) && (bananas1.bananasE == bananas2.bananasE)) return 0;
            else return 0;
        }
        else if (bananas2.bananasE > 0)
        {
            if ((bananas1.bananasE > bananas2.bananasE) || ((bananas1.bananasE == bananas2.bananasE) && (bananas1.bananasP > bananas2.bananasP))
                || bananas1.bananasZ > 0 || bananas1.bananasY > 0) return 1;
            else if ((bananas1.bananasE < bananas2.bananasE) || ((bananas1.bananasE == bananas2.bananasE) && (bananas1.bananasP < bananas2.bananasP))) return -1;
            //else if ((bananas1.bananasE == bananas2.bananasE) && (bananas1.bananasP == bananas2.bananasP)) return 0;
            else return 0;
        }
        else if (bananas2.bananasP > 0)
        {
            if ((bananas1.bananasP > bananas2.bananasP) || ((bananas1.bananasP == bananas2.bananasP) && (bananas1.bananasT > bananas2.bananasT))
                || bananas1.bananasE > 0 || bananas1.bananasZ > 0 || bananas1.bananasY > 0) return 1;
            else if ((bananas1.bananasP < bananas2.bananasP) || ((bananas1.bananasP == bananas2.bananasP) && (bananas1.bananasT < bananas2.bananasT))) return -1;
            //else if ((bananas1.bananasP == bananas2.bananasP) && (bananas1.bananasT == bananas2.bananasT)) return 0;
            else return 0;
        }
        else if (bananas2.bananasT > 0)
        {
            if ((bananas1.bananasT > bananas2.bananasT) || ((bananas1.bananasT == bananas2.bananasT) && (bananas1.bananasG > bananas2.bananasG))
                || bananas1.bananasP > 0 || bananas1.bananasE > 0 || bananas1.bananasZ > 0 || bananas1.bananasY > 0) return 1;
            else if ((bananas1.bananasT < bananas2.bananasT) || ((bananas1.bananasT == bananas2.bananasT) && (bananas1.bananasG < bananas2.bananasG))) return -1;
            //else if ((bananas1.bananasT == bananas2.bananasT) && (bananas1.bananasG == bananas2.bananasG)) return 0;
            else return 0;
        }
        else if (bananas2.bananasG > 0)
        {
            if ((bananas1.bananasG > bananas2.bananasG) || ((bananas1.bananasG == bananas2.bananasG) && (bananas1.bananasM > bananas2.bananasM))
                || bananas1.bananasT > 0 || bananas1.bananasP > 0 || bananas1.bananasE > 0 || bananas1.bananasZ > 0 || bananas1.bananasY > 0) return 1;
            else if ((bananas1.bananasG < bananas2.bananasG) || ((bananas1.bananasG == bananas2.bananasG) && (bananas1.bananasM < bananas2.bananasM))) return -1;
            //else if ((bananas1.bananasG == bananas2.bananasG) && (bananas1.bananasM == bananas2.bananasM)) return 0;
            else return 0;
        }
        else if (bananas2.bananasM > 0)
        {
            if ((bananas1.bananasM > bananas2.bananasM) || ((bananas1.bananasM == bananas2.bananasM) && (bananas1.bananasK > bananas2.bananasK))
                || bananas1.bananasG > 0 || bananas1.bananasT > 0 || bananas1.bananasP > 0 
                || bananas1.bananasE > 0 || bananas1.bananasZ > 0 || bananas1.bananasY > 0) return 1;
            else if ((bananas1.bananasM < bananas2.bananasM) || ((bananas1.bananasM == bananas2.bananasM) && (bananas1.bananasK < bananas2.bananasK))) return -1;
            //else if ((bananas1.bananasM == bananas2.bananasM) && (bananas1.bananasK == bananas2.bananasK)) return 0;
            else return 0;
        }
        else if (bananas2.bananasK > 0)
        {
            if ((bananas1.bananasK > bananas2.bananasK) || ((bananas1.bananasK == bananas2.bananasK) && (bananas1.bananas1 > bananas2.bananas1))
                || bananas1.bananasM > 0 || bananas1.bananasG > 0 || bananas1.bananasT > 0
                || bananas1.bananasP > 0 || bananas1.bananasE > 0 || bananas1.bananasZ > 0 || bananas1.bananasY > 0) return 1;
            else if ((bananas1.bananasK < bananas2.bananasK) || ((bananas1.bananasK == bananas2.bananasK) && (bananas1.bananas1 < bananas2.bananas1))) return -1;
            //else if ((bananas1.bananasK == bananas2.bananasK) && (bananas1.bananas1 == bananas2.bananas1)) return 0;
            else return 0;
        }
        else
        {
            if (bananas1.bananas1 > bananas2.bananas1 || bananas1.bananasK > 0 || bananas1.bananasM > 0 || bananas1.bananasG > 0 || bananas1.bananasT > 0 
                || bananas1.bananasP > 0 || bananas1.bananasE > 0 || bananas1.bananasZ > 0 || bananas1.bananasY > 0) return 1;
            else if (bananas1.bananas1 < bananas2.bananas1) return -1;
            else return 0;
        }
    }

   /* private int bananas1;
      private int bananasK;
      private int bananasM;
      private int bananasG;
      private int bananasT;
      private int bananasP;
      private int bananasE;
      private int bananasZ;
      private int bananasY;*/

    public void SpendBananas(Bananas bananas)
    {
        //this.bananas1 -= bananas.bananas1;
        if (bananas.bananas1 > this.bananas1 && this.bananasK > 0)
        {
            this.bananasK -= 1;
            this.bananas1 += 1000;
        }
        else if (bananas.bananas1 > this.bananas1 && bananasM > 0)
        {
            this.bananasM -= 1;
            this.bananasK += 999;
            this.bananas1 += 1000;
        }
        else if (bananas.bananas1 > this.bananas1 && bananasG > 0)
        {
            this.bananasG -= 1;
            this.bananasM += 999;
            this.bananasK += 999;
            this.bananas1 += 1000;
        }
        else if (bananas.bananas1 > this.bananas1 && bananasT > 0)
        {
            this.bananasT -= 1;
            this.bananasG += 999;
            this.bananasM += 999;
            this.bananasK += 999;
            this.bananas1 += 1000;
        }
        else if (bananas.bananas1 > this.bananas1 && bananasP > 0)
        {
            this.bananasP -= 1;
            this.bananasT += 999;
            this.bananasG += 999;
            this.bananasM += 999;
            this.bananasK += 999;
            this.bananas1 += 1000;
        }
        else if (bananas.bananas1 > this.bananas1 && bananasE > 0)
        {
            this.bananasE -= 1;
            this.bananasP += 999;
            this.bananasT += 999;
            this.bananasG += 999;
            this.bananasM += 999;
            this.bananasK += 999;
            this.bananas1 += 1000;
        }
        else if (bananas.bananas1 > this.bananas1 && bananasZ > 0)
        {
            this.bananasZ -= 1;
            this.bananasE += 999;
            this.bananasP += 999;
            this.bananasT += 999;
            this.bananasG += 999;
            this.bananasM += 999;
            this.bananasK += 999;
            this.bananas1 += 1000;
        }
        else if (bananas.bananas1 > this.bananas1 && bananasY > 0)
        {
            this.bananasY -= 1;
            this.bananasZ += 999;
            this.bananasE += 999;
            this.bananasP += 999;
            this.bananasT += 999;
            this.bananasG += 999;
            this.bananasM += 999;
            this.bananasK += 999;
            this.bananas1 += 1000;
        }
        this.bananas1 -= bananas.bananas1;

        if (bananas.bananasK > this.bananasK && bananasM > 0)
        {
            this.bananasM -= 1;
            this.bananasK += 1000;
        }
        else if (bananas.bananasK > this.bananasK && bananasG > 0)
        {
            this.bananasG -= 1;
            this.bananasM += 999;
            this.bananasK += 1000;
        }
        else if (bananas.bananasK > this.bananasK && bananasT > 0)
        {
            this.bananasT -= 1;
            this.bananasG += 999;
            this.bananasM += 999;
            this.bananasK += 1000;
        }
        else if (bananas.bananasK > this.bananasK && bananasP > 0)
        {
            this.bananasP -= 1;
            this.bananasT += 999;
            this.bananasG += 999;
            this.bananasM += 999;
            this.bananasK += 1000;
        }
        else if (bananas.bananasK > this.bananasK && bananasE > 0)
        {
            this.bananasE -= 1;
            this.bananasP += 999;
            this.bananasT += 999;
            this.bananasG += 999;
            this.bananasM += 999;
            this.bananasK += 1000;
        }
        else if (bananas.bananasK > this.bananasK && bananasZ > 0)
        {
            this.bananasZ -= 1;
            this.bananasE += 999;
            this.bananasP += 999;
            this.bananasT += 999;
            this.bananasG += 999;
            this.bananasM += 999;
            this.bananasK += 1000;
        }
        else if (bananas.bananasK > this.bananasK && bananasY > 0)
        {
            this.bananasY -= 1;
            this.bananasZ += 999;
            this.bananasE += 999;
            this.bananasP += 999;
            this.bananasT += 999;
            this.bananasG += 999;
            this.bananasM += 999;
            this.bananasK += 1000;
        }
        this.bananasK -= bananas.bananasK;

        if (bananas.bananasM > this.bananasM && bananasG > 0)
        {
            this.bananasG -= 1;
            this.bananasM += 1000;
        }
        else if (bananas.bananasM > this.bananasM && bananasT > 0)
        {
            this.bananasT -= 1;
            this.bananasG += 999;
            this.bananasM += 1000;
        }
        else if (bananas.bananasM > this.bananasM && bananasP > 0)
        {
            this.bananasP -= 1;
            this.bananasT += 999;
            this.bananasG += 999;
            this.bananasM += 1000;
        }
        else if (bananas.bananasM > this.bananasM && bananasE > 0)
        {
            this.bananasE -= 1;
            this.bananasP += 999;
            this.bananasT += 999;
            this.bananasG += 999;
            this.bananasM += 1000;
        }
        else if (bananas.bananasM > this.bananasM && bananasZ > 0)
        {
            this.bananasZ -= 1;
            this.bananasE += 999;
            this.bananasP += 999;
            this.bananasT += 999;
            this.bananasG += 999;
            this.bananasM += 1000;
        }
        else if (bananas.bananasM > this.bananasM && bananasY > 0)
        {
            this.bananasY -= 1;
            this.bananasZ += 999;
            this.bananasE += 999;
            this.bananasP += 999;
            this.bananasT += 999;
            this.bananasG += 999;
            this.bananasM += 1000;
        }
        this.bananasM -= bananas.bananasM;

        if (bananas.bananasG > this.bananasG && bananasT > 0)
        {
            this.bananasT -= 1;
            this.bananasG += 1000;
        }
        else if (bananas.bananasG > this.bananasG && bananasP > 0)
        {
            this.bananasP -= 1;
            this.bananasT += 999;
            this.bananasG += 1000;
        }
        else if (bananas.bananasG > this.bananasG && bananasE > 0)
        {
            this.bananasE -= 1;
            this.bananasP += 999;
            this.bananasT += 999;
            this.bananasG += 1000;
        }
        else if (bananas.bananasG > this.bananasG && bananasZ > 0)
        {
            this.bananasZ -= 1;
            this.bananasE += 999;
            this.bananasP += 999;
            this.bananasT += 999;
            this.bananasG += 1000;
        }
        else if (bananas.bananasG > this.bananasG && bananasY > 0)
        {
            this.bananasY -= 1;
            this.bananasZ += 999;
            this.bananasE += 999;
            this.bananasP += 999;
            this.bananasT += 999;
            this.bananasG += 1000;
        }
        this.bananasG -= bananas.bananasG;

        if (bananas.bananasT > this.bananasT && bananasP > 0)
        {
            this.bananasP -= 1;
            this.bananasT += 1000;
        }
        else if (bananas.bananasG > this.bananasG && bananasE > 0)
        {
            this.bananasE -= 1;
            this.bananasP += 999;
            this.bananasT += 1000;
        }
        else if (bananas.bananasG > this.bananasG && bananasZ > 0)
        {
            this.bananasZ -= 1;
            this.bananasE += 999;
            this.bananasP += 999;
            this.bananasT += 1000;
        }
        else if (bananas.bananasG > this.bananasG && bananasY > 0)
        {
            this.bananasY -= 1;
            this.bananasZ += 999;
            this.bananasE += 999;
            this.bananasP += 999;
            this.bananasT += 1000;
        }
        this.bananasT -= bananas.bananasT;

        if (bananas.bananasP > this.bananasP && bananasE > 0)
        {
            this.bananasE -= 1;
            this.bananasP += 1000;
        }
        else if (bananas.bananasP > this.bananasP && bananasZ > 0)
        {
            this.bananasZ -= 1;
            this.bananasE += 999;
            this.bananasP += 1000;
        }
        else if (bananas.bananasP > this.bananasP && bananasY > 0)
        {
            this.bananasY -= 1;
            this.bananasZ += 999;
            this.bananasE += 999;
            this.bananasP += 1000;
        }

        this.bananasP -= bananas.bananasP;

        if (bananas.bananasE > this.bananasE && bananasZ > 0)
        {
            this.bananasZ -= 1;
            this.bananasE += 1000;
        }
        else if (bananas.bananasE > this.bananasE && bananasY > 0)
        {
            this.bananasY -= 1;
            this.bananasZ += 999;
            this.bananasE += 1000;
        }
        this.bananasE -= bananas.bananasE;

        if (bananas.bananasZ > this.bananasZ && bananasY > 0)
        {
            this.bananasY -= 1;
            this.bananasZ += 1000;
        }
        this.bananasZ -= bananas.bananasZ;


        this.bananasY -= bananas.bananasY;
    }

    public void AddBananas(Bananas bananas)
    {
        this.bananas1 += bananas.bananas1;
        this.bananasK += bananas.bananasK;
        this.bananasM += bananas.bananasM;
        this.bananasG += bananas.bananasG;
        this.bananasT += bananas.bananasT;
        this.bananasP += bananas.bananasP;
        this.bananasE += bananas.bananasE;
        this.bananasZ += bananas.bananasZ;
        this.bananasY += bananas.bananasY;
    }

    public static Bananas operator+ (Bananas b1, Bananas b2)
    {
        Bananas bananas = new Bananas();
        
        bananas.bananas1 = b1.bananas1 + b2.bananas1;
        bananas.bananasK = b1.bananasK + b2.bananasK;
        bananas.bananasM = b1.bananasM + b2.bananasM;
        bananas.bananasG = b1.bananasG + b2.bananasG;
        bananas.bananasT = b1.bananasT + b2.bananasT;
        bananas.bananasP = b1.bananasP + b2.bananasP;
        bananas.bananasE = b1.bananasE + b2.bananasE;
        bananas.bananasZ = b1.bananasZ + b2.bananasZ;
        bananas.bananasY = b1.bananasY + b2.bananasY;

        return bananas;
    }

    public static Bananas operator- (Bananas b1, Bananas b2)
    {
        Bananas bananas = new Bananas();

        bananas.bananas1 = b1.bananas1 - b2.bananas1;
        bananas.bananasK = b1.bananasK - b2.bananasK;
        bananas.bananasM = b1.bananasM - b2.bananasM;
        bananas.bananasG = b1.bananasG - b2.bananasG;
        bananas.bananasT = b1.bananasT - b2.bananasT;
        bananas.bananasP = b1.bananasP - b2.bananasP;
        bananas.bananasE = b1.bananasE - b2.bananasE;
        bananas.bananasZ = b1.bananasZ - b2.bananasZ;
        bananas.bananasY = b1.bananasY - b2.bananasY;

        return bananas;
    }

    public static Bananas operator* (Bananas b, int i)
    {
        Bananas bananas = new Bananas();
        bananas.bananas1 = b.bananas1 * i;
        bananas.bananasK = b.bananasK * i;
        bananas.bananasM = b.bananasM * i;
        bananas.bananasG = b.bananasG * i;
        bananas.bananasT = b.bananasT * i;
        bananas.bananasP = b.bananasP * i;
        bananas.bananasE = b.bananasE * i;
        bananas.bananasZ = b.bananasZ * i;
        bananas.bananasY = b.bananasY * i;

        return bananas;
    }

    

    public  string ToSave()
    {
        return  bananas1 + "\n" + bananasK + "\n" + bananasM + "\n" + 
                bananasG + "\n" + bananasT + "\n" + bananasP + "\n" +
                bananasE + "\n" + bananasZ + "\n" + bananasY;
    }

    public void ChooseByPrefix(int bananas, BananasPrefixes prefix)
    {
        if (prefix == BananasPrefixes.UNITY)
        {
            bananas1 = bananas;
        }
        else if (prefix == BananasPrefixes.KILO)
        {
            bananasK = bananas;
        }
        else if (prefix == BananasPrefixes.MEGA)
        {
            bananasM = bananas;
        }
        else if (prefix == BananasPrefixes.GIGA)
        {
            bananasG = bananas;
        }
        else if (prefix == BananasPrefixes.TERTA)
        {
            bananasT = bananas;
        }
        else if (prefix == BananasPrefixes.PETA)
        {
            bananasP = bananas;
        }
        else if (prefix == BananasPrefixes.EKSA)
        {
            bananasE = bananas;
        }
        else if (prefix == BananasPrefixes.ZETTA)
        {
            bananasE = bananas;
        }
        else if (prefix == BananasPrefixes.JOTTA)
        {
            bananasY = bananas;
        }
    }

    public Bananas(int bananas, BananasPrefixes prefix)
    {
        ChooseByPrefix(bananas, prefix);
    }

    public Bananas(int bananas1, BananasPrefixes prefix1, int bananas2, BananasPrefixes prefix2)
    {
        ChooseByPrefix(bananas1, prefix1);
        ChooseByPrefix(bananas2, prefix2);
    }

    public void CalculateBananas()
    {
        while (bananas1 >= 1000)
        {
            bananas1 -= 1000;
            bananasK++;
        }
        while (bananasK >= 1000)
        {
            bananasK -= 1000;
            bananasM++;
        }
        while (bananasM >= 1000)
        {
            bananasM -= 1000;
            bananasG++;
        }
        while (bananasG >= 1000)
        {
            bananasG -= 1000;
            bananasT++;
        }
        while (bananasT >= 1000)
        {
            bananasT -= 1000;
            bananasP++;
        }
        while (bananasP >= 1000)
        {
            bananasP -= 1000;
            bananasE++;
        }
        while (bananasE >= 1000)
        {
            bananasE -= 1000;
            bananasZ++;
        }
        while (bananasZ >= 1000)
        {
            bananasZ -= 1000;
            bananasY++;
        }
    }

    public override string ToString()
    {
        CalculateBananas();

        if (bananasY > 0)
        {
            return bananasY + "," + bananasZ / 100 + "Y";
        }
        else if (bananasZ > 0)
        {
            return bananasZ + "," + bananasE / 100 + "Z";
        }
        else if (bananasE > 0)
        {
            return bananasE + "," + bananasP / 100 + "E";
        }
        else if (bananasP > 0)
        {
            return bananasP + "," + bananasT / 100 + "P";
        }
        else if (bananasT > 0)
        {
            return bananasT + "," + bananasG / 100 + "T";
        }
        else if (bananasG > 0)
        {
            return bananasG + "," + bananasM / 100 + "G";
        }
        else if (bananasM > 0)
        {
            return bananasM + "," + bananasK / 100 + "M";
        }
        else if (bananasK > 0)
        {
            return bananasK + "," + bananas1 / 100 + "K";
        }
        else return bananas1.ToString();
    }
}
