namespace FileSplitter
{
    static class MIK
    {
        public static char mik2U(byte rc)
        {
            switch (rc)
            {

                case 0x20: return '\u0020';//  SPACE
                case 0x21: return '\u0021';//  EXCLAMATION MARK
                case 0x22: return '\u0022';//  QUOTATION MARK
                case 0x23: return '\u0023';//  NUMBER SIGN
                case 0x24: return '\u0024';//  DOLLAR SIGN
                case 0x25: return '\u0025';//  PERCENT SIGN
                case 0x26: return '\u0026';//  AMPERSAND
                case 0x27: return '\u0027';//  APOSTROPHE
                case 0x28: return '\u0028';//  LEFT PARENTHESIS
                case 0x29: return '\u0029';//  RIGHT PARENTHESIS
                case 0x2A: return '\u002A';// ASTERISK
                case 0x2B: return '\u002B';// PLUS SIGN
                case 0x2C: return '\u002C';// COMMA
                case 0x2D: return '\u002D';//  HYPHEN - MINUS
                case 0x2E: return '\u002E';//  FULL STOP
                case 0x2F: return '\u002F';//  SOLIDUS
                case 0x30: return '\u0030';//  DIGIT ZERO
                case 0x31: return '\u0031';//  DIGIT ONE
                case 0x32: return '\u0032';//  DIGIT TWO
                case 0x33: return '\u0033';//  DIGIT THREE
                case 0x34: return '\u0034';//  DIGIT FOUR
                case 0x35: return '\u0035';//  DIGIT FIVE
                case 0x36: return '\u0036';//  DIGIT SIX
                case 0x37: return '\u0037';//  DIGIT SEVEN
                case 0x38: return '\u0038';//  DIGIT EIGHT
                case 0x39: return '\u0039';//  DIGIT NINE
                case 0x3A: return '\u003A';// COLON
                case 0x3B: return '\u003B';// SEMICOLON
                case 0x3C: return '\u003C';// LESS-THAN SIGN
                case 0x3D: return '\u003D';//  EQUALS SIGN
                case 0x3E: return '\u003E';//  GREATER - THAN SIGN
                case 0x3F: return '\u003F';//  QUESTION MARK
                case 0x40: return '\u0040';//  COMMERCIAL AT
                case 0x41: return '\u0041';//  LATIN CAPITAL LETTER A
                case 0x42: return '\u0042';//  LATIN CAPITAL LETTER B
                case 0x43: return '\u0043';//  LATIN CAPITAL LETTER C
                case 0x44: return '\u0044';//  LATIN CAPITAL LETTER D
                case 0x45: return '\u0045';//  LATIN CAPITAL LETTER E
                case 0x46: return '\u0046';//  LATIN CAPITAL LETTER F
                case 0x47: return '\u0047';//  LATIN CAPITAL LETTER G
                case 0x48: return '\u0048';//  LATIN CAPITAL LETTER H
                case 0x49: return '\u0049';//  LATIN CAPITAL LETTER I
                case 0x4A: return '\u004A';// LATIN CAPITAL LETTER J
                case 0x4B: return '\u004B';// LATIN CAPITAL LETTER K
                case 0x4C: return '\u004C';// LATIN CAPITAL LETTER L
                case 0x4D: return '\u004D';//  LATIN CAPITAL LETTER M
                case 0x4E: return '\u004E';//  LATIN CAPITAL LETTER N
                case 0x4F: return '\u004F';//  LATIN CAPITAL LETTER O
                case 0x50: return '\u0050';//  LATIN CAPITAL LETTER P
                case 0x51: return '\u0051';//  LATIN CAPITAL LETTER Q
                case 0x52: return '\u0052';//  LATIN CAPITAL LETTER R
                case 0x53: return '\u0053';//  LATIN CAPITAL LETTER S
                case 0x54: return '\u0054';//  LATIN CAPITAL LETTER T
                case 0x55: return '\u0055';//  LATIN CAPITAL LETTER: U
                case 0x56: return '\u0056';//  LATIN CAPITAL LETTER V
                case 0x57: return '\u0057';//  LATIN CAPITAL LETTER W
                case 0x58: return '\u0058';//  LATIN CAPITAL LETTER X
                case 0x59: return '\u0059';//  LATIN CAPITAL LETTER Y
                case 0x5A: return '\u005A';// LATIN CAPITAL LETTER Z
                case 0x5B: return '\u005B';// LEFT SQUARE BRACKET
                case 0x5C: return '\u005C';// REVERSE SOLIDUS
                case 0x5D: return '\u005D';//  RIGHT SQUARE BRACKET
                case 0x5E: return '\u005E';//  CIRCUMFLEX ACCENT
                case 0x5F: return '\u005F';//  LOW LINE
                case 0x60: return '\u0060';//  GRAVE ACCENT
                case 0x61: return '\u0061';//  LATIN SMALL LETTER A
                case 0x62: return '\u0062';//  LATIN SMALL LETTER B
                case 0x63: return '\u0063';//  LATIN SMALL LETTER C
                case 0x64: return '\u0064';//  LATIN SMALL LETTER D
                case 0x65: return '\u0065';//  LATIN SMALL LETTER E
                case 0x66: return '\u0066';//  LATIN SMALL LETTER F
                case 0x67: return '\u0067';//  LATIN SMALL LETTER G
                case 0x68: return '\u0068';//  LATIN SMALL LETTER H
                case 0x69: return '\u0069';//  LATIN SMALL LETTER I
                case 0x6A: return '\u006A';// LATIN SMALL LETTER J
                case 0x6B: return '\u006B';// LATIN SMALL LETTER K
                case 0x6C: return '\u006C';// LATIN SMALL LETTER L
                case 0x6D: return '\u006D';//  LATIN SMALL LETTER M
                case 0x6E: return '\u006E';//  LATIN SMALL LETTER N
                case 0x6F: return '\u006F';//  LATIN SMALL LETTER O
                case 0x70: return '\u0070';//  LATIN SMALL LETTER P
                case 0x71: return '\u0071';//  LATIN SMALL LETTER Q
                case 0x72: return '\u0072';//  LATIN SMALL LETTER R
                case 0x73: return '\u0073';//  LATIN SMALL LETTER S
                case 0x74: return '\u0074';//  LATIN SMALL LETTER T
                case 0x75: return '\u0075';//  LATIN SMALL LETTER: U
                case 0x76: return '\u0076';//  LATIN SMALL LETTER V
                case 0x77: return '\u0077';//  LATIN SMALL LETTER W
                case 0x78: return '\u0078';//  LATIN SMALL LETTER X
                case 0x79: return '\u0079';//  LATIN SMALL LETTER Y
                case 0x7A: return '\u007A';// LATIN SMALL LETTER Z
                case 0x7B: return '\u007B';// LEFT CURLY BRACKET
                case 0x7C: return '\u007C';// VERTICAL LINE
                case 0x7D: return '\u007D';//  RIGHT CURLY BRACKET
                case 0x7E: return '\u007E';//  TILDE

                case 0x80: return '\u0410';//  CYRILLIC CAPITAL LETTER A
                case 0x81: return '\u0411';//  CYRILLIC CAPITAL LETTER BE
                case 0x82: return '\u0412';//  CYRILLIC CAPITAL LETTER VE
                case 0x83: return '\u0413';//  CYRILLIC CAPITAL LETTER GHE
                case 0x84: return '\u0414';//  CYRILLIC CAPITAL LETTER DE
                case 0x85: return '\u0415';//  CYRILLIC CAPITAL LETTER IE
                case 0x86: return '\u0416';//  CYRILLIC CAPITAL LETTER ZHE
                case 0x87: return '\u0417';//  CYRILLIC CAPITAL LETTER ZE
                case 0x88: return '\u0418';//  CYRILLIC CAPITAL LETTER I
                case 0x89: return '\u0419';//  CYRILLIC CAPITAL LETTER SHORT I
                case 0x8A: return '\u041A';// CYRILLIC CAPITAL LETTER KA
                case 0x8B: return '\u041B';// LETTER EL
                case 0x8C: return '\u041C';// CYRILLIC CAPITAL LETTER EM
                case 0x8D: return '\u041D';//  CYRILLIC CAPITAL LETTER EN
                case 0x8E: return '\u041E';//  CYRILLIC CAPITAL LETTER O
                case 0x8F: return '\u041F';//  CYRILLIC CAPITAL LETTER PE
                case 0x90: return '\u0420';//  CYRILLIC CAPITAL LETTER ER
                case 0x91: return '\u0421';//  CYRILLIC CAPITAL LETTER ES
                case 0x92: return '\u0422';//  CYRILLIC CAPITAL LETTER TE
                case 0x93: return '\u0423';//  CYRILLIC CAPITAL LETTER: U
                case 0x94: return '\u0424';//  CYRILLIC CAPITAL LETTER EF
                case 0x95: return '\u0425';//  CYRILLIC CAPITAL LETTER HA
                case 0x96: return '\u0426';//  CYRILLIC CAPITAL LETTER TSE
                case 0x97: return '\u0427';//  CYRILLIC CAPITAL LETTER CHE
                case 0x98: return '\u0428';//  CYRILLIC CAPITAL LETTER SHA
                case 0x99: return '\u0429';//  CYRILLIC CAPITAL LETTER SHCHA
                case 0x9A: return '\u042A';// CYRILLIC CAPITAL LETTER HARD SIGN
                case 0x9B: return '\u042B';// CYRILLIC CAPITAL LETTER YERU
                case 0x9C: return '\u042C';// CYRILLIC CAPITAL LETTER SOFT SIGN
                case 0x9D: return '\u042D';//  CYRILLIC CAPITAL LETTER E
                case 0x9E: return '\u042E';//  CYRILLIC CAPITAL LETTER YU
                case 0x9F: return '\u042F';//  CYRILLIC CAPITAL LETTER YA
                case 0xA0: return '\u0430';//  CYRILLIC SMALL LETTER A
                case 0xA1: return '\u0431';//  CYRILLIC SMALL LETTER BE
                case 0xA2: return '\u0432';//  CYRILLIC SMALL LETTER VE
                case 0xA3: return '\u0433';//  CYRILLIC SMALL LETTER GHE
                case 0xA4: return '\u0434';//  CYRILLIC SMALL LETTER DE
                case 0xA5: return '\u0435';//  CYRILLIC SMALL LETTER IE
                case 0xA6: return '\u0436';//  CYRILLIC SMALL LETTER ZHE
                case 0xA7: return '\u0437';//  CYRILLIC SMALL LETTER ZE
                case 0xA8: return '\u0438';//  CYRILLIC SMALL LETTER I
                case 0xA9: return '\u0439';//  CYRILLIC SMALL LETTER SHORT I
                case 0xAA: return '\u043A';// CYRILLIC SMALL LETTER KA
                case 0xAB: return '\u043B';// CYRILLIC SMALL LETTER EL
                case 0xAC: return '\u043C';// CYRILLIC SMALL LETTER EM
                case 0xAD: return '\u043D';//  CYRILLIC SMALL LETTER EN
                case 0xAE: return '\u043E';//  CYRILLIC SMALL LETTER O
                case 0xAF: return '\u043F';//  CYRILLIC SMALL LETTER PE
                case 0xB0: return '\u0440';//  CYRILLIC SMALL LETTER ER
                case 0xB1: return '\u0441';//  CYRILLIC SMALL LETTER ES
                case 0xB2: return '\u0442';//  CYRILLIC SMALL LETTER TE
                case 0xB3: return '\u0443';//  CYRILLIC SMALL LETTER: U
                case 0xB4: return '\u0444';//  CYRILLIC SMALL LETTER EF
                case 0xB5: return '\u0445';//  CYRILLIC SMALL LETTER HA
                case 0xB6: return '\u0446';//  CYRILLIC SMALL LETTER TSE
                case 0xB7: return '\u0447';//  CYRILLIC SMALL LETTER CHE
                case 0xB8: return '\u0448';//  CYRILLIC SMALL LETTER SHA
                case 0xB9: return '\u0449';//  CYRILLIC SMALL LETTER SHCHA
                case 0xBA: return '\u044A';// CYRILLIC SMALL LETTER HARD SIGN
                case 0xBB: return '\u044B';// CYRILLIC SMALL LETTER YERU
                case 0xBC: return '\u044C';// CYRILLIC SMALL LETTER SOFT SIGN
                case 0xBD: return '\u044D';//  CYRILLIC SMALL LETTER E
                case 0xBE: return '\u044E';//  CYRILLIC SMALL LETTER YU
                case 0xBF: return '\u044F';//  CYRILLIC SMALL LETTER YA

                case 0xC0: return '\u2514';//  BOX DRAWINGS LIGHT: UP AND RIGHT
                case 0xC1: return '\u2534';//  BOX DRAWINGS LIGHT: UP AND HORIZONTAL
                case 0xC2: return '\u252C';// BOX DRAWINGS LIGHT DOWN AND HORIZONTAL
                case 0xC3: return '\u251C';// BOX DRAWINGS LIGHT VERTICAL AND RIGHT
                case 0xC4: return '\u2500';//  BOX DRAWINGS LIGHT HORIZONTAL
                case 0xC5: return '\u253C';// BOX DRAWINGS LIGHT VERTICAL AND HORIZONTAL
                case 0xC6: return '\u2563';//  BOX DRAWINGS DOUBLE VERTICAL AND LEFT
                case 0xC7: return '\u2551';//  BOX DRAWINGS DOUBLE VERTICAL
                case 0xC8: return '\u255A';// BOX DRAWINGS DOUBLE: UP AND RIGHT
                case 0xC9: return '\u2554';//  BOX DRAWINGS DOUBLE DOWN AND RIGHT
                case 0xCA: return '\u2569';//  BOX DRAWINGS DOUBLE: UP AND HORIZONTAL
                case 0xCB: return '\u2566';//  BOX DRAWINGS DOUBLE DOWN AND HORIZONTAL
                case 0xCC: return '\u2560';//  BOX DRAWINGS DOUBLE VERTICAL AND RIGHT
                case 0xCD: return '\u2550';//  BOX DRAWINGS DOUBLE HORIZONTAL
                case 0xCE: return '\u256C';// BOX DRAWINGS DOUBLE VERTICAL AND HORIZONTAL
                case 0xCF: return '\u2510';//  BOX DRAWINGS LIGHT DOWN AND LEFT
                case 0xD0: return '\u2591';//  LIGHT SHADE
                case 0xD1: return '\u2592';//  MEDIUM SHADE
                case 0xD2: return '\u2593';//  DARK SHADE
                case 0xD3: return '\u2502';//  BOX DRAWINGS LIGHT VERTICAL
                case 0xD4: return '\u2524';//  BOX DRAWINGS LIGHT VERTICAL AND LEFT
                case 0xD5: return '\u2116';//  NUMERO SIGN
                case 0xD6: return '\u00A7';// SECTION SIGN
                case 0xD7: return '\u2557';//  BOX DRAWINGS DOUBLE DOWN AND LEFT
                case 0xD8: return '\u255D';//  BOX DRAWINGS DOUBLE: UP AND LEFT
                case 0xD9: return '\u2518';//  BOX DRAWINGS LIGHT: UP AND LEFT
                case 0xDA: return '\u250C';// BOX DRAWINGS LIGHT DOWN AND RIGHT
                case 0xDB: return '\u2588';//  FULL BLOCK
                case 0xDC: return '\u2584';//  LOWER HALF BLOCK
                case 0xDD: return '\u258C';// LEFT HALF BLOCK
                case 0xDE: return '\u2590';//  RIGHT HALF BLOCK
                case 0xDF: return '\u2580';// : UPPER HALF BLOCK
                case 0xE0: return '\u03B1';// GREEK SMALL LETTER ALPHA
                case 0xE1: return '\u03B2';// GREEK SMALL LETTER BETA
                case 0xE2: return '\u0393';//  GREEK CAPITAL LETTER GAMMA
                case 0xE3: return '\u03C0';// GREEK SMALL LETTER PI
                case 0xE4: return '\u03A3';// GREEK CAPITAL LETTER SIGMA
                case 0xE5: return '\u03C3';// GREEK SMALL LETTER SIGMA
                case 0xE6: return '\u03BC';// GREEK SMALL LETTER MU
                case 0xE7: return '\u03C4';// GREEK SMALL LETTER TAU
                case 0xE8: return '\u03A6';// GREEK CAPITAL LETTER PHI
                case 0xE9: return '\u0398';//  GREEK CAPITAL LETTER THETA
                case 0xEA: return '\u03A9';// GREEK CAPITAL LETTER OMEGA
                case 0xEB: return '\u03B4';// GREEK SMALL LETTER DELTA
                case 0xEC: return '\u221E';//  INFINITY
                case 0xED: return '\u2205';//  EMPTY SET
                case 0xEE: return '\u2208';//  ELEMENT OF
                case 0xEF: return '\u2229';//  INTERSECTION
                case 0xF0: return '\u2261';//  IDENTICAL TO
                case 0xF1: return '\u00B1';// PLUS-MINUS SIGN
                case 0xF2: return '\u2265';//  GREATER - THAN OR EQUAL TO
                case 0xF3: return '\u2264';//  LESS - THAN OR EQUAL TO
                case 0xF4: return '\u2320';//  TOP HALF INTEGRAL
                case 0xF5: return '\u2321';//  BOTTOM HALF INTEGRAL
                case 0xF6: return '\u00F7';//  DIVISION SIGN
                case 0xF7: return '\u2248';//  ALMOST EQUAL TO
                case 0xF8: return '\u00B0';// DEGREE SIGN
                case 0xF9: return '\u2219';//  BULLET OPERATOR
                case 0xFA: return '\u00B7';// MIDDLE DOT
                case 0xFB: return '\u221A';// SQUARE ROOT
                case 0xFC: return '\u207F';//  SUPERSCRIPT LATIN SMALL LETTER N
                case 0xFD: return '\u00B2';// SUPERSCRIPT TWO
                case 0xFE: return '\u25A0';// BLACK SQUARE
                case 0xFF: return '\u00A0';// NO-BREAK SPACE

                default: return (char)rc;
            }
        }
    }
}