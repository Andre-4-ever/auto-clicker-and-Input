#include <Windows.h>
#include <iostream>
#include <XInput.h>

class Input_test()
{
    test2();
    public void test()
    {
        SHORT key;
        UINT mappedkey;
        INPUT input = { 0 };
        key = VkKeyScan('w');
        mappedkey = MapVirtualKey(LOBYTE(key), 0);
        input.type = INPUT_KEYBOARD;
        input.ki.dwFlags = KEYEVENTF_SCANCODE;
        input.ki.wScan = mappedkey;
        SendInput(1, &input, sizeof(input));
        Sleep(10);
        input.ki.dwFlags = KEYEVENTF_SCANCODE | KEYEVENTF_KEYUP;
        SendInput(1, &input, sizeof(input));
    }
    public void test2()
    {
        XInput.setAutoSend(false);
        XInput.begin();
        XInput.setButton(BUTTON_A, !1);

        XInput.send();
        debug.write();
    }
}