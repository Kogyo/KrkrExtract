# CS_ARCH_ARM, CS_MODE_THUMB, None
0x40,0xef,0xa1,0x07 = vabd.s8 d16, d16, d17
0x50,0xef,0xa1,0x07 = vabd.s16 d16, d16, d17
0x60,0xef,0xa1,0x07 = vabd.s32 d16, d16, d17
0x40,0xff,0xa1,0x07 = vabd.u8 d16, d16, d17
0x50,0xff,0xa1,0x07 = vabd.u16 d16, d16, d17
0x60,0xff,0xa1,0x07 = vabd.u32 d16, d16, d17
0x60,0xff,0xa1,0x0d = vabd.f32 d16, d16, d17
0x40,0xef,0xe2,0x07 = vabd.s8 q8, q8, q9
0x50,0xef,0xe2,0x07 = vabd.s16 q8, q8, q9
0x60,0xef,0xe2,0x07 = vabd.s32 q8, q8, q9
0x40,0xff,0xe2,0x07 = vabd.u8 q8, q8, q9
0x50,0xff,0xe2,0x07 = vabd.u16 q8, q8, q9
0x60,0xff,0xe2,0x07 = vabd.u32 q8, q8, q9
0x60,0xff,0xe2,0x0d = vabd.f32 q8, q8, q9
0xc0,0xef,0xa1,0x07 = vabdl.s8 q8, d16, d17
0xd0,0xef,0xa1,0x07 = vabdl.s16 q8, d16, d17
0xe0,0xef,0xa1,0x07 = vabdl.s32 q8, d16, d17
0xc0,0xff,0xa1,0x07 = vabdl.u8 q8, d16, d17
0xd0,0xff,0xa1,0x07 = vabdl.u16 q8, d16, d17
0xe0,0xff,0xa1,0x07 = vabdl.u32 q8, d16, d17
0x42,0xef,0xb1,0x07 = vaba.s8 d16, d18, d17
0x52,0xef,0xb1,0x07 = vaba.s16 d16, d18, d17
0x62,0xef,0xb1,0x07 = vaba.s32 d16, d18, d17
0x42,0xff,0xb1,0x07 = vaba.u8 d16, d18, d17
0x52,0xff,0xb1,0x07 = vaba.u16 d16, d18, d17
0x62,0xff,0xb1,0x07 = vaba.u32 d16, d18, d17
0x40,0xef,0xf4,0x27 = vaba.s8 q9, q8, q10
0x50,0xef,0xf4,0x27 = vaba.s16 q9, q8, q10
0x60,0xef,0xf4,0x27 = vaba.s32 q9, q8, q10
0x40,0xff,0xf4,0x27 = vaba.u8 q9, q8, q10
0x50,0xff,0xf4,0x27 = vaba.u16 q9, q8, q10
0x60,0xff,0xf4,0x27 = vaba.u32 q9, q8, q10
0xc3,0xef,0xa2,0x05 = vabal.s8 q8, d19, d18
0xd3,0xef,0xa2,0x05 = vabal.s16 q8, d19, d18
0xe3,0xef,0xa2,0x05 = vabal.s32 q8, d19, d18
0xc3,0xff,0xa2,0x05 = vabal.u8 q8, d19, d18
0xd3,0xff,0xa2,0x05 = vabal.u16 q8, d19, d18
0xe3,0xff,0xa2,0x05 = vabal.u32 q8, d19, d18
