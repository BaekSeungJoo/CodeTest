public class Solution {
    public long solution(long n) {
        long answer = 0;
        double squareRoot = n;

        int ninusIndex = 1;

        squareRoot /= 2;

        while (true)
        {
            if (squareRoot - ninusIndex < 0)
            {
                break;
            }

            squareRoot -= ninusIndex;
            ninusIndex++;
        }

        squareRoot *= 2;

        double square = squareRoot * squareRoot;

        if(square == n)
        {
            answer = (long)squareRoot + 1;
            answer *= answer;
        }
        else
        {
            answer = -1;
        }

        return answer;
    }
}