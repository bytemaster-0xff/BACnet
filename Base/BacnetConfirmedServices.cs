namespace System.IO.BACnet
{
    public enum BacnetConfirmedServices : byte
    {
        /* Alarm and Event Services */
        SERVICE_CONFIRMED_ACKNOWLEDGE_ALARM = 0,
        SERVICE_CONFIRMED_COV_NOTIFICATION = 1,
        SERVICE_CONFIRMED_EVENT_NOTIFICATION = 2,
        SERVICE_CONFIRMED_GET_ALARM_SUMMARY = 3,
        SERVICE_CONFIRMED_GET_ENROLLMENT_SUMMARY = 4,
        SERVICE_CONFIRMED_GET_EVENT_INFORMATION = 29,
        SERVICE_CONFIRMED_SUBSCRIBE_COV = 5,
        SERVICE_CONFIRMED_SUBSCRIBE_COV_PROPERTY = 28,
        SERVICE_CONFIRMED_LIFE_SAFETY_OPERATION = 27,
        /* File Access Services */
        SERVICE_CONFIRMED_ATOMIC_READ_FILE = 6,
        SERVICE_CONFIRMED_ATOMIC_WRITE_FILE = 7,
        /* Object Access Services */
        SERVICE_CONFIRMED_ADD_LIST_ELEMENT = 8,
        SERVICE_CONFIRMED_REMOVE_LIST_ELEMENT = 9,
        SERVICE_CONFIRMED_CREATE_OBJECT = 10,
        SERVICE_CONFIRMED_DELETE_OBJECT = 11,
        SERVICE_CONFIRMED_READ_PROPERTY = 12,
        SERVICE_CONFIRMED_READ_PROP_CONDITIONAL = 13,
        SERVICE_CONFIRMED_READ_PROP_MULTIPLE = 14,
        SERVICE_CONFIRMED_READ_RANGE = 26,
        SERVICE_CONFIRMED_WRITE_PROPERTY = 15,
        SERVICE_CONFIRMED_WRITE_PROP_MULTIPLE = 16,
        /* Remote Device Management Services */
        SERVICE_CONFIRMED_DEVICE_COMMUNICATION_CONTROL = 17,
        SERVICE_CONFIRMED_PRIVATE_TRANSFER = 18,
        SERVICE_CONFIRMED_TEXT_MESSAGE = 19,
        SERVICE_CONFIRMED_REINITIALIZE_DEVICE = 20,
        /* Virtual Terminal Services */
        SERVICE_CONFIRMED_VT_OPEN = 21,
        SERVICE_CONFIRMED_VT_CLOSE = 22,
        SERVICE_CONFIRMED_VT_DATA = 23,
        /* Security Services */
        SERVICE_CONFIRMED_AUTHENTICATE = 24,
        SERVICE_CONFIRMED_REQUEST_KEY = 25,
        /* Services added after 1995 */
        /* readRange (26) see Object Access Services */
        /* lifeSafetyOperation (27) see Alarm and Event Services */
        /* subscribeCOVProperty (28) see Alarm and Event Services */
        /* getEventInformation (29) see Alarm and Event Services */
        MAX_BACNET_CONFIRMED_SERVICE = 30
    }
}