﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileDevice.CoreFundation
{
    public enum CFStringEncoding
    {
        kCFStringEncodingANSEL = 0x601,
        kCFStringEncodingASCII = 0x600,
        kCFStringEncodingBig5 = 0xa03,
        kCFStringEncodingBig5_E = 0xa09,
        kCFStringEncodingBig5_HKSCS_1999 = 0xa06,
        kCFStringEncodingCNS_11643_92_P1 = 0x651,
        kCFStringEncodingCNS_11643_92_P2 = 0x652,
        kCFStringEncodingCNS_11643_92_P3 = 0x653,
        kCFStringEncodingDOSArabic = 0x419,
        kCFStringEncodingDOSBalticRim = 0x406,
        kCFStringEncodingDOSCanadianFrench = 0x418,
        kCFStringEncodingDOSChineseSimplif = 0x421,
        kCFStringEncodingDOSChineseTrad = 0x423,
        kCFStringEncodingDOSCyrillic = 0x413,
        kCFStringEncodingDOSGreek = 0x405,
        kCFStringEncodingDOSGreek1 = 0x411,
        kCFStringEncodingDOSGreek2 = 0x41c,
        kCFStringEncodingDOSHebrew = 0x417,
        kCFStringEncodingDOSIcelandic = 0x416,
        kCFStringEncodingDOSJapanese = 0x420,
        kCFStringEncodingDOSKorean = 0x422,
        kCFStringEncodingDOSLatin1 = 0x410,
        kCFStringEncodingDOSLatin2 = 0x412,
        kCFStringEncodingDOSLatinUS = 0x400,
        kCFStringEncodingDOSNordic = 0x41a,
        kCFStringEncodingDOSPortuguese = 0x415,
        kCFStringEncodingDOSRussian = 0x41b,
        kCFStringEncodingDOSThai = 0x41d,
        kCFStringEncodingDOSTurkish = 0x414,
        kCFStringEncodingEBCDIC_CP037 = 0xc02,
        kCFStringEncodingEBCDIC_US = 0xc01,
        kCFStringEncodingEUC_CN = 0x930,
        kCFStringEncodingEUC_JP = 0x920,
        kCFStringEncodingEUC_KR = 0x940,
        kCFStringEncodingEUC_TW = 0x931,
        kCFStringEncodingGB_18030_2000 = 0x632,
        kCFStringEncodingGB_2312_80 = 0x630,
        kCFStringEncodingGBK_95 = 0x631,
        kCFStringEncodingHZ_GB_2312 = 0xa05,
        kCFStringEncodingISO_2022_CN = 0x830,
        kCFStringEncodingISO_2022_CN_EXT = 0x831,
        kCFStringEncodingISO_2022_JP = 0x820,
        kCFStringEncodingISO_2022_JP_1 = 0x822,
        kCFStringEncodingISO_2022_JP_2 = 0x821,
        kCFStringEncodingISO_2022_JP_3 = 0x823,
        kCFStringEncodingISO_2022_KR = 0x840,
        kCFStringEncodingISOLatin1 = 0x201,
        kCFStringEncodingISOLatin10 = 0x210,
        kCFStringEncodingISOLatin2 = 0x202,
        kCFStringEncodingISOLatin3 = 0x203,
        kCFStringEncodingISOLatin4 = 0x204,
        kCFStringEncodingISOLatin5 = 0x209,
        kCFStringEncodingISOLatin6 = 0x20a,
        kCFStringEncodingISOLatin7 = 0x20d,
        kCFStringEncodingISOLatin8 = 0x20e,
        kCFStringEncodingISOLatin9 = 0x20f,
        kCFStringEncodingISOLatinArabic = 0x206,
        kCFStringEncodingISOLatinCyrillic = 0x205,
        kCFStringEncodingISOLatinGreek = 0x207,
        kCFStringEncodingISOLatinHebrew = 520,
        kCFStringEncodingISOLatinThai = 0x20b,
        kCFStringEncodingJIS_C6226_78 = 0x624,
        kCFStringEncodingJIS_X0201_76 = 0x620,
        kCFStringEncodingJIS_X0208_83 = 0x621,
        kCFStringEncodingJIS_X0208_90 = 0x622,
        kCFStringEncodingJIS_X0212_90 = 0x623,
        kCFStringEncodingKOI8_R = 0xa02,
        kCFStringEncodingKOI8_U = 0xa08,
        kCFStringEncodingKSC_5601_87 = 0x640,
        kCFStringEncodingKSC_5601_92_Johab = 0x641,
        kCFStringEncodingMacArabic = 4,
        kCFStringEncodingMacArmenian = 0x18,
        kCFStringEncodingMacBengali = 13,
        kCFStringEncodingMacBurmese = 0x13,
        kCFStringEncodingMacCeltic = 0x27,
        kCFStringEncodingMacCentralEurRoman = 0x1d,
        kCFStringEncodingMacChineseSimp = 0x19,
        kCFStringEncodingMacChineseTrad = 2,
        kCFStringEncodingMacCroatian = 0x24,
        kCFStringEncodingMacCyrillic = 7,
        kCFStringEncodingMacDevanagari = 9,
        kCFStringEncodingMacDingbats = 0x22,
        kCFStringEncodingMacEthiopic = 0x1c,
        kCFStringEncodingMacExtArabic = 0x1f,
        kCFStringEncodingMacFarsi = 140,
        kCFStringEncodingMacGaelic = 40,
        kCFStringEncodingMacGeorgian = 0x17,
        kCFStringEncodingMacGreek = 6,
        kCFStringEncodingMacGujarati = 11,
        kCFStringEncodingMacGurmukhi = 10,
        kCFStringEncodingMacHebrew = 5,
        kCFStringEncodingMacHFS = 0xff,
        kCFStringEncodingMacIcelandic = 0x25,
        kCFStringEncodingMacInuit = 0xec,
        kCFStringEncodingMacJapanese = 1,
        kCFStringEncodingMacKannada = 0x10,
        kCFStringEncodingMacKhmer = 20,
        kCFStringEncodingMacKorean = 3,
        kCFStringEncodingMacLaotian = 0x16,
        kCFStringEncodingMacMalayalam = 0x11,
        kCFStringEncodingMacMongolian = 0x1b,
        kCFStringEncodingMacOriya = 12,
        kCFStringEncodingMacRoman = 0,
        kCFStringEncodingMacRomanian = 0x26,
        kCFStringEncodingMacRomanLatin1 = 0xa04,
        kCFStringEncodingMacSinhalese = 0x12,
        kCFStringEncodingMacSymbol = 0x21,
        kCFStringEncodingMacTamil = 14,
        kCFStringEncodingMacTelugu = 15,
        kCFStringEncodingMacThai = 0x15,
        kCFStringEncodingMacTibetan = 0x1a,
        kCFStringEncodingMacTurkish = 0x23,
        kCFStringEncodingMacUkrainian = 0x98,
        kCFStringEncodingMacVietnamese = 30,
        kCFStringEncodingMacVT100 = 0xfc,
        kCFStringEncodingNextStepJapanese = 0xb02,
        kCFStringEncodingNextStepLatin = 0xb01,
        kCFStringEncodingShiftJIS = 0xa01,
        kCFStringEncodingShiftJIS_X0213 = 0x628,
        kCFStringEncodingShiftJIS_X0213_00 = 0x628,
        kCFStringEncodingShiftJIS_X0213_MenKuTen = 0x629,
        kCFStringEncodingUTF7 = 0x4000100,
        kCFStringEncodingUTF7_IMAP = 0xa10,
        kCFStringEncodingVISCII = 0xa07,
        kCFStringEncodingWindowsArabic = 0x506,
        kCFStringEncodingWindowsBalticRim = 0x507,
        kCFStringEncodingWindowsCyrillic = 0x502,
        kCFStringEncodingWindowsGreek = 0x503,
        kCFStringEncodingWindowsHebrew = 0x505,
        kCFStringEncodingWindowsKoreanJohab = 0x510,
        kCFStringEncodingWindowsLatin1 = 0x500,
        kCFStringEncodingWindowsLatin2 = 0x501,
        kCFStringEncodingWindowsLatin5 = 0x504,
        kCFStringEncodingWindowsVietnamese = 0x508
    }
}
