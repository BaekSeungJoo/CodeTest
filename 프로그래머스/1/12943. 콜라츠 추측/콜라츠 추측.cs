public class Solution {
    public int solution(int num) {
        long startNumber = num;
        int answer = 0;
        int count = 0;

        while(startNumber != 1 && count <= 500)
        {
            if (startNumber % 2 == 0)
            {
                startNumber /= 2;
            }

            else
            {
                startNumber *= 3;
                startNumber++;
            }

            count++;
        }

        if(count >= 500) 
        {
            answer = -1;
        }
        else
        {
            answer = count;
        }

        return answer;
    }
}