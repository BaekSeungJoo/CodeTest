#include <string>
#include <vector>

using namespace std;

int solution(int a, int b) {
    int answer = 0;

    string str1 = to_string(a);
    string str2 = to_string(b);
    
    int Number1 = stoi(str1 + str2);
    int Number2 = stoi(str2 + str1);
    
    answer = max(Number1, Number2);
    
    return answer;
}