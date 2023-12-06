using System;

public class Solution {
    public int solution(int[] absolutes, bool[] signs) {
        int answer = 123456789;
        int result = 0;

        for(int i = 0; i < absolutes.Length; i++)
        {
            if (signs[i].ToString().ToUpper().StartsWith('T'))
            {
                result = result + absolutes[i];
            }

            else
            {
                result = result - absolutes[i];
            }
        }

        answer = result;
        return answer;
    }
}