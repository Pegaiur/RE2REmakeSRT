﻿namespace RE2REmakeSRT
{
    public static class GameHashes
    {
        // Personally observed upon release.
        public static readonly byte[] Stock_1ShotDemo = new byte[32] { 0x48, 0xB8, 0x8E, 0xCB, 0xE3, 0xA7, 0x2F, 0xD5, 0x43, 0x31, 0x27, 0x0A, 0x57, 0xC2, 0x6B, 0x72, 0x65, 0x31, 0x1C, 0x32, 0xFD, 0x41, 0x64, 0x38, 0xBE, 0x5A, 0xB0, 0x7D, 0x08, 0xD1, 0x3D, 0xE2 };

        // Assumed to exist since PS4 release version was already 1.01 so I assume PC version is the same which means a 1.00 exists somewhere.
        public static readonly byte[] Stock_1p00 = new byte[32]; // Undefined, we don't know the hashes yet!

        // Personally observed upon release.
        public static readonly byte[] Stock_1p01 = new byte[32] { 0xFE, 0x7B, 0xC9, 0x1D, 0x03, 0x2F, 0x9B, 0xD9, 0x82, 0x83, 0xBE, 0x56, 0x1E, 0xA1, 0x51, 0x55, 0x8F, 0xBC, 0x18, 0xC2, 0x6D, 0x7D, 0xEB, 0x54, 0xFE, 0x81, 0xB1, 0x89, 0x5C, 0x80, 0xAC, 0x30 };

        // Personally observed upon release. Ghost Survivors DLC.
        public static readonly byte[] Stock_1p10 = new byte[32] { 0xDF, 0x24, 0xE7, 0x07, 0x3E, 0x38, 0x1C, 0x37, 0xCE, 0xA5, 0x21, 0x95, 0x74, 0xEF, 0x3A, 0x81, 0x60, 0x3B, 0x9F, 0x3F, 0xE0, 0xCA, 0x5C, 0x3A, 0x05, 0x89, 0x95, 0x68, 0x5D, 0x72, 0x90, 0xD0 };

        // Personally observed upon release. Bug fix patch.
        public static readonly byte[] Stock_1p11 = new byte[32] { 0x57, 0x1D, 0xEE, 0x3F, 0x37, 0xF6, 0xE7, 0x86, 0x1A, 0xF1, 0xA4, 0xAD, 0xB8, 0x15, 0xF6, 0xF1, 0x53, 0x37, 0xBA, 0x48, 0x73, 0xE4, 0xD6, 0x99, 0xCA, 0x71, 0x32, 0x85, 0xEA, 0x8D, 0x95, 0x4D };

        // Reported by T710MA on Speedrun.com (https://pbs.twimg.com/media/DzHTNaQUYAEsFFI.jpg:large). Unsure if region modified by Capcom or user-modified.
        public static readonly byte[] Unknown_1 = new byte[32] { 0xD0, 0xA2, 0xB8, 0x74, 0xA1, 0x47, 0x41, 0x08, 0xE7, 0x21, 0x25, 0x58, 0x9F, 0x79, 0xA5, 0x1A, 0x66, 0xC8, 0xCB, 0x05, 0x6B, 0xA3, 0xD5, 0x46, 0x28, 0xDA, 0xED, 0xAE, 0x1D, 0x7E, 0xA5, 0xEB };
    }
}
