#include <fstream>
#include <vector>
#include <set>
#include<iostream>
#include<cstdio>

using namespace std;

const int MAX_VALUES = 10;
const int MAX_OPS = 10;
const int NONVAL = MAX_VALUES + 1;
string ops[MAX_OPS] = { "+", "*", "Equiv", "xor", "nor", "|", "=>", "<=", "!=>", "!<=" };
string abc[MAX_VALUES] = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
bool values[MAX_VALUES];
int v;
bool found = false;
bool f[1 << MAX_VALUES];

bool func0(bool a, bool b) { return a || b; }
bool func1(bool a, bool b) { return a && b; }
bool func2(bool a, bool b) { return a == b; }
bool func3(bool a, bool b) { return a != b; }
bool func4(bool a, bool b) { return !a && !b; }
bool func5(bool a, bool b) { return !a || !b; }
bool func6(bool a, bool b) { return !a || b; }
bool func7(bool a, bool b) { return a || !b; }
bool func8(bool a, bool b) { return a && !b; }
bool func9(bool a, bool b) { return !a && b; }

struct exp
{
    char val, op;
    bool (* op_func) (bool, bool);
	exp* left, *right;
	exp(char val) : val(val) { }
    exp(char op, exp* left, exp* right) : val(NONVAL), op(op), left(left), right(right)
    {
        switch (op)
        {
            case 0: op_func = &func0; break;
            case 1: op_func = &func1; break;
            case 2: op_func = &func2; break;
            case 3: op_func = &func3; break;
            case 4: op_func = &func4; break;
            case 5: op_func = &func5; break;
            case 6: op_func = &func6; break;
            case 7: op_func = &func7; break;
            case 8: op_func = &func8; break;
            case 9: op_func = &func9; break;
        }
    }
    bool calc()
    {
        if (val != NONVAL)
            return values[val];
        return op_func(left->calc(), right->calc());
    }
    string repr_inside()
    {
        if (val != NONVAL)
            return abc[val];
        return "(" + repr() + ")";
    }
    string repr()
    {
        if (val != NONVAL)
            return abc[val];
        string l = left->repr_inside();
        string r = right->repr_inside();
        string o = ops[op];
        if (op < 6 && l > r)
            swap(l, r);
        if (op > 5 && op % 2)
        {
            swap(l, r);
            o = ops[op - 1];
        }
        return l + " " + o + " " + r;
    }
};

//ifstream in("input.txt");
//ofstream out("output.txt");
set<string> ans;

bool equal(exp* e)
{
    for (int i = 0; i < (1 << v); ++i)
    {
        for (int j = 0; j < v; ++j)
            values[v - j - 1] = ((1 << j) & i) > 0;
        if (e->calc() != f[i])
            return false;
    }
    return true;
}

void check(exp* e)
{
    if (!equal(e))
        return;
    found = true;
    ans.insert(e->repr());
}

int main()
{
    cin >> v;
    for (int i = 0; i < (1 << v); ++i)
        cin >> f[i];
    vector<vector<exp*>> e;
    e.resize(1);
    for (int i = 0; i < v; ++i)
    {
        e[0].push_back(new exp(i));
        check(e[0][i]);
    }
    for (int rank = 1; !found; ++rank)
    {
        e.resize(rank + 1);
        for (int l = 0; l < rank; ++l)
        {
            int r = rank - l - 1;
            for (int i = 0; i < e[l].size(); ++i)
                for (int j = 0; j < e[r].size(); ++j)
                    for (int k = 0; k < MAX_OPS; ++k)
                    {
                        e[rank].push_back(new exp(k, e[l][i], e[r][j]));
                        check(e[rank].back());
                    }
        }
    }
    for (set<string>::iterator cur = ans.begin(); cur != ans.end(); ++cur)
        cout << *cur << endl;
    return 0;
}