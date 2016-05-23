namespace System.IO.BACnet
{
    // Add FC : from Karg's Stack
    public enum BacnetUnitsId
    {
        UNITS_METERS_PER_SECOND_PER_SECOND = 166,
        /* Area */
        UNITS_SQUARE_METERS = 0,
        UNITS_SQUARE_CENTIMETERS = 116,
        UNITS_SQUARE_FEET = 1,
        UNITS_SQUARE_INCHES = 115,
        /* Currency */
        UNITS_CURRENCY1 = 105,
        UNITS_CURRENCY2 = 106,
        UNITS_CURRENCY3 = 107,
        UNITS_CURRENCY4 = 108,
        UNITS_CURRENCY5 = 109,
        UNITS_CURRENCY6 = 110,
        UNITS_CURRENCY7 = 111,
        UNITS_CURRENCY8 = 112,
        UNITS_CURRENCY9 = 113,
        UNITS_CURRENCY10 = 114,
        /* Electrical */
        UNITS_MILLIAMPERES = 2,
        UNITS_AMPERES = 3,
        UNITS_AMPERES_PER_METER = 167,
        UNITS_AMPERES_PER_SQUARE_METER = 168,
        UNITS_AMPERE_SQUARE_METERS = 169,
        UNITS_DECIBELS = 199,
        UNITS_DECIBELS_MILLIVOLT = 200,
        UNITS_DECIBELS_VOLT = 201,
        UNITS_FARADS = 170,
        UNITS_HENRYS = 171,
        UNITS_OHMS = 4,
        UNITS_OHM_METERS = 172,
        UNITS_MILLIOHMS = 145,
        UNITS_KILOHMS = 122,
        UNITS_MEGOHMS = 123,
        UNITS_MICROSIEMENS = 190,
        UNITS_MILLISIEMENS = 202,
        UNITS_SIEMENS = 173,        /* 1 mho equals 1 siemens */
        UNITS_SIEMENS_PER_METER = 174,
        UNITS_TESLAS = 175,
        UNITS_VOLTS = 5,
        UNITS_MILLIVOLTS = 124,
        UNITS_KILOVOLTS = 6,
        UNITS_MEGAVOLTS = 7,
        UNITS_VOLT_AMPERES = 8,
        UNITS_KILOVOLT_AMPERES = 9,
        UNITS_MEGAVOLT_AMPERES = 10,
        UNITS_VOLT_AMPERES_REACTIVE = 11,
        UNITS_KILOVOLT_AMPERES_REACTIVE = 12,
        UNITS_MEGAVOLT_AMPERES_REACTIVE = 13,
        UNITS_VOLTS_PER_DEGREE_KELVIN = 176,
        UNITS_VOLTS_PER_METER = 177,
        UNITS_DEGREES_PHASE = 14,
        UNITS_POWER_FACTOR = 15,
        UNITS_WEBERS = 178,
        /* Energy */
        UNITS_JOULES = 16,
        UNITS_KILOJOULES = 17,
        UNITS_KILOJOULES_PER_KILOGRAM = 125,
        UNITS_MEGAJOULES = 126,
        UNITS_WATT_HOURS = 18,
        UNITS_KILOWATT_HOURS = 19,
        UNITS_MEGAWATT_HOURS = 146,
        UNITS_WATT_HOURS_REACTIVE = 203,
        UNITS_KILOWATT_HOURS_REACTIVE = 204,
        UNITS_MEGAWATT_HOURS_REACTIVE = 205,
        UNITS_BTUS = 20,
        UNITS_KILO_BTUS = 147,
        UNITS_MEGA_BTUS = 148,
        UNITS_THERMS = 21,
        UNITS_TON_HOURS = 22,
        /* Enthalpy */
        UNITS_JOULES_PER_KILOGRAM_DRY_AIR = 23,
        UNITS_KILOJOULES_PER_KILOGRAM_DRY_AIR = 149,
        UNITS_MEGAJOULES_PER_KILOGRAM_DRY_AIR = 150,
        UNITS_BTUS_PER_POUND_DRY_AIR = 24,
        UNITS_BTUS_PER_POUND = 117,
        /* Entropy */
        UNITS_JOULES_PER_DEGREE_KELVIN = 127,
        UNITS_KILOJOULES_PER_DEGREE_KELVIN = 151,
        UNITS_MEGAJOULES_PER_DEGREE_KELVIN = 152,
        UNITS_JOULES_PER_KILOGRAM_DEGREE_KELVIN = 128,
        /* Force */
        UNITS_NEWTON = 153,
        /* Frequency */
        UNITS_CYCLES_PER_HOUR = 25,
        UNITS_CYCLES_PER_MINUTE = 26,
        UNITS_HERTZ = 27,
        UNITS_KILOHERTZ = 129,
        UNITS_MEGAHERTZ = 130,
        UNITS_PER_HOUR = 131,
        /* Humidity */
        UNITS_GRAMS_OF_WATER_PER_KILOGRAM_DRY_AIR = 28,
        UNITS_PERCENT_RELATIVE_HUMIDITY = 29,
        /* Length */
        UNITS_MICROMETERS = 194,
        UNITS_MILLIMETERS = 30,
        UNITS_CENTIMETERS = 118,
        UNITS_KILOMETERS = 193,
        UNITS_METERS = 31,
        UNITS_INCHES = 32,
        UNITS_FEET = 33,
        /* Light */
        UNITS_CANDELAS = 179,
        UNITS_CANDELAS_PER_SQUARE_METER = 180,
        UNITS_WATTS_PER_SQUARE_FOOT = 34,
        UNITS_WATTS_PER_SQUARE_METER = 35,
        UNITS_LUMENS = 36,
        UNITS_LUXES = 37,
        UNITS_FOOT_CANDLES = 38,
        /* Mass */
        UNITS_MILLIGRAMS = 196,
        UNITS_GRAMS = 195,
        UNITS_KILOGRAMS = 39,
        UNITS_POUNDS_MASS = 40,
        UNITS_TONS = 41,
        /* Mass Flow */
        UNITS_GRAMS_PER_SECOND = 154,
        UNITS_GRAMS_PER_MINUTE = 155,
        UNITS_KILOGRAMS_PER_SECOND = 42,
        UNITS_KILOGRAMS_PER_MINUTE = 43,
        UNITS_KILOGRAMS_PER_HOUR = 44,
        UNITS_POUNDS_MASS_PER_SECOND = 119,
        UNITS_POUNDS_MASS_PER_MINUTE = 45,
        UNITS_POUNDS_MASS_PER_HOUR = 46,
        UNITS_TONS_PER_HOUR = 156,
        /* Power */
        UNITS_MILLIWATTS = 132,
        UNITS_WATTS = 47,
        UNITS_KILOWATTS = 48,
        UNITS_MEGAWATTS = 49,
        UNITS_BTUS_PER_HOUR = 50,
        UNITS_KILO_BTUS_PER_HOUR = 157,
        UNITS_HORSEPOWER = 51,
        UNITS_TONS_REFRIGERATION = 52,
        /* Pressure */
        UNITS_PASCALS = 53,
        UNITS_HECTOPASCALS = 133,
        UNITS_KILOPASCALS = 54,
        UNITS_MILLIBARS = 134,
        UNITS_BARS = 55,
        UNITS_POUNDS_FORCE_PER_SQUARE_INCH = 56,
        UNITS_MILLIMETERS_OF_WATER = 206,
        UNITS_CENTIMETERS_OF_WATER = 57,
        UNITS_INCHES_OF_WATER = 58,
        UNITS_MILLIMETERS_OF_MERCURY = 59,
        UNITS_CENTIMETERS_OF_MERCURY = 60,
        UNITS_INCHES_OF_MERCURY = 61,
        /* Temperature */
        UNITS_DEGREES_CELSIUS = 62,
        UNITS_DEGREES_KELVIN = 63,
        UNITS_DEGREES_KELVIN_PER_HOUR = 181,
        UNITS_DEGREES_KELVIN_PER_MINUTE = 182,
        UNITS_DEGREES_FAHRENHEIT = 64,
        UNITS_DEGREE_DAYS_CELSIUS = 65,
        UNITS_DEGREE_DAYS_FAHRENHEIT = 66,
        UNITS_DELTA_DEGREES_FAHRENHEIT = 120,
        UNITS_DELTA_DEGREES_KELVIN = 121,
        /* Time */
        UNITS_YEARS = 67,
        UNITS_MONTHS = 68,
        UNITS_WEEKS = 69,
        UNITS_DAYS = 70,
        UNITS_HOURS = 71,
        UNITS_MINUTES = 72,
        UNITS_SECONDS = 73,
        UNITS_HUNDREDTHS_SECONDS = 158,
        UNITS_MILLISECONDS = 159,
        /* Torque */
        UNITS_NEWTON_METERS = 160,
        /* Velocity */
        UNITS_MILLIMETERS_PER_SECOND = 161,
        UNITS_MILLIMETERS_PER_MINUTE = 162,
        UNITS_METERS_PER_SECOND = 74,
        UNITS_METERS_PER_MINUTE = 163,
        UNITS_METERS_PER_HOUR = 164,
        UNITS_KILOMETERS_PER_HOUR = 75,
        UNITS_FEET_PER_SECOND = 76,
        UNITS_FEET_PER_MINUTE = 77,
        UNITS_MILES_PER_HOUR = 78,
        /* Volume */
        UNITS_CUBIC_FEET = 79,
        UNITS_CUBIC_METERS = 80,
        UNITS_IMPERIAL_GALLONS = 81,
        UNITS_MILLILITERS = 197,
        UNITS_LITERS = 82,
        UNITS_US_GALLONS = 83,
        /* Volumetric Flow */
        UNITS_CUBIC_FEET_PER_SECOND = 142,
        UNITS_CUBIC_FEET_PER_MINUTE = 84,
        UNITS_CUBIC_FEET_PER_HOUR = 191,
        UNITS_CUBIC_METERS_PER_SECOND = 85,
        UNITS_CUBIC_METERS_PER_MINUTE = 165,
        UNITS_CUBIC_METERS_PER_HOUR = 135,
        UNITS_IMPERIAL_GALLONS_PER_MINUTE = 86,
        UNITS_MILLILITERS_PER_SECOND = 198,
        UNITS_LITERS_PER_SECOND = 87,
        UNITS_LITERS_PER_MINUTE = 88,
        UNITS_LITERS_PER_HOUR = 136,
        UNITS_US_GALLONS_PER_MINUTE = 89,
        UNITS_US_GALLONS_PER_HOUR = 192,
        /* Other */
        UNITS_DEGREES_ANGULAR = 90,
        UNITS_DEGREES_CELSIUS_PER_HOUR = 91,
        UNITS_DEGREES_CELSIUS_PER_MINUTE = 92,
        UNITS_DEGREES_FAHRENHEIT_PER_HOUR = 93,
        UNITS_DEGREES_FAHRENHEIT_PER_MINUTE = 94,
        UNITS_JOULE_SECONDS = 183,
        UNITS_KILOGRAMS_PER_CUBIC_METER = 186,
        UNITS_KW_HOURS_PER_SQUARE_METER = 137,
        UNITS_KW_HOURS_PER_SQUARE_FOOT = 138,
        UNITS_MEGAJOULES_PER_SQUARE_METER = 139,
        UNITS_MEGAJOULES_PER_SQUARE_FOOT = 140,
        UNITS_NO_UNITS = 95,
        UNITS_NEWTON_SECONDS = 187,
        UNITS_NEWTONS_PER_METER = 188,
        UNITS_PARTS_PER_MILLION = 96,
        UNITS_PARTS_PER_BILLION = 97,
        UNITS_PERCENT = 98,
        UNITS_PERCENT_OBSCURATION_PER_FOOT = 143,
        UNITS_PERCENT_OBSCURATION_PER_METER = 144,
        UNITS_PERCENT_PER_SECOND = 99,
        UNITS_PER_MINUTE = 100,
        UNITS_PER_SECOND = 101,
        UNITS_PSI_PER_DEGREE_FAHRENHEIT = 102,
        UNITS_RADIANS = 103,
        UNITS_RADIANS_PER_SECOND = 184,
        UNITS_REVOLUTIONS_PER_MINUTE = 104,
        UNITS_SQUARE_METERS_PER_NEWTON = 185,
        UNITS_WATTS_PER_METER_PER_DEGREE_KELVIN = 189,
        UNITS_WATTS_PER_SQUARE_METER_DEGREE_KELVIN = 141,
        UNITS_PER_MILLE = 207,
        UNITS_GRAMS_PER_GRAM = 208,
        UNITS_KILOGRAMS_PER_KILOGRAM = 209,
        UNITS_GRAMS_PER_KILOGRAM = 210,
        UNITS_MILLIGRAMS_PER_GRAM = 211,
        UNITS_MILLIGRAMS_PER_KILOGRAM = 212,
        UNITS_GRAMS_PER_MILLILITER = 213,
        UNITS_GRAMS_PER_LITER = 214,
        UNITS_MILLIGRAMS_PER_LITER = 215,
        UNITS_MICROGRAMS_PER_LITER = 216,
        UNITS_GRAMS_PER_CUBIC_METER = 217,
        UNITS_MILLIGRAMS_PER_CUBIC_METER = 218,
        UNITS_MICROGRAMS_PER_CUBIC_METER = 219,
        UNITS_NANOGRAMS_PER_CUBIC_METER = 220,
        UNITS_GRAMS_PER_CUBIC_CENTIMETER = 221,
        UNITS_BECQUERELS = 222,
        UNITS_MEGABECQUERELS = 224,
        UNITS_GRAY = 225,
        UNITS_MILLIGRAY = 226,
        UNITS_MICROGRAY = 227,
        UNITS_SIEVERTS = 228,
        UNITS_MILLISIEVERTS = 229,
        UNITS_MICROSIEVERTS = 230,
        UNITS_MICROSIEVERTS_PER_HOUR = 231,
        UNITS_DECIBELS_A = 232,
        UNITS_NEPHELOMETRIC_TURBIDITY_UNIT = 233,
        UNITS_PH = 234,
        UNITS_GRAMS_PER_SQUARE_METER = 235,
        // Since Addendum 135-2012ar
        UNITS_MINUTES_PER_DEGREE_KELVIN = 236,
        UNITS_METER_SQUARED_PER_METER = 237,
        UNITS_AMPERE_SECONDS = 238,
        UNITS_VOLT_AMPERE_HOURS = 239,
        UNITS_KILOVOLT_AMPERE_HOURS = 240,
        UNITS_MEGAVOLT_AMPERE_HOURS = 241,
        UNITS_VOLT_AMPERE_HOURS_REACTIVE = 242,
        UNITS_KILOVOLT_AMPERE_HOURS_REACTIVE = 243,
        UNITS_MEGAVOLT_AMPERE_HOURS_REACTIVE = 244,
        UNITS_VOLT_SQUARE_HOURS = 245,
        UNITS_AMPERE_SQUARE_HOURS = 246,
        UNITS_JOULE_PER_HOURS = 247,
        UNITS_CUBIC_FEET_PER_DAY = 248,
        UNITS_CUBIC_METERS_PER_DAY = 249,
        UNITS_WATT_HOURS_PER_CUBIC_METER = 250,
        UNITS_JOULES_PER_CUBIC_METER = 251,
        UNITS_MOLE_PERCENT  = 252,
        UNITS_PASCAL_SECONDS = 253
    }
}