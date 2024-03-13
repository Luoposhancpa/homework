#include<iostream>
using namespace std;
#include<string>
#include<stack>
int lengthOfLongestSubstring(string s) {
    int a[26];
    memset(a, -1, sizeof(a));
    int max = 1;
    int start = 0;
    int temp = 1;
    a[s[0] - 'a'] = 0;
    for (int i = 1;i < s.size();i++) {
        int g = s[i] - 'a';
        if (a[s[i] - 'a'] == -1) {
            a[s[i] - 'a'] = i;
            temp++;
        }
        else {
            i = a[s[i] - 'a'] + 1;
            start = i;
            memset(a, -1, sizeof(a));
            
            if (temp > max) {
                max = temp;
                temp = 1;
            }
               
        }
    }
    if (temp > max) {
        max = temp;
        temp = 1;
    }
    return max;
}
int reverse(int x) {
    stack<int>a;
    while (x != 0) {
        a.push(x % 10);
        x = x / 10;
    }
    while (!a.empty()) {
        x = a.top() * 10 + x;
        a.pop();
    }
    return x;
}
int main() {
  
    cout <<reverse(123) ;
	system("pause");
}