public class Solution {
    public long solution(long n) {
        long answer = 0;

        // 몇 자리수 인지 구하기.
        long temp_n = n;
        int numberIndex = 0;

        while (temp_n > 0)
        {
            temp_n /= 10;
            numberIndex++;
        }

        // 각 자리수를 배열안에 넣기.
        int[] resultArray = new int[numberIndex];
        int arrayIndex = 0;
        while (n > 0)
        {
            resultArray[arrayIndex] = (int)(n % 10);
            n /= 10;
            arrayIndex++;
        }

        // 큰것부터 작은 순으로 정렬한 새로운 정수 리턴. ( 버블 정렬 )
        for(int i = 0; i < numberIndex - 1; i++)
        {
            for(int j = 0; j < numberIndex - 1 - i; j++)
            {
                if (resultArray[j] < resultArray[j + 1])
                {
                    int temp = resultArray[j];
                    resultArray[j] = resultArray[j + 1];
                    resultArray[j + 1] = temp;
                }
            }
        }

        // 스트링으로 형변환 진행한뒤 long형으로 변환해서 리턴
        string _answer = "";

        foreach(int i in resultArray) 
        {
            _answer += i.ToString();
        }

        answer = long.Parse(_answer);

        return answer;
    }
}