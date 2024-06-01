﻿namespace PointBlank.Core.Models.Enums
{
  public enum EventErrorEnum : uint
  {
    SUCCESS = 0,
    LOGIN_ALREADY_LOGIN_WEB = 2147483905, // 0x80000101
    LOGIN_USER_PASS_FAIL = 2147483906, // 0x80000102
    LOGIN_LOGOUTING = 2147483908, // 0x80000104
    LOGIN_TIME_OUT_1 = 2147483909, // 0x80000105
    LOGIN_TIME_OUT_2 = 2147483910, // 0x80000106
    LOGIN_BLOCK_ACCOUNT = 2147483911, // 0x80000107
    LOGIN_SERVER_USER_FULL = 2147483918, // 0x8000010E
    LOGIN_DB_BUFFER_FAIL = 2147483924, // 0x80000114
    LOGIN_ID_PASS_INCORRECT = 2147483927, // 0x80000117
    LOGIN_ID_PASS_INCORRECT2 = 2147483928, // 0x80000118
    LOGIN_DELETE_ACCOUNT = 2147483929, // 0x80000119
    LOGIN_EMAIL_AUTH_ERROR = 2147483936, // 0x80000120
    LOGIN_BLOCK_IP = 2147483937, // 0x80000121
    LOGIN_EMAIL_ALERT2 = 2147483938, // 0x80000122
    LOGIN_MIGRATION = 2147483940, // 0x80000124
    LOGIN_NON_STRING = 2147483941, // 0x80000125
    LOGIN_BLOCK_COUNTRY = 2147483942, // 0x80000126
    LOGIN_INVALID_ACCOUNT = 2147483943, // 0x80000127
    LOGIN_PC_BLOCK = 2147483955, // 0x80000133
    BATTLE_NO_REAL_IP = 2147487752, // 0x80001008
    BATTLE_NO_READY_TEAM = 2147487753, // 0x80001009
    BATTLE_FIRST_MAINLOAD = 2147487754, // 0x8000100A
    BATTLE_FIRST_HOLE = 2147487755, // 0x8000100B
    BATTLE_NO_ENEMY = 2147487756, // 0x8000100C
    BATTLE_WAIT_BATTLE_CLIMAX = 2147487759, // 0x8000100F
    BATTLE_NO_START_FOR_UNDER_NAT = 2147487762, // 0x80001012
    BATTLE_PRESTART_BATTLE_ALREADYEND = 2147487765, // 0x80001015
    BATTLE_START_BATTLE_ALREADYEND = 2147487766, // 0x80001016
    LOGIN_INVENTORY_FAIL = 2147487796, // 0x80001034
    VISIT_EVENT_USERFAIL = 2147489024, // 0x80001500
    VISIT_EVENT_NOTENOUGH = 2147489025, // 0x80001501
    VISIT_EVENT_ALREADYCHECK = 2147489026, // 0x80001502
    VISIT_EVENT_WRONGVERSION = 2147489027, // 0x80001503
    VISIT_EVENT_SUCCESS = 2147489028, // 0x80001504
    VISIT_EVENT_UNKNOWN = 2147489029, // 0x80001505
    LOGIN_BLOCK_INNER = 2148532224, // 0x80100000
    LOGIN_BLOCK_OUTER = 2149580800, // 0x80200000
    LOGIN_BLOCK_GAME = 2155872256, // 0x80800000
  }
}
