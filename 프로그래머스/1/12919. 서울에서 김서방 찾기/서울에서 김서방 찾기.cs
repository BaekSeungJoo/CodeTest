public class Solution {
    public string solution(string[] seoul) {
        string answer = "";
        int x = 0;

        for(int i = 0; i < seoul.Length; i++)
        {
            if(seoul[i] == "Kim")
            {
                x = i;
                break;
            }
        }

        answer = string.Format("김서방은 {0}에 있다", x);

        return answer;
    }
}