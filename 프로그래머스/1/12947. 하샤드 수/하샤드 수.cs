public class Solution {
    public bool solution(int x) {
        bool answer;

        int startNumber = x;
        int sum = 0;

        while(x > 0)
        {
            sum += x % 10;
            x /= 10;
        }

        if(startNumber % sum == 0)
        {
            answer = true;
            return answer;
        }
        else
        {
            answer = false;
            return answer;
        }
    }
}