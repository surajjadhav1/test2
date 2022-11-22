namespace MathOparation;

public delegate bool Check (int value);


class Computation
{

    public int Low { get; set; }

    public int High { get; set; }

    public Computation(int Low , int High)
    {
        this.Low = Low;
        this.High = High;
    }

    public int GetSumOf(int low, int high, Check chk)
    {
        int sum=0;
        //int n=low;
        for(int n = low;n <= high;n++)
        {
            if(chk.Invoke(n))
            sum += n;
        }
        return sum;
    }

    public bool IsEven(int value)
    {
        if(value%2 == 0)
            return true;
        return false;
    }

    public bool IsOdd(int value)
    {
        if(value%2 == 1)
            return true;
        return false;
    }

    public bool IsPrime(int value)
    {
        if(value == 1)
            return false;

        if(value == 2 || value==3)
            return true;
        
        if(IsEven(value))
            return false;
        
        if(IsOdd(value))
        {
            for(int i = 3; i * i<= value ;i += 2)
			{
				if((value) % i == 0)
					return false;
			}
        }
			return true;
        
    }
}