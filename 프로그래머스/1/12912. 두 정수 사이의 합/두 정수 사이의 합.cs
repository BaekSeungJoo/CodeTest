public class Solution {
    public long solution(int a, int b) {
        long answer = 0;
        long bigNumber;
        long smallNumber;

        if (a == b) { return a; }

        else if (a > b)
        {
            bigNumber = a;
            smallNumber = b;
        }

        else
        {
            bigNumber = b;
            smallNumber = a;
        }

        long sum = a + b;

        for(long i = smallNumber + 1; i < bigNumber; i++)
        {
            sum += i;
        }

        answer = sum;

        return answer;
    }
}