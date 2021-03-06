﻿#region License
/* SDL2# - C# Wrapper for SDL2
 *
 * Copyright (c) 2013-2016 Ethan Lee.
 *
 * This software is provided 'as-is', without any express or implied warranty.
 * In no event will the authors be held liable for any damages arising from
 * the use of this software.
 *
 * Permission is granted to anyone to use this software for any purpose,
 * including commercial applications, and to alter it and redistribute it
 * freely, subject to the following restrictions:
 *
 * 1. The origin of this software must not be misrepresented; you must not
 * claim that you wrote the original software. If you use this software in a
 * product, an acknowledgment in the product documentation would be
 * appreciated but is not required.
 *
 * 2. Altered source versions must be plainly marked as such, and must not be
 * misrepresented as being the original software.
 *
 * 3. This notice may not be removed or altered from any source distribution.
 *
 * Ethan "flibitijibibo" Lee <flibitijibibo@flibitijibibo.com>
 *
 */
#endregion

using System;

namespace TS.SDL2
{
    public static partial class SDL
    {
        #region SDL_keycode.h

        public const int SDLK_SCANCODE_MASK = (1 << 30);
        public static SDL_Keycode SDL_SCANCODE_TO_KEYCODE(SDL_Scancode X)
        {
            return (SDL_Keycode)((int)X | SDLK_SCANCODE_MASK);
        }

        /* So, in the C headers, SDL_Keycode is a typedef of Sint32
         * and all of the names are in an anonymous enum. Yeah...
         * that's not going to cut it for C#. We'll just put them in an
         * enum for now? */
        public enum SDL_Keycode
        {
            SDLK_UNKNOWN = 0,

            SDLK_RETURN = '\r',
            SDLK_ESCAPE = 27, // '\033'
            SDLK_BACKSPACE = '\b',
            SDLK_TAB = '\t',
            SDLK_SPACE = ' ',
            SDLK_EXCLAIM = '!',
            SDLK_QUOTEDBL = '"',
            SDLK_HASH = '#',
            SDLK_PERCENT = '%',
            SDLK_DOLLAR = '$',
            SDLK_AMPERSAND = '&',
            SDLK_QUOTE = '\'',
            SDLK_LEFTPAREN = '(',
            SDLK_RIGHTPAREN = ')',
            SDLK_ASTERISK = '*',
            SDLK_PLUS = '+',
            SDLK_COMMA = ',',
            SDLK_MINUS = '-',
            SDLK_PERIOD = '.',
            SDLK_SLASH = '/',
            SDLK_0 = '0',
            SDLK_1 = '1',
            SDLK_2 = '2',
            SDLK_3 = '3',
            SDLK_4 = '4',
            SDLK_5 = '5',
            SDLK_6 = '6',
            SDLK_7 = '7',
            SDLK_8 = '8',
            SDLK_9 = '9',
            SDLK_COLON = ':',
            SDLK_SEMICOLON = ';',
            SDLK_LESS = '<',
            SDLK_EQUALS = '=',
            SDLK_GREATER = '>',
            SDLK_QUESTION = '?',
            SDLK_AT = '@',
            /*
            Skip uppercase letters
            */
            SDLK_LEFTBRACKET = '[',
            SDLK_BACKSLASH = '\\',
            SDLK_RIGHTBRACKET = ']',
            SDLK_CARET = '^',
            SDLK_UNDERSCORE = '_',
            SDLK_BACKQUOTE = '`',
            SDLK_a = 'a',
            SDLK_b = 'b',
            SDLK_c = 'c',
            SDLK_d = 'd',
            SDLK_e = 'e',
            SDLK_f = 'f',
            SDLK_g = 'g',
            SDLK_h = 'h',
            SDLK_i = 'i',
            SDLK_j = 'j',
            SDLK_k = 'k',
            SDLK_l = 'l',
            SDLK_m = 'm',
            SDLK_n = 'n',
            SDLK_o = 'o',
            SDLK_p = 'p',
            SDLK_q = 'q',
            SDLK_r = 'r',
            SDLK_s = 's',
            SDLK_t = 't',
            SDLK_u = 'u',
            SDLK_v = 'v',
            SDLK_w = 'w',
            SDLK_x = 'x',
            SDLK_y = 'y',
            SDLK_z = 'z',

            SDLK_CAPSLOCK = (int)SDL_Scancode.SDL_SCANCODE_CAPSLOCK | SDLK_SCANCODE_MASK,

            SDLK_F1 = (int)SDL_Scancode.SDL_SCANCODE_F1 | SDLK_SCANCODE_MASK,
            SDLK_F2 = (int)SDL_Scancode.SDL_SCANCODE_F2 | SDLK_SCANCODE_MASK,
            SDLK_F3 = (int)SDL_Scancode.SDL_SCANCODE_F3 | SDLK_SCANCODE_MASK,
            SDLK_F4 = (int)SDL_Scancode.SDL_SCANCODE_F4 | SDLK_SCANCODE_MASK,
            SDLK_F5 = (int)SDL_Scancode.SDL_SCANCODE_F5 | SDLK_SCANCODE_MASK,
            SDLK_F6 = (int)SDL_Scancode.SDL_SCANCODE_F6 | SDLK_SCANCODE_MASK,
            SDLK_F7 = (int)SDL_Scancode.SDL_SCANCODE_F7 | SDLK_SCANCODE_MASK,
            SDLK_F8 = (int)SDL_Scancode.SDL_SCANCODE_F8 | SDLK_SCANCODE_MASK,
            SDLK_F9 = (int)SDL_Scancode.SDL_SCANCODE_F9 | SDLK_SCANCODE_MASK,
            SDLK_F10 = (int)SDL_Scancode.SDL_SCANCODE_F10 | SDLK_SCANCODE_MASK,
            SDLK_F11 = (int)SDL_Scancode.SDL_SCANCODE_F11 | SDLK_SCANCODE_MASK,
            SDLK_F12 = (int)SDL_Scancode.SDL_SCANCODE_F12 | SDLK_SCANCODE_MASK,

            SDLK_PRINTSCREEN = (int)SDL_Scancode.SDL_SCANCODE_PRINTSCREEN | SDLK_SCANCODE_MASK,
            SDLK_SCROLLLOCK = (int)SDL_Scancode.SDL_SCANCODE_SCROLLLOCK | SDLK_SCANCODE_MASK,
            SDLK_PAUSE = (int)SDL_Scancode.SDL_SCANCODE_PAUSE | SDLK_SCANCODE_MASK,
            SDLK_INSERT = (int)SDL_Scancode.SDL_SCANCODE_INSERT | SDLK_SCANCODE_MASK,
            SDLK_HOME = (int)SDL_Scancode.SDL_SCANCODE_HOME | SDLK_SCANCODE_MASK,
            SDLK_PAGEUP = (int)SDL_Scancode.SDL_SCANCODE_PAGEUP | SDLK_SCANCODE_MASK,
            SDLK_DELETE = 127,
            SDLK_END = (int)SDL_Scancode.SDL_SCANCODE_END | SDLK_SCANCODE_MASK,
            SDLK_PAGEDOWN = (int)SDL_Scancode.SDL_SCANCODE_PAGEDOWN | SDLK_SCANCODE_MASK,
            SDLK_RIGHT = (int)SDL_Scancode.SDL_SCANCODE_RIGHT | SDLK_SCANCODE_MASK,
            SDLK_LEFT = (int)SDL_Scancode.SDL_SCANCODE_LEFT | SDLK_SCANCODE_MASK,
            SDLK_DOWN = (int)SDL_Scancode.SDL_SCANCODE_DOWN | SDLK_SCANCODE_MASK,
            SDLK_UP = (int)SDL_Scancode.SDL_SCANCODE_UP | SDLK_SCANCODE_MASK,

            SDLK_NUMLOCKCLEAR = (int)SDL_Scancode.SDL_SCANCODE_NUMLOCKCLEAR | SDLK_SCANCODE_MASK,
            SDLK_KP_DIVIDE = (int)SDL_Scancode.SDL_SCANCODE_KP_DIVIDE | SDLK_SCANCODE_MASK,
            SDLK_KP_MULTIPLY = (int)SDL_Scancode.SDL_SCANCODE_KP_MULTIPLY | SDLK_SCANCODE_MASK,
            SDLK_KP_MINUS = (int)SDL_Scancode.SDL_SCANCODE_KP_MINUS | SDLK_SCANCODE_MASK,
            SDLK_KP_PLUS = (int)SDL_Scancode.SDL_SCANCODE_KP_PLUS | SDLK_SCANCODE_MASK,
            SDLK_KP_ENTER = (int)SDL_Scancode.SDL_SCANCODE_KP_ENTER | SDLK_SCANCODE_MASK,
            SDLK_KP_1 = (int)SDL_Scancode.SDL_SCANCODE_KP_1 | SDLK_SCANCODE_MASK,
            SDLK_KP_2 = (int)SDL_Scancode.SDL_SCANCODE_KP_2 | SDLK_SCANCODE_MASK,
            SDLK_KP_3 = (int)SDL_Scancode.SDL_SCANCODE_KP_3 | SDLK_SCANCODE_MASK,
            SDLK_KP_4 = (int)SDL_Scancode.SDL_SCANCODE_KP_4 | SDLK_SCANCODE_MASK,
            SDLK_KP_5 = (int)SDL_Scancode.SDL_SCANCODE_KP_5 | SDLK_SCANCODE_MASK,
            SDLK_KP_6 = (int)SDL_Scancode.SDL_SCANCODE_KP_6 | SDLK_SCANCODE_MASK,
            SDLK_KP_7 = (int)SDL_Scancode.SDL_SCANCODE_KP_7 | SDLK_SCANCODE_MASK,
            SDLK_KP_8 = (int)SDL_Scancode.SDL_SCANCODE_KP_8 | SDLK_SCANCODE_MASK,
            SDLK_KP_9 = (int)SDL_Scancode.SDL_SCANCODE_KP_9 | SDLK_SCANCODE_MASK,
            SDLK_KP_0 = (int)SDL_Scancode.SDL_SCANCODE_KP_0 | SDLK_SCANCODE_MASK,
            SDLK_KP_PERIOD = (int)SDL_Scancode.SDL_SCANCODE_KP_PERIOD | SDLK_SCANCODE_MASK,

            SDLK_APPLICATION = (int)SDL_Scancode.SDL_SCANCODE_APPLICATION | SDLK_SCANCODE_MASK,
            SDLK_POWER = (int)SDL_Scancode.SDL_SCANCODE_POWER | SDLK_SCANCODE_MASK,
            SDLK_KP_EQUALS = (int)SDL_Scancode.SDL_SCANCODE_KP_EQUALS | SDLK_SCANCODE_MASK,
            SDLK_F13 = (int)SDL_Scancode.SDL_SCANCODE_F13 | SDLK_SCANCODE_MASK,
            SDLK_F14 = (int)SDL_Scancode.SDL_SCANCODE_F14 | SDLK_SCANCODE_MASK,
            SDLK_F15 = (int)SDL_Scancode.SDL_SCANCODE_F15 | SDLK_SCANCODE_MASK,
            SDLK_F16 = (int)SDL_Scancode.SDL_SCANCODE_F16 | SDLK_SCANCODE_MASK,
            SDLK_F17 = (int)SDL_Scancode.SDL_SCANCODE_F17 | SDLK_SCANCODE_MASK,
            SDLK_F18 = (int)SDL_Scancode.SDL_SCANCODE_F18 | SDLK_SCANCODE_MASK,
            SDLK_F19 = (int)SDL_Scancode.SDL_SCANCODE_F19 | SDLK_SCANCODE_MASK,
            SDLK_F20 = (int)SDL_Scancode.SDL_SCANCODE_F20 | SDLK_SCANCODE_MASK,
            SDLK_F21 = (int)SDL_Scancode.SDL_SCANCODE_F21 | SDLK_SCANCODE_MASK,
            SDLK_F22 = (int)SDL_Scancode.SDL_SCANCODE_F22 | SDLK_SCANCODE_MASK,
            SDLK_F23 = (int)SDL_Scancode.SDL_SCANCODE_F23 | SDLK_SCANCODE_MASK,
            SDLK_F24 = (int)SDL_Scancode.SDL_SCANCODE_F24 | SDLK_SCANCODE_MASK,
            SDLK_EXECUTE = (int)SDL_Scancode.SDL_SCANCODE_EXECUTE | SDLK_SCANCODE_MASK,
            SDLK_HELP = (int)SDL_Scancode.SDL_SCANCODE_HELP | SDLK_SCANCODE_MASK,
            SDLK_MENU = (int)SDL_Scancode.SDL_SCANCODE_MENU | SDLK_SCANCODE_MASK,
            SDLK_SELECT = (int)SDL_Scancode.SDL_SCANCODE_SELECT | SDLK_SCANCODE_MASK,
            SDLK_STOP = (int)SDL_Scancode.SDL_SCANCODE_STOP | SDLK_SCANCODE_MASK,
            SDLK_AGAIN = (int)SDL_Scancode.SDL_SCANCODE_AGAIN | SDLK_SCANCODE_MASK,
            SDLK_UNDO = (int)SDL_Scancode.SDL_SCANCODE_UNDO | SDLK_SCANCODE_MASK,
            SDLK_CUT = (int)SDL_Scancode.SDL_SCANCODE_CUT | SDLK_SCANCODE_MASK,
            SDLK_COPY = (int)SDL_Scancode.SDL_SCANCODE_COPY | SDLK_SCANCODE_MASK,
            SDLK_PASTE = (int)SDL_Scancode.SDL_SCANCODE_PASTE | SDLK_SCANCODE_MASK,
            SDLK_FIND = (int)SDL_Scancode.SDL_SCANCODE_FIND | SDLK_SCANCODE_MASK,
            SDLK_MUTE = (int)SDL_Scancode.SDL_SCANCODE_MUTE | SDLK_SCANCODE_MASK,
            SDLK_VOLUMEUP = (int)SDL_Scancode.SDL_SCANCODE_VOLUMEUP | SDLK_SCANCODE_MASK,
            SDLK_VOLUMEDOWN = (int)SDL_Scancode.SDL_SCANCODE_VOLUMEDOWN | SDLK_SCANCODE_MASK,
            SDLK_KP_COMMA = (int)SDL_Scancode.SDL_SCANCODE_KP_COMMA | SDLK_SCANCODE_MASK,
            SDLK_KP_EQUALSAS400 =
            (int)SDL_Scancode.SDL_SCANCODE_KP_EQUALSAS400 | SDLK_SCANCODE_MASK,

            SDLK_ALTERASE = (int)SDL_Scancode.SDL_SCANCODE_ALTERASE | SDLK_SCANCODE_MASK,
            SDLK_SYSREQ = (int)SDL_Scancode.SDL_SCANCODE_SYSREQ | SDLK_SCANCODE_MASK,
            SDLK_CANCEL = (int)SDL_Scancode.SDL_SCANCODE_CANCEL | SDLK_SCANCODE_MASK,
            SDLK_CLEAR = (int)SDL_Scancode.SDL_SCANCODE_CLEAR | SDLK_SCANCODE_MASK,
            SDLK_PRIOR = (int)SDL_Scancode.SDL_SCANCODE_PRIOR | SDLK_SCANCODE_MASK,
            SDLK_RETURN2 = (int)SDL_Scancode.SDL_SCANCODE_RETURN2 | SDLK_SCANCODE_MASK,
            SDLK_SEPARATOR = (int)SDL_Scancode.SDL_SCANCODE_SEPARATOR | SDLK_SCANCODE_MASK,
            SDLK_OUT = (int)SDL_Scancode.SDL_SCANCODE_OUT | SDLK_SCANCODE_MASK,
            SDLK_OPER = (int)SDL_Scancode.SDL_SCANCODE_OPER | SDLK_SCANCODE_MASK,
            SDLK_CLEARAGAIN = (int)SDL_Scancode.SDL_SCANCODE_CLEARAGAIN | SDLK_SCANCODE_MASK,
            SDLK_CRSEL = (int)SDL_Scancode.SDL_SCANCODE_CRSEL | SDLK_SCANCODE_MASK,
            SDLK_EXSEL = (int)SDL_Scancode.SDL_SCANCODE_EXSEL | SDLK_SCANCODE_MASK,

            SDLK_KP_00 = (int)SDL_Scancode.SDL_SCANCODE_KP_00 | SDLK_SCANCODE_MASK,
            SDLK_KP_000 = (int)SDL_Scancode.SDL_SCANCODE_KP_000 | SDLK_SCANCODE_MASK,
            SDLK_THOUSANDSSEPARATOR =
            (int)SDL_Scancode.SDL_SCANCODE_THOUSANDSSEPARATOR | SDLK_SCANCODE_MASK,
            SDLK_DECIMALSEPARATOR =
            (int)SDL_Scancode.SDL_SCANCODE_DECIMALSEPARATOR | SDLK_SCANCODE_MASK,
            SDLK_CURRENCYUNIT = (int)SDL_Scancode.SDL_SCANCODE_CURRENCYUNIT | SDLK_SCANCODE_MASK,
            SDLK_CURRENCYSUBUNIT =
            (int)SDL_Scancode.SDL_SCANCODE_CURRENCYSUBUNIT | SDLK_SCANCODE_MASK,
            SDLK_KP_LEFTPAREN = (int)SDL_Scancode.SDL_SCANCODE_KP_LEFTPAREN | SDLK_SCANCODE_MASK,
            SDLK_KP_RIGHTPAREN = (int)SDL_Scancode.SDL_SCANCODE_KP_RIGHTPAREN | SDLK_SCANCODE_MASK,
            SDLK_KP_LEFTBRACE = (int)SDL_Scancode.SDL_SCANCODE_KP_LEFTBRACE | SDLK_SCANCODE_MASK,
            SDLK_KP_RIGHTBRACE = (int)SDL_Scancode.SDL_SCANCODE_KP_RIGHTBRACE | SDLK_SCANCODE_MASK,
            SDLK_KP_TAB = (int)SDL_Scancode.SDL_SCANCODE_KP_TAB | SDLK_SCANCODE_MASK,
            SDLK_KP_BACKSPACE = (int)SDL_Scancode.SDL_SCANCODE_KP_BACKSPACE | SDLK_SCANCODE_MASK,
            SDLK_KP_A = (int)SDL_Scancode.SDL_SCANCODE_KP_A | SDLK_SCANCODE_MASK,
            SDLK_KP_B = (int)SDL_Scancode.SDL_SCANCODE_KP_B | SDLK_SCANCODE_MASK,
            SDLK_KP_C = (int)SDL_Scancode.SDL_SCANCODE_KP_C | SDLK_SCANCODE_MASK,
            SDLK_KP_D = (int)SDL_Scancode.SDL_SCANCODE_KP_D | SDLK_SCANCODE_MASK,
            SDLK_KP_E = (int)SDL_Scancode.SDL_SCANCODE_KP_E | SDLK_SCANCODE_MASK,
            SDLK_KP_F = (int)SDL_Scancode.SDL_SCANCODE_KP_F | SDLK_SCANCODE_MASK,
            SDLK_KP_XOR = (int)SDL_Scancode.SDL_SCANCODE_KP_XOR | SDLK_SCANCODE_MASK,
            SDLK_KP_POWER = (int)SDL_Scancode.SDL_SCANCODE_KP_POWER | SDLK_SCANCODE_MASK,
            SDLK_KP_PERCENT = (int)SDL_Scancode.SDL_SCANCODE_KP_PERCENT | SDLK_SCANCODE_MASK,
            SDLK_KP_LESS = (int)SDL_Scancode.SDL_SCANCODE_KP_LESS | SDLK_SCANCODE_MASK,
            SDLK_KP_GREATER = (int)SDL_Scancode.SDL_SCANCODE_KP_GREATER | SDLK_SCANCODE_MASK,
            SDLK_KP_AMPERSAND = (int)SDL_Scancode.SDL_SCANCODE_KP_AMPERSAND | SDLK_SCANCODE_MASK,
            SDLK_KP_DBLAMPERSAND =
            (int)SDL_Scancode.SDL_SCANCODE_KP_DBLAMPERSAND | SDLK_SCANCODE_MASK,
            SDLK_KP_VERTICALBAR =
            (int)SDL_Scancode.SDL_SCANCODE_KP_VERTICALBAR | SDLK_SCANCODE_MASK,
            SDLK_KP_DBLVERTICALBAR =
            (int)SDL_Scancode.SDL_SCANCODE_KP_DBLVERTICALBAR | SDLK_SCANCODE_MASK,
            SDLK_KP_COLON = (int)SDL_Scancode.SDL_SCANCODE_KP_COLON | SDLK_SCANCODE_MASK,
            SDLK_KP_HASH = (int)SDL_Scancode.SDL_SCANCODE_KP_HASH | SDLK_SCANCODE_MASK,
            SDLK_KP_SPACE = (int)SDL_Scancode.SDL_SCANCODE_KP_SPACE | SDLK_SCANCODE_MASK,
            SDLK_KP_AT = (int)SDL_Scancode.SDL_SCANCODE_KP_AT | SDLK_SCANCODE_MASK,
            SDLK_KP_EXCLAM = (int)SDL_Scancode.SDL_SCANCODE_KP_EXCLAM | SDLK_SCANCODE_MASK,
            SDLK_KP_MEMSTORE = (int)SDL_Scancode.SDL_SCANCODE_KP_MEMSTORE | SDLK_SCANCODE_MASK,
            SDLK_KP_MEMRECALL = (int)SDL_Scancode.SDL_SCANCODE_KP_MEMRECALL | SDLK_SCANCODE_MASK,
            SDLK_KP_MEMCLEAR = (int)SDL_Scancode.SDL_SCANCODE_KP_MEMCLEAR | SDLK_SCANCODE_MASK,
            SDLK_KP_MEMADD = (int)SDL_Scancode.SDL_SCANCODE_KP_MEMADD | SDLK_SCANCODE_MASK,
            SDLK_KP_MEMSUBTRACT =
            (int)SDL_Scancode.SDL_SCANCODE_KP_MEMSUBTRACT | SDLK_SCANCODE_MASK,
            SDLK_KP_MEMMULTIPLY =
            (int)SDL_Scancode.SDL_SCANCODE_KP_MEMMULTIPLY | SDLK_SCANCODE_MASK,
            SDLK_KP_MEMDIVIDE = (int)SDL_Scancode.SDL_SCANCODE_KP_MEMDIVIDE | SDLK_SCANCODE_MASK,
            SDLK_KP_PLUSMINUS = (int)SDL_Scancode.SDL_SCANCODE_KP_PLUSMINUS | SDLK_SCANCODE_MASK,
            SDLK_KP_CLEAR = (int)SDL_Scancode.SDL_SCANCODE_KP_CLEAR | SDLK_SCANCODE_MASK,
            SDLK_KP_CLEARENTRY = (int)SDL_Scancode.SDL_SCANCODE_KP_CLEARENTRY | SDLK_SCANCODE_MASK,
            SDLK_KP_BINARY = (int)SDL_Scancode.SDL_SCANCODE_KP_BINARY | SDLK_SCANCODE_MASK,
            SDLK_KP_OCTAL = (int)SDL_Scancode.SDL_SCANCODE_KP_OCTAL | SDLK_SCANCODE_MASK,
            SDLK_KP_DECIMAL = (int)SDL_Scancode.SDL_SCANCODE_KP_DECIMAL | SDLK_SCANCODE_MASK,
            SDLK_KP_HEXADECIMAL =
            (int)SDL_Scancode.SDL_SCANCODE_KP_HEXADECIMAL | SDLK_SCANCODE_MASK,

            SDLK_LCTRL = (int)SDL_Scancode.SDL_SCANCODE_LCTRL | SDLK_SCANCODE_MASK,
            SDLK_LSHIFT = (int)SDL_Scancode.SDL_SCANCODE_LSHIFT | SDLK_SCANCODE_MASK,
            SDLK_LALT = (int)SDL_Scancode.SDL_SCANCODE_LALT | SDLK_SCANCODE_MASK,
            SDLK_LGUI = (int)SDL_Scancode.SDL_SCANCODE_LGUI | SDLK_SCANCODE_MASK,
            SDLK_RCTRL = (int)SDL_Scancode.SDL_SCANCODE_RCTRL | SDLK_SCANCODE_MASK,
            SDLK_RSHIFT = (int)SDL_Scancode.SDL_SCANCODE_RSHIFT | SDLK_SCANCODE_MASK,
            SDLK_RALT = (int)SDL_Scancode.SDL_SCANCODE_RALT | SDLK_SCANCODE_MASK,
            SDLK_RGUI = (int)SDL_Scancode.SDL_SCANCODE_RGUI | SDLK_SCANCODE_MASK,

            SDLK_MODE = (int)SDL_Scancode.SDL_SCANCODE_MODE | SDLK_SCANCODE_MASK,

            SDLK_AUDIONEXT = (int)SDL_Scancode.SDL_SCANCODE_AUDIONEXT | SDLK_SCANCODE_MASK,
            SDLK_AUDIOPREV = (int)SDL_Scancode.SDL_SCANCODE_AUDIOPREV | SDLK_SCANCODE_MASK,
            SDLK_AUDIOSTOP = (int)SDL_Scancode.SDL_SCANCODE_AUDIOSTOP | SDLK_SCANCODE_MASK,
            SDLK_AUDIOPLAY = (int)SDL_Scancode.SDL_SCANCODE_AUDIOPLAY | SDLK_SCANCODE_MASK,
            SDLK_AUDIOMUTE = (int)SDL_Scancode.SDL_SCANCODE_AUDIOMUTE | SDLK_SCANCODE_MASK,
            SDLK_MEDIASELECT = (int)SDL_Scancode.SDL_SCANCODE_MEDIASELECT | SDLK_SCANCODE_MASK,
            SDLK_WWW = (int)SDL_Scancode.SDL_SCANCODE_WWW | SDLK_SCANCODE_MASK,
            SDLK_MAIL = (int)SDL_Scancode.SDL_SCANCODE_MAIL | SDLK_SCANCODE_MASK,
            SDLK_CALCULATOR = (int)SDL_Scancode.SDL_SCANCODE_CALCULATOR | SDLK_SCANCODE_MASK,
            SDLK_COMPUTER = (int)SDL_Scancode.SDL_SCANCODE_COMPUTER | SDLK_SCANCODE_MASK,
            SDLK_AC_SEARCH = (int)SDL_Scancode.SDL_SCANCODE_AC_SEARCH | SDLK_SCANCODE_MASK,
            SDLK_AC_HOME = (int)SDL_Scancode.SDL_SCANCODE_AC_HOME | SDLK_SCANCODE_MASK,
            SDLK_AC_BACK = (int)SDL_Scancode.SDL_SCANCODE_AC_BACK | SDLK_SCANCODE_MASK,
            SDLK_AC_FORWARD = (int)SDL_Scancode.SDL_SCANCODE_AC_FORWARD | SDLK_SCANCODE_MASK,
            SDLK_AC_STOP = (int)SDL_Scancode.SDL_SCANCODE_AC_STOP | SDLK_SCANCODE_MASK,
            SDLK_AC_REFRESH = (int)SDL_Scancode.SDL_SCANCODE_AC_REFRESH | SDLK_SCANCODE_MASK,
            SDLK_AC_BOOKMARKS = (int)SDL_Scancode.SDL_SCANCODE_AC_BOOKMARKS | SDLK_SCANCODE_MASK,

            SDLK_BRIGHTNESSDOWN =
            (int)SDL_Scancode.SDL_SCANCODE_BRIGHTNESSDOWN | SDLK_SCANCODE_MASK,
            SDLK_BRIGHTNESSUP = (int)SDL_Scancode.SDL_SCANCODE_BRIGHTNESSUP | SDLK_SCANCODE_MASK,
            SDLK_DISPLAYSWITCH = (int)SDL_Scancode.SDL_SCANCODE_DISPLAYSWITCH | SDLK_SCANCODE_MASK,
            SDLK_KBDILLUMTOGGLE =
            (int)SDL_Scancode.SDL_SCANCODE_KBDILLUMTOGGLE | SDLK_SCANCODE_MASK,
            SDLK_KBDILLUMDOWN = (int)SDL_Scancode.SDL_SCANCODE_KBDILLUMDOWN | SDLK_SCANCODE_MASK,
            SDLK_KBDILLUMUP = (int)SDL_Scancode.SDL_SCANCODE_KBDILLUMUP | SDLK_SCANCODE_MASK,
            SDLK_EJECT = (int)SDL_Scancode.SDL_SCANCODE_EJECT | SDLK_SCANCODE_MASK,
            SDLK_SLEEP = (int)SDL_Scancode.SDL_SCANCODE_SLEEP | SDLK_SCANCODE_MASK
        }

        /* Key modifiers (bitfield) */
        [Flags]
        public enum SDL_Keymod : ushort
        {
            KMOD_NONE = 0x0000,
            KMOD_LSHIFT = 0x0001,
            KMOD_RSHIFT = 0x0002,
            KMOD_LCTRL = 0x0040,
            KMOD_RCTRL = 0x0080,
            KMOD_LALT = 0x0100,
            KMOD_RALT = 0x0200,
            KMOD_LGUI = 0x0400,
            KMOD_RGUI = 0x0800,
            KMOD_NUM = 0x1000,
            KMOD_CAPS = 0x2000,
            KMOD_MODE = 0x4000,
            KMOD_RESERVED = 0x8000,

            /* These are defines in the SDL headers */
            KMOD_CTRL = (KMOD_LCTRL | KMOD_RCTRL),
            KMOD_SHIFT = (KMOD_LSHIFT | KMOD_RSHIFT),
            KMOD_ALT = (KMOD_LALT | KMOD_RALT),
            KMOD_GUI = (KMOD_LGUI | KMOD_RGUI)
        }

        #endregion
    }
}
