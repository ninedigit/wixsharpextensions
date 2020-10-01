/******************************************************************************/
/*       _                                    */
/*       \`*-.                                */
/*    )  _`-.                                 */
/*       .  : `. .                                */
/*       : _   '  \                               */
/*       ; *` _.   `*-._                              */
/*       `-.-'      `-.                           */
/*     ;       `       `.                         */
/*     :.       .    \                        */
/*     . \  .   :   .-'   .     NABU Project                  */
/*     '  `+.;  ;  '      :     Microsoft.Win32.Interop Library       */
/*     :  '  |    ;       ;-.   Copyright © 2005, adontz          */
/*     ; '   : :`-:     _.`* ;                        */
/*      .*' /  .*' ; .*`- +'  `*'                         */
/*      `*-*   `*-*  `*-*'                            */
/*                                        */
/******************************************************************************/

// credits: http://www.pinvoke.net/default.aspx/Constants/WINERROR.html

namespace NineDigit.WixSharpExtensions.Resources
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Naming", "CA1707:Identifiers should not contain underscores", Justification = "<Pending>")]
    public static class ResultCom
    {
        /// <summary>
        /// Not implemented
        /// </summary>
        public const int E_NOTIMPL = (int)(0x80000001 - 0x100000000);
        /// <summary>
        /// Ran out of memory
        /// </summary>
        public const int E_OUTOFMEMORY = (int)(0x80000002 - 0x100000000);
        /// <summary>
        /// One or more arguments are invalid
        /// </summary>
        public const int E_INVALIDARG = (int)(0x80000003 - 0x100000000);
        /// <summary>
        /// No such interface supported
        /// </summary>
        public const int E_NOINTERFACE = (int)(0x80000004 - 0x100000000);
        /// <summary>
        /// Invalid pointer
        /// </summary>
        public const int E_POINTER = (int)(0x80000005 - 0x100000000);
        /// <summary>
        /// Invalid handle
        /// </summary>
        public const int E_HANDLE = (int)(0x80000006 - 0x100000000);
        /// <summary>
        /// Operation aborted
        /// </summary>
        public const int E_ABORT = (int)(0x80000007 - 0x100000000);
        /// <summary>
        /// Unspecified error
        /// </summary>
        public const int E_FAIL = (int)(0x80000008 - 0x100000000);
        /// <summary>
        /// General access denied error
        /// </summary>
        public const int E_ACCESSDENIED = (int)(0x80000009 - 0x100000000);
        /// <summary>
        /// The data necessary to complete this operation is not yet available.
        /// </summary>
        public const int E_PENDING = (int)(0x8000000A - 0x100000000);
        /// <summary>
        /// Thread local storage failure
        /// </summary>
        public const int CO_E_INIT_TLS = (int)(0x80004006 - 0x100000000);
        /// <summary>
        /// Get shared memory allocator failure
        /// </summary>
        public const int CO_E_INIT_SHARED_ALLOCATOR = (int)(0x80004007 - 0x100000000);
        /// <summary>
        /// Get memory allocator failure
        /// </summary>
        public const int CO_E_INIT_MEMORY_ALLOCATOR = (int)(0x80004008 - 0x100000000);
        /// <summary>
        /// Unable to initialize class cache
        /// </summary>
        public const int CO_E_INIT_CLASS_CACHE = (int)(0x80004009 - 0x100000000);
        /// <summary>
        /// Unable to initialize RPC services
        /// </summary>
        public const int CO_E_INIT_RPC_CHANNEL = (int)(0x8000400A - 0x100000000);
        /// <summary>
        /// Cannot set thread local storage channel control
        /// </summary>
        public const int CO_E_INIT_TLS_SET_CHANNEL_CONTROL = (int)(0x8000400B - 0x100000000);
        /// <summary>
        /// Could not allocate thread local storage channel control
        /// </summary>
        public const int CO_E_INIT_TLS_CHANNEL_CONTROL = (int)(0x8000400C - 0x100000000);
        /// <summary>
        /// The user supplied memory allocator is unacceptable
        /// </summary>
        public const int CO_E_INIT_UNACCEPTED_USER_ALLOCATOR = (int)(0x8000400D - 0x100000000);
        /// <summary>
        /// The OLE service mutex already exists
        /// </summary>
        public const int CO_E_INIT_SCM_MUTEX_EXISTS = (int)(0x8000400E - 0x100000000);
        /// <summary>
        /// The OLE service file mapping already exists
        /// </summary>
        public const int CO_E_INIT_SCM_FILE_MAPPING_EXISTS = (int)(0x8000400F - 0x100000000);
        /// <summary>
        /// Unable to map view of file for OLE service
        /// </summary>
        public const int CO_E_INIT_SCM_MAP_VIEW_OF_FILE = (int)(0x80004010 - 0x100000000);
        /// <summary>
        /// Failure attempting to launch OLE service
        /// </summary>
        public const int CO_E_INIT_SCM_EXEC_FAILURE = (int)(0x80004011 - 0x100000000);
        /// <summary>
        /// There was an attempt to call CoInitialize a second time while single threaded
        /// </summary>
        public const int CO_E_INIT_ONLY_SINGLE_THREADED = (int)(0x80004012 - 0x100000000);
        /// <summary>
        /// A Remote activation was necessary but was not allowed
        /// </summary>
        public const int CO_E_CANT_REMOTE = (int)(0x80004013 - 0x100000000);
        /// <summary>
        /// A Remote activation was necessary but the server name provided was invalid
        /// </summary>
        public const int CO_E_BAD_SERVER_NAME = (int)(0x80004014 - 0x100000000);
        /// <summary>
        /// The class is configured to run as a security id different from the caller
        /// </summary>
        public const int CO_E_WRONG_SERVER_IDENTITY = (int)(0x80004015 - 0x100000000);
        /// <summary>
        /// Use of Ole1 services requiring DDE windows is disabled
        /// </summary>
        public const int CO_E_OLE1DDE_DISABLED = (int)(0x80004016 - 0x100000000);
        /// <summary>
        /// A RunAs specification must be &lt;domain name&gt;\&lt;user name&gt; or simply &lt;user name&gt;
        /// </summary>
        public const int CO_E_RUNAS_SYNTAX = (int)(0x80004017 - 0x100000000);
        /// <summary>
        /// The server process could not be started.  The pathname may be incorrect.
        /// </summary>
        public const int CO_E_CREATEPROCESS_FAILURE = (int)(0x80004018 - 0x100000000);
        /// <summary>
        /// The server process could not be started as the configured identity.  The pathname may be incorrect or unavailable.
        /// </summary>
        public const int CO_E_RUNAS_CREATEPROCESS_FAILURE = (int)(0x80004019 - 0x100000000);
        /// <summary>
        /// The server process could not be started because the configured identity is incorrect.  Check the username and password.
        /// </summary>
        public const int CO_E_RUNAS_LOGON_FAILURE = (int)(0x8000401A - 0x100000000);
        /// <summary>
        /// The client is not allowed to launch this server.
        /// </summary>
        public const int CO_E_LAUNCH_PERMSSION_DENIED = (int)(0x8000401B - 0x100000000);
        /// <summary>
        /// The service providing this server could not be started.
        /// </summary>
        public const int CO_E_START_SERVICE_FAILURE = (int)(0x8000401C - 0x100000000);
        /// <summary>
        /// This computer was unable to communicate with the computer providing the server.
        /// </summary>
        public const int CO_E_REMOTE_COMMUNICATION_FAILURE = (int)(0x8000401D - 0x100000000);
        /// <summary>
        /// The server did not respond after being launched.
        /// </summary>
        public const int CO_E_SERVER_START_TIMEOUT = (int)(0x8000401E - 0x100000000);
        /// <summary>
        /// The registration information for this server is inconsistent or incomplete.
        /// </summary>
        public const int CO_E_CLSREG_INCONSISTENT = (int)(0x8000401F - 0x100000000);
        /// <summary>
        /// The registration information for this interface is inconsistent or incomplete.
        /// </summary>
        public const int CO_E_IIDREG_INCONSISTENT = (int)(0x80004020 - 0x100000000);
        /// <summary>
        /// The operation attempted is not supported.
        /// </summary>
        public const int CO_E_NOT_SUPPORTED = (int)(0x80004021 - 0x100000000);
        /// <summary>
        /// A dll must be loaded.
        /// </summary>
        public const int CO_E_RELOAD_DLL = (int)(0x80004022 - 0x100000000);
        /// <summary>
        /// A Microsoft Software Installer error was encountered.
        /// </summary>
        public const int CO_E_MSI_ERROR = (int)(0x80004023 - 0x100000000);
        /// <summary>
        /// The specified activation could not occur in the client context as specified.
        /// </summary>
        public const int CO_E_ATTEMPT_TO_CREATE_OUTSIDE_CLIENT_CONTEXT = (int)(0x80004024 - 0x100000000);
        /// <summary>
        /// Activations on the server are paused.
        /// </summary>
        public const int CO_E_SERVER_PAUSED = (int)(0x80004025 - 0x100000000);
        /// <summary>
        /// Activations on the server are not paused.
        /// </summary>
        public const int CO_E_SERVER_NOT_PAUSED = (int)(0x80004026 - 0x100000000);
        /// <summary>
        /// The component or application containing the component has been disabled.
        /// </summary>
        public const int CO_E_CLASS_DISABLED = (int)(0x80004027 - 0x100000000);
        /// <summary>
        /// The common language runtime is not available
        /// </summary>
        public const int CO_E_CLRNOTAVAILABLE = (int)(0x80004028 - 0x100000000);
        /// <summary>
        /// The thread-pool rejected the submitted asynchronous work.
        /// </summary>
        public const int CO_E_ASYNC_WORK_REJECTED = (int)(0x80004029 - 0x100000000);
        /// <summary>
        /// The server started, but did not finish initializing in a timely fashion.
        /// </summary>
        public const int CO_E_SERVER_INIT_TIMEOUT = (int)(0x8000402A - 0x100000000);
        /// <summary>
        /// Unable to complete the call since there is no COM+ security context inside IObjectControl.Activate.
        /// </summary>
        public const int CO_E_NO_SECCTX_IN_ACTIVATE = (int)(0x8000402B - 0x100000000);
        /// <summary>
        /// The provided tracker configuration is invalid
        /// </summary>
        public const int CO_E_TRACKER_CONFIG = (int)(0x80004030 - 0x100000000);
        /// <summary>
        /// The provided thread pool configuration is invalid
        /// </summary>
        public const int CO_E_THREADPOOL_CONFIG = (int)(0x80004031 - 0x100000000);
        /// <summary>
        /// The provided side-by-side configuration is invalid
        /// </summary>
        public const int CO_E_SXS_CONFIG = (int)(0x80004032 - 0x100000000);
        /// <summary>
        /// The server principal name (SPN) obtained during security negotiation is malformed.
        /// </summary>
        public const int CO_E_MALFORMED_SPN = (int)(0x80004033 - 0x100000000);
        /// <summary>
        /// The operation completed successfully.
        /// </summary>
        public const int S_OK = 0x00000000;
        /// <summary>
        /// Incorrect function.
        /// </summary>
        public const int S_FALSE = 0x00000001;
        /// <summary>
        /// Invalid OLEVERB structure
        /// </summary>
        public const int OLE_E_FIRST = (int)(0x80040000 - 0x100000000);
        /// <summary>
        /// No information avialable.
        /// </summary>
        public const int OLE_E_LAST = (int)(0x800400FF - 0x100000000);
        /// <summary>
        /// Use the registry database to provide the requested information
        /// </summary>
        public const int OLE_S_FIRST = 0x00040000;
        /// <summary>
        /// No information avialable.
        /// </summary>
        public const int OLE_S_LAST = 0x000400FF;
        /// <summary>
        /// Invalid OLEVERB structure
        /// </summary>
        public const int OLE_E_OLEVERB = (int)(0x80040000 - 0x100000000);
        /// <summary>
        /// Invalid advise flags
        /// </summary>
        public const int OLE_E_ADVF = (int)(0x80040001 - 0x100000000);
        /// <summary>
        /// Can't enumerate any more, because the associated data is missing
        /// </summary>
        public const int OLE_E_ENUM_NOMORE = (int)(0x80040002 - 0x100000000);
        /// <summary>
        /// This implementation doesn't take advises
        /// </summary>
        public const int OLE_E_ADVISENOTSUPPORTED = (int)(0x80040003 - 0x100000000);
        /// <summary>
        /// There is no connection for this connection ID
        /// </summary>
        public const int OLE_E_NOCONNECTION = (int)(0x80040004 - 0x100000000);
        /// <summary>
        /// Need to run the object to perform this operation
        /// </summary>
        public const int OLE_E_NOTRUNNING = (int)(0x80040005 - 0x100000000);
        /// <summary>
        /// There is no cache to operate on
        /// </summary>
        public const int OLE_E_NOCACHE = (int)(0x80040006 - 0x100000000);
        /// <summary>
        /// Uninitialized object
        /// </summary>
        public const int OLE_E_BLANK = (int)(0x80040007 - 0x100000000);
        /// <summary>
        /// Linked object's source class has changed
        /// </summary>
        public const int OLE_E_CLASSDIFF = (int)(0x80040008 - 0x100000000);
        /// <summary>
        /// Not able to get the moniker of the object
        /// </summary>
        public const int OLE_E_CANT_GETMONIKER = (int)(0x80040009 - 0x100000000);
        /// <summary>
        /// Not able to bind to the source
        /// </summary>
        public const int OLE_E_CANT_BINDTOSOURCE = (int)(0x8004000A - 0x100000000);
        /// <summary>
        /// Object is static; operation not allowed
        /// </summary>
        public const int OLE_E_STATIC = (int)(0x8004000B - 0x100000000);
        /// <summary>
        /// User canceled out of save dialog
        /// </summary>
        public const int OLE_E_PROMPTSAVECANCELLED = (int)(0x8004000C - 0x100000000);
        /// <summary>
        /// Invalid rectangle
        /// </summary>
        public const int OLE_E_INVALIDRECT = (int)(0x8004000D - 0x100000000);
        /// <summary>
        /// compobj.dll is too old for the ole2.dll initialized
        /// </summary>
        public const int OLE_E_WRONGCOMPOBJ = (int)(0x8004000E - 0x100000000);
        /// <summary>
        /// Invalid window handle
        /// </summary>
        public const int OLE_E_INVALIDHWND = (int)(0x8004000F - 0x100000000);
        /// <summary>
        /// Object is not in any of the inplace active states
        /// </summary>
        public const int OLE_E_NOT_INPLACEACTIVE = (int)(0x80040010 - 0x100000000);
        /// <summary>
        /// Not able to convert object
        /// </summary>
        public const int OLE_E_CANTCONVERT = (int)(0x80040011 - 0x100000000);
        /// <summary>
        /// Not able to perform the operation because object is not given storage yet
        /// </summary>
        public const int OLE_E_NOSTORAGE = (int)(0x80040012 - 0x100000000);
        /// <summary>
        /// Invalid FORMATETC structure
        /// </summary>
        public const int DV_E_FORMATETC = (int)(0x80040064 - 0x100000000);
        /// <summary>
        /// Invalid DVTARGETDEVICE structure
        /// </summary>
        public const int DV_E_DVTARGETDEVICE = (int)(0x80040065 - 0x100000000);
        /// <summary>
        /// Invalid STDGMEDIUM structure
        /// </summary>
        public const int DV_E_STGMEDIUM = (int)(0x80040066 - 0x100000000);
        /// <summary>
        /// Invalid STATDATA structure
        /// </summary>
        public const int DV_E_STATDATA = (int)(0x80040067 - 0x100000000);
        /// <summary>
        /// Invalid lindex
        /// </summary>
        public const int DV_E_LINDEX = (int)(0x80040068 - 0x100000000);
        /// <summary>
        /// Invalid tymed
        /// </summary>
        public const int DV_E_TYMED = (int)(0x80040069 - 0x100000000);
        /// <summary>
        /// Invalid clipboard format
        /// </summary>
        public const int DV_E_CLIPFORMAT = (int)(0x8004006A - 0x100000000);
        /// <summary>
        /// Invalid aspect(s)
        /// </summary>
        public const int DV_E_DVASPECT = (int)(0x8004006B - 0x100000000);
        /// <summary>
        /// tdSize parameter of the DVTARGETDEVICE structure is invalid
        /// </summary>
        public const int DV_E_DVTARGETDEVICE_SIZE = (int)(0x8004006C - 0x100000000);
        /// <summary>
        /// Object doesn't support IViewObject interface
        /// </summary>
        public const int DV_E_NOIVIEWOBJECT = (int)(0x8004006D - 0x100000000);
        /// <summary>
        /// Trying to revoke a drop target that has not been registered
        /// </summary>
        public const int DRAGDROP_E_FIRST = (int)(0x80040100 - 0x100000000);
        /// <summary>
        /// No information avialable.
        /// </summary>
        public const int DRAGDROP_E_LAST = (int)(0x8004010F - 0x100000000);
        /// <summary>
        /// Successful drop took place
        /// </summary>
        public const int DRAGDROP_S_FIRST = 0x00040100;
        /// <summary>
        /// No information avialable.
        /// </summary>
        public const int DRAGDROP_S_LAST = 0x0004010F;
        /// <summary>
        /// Trying to revoke a drop target that has not been registered
        /// </summary>
        public const int DRAGDROP_E_NOTREGISTERED = (int)(0x80040100 - 0x100000000);
        /// <summary>
        /// This window has already been registered as a drop target
        /// </summary>
        public const int DRAGDROP_E_ALREADYREGISTERED = (int)(0x80040101 - 0x100000000);
        /// <summary>
        /// Invalid window handle
        /// </summary>
        public const int DRAGDROP_E_INVALIDHWND = (int)(0x80040102 - 0x100000000);
        /// <summary>
        /// Class does not support aggregation (or class object is remote)
        /// </summary>
        public const int CLASSFACTORY_E_FIRST = (int)(0x80040110 - 0x100000000);
        /// <summary>
        /// No information avialable.
        /// </summary>
        public const int CLASSFACTORY_E_LAST = (int)(0x8004011F - 0x100000000);
        /// <summary>
        /// No information avialable.
        /// </summary>
        public const int CLASSFACTORY_S_FIRST = 0x00040110;
        /// <summary>
        /// No information avialable.
        /// </summary>
        public const int CLASSFACTORY_S_LAST = 0x0004011F;
        /// <summary>
        /// Class does not support aggregation (or class object is remote)
        /// </summary>
        public const int CLASS_E_NOAGGREGATION = (int)(0x80040110 - 0x100000000);
        /// <summary>
        /// ClassFactory cannot supply requested class
        /// </summary>
        public const int CLASS_E_CLASSNOTAVAILABLE = (int)(0x80040111 - 0x100000000);
        /// <summary>
        /// Class is not licensed for use
        /// </summary>
        public const int CLASS_E_NOTLICENSED = (int)(0x80040112 - 0x100000000);
        /// <summary>
        /// No information avialable.
        /// </summary>
        public const int MARSHAL_E_FIRST = (int)(0x80040120 - 0x100000000);
        /// <summary>
        /// No information avialable.
        /// </summary>
        public const int MARSHAL_E_LAST = (int)(0x8004012F - 0x100000000);
        /// <summary>
        /// No information avialable.
        /// </summary>
        public const int MARSHAL_S_FIRST = 0x00040120;
        /// <summary>
        /// No information avialable.
        /// </summary>
        public const int MARSHAL_S_LAST = 0x0004012F;
        /// <summary>
        /// No information avialable.
        /// </summary>
        public const int DATA_E_FIRST = (int)(0x80040130 - 0x100000000);
        /// <summary>
        /// No information avialable.
        /// </summary>
        public const int DATA_E_LAST = (int)(0x8004013F - 0x100000000);
        /// <summary>
        /// Data has same FORMATETC
        /// </summary>
        public const int DATA_S_FIRST = 0x00040130;
        /// <summary>
        /// No information avialable.
        /// </summary>
        public const int DATA_S_LAST = 0x0004013F;
        /// <summary>
        /// Error drawing view
        /// </summary>
        public const int VIEW_E_FIRST = (int)(0x80040140 - 0x100000000);
        /// <summary>
        /// No information avialable.
        /// </summary>
        public const int VIEW_E_LAST = (int)(0x8004014F - 0x100000000);
        /// <summary>
        /// View is already frozen
        /// </summary>
        public const int VIEW_S_FIRST = 0x00040140;
        /// <summary>
        /// No information avialable.
        /// </summary>
        public const int VIEW_S_LAST = 0x0004014F;
        /// <summary>
        /// Error drawing view
        /// </summary>
        public const int VIEW_E_DRAW = (int)(0x80040140 - 0x100000000);
        /// <summary>
        /// Could not read key from registry
        /// </summary>
        public const int REGDB_E_FIRST = (int)(0x80040150 - 0x100000000);
        /// <summary>
        /// No information avialable.
        /// </summary>
        public const int REGDB_E_LAST = (int)(0x8004015F - 0x100000000);
        /// <summary>
        /// No information avialable.
        /// </summary>
        public const int REGDB_S_FIRST = 0x00040150;
        /// <summary>
        /// No information avialable.
        /// </summary>
        public const int REGDB_S_LAST = 0x0004015F;
        /// <summary>
        /// Could not read key from registry
        /// </summary>
        public const int REGDB_E_READREGDB = (int)(0x80040150 - 0x100000000);
        /// <summary>
        /// Could not write key to registry
        /// </summary>
        public const int REGDB_E_WRITEREGDB = (int)(0x80040151 - 0x100000000);
        /// <summary>
        /// Could not find the key in the registry
        /// </summary>
        public const int REGDB_E_KEYMISSING = (int)(0x80040152 - 0x100000000);
        /// <summary>
        /// Invalid value for registry
        /// </summary>
        public const int REGDB_E_INVALIDVALUE = (int)(0x80040153 - 0x100000000);
        /// <summary>
        /// Class not registered
        /// </summary>
        public const int REGDB_E_CLASSNOTREG = (int)(0x80040154 - 0x100000000);
        /// <summary>
        /// Interface not registered
        /// </summary>
        public const int REGDB_E_IIDNOTREG = (int)(0x80040155 - 0x100000000);
        /// <summary>
        /// Threading model entry is not valid
        /// </summary>
        public const int REGDB_E_BADTHREADINGMODEL = (int)(0x80040156 - 0x100000000);
        /// <summary>
        /// CATID does not exist
        /// </summary>
        public const int CAT_E_FIRST = (int)(0x80040160 - 0x100000000);
        /// <summary>
        /// Description not found
        /// </summary>
        public const int CAT_E_LAST = (int)(0x80040161 - 0x100000000);
        /// <summary>
        /// CATID does not exist
        /// </summary>
        public const int CAT_E_CATIDNOEXIST = (int)(0x80040160 - 0x100000000);
        /// <summary>
        /// Description not found
        /// </summary>
        public const int CAT_E_NODESCRIPTION = (int)(0x80040161 - 0x100000000);
        /// <summary>
        /// No package in the software installation data in the Active Directory meets this criteria.
        /// </summary>
        public const int CS_E_FIRST = (int)(0x80040164 - 0x100000000);
        /// <summary>
        /// An error occurred in the software installation data in the Active Directory.
        /// </summary>
        public const int CS_E_LAST = (int)(0x8004016F - 0x100000000);
        /// <summary>
        /// No package in the software installation data in the Active Directory meets this criteria.
        /// </summary>
        public const int CS_E_PACKAGE_NOTFOUND = (int)(0x80040164 - 0x100000000);
        /// <summary>
        /// Deleting this will break the referential integrity of the software installation data in the Active Directory.
        /// </summary>
        public const int CS_E_NOT_DELETABLE = (int)(0x80040165 - 0x100000000);
        /// <summary>
        /// The CLSID was not found in the software installation data in the Active Directory.
        /// </summary>
        public const int CS_E_CLASS_NOTFOUND = (int)(0x80040166 - 0x100000000);
        /// <summary>
        /// The software installation data in the Active Directory is corrupt.
        /// </summary>
        public const int CS_E_INVALID_VERSION = (int)(0x80040167 - 0x100000000);
        /// <summary>
        /// There is no software installation data in the Active Directory.
        /// </summary>
        public const int CS_E_NO_CLASSSTORE = (int)(0x80040168 - 0x100000000);
        /// <summary>
        /// There is no software installation data object in the Active Directory.
        /// </summary>
        public const int CS_E_OBJECT_NOTFOUND = (int)(0x80040169 - 0x100000000);
        /// <summary>
        /// The software installation data object in the Active Directory already exists.
        /// </summary>
        public const int CS_E_OBJECT_ALREADY_EXISTS = (int)(0x8004016A - 0x100000000);
        /// <summary>
        /// The path to the software installation data in the Active Directory is not correct.
        /// </summary>
        public const int CS_E_INVALID_PATH = (int)(0x8004016B - 0x100000000);
        /// <summary>
        /// A network error interrupted the operation.
        /// </summary>
        public const int CS_E_NETWORK_ERROR = (int)(0x8004016C - 0x100000000);
        /// <summary>
        /// The size of this object exceeds the maximum size set by the Administrator.
        /// </summary>
        public const int CS_E_ADMIN_LIMIT_EXCEEDED = (int)(0x8004016D - 0x100000000);
        /// <summary>
        /// The schema for the software installation data in the Active Directory does not match the required schema.
        /// </summary>
        public const int CS_E_SCHEMA_MISMATCH = (int)(0x8004016E - 0x100000000);
        /// <summary>
        /// An error occurred in the software installation data in the Active Directory.
        /// </summary>
        public const int CS_E_INTERNAL_ERROR = (int)(0x8004016F - 0x100000000);
        /// <summary>
        /// Cache not updated
        /// </summary>
        public const int CACHE_E_FIRST = (int)(0x80040170 - 0x100000000);
        /// <summary>
        /// No information avialable.
        /// </summary>
        public const int CACHE_E_LAST = (int)(0x8004017F - 0x100000000);
        /// <summary>
        /// FORMATETC not supported
        /// </summary>
        public const int CACHE_S_FIRST = 0x00040170;
        /// <summary>
        /// No information avialable.
        /// </summary>
        public const int CACHE_S_LAST = 0x0004017F;
        /// <summary>
        /// Cache not updated
        /// </summary>
        public const int CACHE_E_NOCACHE_UPDATED = (int)(0x80040170 - 0x100000000);
        /// <summary>
        /// No verbs for OLE object
        /// </summary>
        public const int OLEOBJ_E_FIRST = (int)(0x80040180 - 0x100000000);
        /// <summary>
        /// No information avialable.
        /// </summary>
        public const int OLEOBJ_E_LAST = (int)(0x8004018F - 0x100000000);
        /// <summary>
        /// Invalid verb for OLE object
        /// </summary>
        public const int OLEOBJ_S_FIRST = 0x00040180;
        /// <summary>
        /// No information avialable.
        /// </summary>
        public const int OLEOBJ_S_LAST = 0x0004018F;
        /// <summary>
        /// No verbs for OLE object
        /// </summary>
        public const int OLEOBJ_E_NOVERBS = (int)(0x80040180 - 0x100000000);
        /// <summary>
        /// Invalid verb for OLE object
        /// </summary>
        public const int OLEOBJ_E_INVALIDVERB = (int)(0x80040181 - 0x100000000);
        /// <summary>
        /// No information avialable.
        /// </summary>
        public const int CLIENTSITE_E_FIRST = (int)(0x80040190 - 0x100000000);
        /// <summary>
        /// No information avialable.
        /// </summary>
        public const int CLIENTSITE_E_LAST = (int)(0x8004019F - 0x100000000);
        /// <summary>
        /// No information avialable.
        /// </summary>
        public const int CLIENTSITE_S_FIRST = 0x00040190;
        /// <summary>
        /// No information avialable.
        /// </summary>
        public const int CLIENTSITE_S_LAST = 0x0004019F;
        /// <summary>
        /// Undo is not available
        /// </summary>
        public const int INPLACE_E_NOTUNDOABLE = (int)(0x800401A0 - 0x100000000);
        /// <summary>
        /// Space for tools is not available
        /// </summary>
        public const int INPLACE_E_NOTOOLSPACE = (int)(0x800401A1 - 0x100000000);
        /// <summary>
        /// Undo is not available
        /// </summary>
        public const int INPLACE_E_FIRST = (int)(0x800401A0 - 0x100000000);
        /// <summary>
        /// No information avialable.
        /// </summary>
        public const int INPLACE_E_LAST = (int)(0x800401AF - 0x100000000);
        /// <summary>
        /// Message is too long; some of it had to be truncated before displaying
        /// </summary>
        public const int INPLACE_S_FIRST = 0x000401A0;
        /// <summary>
        /// No information avialable.
        /// </summary>
        public const int INPLACE_S_LAST = 0x000401AF;
        /// <summary>
        /// No information avialable.
        /// </summary>
        public const int ENUM_E_FIRST = (int)(0x800401B0 - 0x100000000);
        /// <summary>
        /// No information avialable.
        /// </summary>
        public const int ENUM_E_LAST = (int)(0x800401BF - 0x100000000);
        /// <summary>
        /// No information avialable.
        /// </summary>
        public const int ENUM_S_FIRST = 0x000401B0;
        /// <summary>
        /// No information avialable.
        /// </summary>
        public const int ENUM_S_LAST = 0x000401BF;
        /// <summary>
        /// OLESTREAM Get method failed
        /// </summary>
        public const int CONVERT10_E_FIRST = (int)(0x800401C0 - 0x100000000);
        /// <summary>
        /// No information avialable.
        /// </summary>
        public const int CONVERT10_E_LAST = (int)(0x800401CF - 0x100000000);
        /// <summary>
        /// Unable to convert OLESTREAM to IStorage
        /// </summary>
        public const int CONVERT10_S_FIRST = 0x000401C0;
        /// <summary>
        /// No information avialable.
        /// </summary>
        public const int CONVERT10_S_LAST = 0x000401CF;
        /// <summary>
        /// OLESTREAM Get method failed
        /// </summary>
        public const int CONVERT10_E_OLESTREAM_GET = (int)(0x800401C0 - 0x100000000);
        /// <summary>
        /// OLESTREAM Put method failed
        /// </summary>
        public const int CONVERT10_E_OLESTREAM_PUT = (int)(0x800401C1 - 0x100000000);
        /// <summary>
        /// Contents of the OLESTREAM not in correct format
        /// </summary>
        public const int CONVERT10_E_OLESTREAM_FMT = (int)(0x800401C2 - 0x100000000);
        /// <summary>
        /// There was an error in a Windows GDI call while converting the bitmap to a DIB
        /// </summary>
        public const int CONVERT10_E_OLESTREAM_BITMAP_TO_DIB = (int)(0x800401C3 - 0x100000000);
        /// <summary>
        /// Contents of the IStorage not in correct format
        /// </summary>
        public const int CONVERT10_E_STG_FMT = (int)(0x800401C4 - 0x100000000);
        /// <summary>
        /// Contents of IStorage is missing one of the standard streams
        /// </summary>
        public const int CONVERT10_E_STG_NO_STD_STREAM = (int)(0x800401C5 - 0x100000000);
        /// <summary>
        /// There was an error in a Windows GDI call while converting the DIB to a bitmap.
        /// </summary>
        public const int CONVERT10_E_STG_DIB_TO_BITMAP = (int)(0x800401C6 - 0x100000000);
        /// <summary>
        /// OpenClipboard Failed
        /// </summary>
        public const int CLIPBRD_E_FIRST = (int)(0x800401D0 - 0x100000000);
        /// <summary>
        /// No information avialable.
        /// </summary>
        public const int CLIPBRD_E_LAST = (int)(0x800401DF - 0x100000000);
        /// <summary>
        /// No information avialable.
        /// </summary>
        public const int CLIPBRD_S_FIRST = 0x000401D0;
        /// <summary>
        /// No information avialable.
        /// </summary>
        public const int CLIPBRD_S_LAST = 0x000401DF;
        /// <summary>
        /// OpenClipboard Failed
        /// </summary>
        public const int CLIPBRD_E_CANT_OPEN = (int)(0x800401D0 - 0x100000000);
        /// <summary>
        /// EmptyClipboard Failed
        /// </summary>
        public const int CLIPBRD_E_CANT_EMPTY = (int)(0x800401D1 - 0x100000000);
        /// <summary>
        /// SetClipboard Failed
        /// </summary>
        public const int CLIPBRD_E_CANT_SET = (int)(0x800401D2 - 0x100000000);
        /// <summary>
        /// Data on clipboard is invalid
        /// </summary>
        public const int CLIPBRD_E_BAD_DATA = (int)(0x800401D3 - 0x100000000);
        /// <summary>
        /// CloseClipboard Failed
        /// </summary>
        public const int CLIPBRD_E_CANT_CLOSE = (int)(0x800401D4 - 0x100000000);
        /// <summary>
        /// Moniker needs to be connected manually
        /// </summary>
        public const int MK_E_FIRST = (int)(0x800401E0 - 0x100000000);
        /// <summary>
        /// Moniker could not be enumerated
        /// </summary>
        public const int MK_E_LAST = (int)(0x800401EF - 0x100000000);
        /// <summary>
        /// No information avialable.
        /// </summary>
        public const int MK_S_FIRST = 0x000401E0;
        /// <summary>
        /// No information avialable.
        /// </summary>
        public const int MK_S_LAST = 0x000401EF;
        /// <summary>
        /// Moniker needs to be connected manually
        /// </summary>
        public const int MK_E_CONNECTMANUALLY = (int)(0x800401E0 - 0x100000000);
        /// <summary>
        /// Operation exceeded deadline
        /// </summary>
        public const int MK_E_EXCEEDEDDEADLINE = (int)(0x800401E1 - 0x100000000);
        /// <summary>
        /// Moniker needs to be generic
        /// </summary>
        public const int MK_E_NEEDGENERIC = (int)(0x800401E2 - 0x100000000);
        /// <summary>
        /// Operation unavailable
        /// </summary>
        public const int MK_E_UNAVAILABLE = (int)(0x800401E3 - 0x100000000);
        /// <summary>
        /// Invalid syntax
        /// </summary>
        public const int MK_E_SYNTAX = (int)(0x800401E4 - 0x100000000);
        /// <summary>
        /// No object for moniker
        /// </summary>
        public const int MK_E_NOOBJECT = (int)(0x800401E5 - 0x100000000);
        /// <summary>
        /// Bad extension for file
        /// </summary>
        public const int MK_E_INVALIDEXTENSION = (int)(0x800401E6 - 0x100000000);
        /// <summary>
        /// Intermediate operation failed
        /// </summary>
        public const int MK_E_INTERMEDIATEINTERFACENOTSUPPORTED = (int)(0x800401E7 - 0x100000000);
        /// <summary>
        /// Moniker is not bindable
        /// </summary>
        public const int MK_E_NOTBINDABLE = (int)(0x800401E8 - 0x100000000);
        /// <summary>
        /// Moniker is not bound
        /// </summary>
        public const int MK_E_NOTBOUND = (int)(0x800401E9 - 0x100000000);
        /// <summary>
        /// Moniker cannot open file
        /// </summary>
        public const int MK_E_CANTOPENFILE = (int)(0x800401EA - 0x100000000);
        /// <summary>
        /// User input required for operation to succeed
        /// </summary>
        public const int MK_E_MUSTBOTHERUSER = (int)(0x800401EB - 0x100000000);
        /// <summary>
        /// Moniker class has no inverse
        /// </summary>
        public const int MK_E_NOINVERSE = (int)(0x800401EC - 0x100000000);
        /// <summary>
        /// Moniker does not refer to storage
        /// </summary>
        public const int MK_E_NOSTORAGE = (int)(0x800401ED - 0x100000000);
        /// <summary>
        /// No common prefix
        /// </summary>
        public const int MK_E_NOPREFIX = (int)(0x800401EE - 0x100000000);
        /// <summary>
        /// Moniker could not be enumerated
        /// </summary>
        public const int MK_E_ENUMERATION_FAILED = (int)(0x800401EF - 0x100000000);
        /// <summary>
        /// CoInitialize has not been called.
        /// </summary>
        public const int CO_E_FIRST = (int)(0x800401F0 - 0x100000000);
        /// <summary>
        /// Object has been released
        /// </summary>
        public const int CO_E_LAST = (int)(0x800401FF - 0x100000000);
        /// <summary>
        /// No information avialable.
        /// </summary>
        public const int CO_S_FIRST = 0x000401F0;
        /// <summary>
        /// No information avialable.
        /// </summary>
        public const int CO_S_LAST = 0x000401FF;
        /// <summary>
        /// CoInitialize has not been called.
        /// </summary>
        public const int CO_E_NOTINITIALIZED = (int)(0x800401F0 - 0x100000000);
        /// <summary>
        /// CoInitialize has already been called.
        /// </summary>
        public const int CO_E_ALREADYINITIALIZED = (int)(0x800401F1 - 0x100000000);
        /// <summary>
        /// Class of object cannot be determined
        /// </summary>
        public const int CO_E_CANTDETERMINECLASS = (int)(0x800401F2 - 0x100000000);
        /// <summary>
        /// Invalid class string
        /// </summary>
        public const int CO_E_CLASSSTRING = (int)(0x800401F3 - 0x100000000);
        /// <summary>
        /// Invalid interface string
        /// </summary>
        public const int CO_E_IIDSTRING = (int)(0x800401F4 - 0x100000000);
        /// <summary>
        /// Application not found
        /// </summary>
        public const int CO_E_APPNOTFOUND = (int)(0x800401F5 - 0x100000000);
        /// <summary>
        /// Application cannot be run more than once
        /// </summary>
        public const int CO_E_APPSINGLEUSE = (int)(0x800401F6 - 0x100000000);
        /// <summary>
        /// Some error in application program
        /// </summary>
        public const int CO_E_ERRORINAPP = (int)(0x800401F7 - 0x100000000);
        /// <summary>
        /// DLL for class not found
        /// </summary>
        public const int CO_E_DLLNOTFOUND = (int)(0x800401F8 - 0x100000000);
        /// <summary>
        /// Error in the DLL
        /// </summary>
        public const int CO_E_ERRORINDLL = (int)(0x800401F9 - 0x100000000);
        /// <summary>
        /// Wrong OS or OS version for application
        /// </summary>
        public const int CO_E_WRONGOSFORAPP = (int)(0x800401FA - 0x100000000);
        /// <summary>
        /// Object is not registered
        /// </summary>
        public const int CO_E_OBJNOTREG = (int)(0x800401FB - 0x100000000);
        /// <summary>
        /// Object is already registered
        /// </summary>
        public const int CO_E_OBJISREG = (int)(0x800401FC - 0x100000000);
        /// <summary>
        /// Object is not connected to server
        /// </summary>
        public const int CO_E_OBJNOTCONNECTED = (int)(0x800401FD - 0x100000000);
        /// <summary>
        /// Application was launched but it didn't register a class factory
        /// </summary>
        public const int CO_E_APPDIDNTREG = (int)(0x800401FE - 0x100000000);
        /// <summary>
        /// Object has been released
        /// </summary>
        public const int CO_E_RELEASED = (int)(0x800401FF - 0x100000000);
        /// <summary>
        /// No information avialable.
        /// </summary>
        public const int EVENT_E_FIRST = (int)(0x80040200 - 0x100000000);
        /// <summary>
        /// No information avialable.
        /// </summary>
        public const int EVENT_E_LAST = (int)(0x8004021F - 0x100000000);
        /// <summary>
        /// An event was able to invoke some but not all of the subscribers
        /// </summary>
        public const int EVENT_S_FIRST = 0x00040200;
        /// <summary>
        /// No information avialable.
        /// </summary>
        public const int EVENT_S_LAST = 0x0004021F;
        /// <summary>
        /// An event was able to invoke some but not all of the subscribers
        /// </summary>
        public const int EVENT_S_SOME_SUBSCRIBERS_FAILED = 0x00040200;
        /// <summary>
        /// An event was unable to invoke any of the subscribers
        /// </summary>
        public const int EVENT_E_ALL_SUBSCRIBERS_FAILED = (int)(0x80040201 - 0x100000000);
        /// <summary>
        /// An event was delivered but there were no subscribers
        /// </summary>
        public const int EVENT_S_NOSUBSCRIBERS = 0x00040202;
        /// <summary>
        /// A syntax error occurred trying to evaluate a query string
        /// </summary>
        public const int EVENT_E_QUERYSYNTAX = (int)(0x80040203 - 0x100000000);
        /// <summary>
        /// An invalid field name was used in a query string
        /// </summary>
        public const int EVENT_E_QUERYFIELD = (int)(0x80040204 - 0x100000000);
        /// <summary>
        /// An unexpected exception was raised
        /// </summary>
        public const int EVENT_E_INTERNALEXCEPTION = (int)(0x80040205 - 0x100000000);
        /// <summary>
        /// An unexpected internal error was detected
        /// </summary>
        public const int EVENT_E_INTERNALERROR = (int)(0x80040206 - 0x100000000);
        /// <summary>
        /// The owner SID on a per-user subscription doesn't exist
        /// </summary>
        public const int EVENT_E_INVALID_PER_USER_SID = (int)(0x80040207 - 0x100000000);
        /// <summary>
        /// A user-supplied component or subscriber raised an exception
        /// </summary>
        public const int EVENT_E_USER_EXCEPTION = (int)(0x80040208 - 0x100000000);
        /// <summary>
        /// An interface has too many methods to fire events from
        /// </summary>
        public const int EVENT_E_TOO_MANY_METHODS = (int)(0x80040209 - 0x100000000);
        /// <summary>
        /// A subscription cannot be stored unless its event class already exists
        /// </summary>
        public const int EVENT_E_MISSING_EVENTCLASS = (int)(0x8004020A - 0x100000000);
        /// <summary>
        /// Not all the objects requested could be removed
        /// </summary>
        public const int EVENT_E_NOT_ALL_REMOVED = (int)(0x8004020B - 0x100000000);
        /// <summary>
        /// COM+ is required for this operation, but is not installed
        /// </summary>
        public const int EVENT_E_COMPLUS_NOT_INSTALLED = (int)(0x8004020C - 0x100000000);
        /// <summary>
        /// Cannot modify or delete an object that was not added using the COM+ Admin SDK
        /// </summary>
        public const int EVENT_E_CANT_MODIFY_OR_DELETE_UNCONFIGURED_OBJECT = (int)(0x8004020D - 0x100000000);
        /// <summary>
        /// Cannot modify or delete an object that was added using the COM+ Admin SDK
        /// </summary>
        public const int EVENT_E_CANT_MODIFY_OR_DELETE_CONFIGURED_OBJECT = (int)(0x8004020E - 0x100000000);
        /// <summary>
        /// The event class for this subscription is in an invalid partition
        /// </summary>
        public const int EVENT_E_INVALID_EVENT_CLASS_PARTITION = (int)(0x8004020F - 0x100000000);
        /// <summary>
        /// The owner of the PerUser subscription is not logged on to the system specified
        /// </summary>
        public const int EVENT_E_PER_USER_SID_NOT_LOGGED_ON = (int)(0x80040210 - 0x100000000);
        /// <summary>
        /// Another single phase resource manager has already been enlisted in this transaction.
        /// </summary>
        public const int XACT_E_FIRST = (int)(0x8004D000 - 0x100000000);
        /// <summary>
        /// The local transaction has aborted.
        /// </summary>
        public const int XACT_E_LAST = (int)(0x8004D029 - 0x100000000);
        /// <summary>
        /// An asynchronous operation was specified. The operation has begun, but its outcome is not known yet.
        /// </summary>
        public const int XACT_S_FIRST = 0x0004D000;
        /// <summary>
        /// The resource manager has requested to be the coordinator (last resource manager) for the transaction.
        /// </summary>
        public const int XACT_S_LAST = 0x0004D010;
        /// <summary>
        /// Another single phase resource manager has already been enlisted in this transaction.
        /// </summary>
        public const int XACT_E_ALREADYOTHERSINGLEPHASE = (int)(0x8004D000 - 0x100000000);
        /// <summary>
        /// A retaining commit or abort is not supported
        /// </summary>
        public const int XACT_E_CANTRETAIN = (int)(0x8004D001 - 0x100000000);
        /// <summary>
        /// The transaction failed to commit for an unknown reason. The transaction was aborted.
        /// </summary>
        public const int XACT_E_COMMITFAILED = (int)(0x8004D002 - 0x100000000);
        /// <summary>
        /// Cannot call commit on this transaction object because the calling application did not initiate the transaction.
        /// </summary>
        public const int XACT_E_COMMITPREVENTED = (int)(0x8004D003 - 0x100000000);
        /// <summary>
        /// Instead of committing, the resource heuristically aborted.
        /// </summary>
        public const int XACT_E_HEURISTICABORT = (int)(0x8004D004 - 0x100000000);
        /// <summary>
        /// Instead of aborting, the resource heuristically committed.
        /// </summary>
        public const int XACT_E_HEURISTICCOMMIT = (int)(0x8004D005 - 0x100000000);
        /// <summary>
        /// Some of the states of the resource were committed while others were aborted, likely because of heuristic decisions.
        /// </summary>
        public const int XACT_E_HEURISTICDAMAGE = (int)(0x8004D006 - 0x100000000);
        /// <summary>
        /// Some of the states of the resource may have been committed while others may have been aborted, likely because of heuristic decisions.
        /// </summary>
        public const int XACT_E_HEURISTICDANGER = (int)(0x8004D007 - 0x100000000);
        /// <summary>
        /// The requested isolation level is not valid or supported.
        /// </summary>
        public const int XACT_E_ISOLATIONLEVEL = (int)(0x8004D008 - 0x100000000);
        /// <summary>
        /// The transaction manager doesn't support an asynchronous operation for this method.
        /// </summary>
        public const int XACT_E_NOASYNC = (int)(0x8004D009 - 0x100000000);
        /// <summary>
        /// Unable to enlist in the transaction.
        /// </summary>
        public const int XACT_E_NOENLIST = (int)(0x8004D00A - 0x100000000);
        /// <summary>
        /// The requested semantics of retention of isolation across retaining commit and abort boundaries cannot be supported by this transaction implementation, or isoFlags was not equal to zero.
        /// </summary>
        public const int XACT_E_NOISORETAIN = (int)(0x8004D00B - 0x100000000);
        /// <summary>
        /// There is no resource presently associated with this enlistment
        /// </summary>
        public const int XACT_E_NORESOURCE = (int)(0x8004D00C - 0x100000000);
        /// <summary>
        /// The transaction failed to commit due to the failure of optimistic concurrency control in at least one of the resource managers.
        /// </summary>
        public const int XACT_E_NOTCURRENT = (int)(0x8004D00D - 0x100000000);
        /// <summary>
        /// The transaction has already been implicitly or explicitly committed or aborted
        /// </summary>
        public const int XACT_E_NOTRANSACTION = (int)(0x8004D00E - 0x100000000);
        /// <summary>
        /// An invalid combination of flags was specified
        /// </summary>
        public const int XACT_E_NOTSUPPORTED = (int)(0x8004D00F - 0x100000000);
        /// <summary>
        /// The resource manager id is not associated with this transaction or the transaction manager.
        /// </summary>
        public const int XACT_E_UNKNOWNRMGRID = (int)(0x8004D010 - 0x100000000);
        /// <summary>
        /// This method was called in the wrong state
        /// </summary>
        public const int XACT_E_WRONGSTATE = (int)(0x8004D011 - 0x100000000);
        /// <summary>
        /// The indicated unit of work does not match the unit of work expected by the resource manager.
        /// </summary>
        public const int XACT_E_WRONGUOW = (int)(0x8004D012 - 0x100000000);
        /// <summary>
        /// An enlistment in a transaction already exists.
        /// </summary>
        public const int XACT_E_XTIONEXISTS = (int)(0x8004D013 - 0x100000000);
        /// <summary>
        /// An import object for the transaction could not be found.
        /// </summary>
        public const int XACT_E_NOIMPORTOBJECT = (int)(0x8004D014 - 0x100000000);
        /// <summary>
        /// The transaction cookie is invalid.
        /// </summary>
        public const int XACT_E_INVALIDCOOKIE = (int)(0x8004D015 - 0x100000000);
        /// <summary>
        /// The transaction status is in doubt. A communication failure occurred, or a transaction manager or resource manager has failed
        /// </summary>
        public const int XACT_E_INDOUBT = (int)(0x8004D016 - 0x100000000);
        /// <summary>
        /// A time-out was specified, but time-outs are not supported.
        /// </summary>
        public const int XACT_E_NOTIMEOUT = (int)(0x8004D017 - 0x100000000);
        /// <summary>
        /// The requested operation is already in progress for the transaction.
        /// </summary>
        public const int XACT_E_ALREADYINPROGRESS = (int)(0x8004D018 - 0x100000000);
        /// <summary>
        /// The transaction has already been aborted.
        /// </summary>
        public const int XACT_E_ABORTED = (int)(0x8004D019 - 0x100000000);
        /// <summary>
        /// The Transaction Manager returned a log full error.
        /// </summary>
        public const int XACT_E_LOGFULL = (int)(0x8004D01A - 0x100000000);
        /// <summary>
        /// The Transaction Manager is not available.
        /// </summary>
        public const int XACT_E_TMNOTAVAILABLE = (int)(0x8004D01B - 0x100000000);
        /// <summary>
        /// A connection with the transaction manager was lost.
        /// </summary>
        public const int XACT_E_CONNECTION_DOWN = (int)(0x8004D01C - 0x100000000);
        /// <summary>
        /// A request to establish a connection with the transaction manager was denied.
        /// </summary>
        public const int XACT_E_CONNECTION_DENIED = (int)(0x8004D01D - 0x100000000);
        /// <summary>
        /// Resource manager reenlistment to determine transaction status timed out.
        /// </summary>
        public const int XACT_E_REENLISTTIMEOUT = (int)(0x8004D01E - 0x100000000);
        /// <summary>
        /// This transaction manager failed to establish a connection with another TIP transaction manager.
        /// </summary>
        public const int XACT_E_TIP_CONNECT_FAILED = (int)(0x8004D01F - 0x100000000);
        /// <summary>
        /// This transaction manager encountered a protocol error with another TIP transaction manager.
        /// </summary>
        public const int XACT_E_TIP_PROTOCOL_ERROR = (int)(0x8004D020 - 0x100000000);
        /// <summary>
        /// This transaction manager could not propagate a transaction from another TIP transaction manager.
        /// </summary>
        public const int XACT_E_TIP_PULL_FAILED = (int)(0x8004D021 - 0x100000000);
        /// <summary>
        /// The Transaction Manager on the destination machine is not available.
        /// </summary>
        public const int XACT_E_DEST_TMNOTAVAILABLE = (int)(0x8004D022 - 0x100000000);
        /// <summary>
        /// The Transaction Manager has disabled its support for TIP.
        /// </summary>
        public const int XACT_E_TIP_DISABLED = (int)(0x8004D023 - 0x100000000);
        /// <summary>
        /// The transaction manager has disabled its support for remote/network transactions.
        /// </summary>
        public const int XACT_E_NETWORK_TX_DISABLED = (int)(0x8004D024 - 0x100000000);
        /// <summary>
        /// The partner transaction manager has disabled its support for remote/network transactions.
        /// </summary>
        public const int XACT_E_PARTNER_NETWORK_TX_DISABLED = (int)(0x8004D025 - 0x100000000);
        /// <summary>
        /// The transaction manager has disabled its support for XA transactions.
        /// </summary>
        public const int XACT_E_XA_TX_DISABLED = (int)(0x8004D026 - 0x100000000);
        /// <summary>
        /// MSDTC was unable to read its configuration information.
        /// </summary>
        public const int XACT_E_UNABLE_TO_READ_DTC_CONFIG = (int)(0x8004D027 - 0x100000000);
        /// <summary>
        /// MSDTC was unable to load the dtc proxy dll.
        /// </summary>
        public const int XACT_E_UNABLE_TO_LOAD_DTC_PROXY = (int)(0x8004D028 - 0x100000000);
        /// <summary>
        /// The local transaction has aborted.
        /// </summary>
        public const int XACT_E_ABORTING = (int)(0x8004D029 - 0x100000000);
        /// <summary>
        /// XACT_E_CLERKNOTFOUND
        /// </summary>
        public const int XACT_E_CLERKNOTFOUND = (int)(0x8004D080 - 0x100000000);
        /// <summary>
        /// XACT_E_CLERKEXISTS
        /// </summary>
        public const int XACT_E_CLERKEXISTS = (int)(0x8004D081 - 0x100000000);
        /// <summary>
        /// XACT_E_RECOVERYINPROGRESS
        /// </summary>
        public const int XACT_E_RECOVERYINPROGRESS = (int)(0x8004D082 - 0x100000000);
        /// <summary>
        /// XACT_E_TRANSACTIONCLOSED
        /// </summary>
        public const int XACT_E_TRANSACTIONCLOSED = (int)(0x8004D083 - 0x100000000);
        /// <summary>
        /// XACT_E_INVALIDLSN
        /// </summary>
        public const int XACT_E_INVALIDLSN = (int)(0x8004D084 - 0x100000000);
        /// <summary>
        /// XACT_E_REPLAYREQUEST
        /// </summary>
        public const int XACT_E_REPLAYREQUEST = (int)(0x8004D085 - 0x100000000);
        /// <summary>
        /// An asynchronous operation was specified. The operation has begun, but its outcome is not known yet.
        /// </summary>
        public const int XACT_S_ASYNC = 0x0004D000;
        /// <summary>
        /// XACT_S_DEFECT
        /// </summary>
        public const int XACT_S_DEFECT = 0x0004D001;
        /// <summary>
        /// The method call succeeded because the transaction was read-only.
        /// </summary>
        public const int XACT_S_READONLY = 0x0004D002;
        /// <summary>
        /// The transaction was successfully aborted. However, this is a coordinated transaction, and some number of enlisted resources were aborted outright because they could not support abort-retaining semantics
        /// </summary>
        public const int XACT_S_SOMENORETAIN = 0x0004D003;
        /// <summary>
        /// No changes were made during this call, but the sink wants another chance to look if any other sinks make further changes.
        /// </summary>
        public const int XACT_S_OKINFORM = 0x0004D004;
        /// <summary>
        /// The sink is content and wishes the transaction to proceed. Changes were made to one or more resources during this call.
        /// </summary>
        public const int XACT_S_MADECHANGESCONTENT = 0x0004D005;
        /// <summary>
        /// The sink is for the moment and wishes the transaction to proceed, but if other changes are made following this return by other event sinks then this sink wants another chance to look
        /// </summary>
        public const int XACT_S_MADECHANGESINFORM = 0x0004D006;
        /// <summary>
        /// The transaction was successfully aborted. However, the abort was non-retaining.
        /// </summary>
        public const int XACT_S_ALLNORETAIN = 0x0004D007;
        /// <summary>
        /// An abort operation was already in progress.
        /// </summary>
        public const int XACT_S_ABORTING = 0x0004D008;
        /// <summary>
        /// The resource manager has performed a single-phase commit of the transaction.
        /// </summary>
        public const int XACT_S_SINGLEPHASE = 0x0004D009;
        /// <summary>
        /// The local transaction has not aborted.
        /// </summary>
        public const int XACT_S_LOCALLY_OK = 0x0004D00A;
        /// <summary>
        /// The resource manager has requested to be the coordinator (last resource manager) for the transaction.
        /// </summary>
        public const int XACT_S_LASTRESOURCEMANAGER = 0x0004D010;
        /// <summary>
        /// No information avialable.
        /// </summary>
        public const int CONTEXT_E_FIRST = (int)(0x8004E000 - 0x100000000);
        /// <summary>
        /// The TxIsolation Level property for the COM+ component being created is stronger than the TxIsolationLevel for the "root" component for the transaction.  The creation failed.
        /// </summary>
        public const int CONTEXT_E_LAST = (int)(0x8004E02F - 0x100000000);
        /// <summary>
        /// No information avialable.
        /// </summary>
        public const int CONTEXT_S_FIRST = 0x0004E000;
        /// <summary>
        /// No information avialable.
        /// </summary>
        public const int CONTEXT_S_LAST = 0x0004E02F;
        /// <summary>
        /// The root transaction wanted to commit, but transaction aborted
        /// </summary>
        public const int CONTEXT_E_ABORTED = (int)(0x8004E002 - 0x100000000);
        /// <summary>
        /// You made a method call on a COM+ component that has a transaction that has already aborted or in the process of aborting.
        /// </summary>
        public const int CONTEXT_E_ABORTING = (int)(0x8004E003 - 0x100000000);
        /// <summary>
        /// There is no MTS object context
        /// </summary>
        public const int CONTEXT_E_NOCONTEXT = (int)(0x8004E004 - 0x100000000);
        /// <summary>
        /// No information avialable.
        /// </summary>
        public const int CONTEXT_E_WOULD_DEADLOCK = (int)(0x8004E005 - 0x100000000);
        /// <summary>
        /// The component is configured to use synchronization and a thread has timed out waiting to enter the context.
        /// </summary>
        public const int CONTEXT_E_SYNCH_TIMEOUT = (int)(0x8004E006 - 0x100000000);
        /// <summary>
        /// You made a method call on a COM+ component that has a transaction that has already committed or aborted.
        /// </summary>
        public const int CONTEXT_E_OLDREF = (int)(0x8004E007 - 0x100000000);
        /// <summary>
        /// The specified role was not configured for the application
        /// </summary>
        public const int CONTEXT_E_ROLENOTFOUND = (int)(0x8004E00C - 0x100000000);
        /// <summary>
        /// COM+ was unable to talk to the Microsoft Distributed Transaction Coordinator
        /// </summary>
        public const int CONTEXT_E_TMNOTAVAILABLE = (int)(0x8004E00F - 0x100000000);
        /// <summary>
        /// An unexpected error occurred during COM+ Activation.
        /// </summary>
        public const int CO_E_ACTIVATIONFAILED = (int)(0x8004E021 - 0x100000000);
        /// <summary>
        /// COM+ Activation failed. Check the event log for more information
        /// </summary>
        public const int CO_E_ACTIVATIONFAILED_EVENTLOGGED = (int)(0x8004E022 - 0x100000000);
        /// <summary>
        /// COM+ Activation failed due to a catalog or configuration error.
        /// </summary>
        public const int CO_E_ACTIVATIONFAILED_CATALOGERROR = (int)(0x8004E023 - 0x100000000);
        /// <summary>
        /// COM+ activation failed because the activation could not be completed in the specified amount of time.
        /// </summary>
        public const int CO_E_ACTIVATIONFAILED_TIMEOUT = (int)(0x8004E024 - 0x100000000);
        /// <summary>
        /// COM+ Activation failed because an initialization function failed.  Check the event log for more information.
        /// </summary>
        public const int CO_E_INITIALIZATIONFAILED = (int)(0x8004E025 - 0x100000000);
        /// <summary>
        /// The requested operation requires that JIT be in the current context and it is not
        /// </summary>
        public const int CONTEXT_E_NOJIT = (int)(0x8004E026 - 0x100000000);
        /// <summary>
        /// The requested operation requires that the current context have a Transaction, and it does not
        /// </summary>
        public const int CONTEXT_E_NOTRANSACTION = (int)(0x8004E027 - 0x100000000);
        /// <summary>
        /// The components threading model has changed after install into a COM+ Application.  Please re-install component.
        /// </summary>
        public const int CO_E_THREADINGMODEL_CHANGED = (int)(0x8004E028 - 0x100000000);
        /// <summary>
        /// IIS intrinsics not available.  Start your work with IIS.
        /// </summary>
        public const int CO_E_NOIISINTRINSICS = (int)(0x8004E029 - 0x100000000);
        /// <summary>
        /// An attempt to write a cookie failed.
        /// </summary>
        public const int CO_E_NOCOOKIES = (int)(0x8004E02A - 0x100000000);
        /// <summary>
        /// An attempt to use a database generated a database specific error.
        /// </summary>
        public const int CO_E_DBERROR = (int)(0x8004E02B - 0x100000000);
        /// <summary>
        /// The COM+ component you created must use object pooling to work.
        /// </summary>
        public const int CO_E_NOTPOOLED = (int)(0x8004E02C - 0x100000000);
        /// <summary>
        /// The COM+ component you created must use object construction to work correctly.
        /// </summary>
        public const int CO_E_NOTCONSTRUCTED = (int)(0x8004E02D - 0x100000000);
        /// <summary>
        /// The COM+ component requires synchronization, and it is not configured for it.
        /// </summary>
        public const int CO_E_NOSYNCHRONIZATION = (int)(0x8004E02E - 0x100000000);
        /// <summary>
        /// The TxIsolation Level property for the COM+ component being created is stronger than the TxIsolationLevel for the "root" component for the transaction.  The creation failed.
        /// </summary>
        public const int CO_E_ISOLEVELMISMATCH = (int)(0x8004E02F - 0x100000000);
        /// <summary>
        /// Use the registry database to provide the requested information
        /// </summary>
        public const int OLE_S_USEREG = 0x00040000;
        /// <summary>
        /// Success, but static
        /// </summary>
        public const int OLE_S_STATIC = 0x00040001;
        /// <summary>
        /// Macintosh clipboard format
        /// </summary>
        public const int OLE_S_MAC_CLIPFORMAT = 0x00040002;
        /// <summary>
        /// Successful drop took place
        /// </summary>
        public const int DRAGDROP_S_DROP = 0x00040100;
        /// <summary>
        /// Drag-drop operation canceled
        /// </summary>
        public const int DRAGDROP_S_CANCEL = 0x00040101;
        /// <summary>
        /// Use the default cursor
        /// </summary>
        public const int DRAGDROP_S_USEDEFAULTCURSORS = 0x00040102;
        /// <summary>
        /// Data has same FORMATETC
        /// </summary>
        public const int DATA_S_SAMEFORMATETC = 0x00040130;
        /// <summary>
        /// View is already frozen
        /// </summary>
        public const int VIEW_S_ALREADY_FROZEN = 0x00040140;
        /// <summary>
        /// FORMATETC not supported
        /// </summary>
        public const int CACHE_S_FORMATETC_NOTSUPPORTED = 0x00040170;
        /// <summary>
        /// Same cache
        /// </summary>
        public const int CACHE_S_SAMECACHE = 0x00040171;
        /// <summary>
        /// Some cache(s) not updated
        /// </summary>
        public const int CACHE_S_SOMECACHES_NOTUPDATED = 0x00040172;
        /// <summary>
        /// Invalid verb for OLE object
        /// </summary>
        public const int OLEOBJ_S_INVALIDVERB = 0x00040180;
        /// <summary>
        /// Verb number is valid but verb cannot be done now
        /// </summary>
        public const int OLEOBJ_S_CANNOT_DOVERB_NOW = 0x00040181;
        /// <summary>
        /// Invalid window handle passed
        /// </summary>
        public const int OLEOBJ_S_INVALIDHWND = 0x00040182;
        /// <summary>
        /// Message is too long; some of it had to be truncated before displaying
        /// </summary>
        public const int INPLACE_S_TRUNCATED = 0x000401A0;
        /// <summary>
        /// Unable to convert OLESTREAM to IStorage
        /// </summary>
        public const int CONVERT10_S_NO_PRESENTATION = 0x000401C0;
        /// <summary>
        /// Moniker reduced to itself
        /// </summary>
        public const int MK_S_REDUCED_TO_SELF = 0x000401E2;
        /// <summary>
        /// Common prefix is this moniker
        /// </summary>
        public const int MK_S_ME = 0x000401E4;
        /// <summary>
        /// Common prefix is input moniker
        /// </summary>
        public const int MK_S_HIM = 0x000401E5;
        /// <summary>
        /// Common prefix is both monikers
        /// </summary>
        public const int MK_S_US = 0x000401E6;
        /// <summary>
        /// Moniker is already registered in running object table
        /// </summary>
        public const int MK_S_MONIKERALREADYREGISTERED = 0x000401E7;
        /// <summary>
        /// The task is ready to run at its next scheduled time.
        /// </summary>
        public const int SCHED_S_TASK_READY = 0x00041300;
        /// <summary>
        /// The task is currently running.
        /// </summary>
        public const int SCHED_S_TASK_RUNNING = 0x00041301;
        /// <summary>
        /// The task will not run at the scheduled times because it has been disabled.
        /// </summary>
        public const int SCHED_S_TASK_DISABLED = 0x00041302;
        /// <summary>
        /// The task has not yet run.
        /// </summary>
        public const int SCHED_S_TASK_HAS_NOT_RUN = 0x00041303;
        /// <summary>
        /// There are no more runs scheduled for this task.
        /// </summary>
        public const int SCHED_S_TASK_NO_MORE_RUNS = 0x00041304;
        /// <summary>
        /// One or more of the properties that are needed to run this task on a schedule have not been set.
        /// </summary>
        public const int SCHED_S_TASK_NOT_SCHEDULED = 0x00041305;
        /// <summary>
        /// The last run of the task was terminated by the user.
        /// </summary>
        public const int SCHED_S_TASK_TERMINATED = 0x00041306;
        /// <summary>
        /// Either the task has no triggers or the existing triggers are disabled or not set.
        /// </summary>
        public const int SCHED_S_TASK_NO_VALID_TRIGGERS = 0x00041307;
        /// <summary>
        /// Event triggers don't have set run times.
        /// </summary>
        public const int SCHED_S_EVENT_TRIGGER = 0x00041308;
        /// <summary>
        /// Trigger not found.
        /// </summary>
        public const int SCHED_E_TRIGGER_NOT_FOUND = (int)(0x80041309 - 0x100000000);
        /// <summary>
        /// One or more of the properties that are needed to run this task have not been set.
        /// </summary>
        public const int SCHED_E_TASK_NOT_READY = (int)(0x8004130A - 0x100000000);
        /// <summary>
        /// There is no running instance of the task to terminate.
        /// </summary>
        public const int SCHED_E_TASK_NOT_RUNNING = (int)(0x8004130B - 0x100000000);
        /// <summary>
        /// The Task Scheduler Service is not installed on this computer.
        /// </summary>
        public const int SCHED_E_SERVICE_NOT_INSTALLED = (int)(0x8004130C - 0x100000000);
        /// <summary>
        /// The task object could not be opened.
        /// </summary>
        public const int SCHED_E_CANNOT_OPEN_TASK = (int)(0x8004130D - 0x100000000);
        /// <summary>
        /// The object is either an invalid task object or is not a task object.
        /// </summary>
        public const int SCHED_E_INVALID_TASK = (int)(0x8004130E - 0x100000000);
        /// <summary>
        /// No account information could be found in the Task Scheduler security database for the task indicated.
        /// </summary>
        public const int SCHED_E_ACCOUNT_INFORMATION_NOT_SET = (int)(0x8004130F - 0x100000000);
        /// <summary>
        /// Unable to establish existence of the account specified.
        /// </summary>
        public const int SCHED_E_ACCOUNT_NAME_NOT_FOUND = (int)(0x80041310 - 0x100000000);
        /// <summary>
        /// Corruption was detected in the Task Scheduler security database; the database has been reset.
        /// </summary>
        public const int SCHED_E_ACCOUNT_DBASE_CORRUPT = (int)(0x80041311 - 0x100000000);
        /// <summary>
        /// Task Scheduler security services are available only on Windows NT.
        /// </summary>
        public const int SCHED_E_NO_SECURITY_SERVICES = (int)(0x80041312 - 0x100000000);
        /// <summary>
        /// The task object version is either unsupported or invalid.
        /// </summary>
        public const int SCHED_E_UNKNOWN_OBJECT_VERSION = (int)(0x80041313 - 0x100000000);
        /// <summary>
        /// The task has been configured with an unsupported combination of account settings and run time options.
        /// </summary>
        public const int SCHED_E_UNSUPPORTED_ACCOUNT_OPTION = (int)(0x80041314 - 0x100000000);
        /// <summary>
        /// The Task Scheduler Service is not running.
        /// </summary>
        public const int SCHED_E_SERVICE_NOT_RUNNING = (int)(0x80041315 - 0x100000000);
        /// <summary>
        /// Attempt to create a class object failed
        /// </summary>
        public const int CO_E_CLASS_CREATE_FAILED = (int)(0x80080001 - 0x100000000);
        /// <summary>
        /// OLE service could not bind object
        /// </summary>
        public const int CO_E_SCM_ERROR = (int)(0x80080002 - 0x100000000);
        /// <summary>
        /// RPC communication failed with OLE service
        /// </summary>
        public const int CO_E_SCM_RPC_FAILURE = (int)(0x80080003 - 0x100000000);
        /// <summary>
        /// Bad path to object
        /// </summary>
        public const int CO_E_BAD_PATH = (int)(0x80080004 - 0x100000000);
        /// <summary>
        /// Server execution failed
        /// </summary>
        public const int CO_E_SERVER_EXEC_FAILURE = (int)(0x80080005 - 0x100000000);
        /// <summary>
        /// OLE service could not communicate with the object server
        /// </summary>
        public const int CO_E_OBJSRV_RPC_FAILURE = (int)(0x80080006 - 0x100000000);
        /// <summary>
        /// Moniker path could not be normalized
        /// </summary>
        public const int MK_E_NO_NORMALIZED = (int)(0x80080007 - 0x100000000);
        /// <summary>
        /// Object server is stopping when OLE service contacts it
        /// </summary>
        public const int CO_E_SERVER_STOPPING = (int)(0x80080008 - 0x100000000);
        /// <summary>
        /// An invalid root block pointer was specified
        /// </summary>
        public const int MEM_E_INVALID_ROOT = (int)(0x80080009 - 0x100000000);
        /// <summary>
        /// An allocation chain contained an invalid link pointer
        /// </summary>
        public const int MEM_E_INVALID_LINK = (int)(0x80080010 - 0x100000000);
        /// <summary>
        /// The requested allocation size was too large
        /// </summary>
        public const int MEM_E_INVALID_SIZE = (int)(0x80080011 - 0x100000000);
        /// <summary>
        /// Not all the requested interfaces were available
        /// </summary>
        public const int CO_S_NOTALLINTERFACES = 0x00080012;
        /// <summary>
        /// The specified machine name was not found in the cache.
        /// </summary>
        public const int CO_S_MACHINENAMENOTFOUND = 0x00080013;
        /// <summary>
        /// Unknown interface.
        /// </summary>
        public const int DISP_E_UNKNOWNINTERFACE = (int)(0x80020001 - 0x100000000);
        /// <summary>
        /// Member not found.
        /// </summary>
        public const int DISP_E_MEMBERNOTFOUND = (int)(0x80020003 - 0x100000000);
        /// <summary>
        /// Parameter not found.
        /// </summary>
        public const int DISP_E_PARAMNOTFOUND = (int)(0x80020004 - 0x100000000);
        /// <summary>
        /// Type mismatch.
        /// </summary>
        public const int DISP_E_TYPEMISMATCH = (int)(0x80020005 - 0x100000000);
        /// <summary>
        /// Unknown name.
        /// </summary>
        public const int DISP_E_UNKNOWNNAME = (int)(0x80020006 - 0x100000000);
        /// <summary>
        /// No named arguments.
        /// </summary>
        public const int DISP_E_NONAMEDARGS = (int)(0x80020007 - 0x100000000);
        /// <summary>
        /// Bad variable type.
        /// </summary>
        public const int DISP_E_BADVARTYPE = (int)(0x80020008 - 0x100000000);
        /// <summary>
        /// Exception occurred.
        /// </summary>
        public const int DISP_E_EXCEPTION = (int)(0x80020009 - 0x100000000);
        /// <summary>
        /// Out of present range.
        /// </summary>
        public const int DISP_E_OVERFLOW = (int)(0x8002000A - 0x100000000);
        /// <summary>
        /// Invalid index.
        /// </summary>
        public const int DISP_E_BADINDEX = (int)(0x8002000B - 0x100000000);
        /// <summary>
        /// Unknown language.
        /// </summary>
        public const int DISP_E_UNKNOWNLCID = (int)(0x8002000C - 0x100000000);
        /// <summary>
        /// Memory is locked.
        /// </summary>
        public const int DISP_E_ARRAYISLOCKED = (int)(0x8002000D - 0x100000000);
        /// <summary>
        /// Invalid number of parameters.
        /// </summary>
        public const int DISP_E_BADPARAMCOUNT = (int)(0x8002000E - 0x100000000);
        /// <summary>
        /// Parameter not optional.
        /// </summary>
        public const int DISP_E_PARAMNOTOPTIONAL = (int)(0x8002000F - 0x100000000);
        /// <summary>
        /// Invalid callee.
        /// </summary>
        public const int DISP_E_BADCALLEE = (int)(0x80020010 - 0x100000000);
        /// <summary>
        /// Does not support a collection.
        /// </summary>
        public const int DISP_E_NOTACOLLECTION = (int)(0x80020011 - 0x100000000);
        /// <summary>
        /// Division by zero.
        /// </summary>
        public const int DISP_E_DIVBYZERO = (int)(0x80020012 - 0x100000000);
        /// <summary>
        /// Buffer too small
        /// </summary>
        public const int DISP_E_BUFFERTOOSMALL = (int)(0x80020013 - 0x100000000);
        /// <summary>
        /// Buffer too small.
        /// </summary>
        public const int TYPE_E_BUFFERTOOSMALL = (int)(0x80028016 - 0x100000000);
        /// <summary>
        /// Field name not defined in the record.
        /// </summary>
        public const int TYPE_E_FIELDNOTFOUND = (int)(0x80028017 - 0x100000000);
        /// <summary>
        /// Old format or invalid type library.
        /// </summary>
        public const int TYPE_E_INVDATAREAD = (int)(0x80028018 - 0x100000000);
        /// <summary>
        /// Old format or invalid type library.
        /// </summary>
        public const int TYPE_E_UNSUPFORMAT = (int)(0x80028019 - 0x100000000);
        /// <summary>
        /// Error accessing the OLE registry.
        /// </summary>
        public const int TYPE_E_REGISTRYACCESS = (int)(0x8002801C - 0x100000000);
        /// <summary>
        /// Library not registered.
        /// </summary>
        public const int TYPE_E_LIBNOTREGISTERED = (int)(0x8002801D - 0x100000000);
        /// <summary>
        /// Bound to unknown type.
        /// </summary>
        public const int TYPE_E_UNDEFINEDTYPE = (int)(0x80028027 - 0x100000000);
        /// <summary>
        /// Qualified name disallowed.
        /// </summary>
        public const int TYPE_E_QUALIFIEDNAMEDISALLOWED = (int)(0x80028028 - 0x100000000);
        /// <summary>
        /// Invalid forward reference, or reference to uncompiled type.
        /// </summary>
        public const int TYPE_E_INVALIDSTATE = (int)(0x80028029 - 0x100000000);
        /// <summary>
        /// Type mismatch.
        /// </summary>
        public const int TYPE_E_WRONGTYPEKIND = (int)(0x8002802A - 0x100000000);
        /// <summary>
        /// Element not found.
        /// </summary>
        public const int TYPE_E_ELEMENTNOTFOUND = (int)(0x8002802B - 0x100000000);
        /// <summary>
        /// Ambiguous name.
        /// </summary>
        public const int TYPE_E_AMBIGUOUSNAME = (int)(0x8002802C - 0x100000000);
        /// <summary>
        /// Name already exists in the library.
        /// </summary>
        public const int TYPE_E_NAMECONFLICT = (int)(0x8002802D - 0x100000000);
        /// <summary>
        /// Unknown LCID.
        /// </summary>
        public const int TYPE_E_UNKNOWNLCID = (int)(0x8002802E - 0x100000000);
        /// <summary>
        /// Function not defined in specified DLL.
        /// </summary>
        public const int TYPE_E_DLLFUNCTIONNOTFOUND = (int)(0x8002802F - 0x100000000);
        /// <summary>
        /// Wrong module kind for the operation.
        /// </summary>
        public const int TYPE_E_BADMODULEKIND = (int)(0x800288BD - 0x100000000);
        /// <summary>
        /// Size may not exceed 64K.
        /// </summary>
        public const int TYPE_E_SIZETOOBIG = (int)(0x800288C5 - 0x100000000);
        /// <summary>
        /// Duplicate ID in inheritance hierarchy.
        /// </summary>
        public const int TYPE_E_DUPLICATEID = (int)(0x800288C6 - 0x100000000);
        /// <summary>
        /// Incorrect inheritance depth in standard OLE hmember.
        /// </summary>
        public const int TYPE_E_INVALIDID = (int)(0x800288CF - 0x100000000);
        /// <summary>
        /// Type mismatch.
        /// </summary>
        public const int TYPE_E_TYPEMISMATCH = (int)(0x80028CA0 - 0x100000000);
        /// <summary>
        /// Invalid number of arguments.
        /// </summary>
        public const int TYPE_E_OUTOFBOUNDS = (int)(0x80028CA1 - 0x100000000);
        /// <summary>
        /// I/O Error.
        /// </summary>
        public const int TYPE_E_IOERROR = (int)(0x80028CA2 - 0x100000000);
        /// <summary>
        /// Error creating unique tmp file.
        /// </summary>
        public const int TYPE_E_CANTCREATETMPFILE = (int)(0x80028CA3 - 0x100000000);
        /// <summary>
        /// Error loading type library/DLL.
        /// </summary>
        public const int TYPE_E_CANTLOADLIBRARY = (int)(0x80029C4A - 0x100000000);
        /// <summary>
        /// Inconsistent property functions.
        /// </summary>
        public const int TYPE_E_INCONSISTENTPROPFUNCS = (int)(0x80029C83 - 0x100000000);
        /// <summary>
        /// Circular dependency between types/modules.
        /// </summary>
        public const int TYPE_E_CIRCULARTYPE = (int)(0x80029C84 - 0x100000000);
        /// <summary>
        /// Unable to perform requested operation.
        /// </summary>
        public const int STG_E_INVALIDFUNCTION = (int)(0x80030001 - 0x100000000);
        /// <summary>
        /// %1 could not be found.
        /// </summary>
        public const int STG_E_FILENOTFOUND = (int)(0x80030002 - 0x100000000);
        /// <summary>
        /// The path %1 could not be found.
        /// </summary>
        public const int STG_E_PATHNOTFOUND = (int)(0x80030003 - 0x100000000);
        /// <summary>
        /// There are insufficient resources to open another file.
        /// </summary>
        public const int STG_E_TOOMANYOPENFILES = (int)(0x80030004 - 0x100000000);
        /// <summary>
        /// Access Denied.
        /// </summary>
        public const int STG_E_ACCESSDENIED = (int)(0x80030005 - 0x100000000);
        /// <summary>
        /// Attempted an operation on an invalid object.
        /// </summary>
        public const int STG_E_INVALIDHANDLE = (int)(0x80030006 - 0x100000000);
        /// <summary>
        /// There is insufficient memory available to complete operation.
        /// </summary>
        public const int STG_E_INSUFFICIENTMEMORY = (int)(0x80030008 - 0x100000000);
        /// <summary>
        /// Invalid pointer error.
        /// </summary>
        public const int STG_E_INVALIDPOINTER = (int)(0x80030009 - 0x100000000);
        /// <summary>
        /// There are no more entries to return.
        /// </summary>
        public const int STG_E_NOMOREFILES = (int)(0x80030012 - 0x100000000);
        /// <summary>
        /// Disk is write-protected.
        /// </summary>
        public const int STG_E_DISKISWRITEPROTECTED = (int)(0x80030013 - 0x100000000);
        /// <summary>
        /// An error occurred during a seek operation.
        /// </summary>
        public const int STG_E_SEEKERROR = (int)(0x80030019 - 0x100000000);
        /// <summary>
        /// A disk error occurred during a write operation.
        /// </summary>
        public const int STG_E_WRITEFAULT = (int)(0x8003001D - 0x100000000);
        /// <summary>
        /// A disk error occurred during a read operation.
        /// </summary>
        public const int STG_E_READFAULT = (int)(0x8003001E - 0x100000000);
        /// <summary>
        /// A share violation has occurred.
        /// </summary>
        public const int STG_E_SHAREVIOLATION = (int)(0x80030020 - 0x100000000);
        /// <summary>
        /// A lock violation has occurred.
        /// </summary>
        public const int STG_E_LOCKVIOLATION = (int)(0x80030021 - 0x100000000);
        /// <summary>
        /// %1 already exists.
        /// </summary>
        public const int STG_E_FILEALREADYEXISTS = (int)(0x80030050 - 0x100000000);
        /// <summary>
        /// Invalid parameter error.
        /// </summary>
        public const int STG_E_INVALIDPARAMETER = (int)(0x80030057 - 0x100000000);
        /// <summary>
        /// There is insufficient disk space to complete operation.
        /// </summary>
        public const int STG_E_MEDIUMFULL = (int)(0x80030070 - 0x100000000);
        /// <summary>
        /// Illegal write of non-simple property to simple property set.
        /// </summary>
        public const int STG_E_PROPSETMISMATCHED = (int)(0x800300F0 - 0x100000000);
        /// <summary>
        /// An API call exited abnormally.
        /// </summary>
        public const int STG_E_ABNORMALAPIEXIT = (int)(0x800300FA - 0x100000000);
        /// <summary>
        /// The file %1 is not a valid compound file.
        /// </summary>
        public const int STG_E_INVALIDHEADER = (int)(0x800300FB - 0x100000000);
        /// <summary>
        /// The name %1 is not valid.
        /// </summary>
        public const int STG_E_INVALIDNAME = (int)(0x800300FC - 0x100000000);
        /// <summary>
        /// An unexpected error occurred.
        /// </summary>
        public const int STG_E_UNKNOWN = (int)(0x800300FD - 0x100000000);
        /// <summary>
        /// That function is not implemented.
        /// </summary>
        public const int STG_E_UNIMPLEMENTEDFUNCTION = (int)(0x800300FE - 0x100000000);
        /// <summary>
        /// Invalid flag error.
        /// </summary>
        public const int STG_E_INVALIDFLAG = (int)(0x800300FF - 0x100000000);
        /// <summary>
        /// Attempted to use an object that is busy.
        /// </summary>
        public const int STG_E_INUSE = (int)(0x80030100 - 0x100000000);
        /// <summary>
        /// The storage has been changed since the last commit.
        /// </summary>
        public const int STG_E_NOTCURRENT = (int)(0x80030101 - 0x100000000);
        /// <summary>
        /// Attempted to use an object that has ceased to exist.
        /// </summary>
        public const int STG_E_REVERTED = (int)(0x80030102 - 0x100000000);
        /// <summary>
        /// Can't save.
        /// </summary>
        public const int STG_E_CANTSAVE = (int)(0x80030103 - 0x100000000);
        /// <summary>
        /// The compound file %1 was produced with an incompatible version of storage.
        /// </summary>
        public const int STG_E_OLDFORMAT = (int)(0x80030104 - 0x100000000);
        /// <summary>
        /// The compound file %1 was produced with a newer version of storage.
        /// </summary>
        public const int STG_E_OLDDLL = (int)(0x80030105 - 0x100000000);
        /// <summary>
        /// Share.exe or equivalent is required for operation.
        /// </summary>
        public const int STG_E_SHAREREQUIRED = (int)(0x80030106 - 0x100000000);
        /// <summary>
        /// Illegal operation called on non-file based storage.
        /// </summary>
        public const int STG_E_NOTFILEBASEDSTORAGE = (int)(0x80030107 - 0x100000000);
        /// <summary>
        /// Illegal operation called on object with extant marshallings.
        /// </summary>
        public const int STG_E_EXTANTMARSHALLINGS = (int)(0x80030108 - 0x100000000);
        /// <summary>
        /// The docfile has been corrupted.
        /// </summary>
        public const int STG_E_DOCFILECORRUPT = (int)(0x80030109 - 0x100000000);
        /// <summary>
        /// OLE32.DLL has been loaded at the wrong address.
        /// </summary>
        public const int STG_E_BADBASEADDRESS = (int)(0x80030110 - 0x100000000);
        /// <summary>
        /// The compound file is too large for the current implementation
        /// </summary>
        public const int STG_E_DOCFILETOOLARGE = (int)(0x80030111 - 0x100000000);
        /// <summary>
        /// The compound file was not created with the STGM_SIMPLE flag
        /// </summary>
        public const int STG_E_NOTSIMPLEFORMAT = (int)(0x80030112 - 0x100000000);
        /// <summary>
        /// The file download was aborted abnormally.  The file is incomplete.
        /// </summary>
        public const int STG_E_INCOMPLETE = (int)(0x80030201 - 0x100000000);
        /// <summary>
        /// The file download has been terminated.
        /// </summary>
        public const int STG_E_TERMINATED = (int)(0x80030202 - 0x100000000);
        /// <summary>
        /// The underlying file was converted to compound file format.
        /// </summary>
        public const int STG_S_CONVERTED = 0x00030200;
        /// <summary>
        /// The storage operation should block until more data is available.
        /// </summary>
        public const int STG_S_BLOCK = 0x00030201;
        /// <summary>
        /// The storage operation should retry immediately.
        /// </summary>
        public const int STG_S_RETRYNOW = 0x00030202;
        /// <summary>
        /// The notified event sink will not influence the storage operation.
        /// </summary>
        public const int STG_S_MONITORING = 0x00030203;
        /// <summary>
        /// Multiple opens prevent consolidated. (commit succeeded).
        /// </summary>
        public const int STG_S_MULTIPLEOPENS = 0x00030204;
        /// <summary>
        /// Consolidation of the storage file failed. (commit succeeded).
        /// </summary>
        public const int STG_S_CONSOLIDATIONFAILED = 0x00030205;
        /// <summary>
        /// Consolidation of the storage file is inappropriate. (commit succeeded).
        /// </summary>
        public const int STG_S_CANNOTCONSOLIDATE = 0x00030206;
        /// <summary>
        /// Generic Copy Protection Error.
        /// </summary>
        public const int STG_E_STATUS_COPY_PROTECTION_FAILURE = (int)(0x80030305 - 0x100000000);
        /// <summary>
        /// Copy Protection Error - DVD CSS Authentication failed.
        /// </summary>
        public const int STG_E_CSS_AUTHENTICATION_FAILURE = (int)(0x80030306 - 0x100000000);
        /// <summary>
        /// Copy Protection Error - The given sector does not have a valid CSS key.
        /// </summary>
        public const int STG_E_CSS_KEY_NOT_PRESENT = (int)(0x80030307 - 0x100000000);
        /// <summary>
        /// Copy Protection Error - DVD session key not established.
        /// </summary>
        public const int STG_E_CSS_KEY_NOT_ESTABLISHED = (int)(0x80030308 - 0x100000000);
        /// <summary>
        /// Copy Protection Error - The read failed because the sector is encrypted.
        /// </summary>
        public const int STG_E_CSS_SCRAMBLED_SECTOR = (int)(0x80030309 - 0x100000000);
        /// <summary>
        /// Copy Protection Error - The current DVD's region does not correspond to the region setting of the drive.
        /// </summary>
        public const int STG_E_CSS_REGION_MISMATCH = (int)(0x8003030A - 0x100000000);
        /// <summary>
        /// Copy Protection Error - The drive's region setting may be permanent or the number of user resets has been exhausted.
        /// </summary>
        public const int STG_E_RESETS_EXHAUSTED = (int)(0x8003030B - 0x100000000);
        /// <summary>
        /// Call was rejected by callee.
        /// </summary>
        public const int RPC_E_CALL_REJECTED = (int)(0x80010001 - 0x100000000);
        /// <summary>
        /// Call was canceled by the message filter.
        /// </summary>
        public const int RPC_E_CALL_CANCELED = (int)(0x80010002 - 0x100000000);
        /// <summary>
        /// The caller is dispatching an intertask SendMessage call and cannot call out via PostMessage.
        /// </summary>
        public const int RPC_E_CANTPOST_INSENDCALL = (int)(0x80010003 - 0x100000000);
        /// <summary>
        /// The caller is dispatching an asynchronous call and cannot make an outgoing call on behalf of this call.
        /// </summary>
        public const int RPC_E_CANTCALLOUT_INASYNCCALL = (int)(0x80010004 - 0x100000000);
        /// <summary>
        /// It is illegal to call out while inside message filter.
        /// </summary>
        public const int RPC_E_CANTCALLOUT_INEXTERNALCALL = (int)(0x80010005 - 0x100000000);
        /// <summary>
        /// The connection terminated or is in a bogus state and cannot be used any more. Other connections are still valid.
        /// </summary>
        public const int RPC_E_CONNECTION_TERMINATED = (int)(0x80010006 - 0x100000000);
        /// <summary>
        /// The callee (server [not server application]) is not available and disappeared; all connections are invalid. The call may have executed.
        /// </summary>
        public const int RPC_E_SERVER_DIED = (int)(0x80010007 - 0x100000000);
        /// <summary>
        /// The caller (client) disappeared while the callee (server) was processing a call.
        /// </summary>
        public const int RPC_E_CLIENT_DIED = (int)(0x80010008 - 0x100000000);
        /// <summary>
        /// The data packet with the marshalled parameter data is incorrect.
        /// </summary>
        public const int RPC_E_INVALID_DATAPACKET = (int)(0x80010009 - 0x100000000);
        /// <summary>
        /// The call was not transmitted properly; the message queue was full and was not emptied after yielding.
        /// </summary>
        public const int RPC_E_CANTTRANSMIT_CALL = (int)(0x8001000A - 0x100000000);
        /// <summary>
        /// The client (caller) cannot marshall the parameter data - low memory, etc.
        /// </summary>
        public const int RPC_E_CLIENT_CANTMARSHAL_DATA = (int)(0x8001000B - 0x100000000);
        /// <summary>
        /// The client (caller) cannot unmarshall the return data - low memory, etc.
        /// </summary>
        public const int RPC_E_CLIENT_CANTUNMARSHAL_DATA = (int)(0x8001000C - 0x100000000);
        /// <summary>
        /// The server (callee) cannot marshall the return data - low memory, etc.
        /// </summary>
        public const int RPC_E_SERVER_CANTMARSHAL_DATA = (int)(0x8001000D - 0x100000000);
        /// <summary>
        /// The server (callee) cannot unmarshall the parameter data - low memory, etc.
        /// </summary>
        public const int RPC_E_SERVER_CANTUNMARSHAL_DATA = (int)(0x8001000E - 0x100000000);
        /// <summary>
        /// Received data is invalid; could be server or client data.
        /// </summary>
        public const int RPC_E_INVALID_DATA = (int)(0x8001000F - 0x100000000);
        /// <summary>
        /// A particular parameter is invalid and cannot be (un)marshalled.
        /// </summary>
        public const int RPC_E_INVALID_PARAMETER = (int)(0x80010010 - 0x100000000);
        /// <summary>
        /// There is no second outgoing call on same channel in DDE conversation.
        /// </summary>
        public const int RPC_E_CANTCALLOUT_AGAIN = (int)(0x80010011 - 0x100000000);
        /// <summary>
        /// The callee (server [not server application]) is not available and disappeared; all connections are invalid. The call did not execute.
        /// </summary>
        public const int RPC_E_SERVER_DIED_DNE = (int)(0x80010012 - 0x100000000);
        /// <summary>
        /// System call failed.
        /// </summary>
        public const int RPC_E_SYS_CALL_FAILED = (int)(0x80010100 - 0x100000000);
        /// <summary>
        /// Could not allocate some required resource (memory, events, ...)
        /// </summary>
        public const int RPC_E_OUT_OF_RESOURCES = (int)(0x80010101 - 0x100000000);
        /// <summary>
        /// Attempted to make calls on more than one thread in single threaded mode.
        /// </summary>
        public const int RPC_E_ATTEMPTED_MULTITHREAD = (int)(0x80010102 - 0x100000000);
        /// <summary>
        /// The requested interface is not registered on the server object.
        /// </summary>
        public const int RPC_E_NOT_REGISTERED = (int)(0x80010103 - 0x100000000);
        /// <summary>
        /// RPC could not call the server or could not return the results of calling the server.
        /// </summary>
        public const int RPC_E_FAULT = (int)(0x80010104 - 0x100000000);
        /// <summary>
        /// The server threw an exception.
        /// </summary>
        public const int RPC_E_SERVERFAULT = (int)(0x80010105 - 0x100000000);
        /// <summary>
        /// Cannot change thread mode after it is set.
        /// </summary>
        public const int RPC_E_CHANGED_MODE = (int)(0x80010106 - 0x100000000);
        /// <summary>
        /// The method called does not exist on the server.
        /// </summary>
        public const int RPC_E_INVALIDMETHOD = (int)(0x80010107 - 0x100000000);
        /// <summary>
        /// The object invoked has disconnected from its clients.
        /// </summary>
        public const int RPC_E_DISCONNECTED = (int)(0x80010108 - 0x100000000);
        /// <summary>
        /// The object invoked chose not to process the call now.  Try again later.
        /// </summary>
        public const int RPC_E_RETRY = (int)(0x80010109 - 0x100000000);
        /// <summary>
        /// The message filter indicated that the application is busy.
        /// </summary>
        public const int RPC_E_SERVERCALL_RETRYLATER = (int)(0x8001010A - 0x100000000);
        /// <summary>
        /// The message filter rejected the call.
        /// </summary>
        public const int RPC_E_SERVERCALL_REJECTED = (int)(0x8001010B - 0x100000000);
        /// <summary>
        /// A call control interfaces was called with invalid data.
        /// </summary>
        public const int RPC_E_INVALID_CALLDATA = (int)(0x8001010C - 0x100000000);
        /// <summary>
        /// An outgoing call cannot be made since the application is dispatching an input-synchronous call.
        /// </summary>
        public const int RPC_E_CANTCALLOUT_ININPUTSYNCCALL = (int)(0x8001010D - 0x100000000);
        /// <summary>
        /// The application called an interface that was marshalled for a different thread.
        /// </summary>
        public const int RPC_E_WRONG_THREAD = (int)(0x8001010E - 0x100000000);
        /// <summary>
        /// CoInitialize has not been called on the current thread.
        /// </summary>
        public const int RPC_E_THREAD_NOT_INIT = (int)(0x8001010F - 0x100000000);
        /// <summary>
        /// The version of OLE on the client and server machines does not match.
        /// </summary>
        public const int RPC_E_VERSION_MISMATCH = (int)(0x80010110 - 0x100000000);
        /// <summary>
        /// OLE received a packet with an invalid header.
        /// </summary>
        public const int RPC_E_INVALID_HEADER = (int)(0x80010111 - 0x100000000);
        /// <summary>
        /// OLE received a packet with an invalid extension.
        /// </summary>
        public const int RPC_E_INVALID_EXTENSION = (int)(0x80010112 - 0x100000000);
        /// <summary>
        /// The requested object or interface does not exist.
        /// </summary>
        public const int RPC_E_INVALID_IPID = (int)(0x80010113 - 0x100000000);
        /// <summary>
        /// The requested object does not exist.
        /// </summary>
        public const int RPC_E_INVALID_OBJECT = (int)(0x80010114 - 0x100000000);
        /// <summary>
        /// OLE has sent a request and is waiting for a reply.
        /// </summary>
        public const int RPC_S_CALLPENDING = (int)(0x80010115 - 0x100000000);
        /// <summary>
        /// OLE is waiting before retrying a request.
        /// </summary>
        public const int RPC_S_WAITONTIMER = (int)(0x80010116 - 0x100000000);
        /// <summary>
        /// Call context cannot be accessed after call completed.
        /// </summary>
        public const int RPC_E_CALL_COMPLETE = (int)(0x80010117 - 0x100000000);
        /// <summary>
        /// Impersonate on unsecure calls is not supported.
        /// </summary>
        public const int RPC_E_UNSECURE_CALL = (int)(0x80010118 - 0x100000000);
        /// <summary>
        /// Security must be initialized before any interfaces are marshalled or unmarshalled. It cannot be changed once initialized.
        /// </summary>
        public const int RPC_E_TOO_LATE = (int)(0x80010119 - 0x100000000);
        /// <summary>
        /// No security packages are installed on this machine or the user is not logged on or there are no compatible security packages between the client and server.
        /// </summary>
        public const int RPC_E_NO_GOOD_SECURITY_PACKAGES = (int)(0x8001011A - 0x100000000);
        /// <summary>
        /// Access is denied.
        /// </summary>
        public const int RPC_E_ACCESS_DENIED = (int)(0x8001011B - 0x100000000);
        /// <summary>
        /// Remote calls are not allowed for this process.
        /// </summary>
        public const int RPC_E_REMOTE_DISABLED = (int)(0x8001011C - 0x100000000);
        /// <summary>
        /// The marshaled interface data packet (OBJREF) has an invalid or unknown format.
        /// </summary>
        public const int RPC_E_INVALID_OBJREF = (int)(0x8001011D - 0x100000000);
        /// <summary>
        /// No context is associated with this call. This happens for some custom marshalled calls and on the client side of the call.
        /// </summary>
        public const int RPC_E_NO_CONTEXT = (int)(0x8001011E - 0x100000000);
        /// <summary>
        /// This operation returned because the timeout period expired.
        /// </summary>
        public const int RPC_E_TIMEOUT = (int)(0x8001011F - 0x100000000);
        /// <summary>
        /// There are no synchronize objects to wait on.
        /// </summary>
        public const int RPC_E_NO_SYNC = (int)(0x80010120 - 0x100000000);
        /// <summary>
        /// Full subject issuer chain SSL principal name expected from the server.
        /// </summary>
        public const int RPC_E_FULLSIC_REQUIRED = (int)(0x80010121 - 0x100000000);
        /// <summary>
        /// Principal name is not a valid MSSTD name.
        /// </summary>
        public const int RPC_E_INVALID_STD_NAME = (int)(0x80010122 - 0x100000000);
        /// <summary>
        /// Unable to impersonate DCOM client
        /// </summary>
        public const int CO_E_FAILEDTOIMPERSONATE = (int)(0x80010123 - 0x100000000);
        /// <summary>
        /// Unable to obtain server's security context
        /// </summary>
        public const int CO_E_FAILEDTOGETSECCTX = (int)(0x80010124 - 0x100000000);
        /// <summary>
        /// Unable to open the access token of the current thread
        /// </summary>
        public const int CO_E_FAILEDTOOPENTHREADTOKEN = (int)(0x80010125 - 0x100000000);
        /// <summary>
        /// Unable to obtain user info from an access token
        /// </summary>
        public const int CO_E_FAILEDTOGETTOKENINFO = (int)(0x80010126 - 0x100000000);
        /// <summary>
        /// The client who called IAccessControl::IsAccessPermitted was not the trustee provided to the method
        /// </summary>
        public const int CO_E_TRUSTEEDOESNTMATCHCLIENT = (int)(0x80010127 - 0x100000000);
        /// <summary>
        /// Unable to obtain the client's security blanket
        /// </summary>
        public const int CO_E_FAILEDTOQUERYCLIENTBLANKET = (int)(0x80010128 - 0x100000000);
        /// <summary>
        /// Unable to set a discretionary ACL into a security descriptor
        /// </summary>
        public const int CO_E_FAILEDTOSETDACL = (int)(0x80010129 - 0x100000000);
        /// <summary>
        /// The system function, AccessCheck, returned false
        /// </summary>
        public const int CO_E_ACCESSCHECKFAILED = (int)(0x8001012A - 0x100000000);
        /// <summary>
        /// Either NetAccessDel or NetAccessAdd returned an error code.
        /// </summary>
        public const int CO_E_NETACCESSAPIFAILED = (int)(0x8001012B - 0x100000000);
        /// <summary>
        /// One of the trustee strings provided by the user did not conform to the &lt;Domain&gt;\&lt;Name&gt; syntax and it was not the "*" string
        /// </summary>
        public const int CO_E_WRONGTRUSTEENAMESYNTAX = (int)(0x8001012C - 0x100000000);
        /// <summary>
        /// One of the security identifiers provided by the user was invalid
        /// </summary>
        public const int CO_E_INVALIDSID = (int)(0x8001012D - 0x100000000);
        /// <summary>
        /// Unable to convert a wide character trustee string to a multibyte trustee string
        /// </summary>
        public const int CO_E_CONVERSIONFAILED = (int)(0x8001012E - 0x100000000);
        /// <summary>
        /// Unable to find a security identifier that corresponds to a trustee string provided by the user
        /// </summary>
        public const int CO_E_NOMATCHINGSIDFOUND = (int)(0x8001012F - 0x100000000);
        /// <summary>
        /// The system function, LookupAccountSID, failed
        /// </summary>
        public const int CO_E_LOOKUPACCSIDFAILED = (int)(0x80010130 - 0x100000000);
        /// <summary>
        /// Unable to find a trustee name that corresponds to a security identifier provided by the user
        /// </summary>
        public const int CO_E_NOMATCHINGNAMEFOUND = (int)(0x80010131 - 0x100000000);
        /// <summary>
        /// The system function, LookupAccountName, failed
        /// </summary>
        public const int CO_E_LOOKUPACCNAMEFAILED = (int)(0x80010132 - 0x100000000);
        /// <summary>
        /// Unable to set or reset a serialization handle
        /// </summary>
        public const int CO_E_SETSERLHNDLFAILED = (int)(0x80010133 - 0x100000000);
        /// <summary>
        /// Unable to obtain the Windows directory
        /// </summary>
        public const int CO_E_FAILEDTOGETWINDIR = (int)(0x80010134 - 0x100000000);
        /// <summary>
        /// Path too long
        /// </summary>
        public const int CO_E_PATHTOOInt32 = (int)(0x80010135 - 0x100000000);
        /// <summary>
        /// Unable to generate a uuid.
        /// </summary>
        public const int CO_E_FAILEDTOGENUUID = (int)(0x80010136 - 0x100000000);
        /// <summary>
        /// Unable to create file
        /// </summary>
        public const int CO_E_FAILEDTOCREATEFILE = (int)(0x80010137 - 0x100000000);
        /// <summary>
        /// Unable to close a serialization handle or a file handle.
        /// </summary>
        public const int CO_E_FAILEDTOCLOSEHANDLE = (int)(0x80010138 - 0x100000000);
        /// <summary>
        /// The number of ACEs in an ACL exceeds the system limit.
        /// </summary>
        public const int CO_E_EXCEEDSYSACLLIMIT = (int)(0x80010139 - 0x100000000);
        /// <summary>
        /// Not all the DENY_ACCESS ACEs are arranged in front of the GRANT_ACCESS ACEs in the stream.
        /// </summary>
        public const int CO_E_ACESINWRONGORDER = (int)(0x8001013A - 0x100000000);
        /// <summary>
        /// The version of ACL format in the stream is not supported by this implementation of IAccessControl
        /// </summary>
        public const int CO_E_INCOMPATIBLESTREAMVERSION = (int)(0x8001013B - 0x100000000);
        /// <summary>
        /// Unable to open the access token of the server process
        /// </summary>
        public const int CO_E_FAILEDTOOPENPROCESSTOKEN = (int)(0x8001013C - 0x100000000);
        /// <summary>
        /// Unable to decode the ACL in the stream provided by the user
        /// </summary>
        public const int CO_E_DECODEFAILED = (int)(0x8001013D - 0x100000000);
        /// <summary>
        /// The COM IAccessControl object is not initialized
        /// </summary>
        public const int CO_E_ACNOTINITIALIZED = (int)(0x8001013F - 0x100000000);
        /// <summary>
        /// Call Cancellation is disabled
        /// </summary>
        public const int CO_E_CANCEL_DISABLED = (int)(0x80010140 - 0x100000000);
        /// <summary>
        /// An internal error occurred.
        /// </summary>
        public const int RPC_E_UNEXPECTED = (int)(0x8001FFFF - 0x100000000);
        /// <summary>
        /// The specified event is currently not being audited.
        /// </summary>
        public const int ERROR_AUDITING_DISABLED = (int)(0xC0090001 - 0x100000000);
        /// <summary>
        /// The SID filtering operation removed all SIDs.
        /// </summary>
        public const int ERROR_ALL_SIDS_FILTERED = (int)(0xC0090002 - 0x100000000);
        /// <summary>
        /// Bad UID.
        /// </summary>
        public const int NTE_BAD_UID = (int)(0x80090001 - 0x100000000);
        /// <summary>
        /// Bad Hash.
        /// </summary>
        public const int NTE_BAD_HASH = (int)(0x80090002 - 0x100000000);
        /// <summary>
        /// Bad Key.
        /// </summary>
        public const int NTE_BAD_KEY = (int)(0x80090003 - 0x100000000);
        /// <summary>
        /// Bad Length.
        /// </summary>
        public const int NTE_BAD_LEN = (int)(0x80090004 - 0x100000000);
        /// <summary>
        /// Bad Data.
        /// </summary>
        public const int NTE_BAD_DATA = (int)(0x80090005 - 0x100000000);
        /// <summary>
        /// Invalid Signature.
        /// </summary>
        public const int NTE_BAD_SIGNATURE = (int)(0x80090006 - 0x100000000);
        /// <summary>
        /// Bad Version of provider.
        /// </summary>
        public const int NTE_BAD_VER = (int)(0x80090007 - 0x100000000);
        /// <summary>
        /// Invalid algorithm specified.
        /// </summary>
        public const int NTE_BAD_ALGID = (int)(0x80090008 - 0x100000000);
        /// <summary>
        /// Invalid flags specified.
        /// </summary>
        public const int NTE_BAD_FLAGS = (int)(0x80090009 - 0x100000000);
        /// <summary>
        /// Invalid type specified.
        /// </summary>
        public const int NTE_BAD_TYPE = (int)(0x8009000A - 0x100000000);
        /// <summary>
        /// Key not valid for use in specified state.
        /// </summary>
        public const int NTE_BAD_KEY_STATE = (int)(0x8009000B - 0x100000000);
        /// <summary>
        /// Hash not valid for use in specified state.
        /// </summary>
        public const int NTE_BAD_HASH_STATE = (int)(0x8009000C - 0x100000000);
        /// <summary>
        /// Key does not exist.
        /// </summary>
        public const int NTE_NO_KEY = (int)(0x8009000D - 0x100000000);
        /// <summary>
        /// Insufficient memory available for the operation.
        /// </summary>
        public const int NTE_NO_MEMORY = (int)(0x8009000E - 0x100000000);
        /// <summary>
        /// Object already exists.
        /// </summary>
        public const int NTE_EXISTS = (int)(0x8009000F - 0x100000000);
        /// <summary>
        /// Access denied.
        /// </summary>
        public const int NTE_PERM = (int)(0x80090010 - 0x100000000);
        /// <summary>
        /// Object was not found.
        /// </summary>
        public const int NTE_NOT_FOUND = (int)(0x80090011 - 0x100000000);
        /// <summary>
        /// Data already encrypted.
        /// </summary>
        public const int NTE_DOUBLE_ENCRYPT = (int)(0x80090012 - 0x100000000);
        /// <summary>
        /// Invalid provider specified.
        /// </summary>
        public const int NTE_BAD_PROVIDER = (int)(0x80090013 - 0x100000000);
        /// <summary>
        /// Invalid provider type specified.
        /// </summary>
        public const int NTE_BAD_PROV_TYPE = (int)(0x80090014 - 0x100000000);
        /// <summary>
        /// Provider's public key is invalid.
        /// </summary>
        public const int NTE_BAD_PUBLIC_KEY = (int)(0x80090015 - 0x100000000);
        /// <summary>
        /// Keyset does not exist
        /// </summary>
        public const int NTE_BAD_KEYSET = (int)(0x80090016 - 0x100000000);
        /// <summary>
        /// Provider type not defined.
        /// </summary>
        public const int NTE_PROV_TYPE_NOT_DEF = (int)(0x80090017 - 0x100000000);
        /// <summary>
        /// Provider type as registered is invalid.
        /// </summary>
        public const int NTE_PROV_TYPE_ENTRY_BAD = (int)(0x80090018 - 0x100000000);
        /// <summary>
        /// The keyset is not defined.
        /// </summary>
        public const int NTE_KEYSET_NOT_DEF = (int)(0x80090019 - 0x100000000);
        /// <summary>
        /// Keyset as registered is invalid.
        /// </summary>
        public const int NTE_KEYSET_ENTRY_BAD = (int)(0x8009001A - 0x100000000);
        /// <summary>
        /// Provider type does not match registered value.
        /// </summary>
        public const int NTE_PROV_TYPE_NO_MATCH = (int)(0x8009001B - 0x100000000);
        /// <summary>
        /// The digital signature file is corrupt.
        /// </summary>
        public const int NTE_SIGNATURE_FILE_BAD = (int)(0x8009001C - 0x100000000);
        /// <summary>
        /// Provider DLL failed to initialize correctly.
        /// </summary>
        public const int NTE_PROVIDER_DLL_FAIL = (int)(0x8009001D - 0x100000000);
        /// <summary>
        /// Provider DLL could not be found.
        /// </summary>
        public const int NTE_PROV_DLL_NOT_FOUND = (int)(0x8009001E - 0x100000000);
        /// <summary>
        /// The Keyset parameter is invalid.
        /// </summary>
        public const int NTE_BAD_KEYSET_PARAM = (int)(0x8009001F - 0x100000000);
        /// <summary>
        /// An internal error occurred.
        /// </summary>
        public const int NTE_FAIL = (int)(0x80090020 - 0x100000000);
        /// <summary>
        /// A base error occurred.
        /// </summary>
        public const int NTE_SYS_ERR = (int)(0x80090021 - 0x100000000);
        /// <summary>
        /// Provider could not perform the action since the context was acquired as silent.
        /// </summary>
        public const int NTE_SILENT_CONTEXT = (int)(0x80090022 - 0x100000000);
        /// <summary>
        /// The security token does not have storage space available for an additional container.
        /// </summary>
        public const int NTE_TOKEN_KEYSET_STORAGE_FULL = (int)(0x80090023 - 0x100000000);
        /// <summary>
        /// The profile for the user is a temporary profile.
        /// </summary>
        public const int NTE_TEMPORARY_PROFILE = (int)(0x80090024 - 0x100000000);
        /// <summary>
        /// The key parameters could not be set because the CSP uses fixed parameters.
        /// </summary>
        public const int NTE_FIXEDPARAMETER = (int)(0x80090025 - 0x100000000);
        /// <summary>
        /// Not enough memory is available to complete this request
        /// </summary>
        public const int SEC_E_INSUFFICIENT_MEMORY = (int)(0x80090300 - 0x100000000);
        /// <summary>
        /// The handle specified is invalid
        /// </summary>
        public const int SEC_E_INVALID_HANDLE = (int)(0x80090301 - 0x100000000);
        /// <summary>
        /// The function requested is not supported
        /// </summary>
        public const int SEC_E_UNSUPPORTED_FUNCTION = (int)(0x80090302 - 0x100000000);
        /// <summary>
        /// The specified target is unknown or unreachable
        /// </summary>
        public const int SEC_E_TARGET_UNKNOWN = (int)(0x80090303 - 0x100000000);
        /// <summary>
        /// The Local Security Authority cannot be contacted
        /// </summary>
        public const int SEC_E_INTERNAL_ERROR = (int)(0x80090304 - 0x100000000);
        /// <summary>
        /// The requested security package does not exist
        /// </summary>
        public const int SEC_E_SECPKG_NOT_FOUND = (int)(0x80090305 - 0x100000000);
        /// <summary>
        /// The caller is not the owner of the desired credentials
        /// </summary>
        public const int SEC_E_NOT_OWNER = (int)(0x80090306 - 0x100000000);
        /// <summary>
        /// The security package failed to initialize, and cannot be installed
        /// </summary>
        public const int SEC_E_CANNOT_INSTALL = (int)(0x80090307 - 0x100000000);
        /// <summary>
        /// The token supplied to the function is invalid
        /// </summary>
        public const int SEC_E_INVALID_TOKEN = (int)(0x80090308 - 0x100000000);
        /// <summary>
        /// The security package is not able to marshall the logon buffer, so the logon attempt has failed
        /// </summary>
        public const int SEC_E_CANNOT_PACK = (int)(0x80090309 - 0x100000000);
        /// <summary>
        /// The per-message Quality of Protection is not supported by the security package
        /// </summary>
        public const int SEC_E_QOP_NOT_SUPPORTED = (int)(0x8009030A - 0x100000000);
        /// <summary>
        /// The security context does not allow impersonation of the client
        /// </summary>
        public const int SEC_E_NO_IMPERSONATION = (int)(0x8009030B - 0x100000000);
        /// <summary>
        /// The logon attempt failed
        /// </summary>
        public const int SEC_E_LOGON_DENIED = (int)(0x8009030C - 0x100000000);
        /// <summary>
        /// The credentials supplied to the package were not recognized
        /// </summary>
        public const int SEC_E_UNKNOWN_CREDENTIALS = (int)(0x8009030D - 0x100000000);
        /// <summary>
        /// No credentials are available in the security package
        /// </summary>
        public const int SEC_E_NO_CREDENTIALS = (int)(0x8009030E - 0x100000000);
        /// <summary>
        /// The message or signature supplied for verification has been altered
        /// </summary>
        public const int SEC_E_MESSAGE_ALTERED = (int)(0x8009030F - 0x100000000);
        /// <summary>
        /// The message supplied for verification is out of sequence
        /// </summary>
        public const int SEC_E_OUT_OF_SEQUENCE = (int)(0x80090310 - 0x100000000);
        /// <summary>
        /// No authority could be contacted for authentication.
        /// </summary>
        public const int SEC_E_NO_AUTHENTICATING_AUTHORITY = (int)(0x80090311 - 0x100000000);
        /// <summary>
        /// The function completed successfully, but must be called again to complete the context
        /// </summary>
        public const int SEC_I_CONTINUE_NEEDED = 0x00090312;
        /// <summary>
        /// The function completed successfully, but CompleteToken must be called
        /// </summary>
        public const int SEC_I_COMPLETE_NEEDED = 0x00090313;
        /// <summary>
        /// The function completed successfully, but both CompleteToken and this function must be called to complete the context
        /// </summary>
        public const int SEC_I_COMPLETE_AND_CONTINUE = 0x00090314;
        /// <summary>
        /// The logon was completed, but no network authority was available. The logon was made using locally known information
        /// </summary>
        public const int SEC_I_LOCAL_LOGON = 0x00090315;
        /// <summary>
        /// The requested security package does not exist
        /// </summary>
        public const int SEC_E_BAD_PKGID = (int)(0x80090316 - 0x100000000);
        /// <summary>
        /// The context has expired and can no longer be used.
        /// </summary>
        public const int SEC_E_CONTEXT_EXPIRED = (int)(0x80090317 - 0x100000000);
        /// <summary>
        /// The context has expired and can no longer be used.
        /// </summary>
        public const int SEC_I_CONTEXT_EXPIRED = 0x00090317;
        /// <summary>
        /// The supplied message is incomplete.  The signature was not verified.
        /// </summary>
        public const int SEC_E_INCOMPLETE_MESSAGE = (int)(0x80090318 - 0x100000000);
        /// <summary>
        /// The credentials supplied were not complete, and could not be verified. The context could not be initialized.
        /// </summary>
        public const int SEC_E_INCOMPLETE_CREDENTIALS = (int)(0x80090320 - 0x100000000);
        /// <summary>
        /// The buffers supplied to a function was too small.
        /// </summary>
        public const int SEC_E_BUFFER_TOO_SMALL = (int)(0x80090321 - 0x100000000);
        /// <summary>
        /// The credentials supplied were not complete, and could not be verified. Additional information can be returned from the context.
        /// </summary>
        public const int SEC_I_INCOMPLETE_CREDENTIALS = 0x00090320;
        /// <summary>
        /// The context data must be renegotiated with the peer.
        /// </summary>
        public const int SEC_I_RENEGOTIATE = 0x00090321;
        /// <summary>
        /// The target principal name is incorrect.
        /// </summary>
        public const int SEC_E_WRONG_PRINCIPAL = (int)(0x80090322 - 0x100000000);
        /// <summary>
        /// There is no LSA mode context associated with this context.
        /// </summary>
        public const int SEC_I_NO_LSA_CONTEXT = 0x00090323;
        /// <summary>
        /// The clocks on the client and server machines are skewed.
        /// </summary>
        public const int SEC_E_TIME_SKEW = (int)(0x80090324 - 0x100000000);
        /// <summary>
        /// The certificate chain was issued by an authority that is not trusted.
        /// </summary>
        public const int SEC_E_UNTRUSTED_ROOT = (int)(0x80090325 - 0x100000000);
        /// <summary>
        /// The message received was unexpected or badly formatted.
        /// </summary>
        public const int SEC_E_ILLEGAL_MESSAGE = (int)(0x80090326 - 0x100000000);
        /// <summary>
        /// An unknown error occurred while processing the certificate.
        /// </summary>
        public const int SEC_E_CERT_UNKNOWN = (int)(0x80090327 - 0x100000000);
        /// <summary>
        /// The received certificate has expired.
        /// </summary>
        public const int SEC_E_CERT_EXPIRED = (int)(0x80090328 - 0x100000000);
        /// <summary>
        /// The specified data could not be encrypted.
        /// </summary>
        public const int SEC_E_ENCRYPT_FAILURE = (int)(0x80090329 - 0x100000000);
        /// <summary>
        /// The specified data could not be decrypted.
        /// </summary>
        public const int SEC_E_DECRYPT_FAILURE = (int)(0x80090330 - 0x100000000);
        /// <summary>
        /// The client and server cannot communicate, because they do not possess a common algorithm.
        /// </summary>
        public const int SEC_E_ALGORITHM_MISMATCH = (int)(0x80090331 - 0x100000000);
        /// <summary>
        /// The security context could not be established due to a failure in the requested quality of service (e.g. mutual authentication or delegation).
        /// </summary>
        public const int SEC_E_SECURITY_QOS_FAILED = (int)(0x80090332 - 0x100000000);
        /// <summary>
        /// A security context was deleted before the context was completed.  This is considered a logon failure.
        /// </summary>
        public const int SEC_E_UNFINISHED_CONTEXT_DELETED = (int)(0x80090333 - 0x100000000);
        /// <summary>
        /// The client is trying to negotiate a context and the server requires user-to-user but didn't send a TGT reply.
        /// </summary>
        public const int SEC_E_NO_TGT_REPLY = (int)(0x80090334 - 0x100000000);
        /// <summary>
        /// Unable to accomplish the requested task because the local machine does not have any IP addresses.
        /// </summary>
        public const int SEC_E_NO_IP_ADDRESSES = (int)(0x80090335 - 0x100000000);
        /// <summary>
        /// The supplied credential handle does not match the credential associated with the security context.
        /// </summary>
        public const int SEC_E_WRONG_CREDENTIAL_HANDLE = (int)(0x80090336 - 0x100000000);
        /// <summary>
        /// The crypto system or checksum function is invalid because a required function is unavailable.
        /// </summary>
        public const int SEC_E_CRYPTO_SYSTEM_INVALID = (int)(0x80090337 - 0x100000000);
        /// <summary>
        /// The number of maximum ticket referrals has been exceeded.
        /// </summary>
        public const int SEC_E_MAX_REFERRALS_EXCEEDED = (int)(0x80090338 - 0x100000000);
        /// <summary>
        /// The local machine must be a Kerberos KDC (domain controller) and it is not.
        /// </summary>
        public const int SEC_E_MUST_BE_KDC = (int)(0x80090339 - 0x100000000);
        /// <summary>
        /// The other end of the security negotiation is requires strong crypto but it is not supported on the local machine.
        /// </summary>
        public const int SEC_E_STRONG_CRYPTO_NOT_SUPPORTED = (int)(0x8009033A - 0x100000000);
        /// <summary>
        /// The KDC reply contained more than one principal name.
        /// </summary>
        public const int SEC_E_TOO_MANY_PRINCIPALS = (int)(0x8009033B - 0x100000000);
        /// <summary>
        /// Expected to find PA data for a hint of what etype to use, but it was not found.
        /// </summary>
        public const int SEC_E_NO_PA_DATA = (int)(0x8009033C - 0x100000000);
        /// <summary>
        /// The client cert name does not matches the user name or the KDC name is incorrect.
        /// </summary>
        public const int SEC_E_PKINIT_NAME_MISMATCH = (int)(0x8009033D - 0x100000000);
        /// <summary>
        /// Smartcard logon is required and was not used.
        /// </summary>
        public const int SEC_E_SMARTCARD_LOGON_REQUIRED = (int)(0x8009033E - 0x100000000);
        /// <summary>
        /// A system shutdown is in progress.
        /// </summary>
        public const int SEC_E_SHUTDOWN_IN_PROGRESS = (int)(0x8009033F - 0x100000000);
        /// <summary>
        /// An invalid request was sent to the KDC.
        /// </summary>
        public const int SEC_E_KDC_INVALID_REQUEST = (int)(0x80090340 - 0x100000000);
        /// <summary>
        /// The KDC was unable to generate a referral for the service requested.
        /// </summary>
        public const int SEC_E_KDC_UNABLE_TO_REFER = (int)(0x80090341 - 0x100000000);
        /// <summary>
        /// The encryption type requested is not supported by the KDC.
        /// </summary>
        public const int SEC_E_KDC_UNKNOWN_ETYPE = (int)(0x80090342 - 0x100000000);
        /// <summary>
        /// An unsupported preauthentication mechanism was presented to the kerberos package.
        /// </summary>
        public const int SEC_E_UNSUPPORTED_PREAUTH = (int)(0x80090343 - 0x100000000);
        /// <summary>
        /// The requested operation requires delegation to be enabled on the machine.
        /// </summary>
        public const int SEC_E_DELEGATION_REQUIRED = (int)(0x80090345 - 0x100000000);
        /// <summary>
        /// Client's supplied SSPI channel bindings were incorrect.
        /// </summary>
        public const int SEC_E_BAD_BINDINGS = (int)(0x80090346 - 0x100000000);
        /// <summary>
        /// The received certificate was mapped to multiple accounts.
        /// </summary>
        public const int SEC_E_MULTIPLE_ACCOUNTS = (int)(0x80090347 - 0x100000000);
        /// <summary>
        /// SEC_E_NO_KERB_KEY
        /// </summary>
        public const int SEC_E_NO_KERB_KEY = (int)(0x80090348 - 0x100000000);
        /// <summary>
        /// No information avialable.
        /// </summary>
        public const int SEC_E_CERT_WRONG_USAGE = (int)(0x80090349 - 0x100000000);
        /// <summary>
        /// No information avialable.
        /// </summary>
        public const int SEC_E_DOWNGRADE_DETECTED = (int)(0x80090350 - 0x100000000);
        /// <summary>
        /// No information avialable.
        /// </summary>
        public const int SEC_E_SMARTCARD_CERT_REVOKED = (int)(0x80090351 - 0x100000000);
        /// <summary>
        /// No information avialable.
        /// </summary>
        public const int SEC_E_ISSUING_CA_UNTRUSTED = (int)(0x80090352 - 0x100000000);
        /// <summary>
        /// No information avialable.
        /// </summary>
        public const int SEC_E_REVOCATION_OFFLINE_C = (int)(0x80090353 - 0x100000000);
        /// <summary>
        /// No information avialable.
        /// </summary>
        public const int SEC_E_PKINIT_CLIENT_FAILURE = (int)(0x80090354 - 0x100000000);
        /// <summary>
        /// No information avialable.
        /// </summary>
        public const int SEC_E_SMARTCARD_CERT_EXPIRED = (int)(0x80090355 - 0x100000000);
        /// <summary>
        /// No information avialable.
        /// </summary>
        public const int SEC_E_NO_S4U_PROT_SUPPORT = (int)(0x80090356 - 0x100000000);
        /// <summary>
        /// No information avialable.
        /// </summary>
        public const int SEC_E_CROSSREALM_DELEGATION_FAILURE = (int)(0x80090357 - 0x100000000);
        /// <summary>
        /// No information avialable.
        /// </summary>
        public const int SEC_E_NO_SPM = SEC_E_INTERNAL_ERROR;
        /// <summary>
        /// No information avialable.
        /// </summary>
        public const int SEC_E_NOT_SUPPORTED = SEC_E_UNSUPPORTED_FUNCTION;
        /// <summary>
        /// An error occurred while performing an operation on a cryptographic message.
        /// </summary>
        public const int CRYPT_E_MSG_ERROR = (int)(0x80091001 - 0x100000000);
        /// <summary>
        /// Unknown cryptographic algorithm.
        /// </summary>
        public const int CRYPT_E_UNKNOWN_ALGO = (int)(0x80091002 - 0x100000000);
        /// <summary>
        /// The object identifier is poorly formatted.
        /// </summary>
        public const int CRYPT_E_OID_FORMAT = (int)(0x80091003 - 0x100000000);
        /// <summary>
        /// Invalid cryptographic message type.
        /// </summary>
        public const int CRYPT_E_INVALID_MSG_TYPE = (int)(0x80091004 - 0x100000000);
        /// <summary>
        /// Unexpected cryptographic message encoding.
        /// </summary>
        public const int CRYPT_E_UNEXPECTED_ENCODING = (int)(0x80091005 - 0x100000000);
        /// <summary>
        /// The cryptographic message does not contain an expected authenticated attribute.
        /// </summary>
        public const int CRYPT_E_AUTH_ATTR_MISSING = (int)(0x80091006 - 0x100000000);
        /// <summary>
        /// The hash value is not correct.
        /// </summary>
        public const int CRYPT_E_HASH_VALUE = (int)(0x80091007 - 0x100000000);
        /// <summary>
        /// The index value is not valid.
        /// </summary>
        public const int CRYPT_E_INVALID_INDEX = (int)(0x80091008 - 0x100000000);
        /// <summary>
        /// The content of the cryptographic message has already been decrypted.
        /// </summary>
        public const int CRYPT_E_ALREADY_DECRYPTED = (int)(0x80091009 - 0x100000000);
        /// <summary>
        /// The content of the cryptographic message has not been decrypted yet.
        /// </summary>
        public const int CRYPT_E_NOT_DECRYPTED = (int)(0x8009100A - 0x100000000);
        /// <summary>
        /// The enveloped-data message does not contain the specified recipient.
        /// </summary>
        public const int CRYPT_E_RECIPIENT_NOT_FOUND = (int)(0x8009100B - 0x100000000);
        /// <summary>
        /// Invalid control type.
        /// </summary>
        public const int CRYPT_E_CONTROL_TYPE = (int)(0x8009100C - 0x100000000);
        /// <summary>
        /// Invalid issuer and/or serial number.
        /// </summary>
        public const int CRYPT_E_ISSUER_SERIALNUMBER = (int)(0x8009100D - 0x100000000);
        /// <summary>
        /// Cannot find the original signer.
        /// </summary>
        public const int CRYPT_E_SIGNER_NOT_FOUND = (int)(0x8009100E - 0x100000000);
        /// <summary>
        /// The cryptographic message does not contain all of the requested attributes.
        /// </summary>
        public const int CRYPT_E_ATTRIBUTES_MISSING = (int)(0x8009100F - 0x100000000);
        /// <summary>
        /// The streamed cryptographic message is not ready to return data.
        /// </summary>
        public const int CRYPT_E_STREAM_MSG_NOT_READY = (int)(0x80091010 - 0x100000000);
        /// <summary>
        /// The streamed cryptographic message requires more data to complete the decode operation.
        /// </summary>
        public const int CRYPT_E_STREAM_INSUFFICIENT_DATA = (int)(0x80091011 - 0x100000000);
        /// <summary>
        /// The protected data needs to be re-protected.
        /// </summary>
        public const int CRYPT_I_NEW_PROTECTION_REQUIRED = 0x00091012;
        /// <summary>
        /// The length specified for the output data was insufficient.
        /// </summary>
        public const int CRYPT_E_BAD_LEN = (int)(0x80092001 - 0x100000000);
        /// <summary>
        /// An error occurred during encode or decode operation.
        /// </summary>
        public const int CRYPT_E_BAD_ENCODE = (int)(0x80092002 - 0x100000000);
        /// <summary>
        /// An error occurred while reading or writing to a file.
        /// </summary>
        public const int CRYPT_E_FILE_ERROR = (int)(0x80092003 - 0x100000000);
        /// <summary>
        /// Cannot find object or property.
        /// </summary>
        public const int CRYPT_E_NOT_FOUND = (int)(0x80092004 - 0x100000000);
        /// <summary>
        /// The object or property already exists.
        /// </summary>
        public const int CRYPT_E_EXISTS = (int)(0x80092005 - 0x100000000);
        /// <summary>
        /// No provider was specified for the store or object.
        /// </summary>
        public const int CRYPT_E_NO_PROVIDER = (int)(0x80092006 - 0x100000000);
        /// <summary>
        /// The specified certificate is self signed.
        /// </summary>
        public const int CRYPT_E_SELF_SIGNED = (int)(0x80092007 - 0x100000000);
        /// <summary>
        /// The previous certificate or CRL context was deleted.
        /// </summary>
        public const int CRYPT_E_DELETED_PREV = (int)(0x80092008 - 0x100000000);
        /// <summary>
        /// Cannot find the requested object.
        /// </summary>
        public const int CRYPT_E_NO_MATCH = (int)(0x80092009 - 0x100000000);
        /// <summary>
        /// The certificate does not have a property that references a private key.
        /// </summary>
        public const int CRYPT_E_UNEXPECTED_MSG_TYPE = (int)(0x8009200A - 0x100000000);
        /// <summary>
        /// Cannot find the certificate and private key for decryption.
        /// </summary>
        public const int CRYPT_E_NO_KEY_PROPERTY = (int)(0x8009200B - 0x100000000);
        /// <summary>
        /// Cannot find the certificate and private key to use for decryption.
        /// </summary>
        public const int CRYPT_E_NO_DECRYPT_CERT = (int)(0x8009200C - 0x100000000);
        /// <summary>
        /// Not a cryptographic message or the cryptographic message is not formatted correctly.
        /// </summary>
        public const int CRYPT_E_BAD_MSG = (int)(0x8009200D - 0x100000000);
        /// <summary>
        /// The signed cryptographic message does not have a signer for the specified signer index.
        /// </summary>
        public const int CRYPT_E_NO_SIGNER = (int)(0x8009200E - 0x100000000);
        /// <summary>
        /// Final closure is pending until additional frees or closes.
        /// </summary>
        public const int CRYPT_E_PENDING_CLOSE = (int)(0x8009200F - 0x100000000);
        /// <summary>
        /// The certificate is revoked.
        /// </summary>
        public const int CRYPT_E_REVOKED = (int)(0x80092010 - 0x100000000);
        /// <summary>
        /// No Dll or exported function was found to verify revocation.
        /// </summary>
        public const int CRYPT_E_NO_REVOCATION_DLL = (int)(0x80092011 - 0x100000000);
        /// <summary>
        /// The revocation function was unable to check revocation for the certificate.
        /// </summary>
        public const int CRYPT_E_NO_REVOCATION_CHECK = (int)(0x80092012 - 0x100000000);
        /// <summary>
        /// The revocation function was unable to check revocation because the revocation server was offline.
        /// </summary>
        public const int CRYPT_E_REVOCATION_OFFLINE = (int)(0x80092013 - 0x100000000);
        /// <summary>
        /// The certificate is not in the revocation server's database.
        /// </summary>
        public const int CRYPT_E_NOT_IN_REVOCATION_DATABASE = (int)(0x80092014 - 0x100000000);
        /// <summary>
        /// The string contains a non-numeric character.
        /// </summary>
        public const int CRYPT_E_INVALID_NUMERIC_STRING = (int)(0x80092020 - 0x100000000);
        /// <summary>
        /// The string contains a non-printable character.
        /// </summary>
        public const int CRYPT_E_INVALID_PRINTABLE_STRING = (int)(0x80092021 - 0x100000000);
        /// <summary>
        /// The string contains a character not in the 7 bit ASCII character set.
        /// </summary>
        public const int CRYPT_E_INVALID_IA5_STRING = (int)(0x80092022 - 0x100000000);
        /// <summary>
        /// The string contains an invalid X500 name attribute key, oid, value or delimiter.
        /// </summary>
        public const int CRYPT_E_INVALID_X500_STRING = (int)(0x80092023 - 0x100000000);
        /// <summary>
        /// The dwValueType for the CERT_NAME_VALUE is not one of the character strings.  Most likely it is either a CERT_RDN_ENCODED_BLOB or CERT_TDN_OCTED_STRING.
        /// </summary>
        public const int CRYPT_E_NOT_CHAR_STRING = (int)(0x80092024 - 0x100000000);
        /// <summary>
        /// The Put operation can not continue.  The file needs to be resized.  However, there is already a signature present.  A complete signing operation must be done.
        /// </summary>
        public const int CRYPT_E_FILERESIZED = (int)(0x80092025 - 0x100000000);
        /// <summary>
        /// The cryptographic operation failed due to a local security option setting.
        /// </summary>
        public const int CRYPT_E_SECURITY_SETTINGS = (int)(0x80092026 - 0x100000000);
        /// <summary>
        /// No DLL or exported function was found to verify subject usage.
        /// </summary>
        public const int CRYPT_E_NO_VERIFY_USAGE_DLL = (int)(0x80092027 - 0x100000000);
        /// <summary>
        /// The called function was unable to do a usage check on the subject.
        /// </summary>
        public const int CRYPT_E_NO_VERIFY_USAGE_CHECK = (int)(0x80092028 - 0x100000000);
        /// <summary>
        /// Since the server was offline, the called function was unable to complete the usage check.
        /// </summary>
        public const int CRYPT_E_VERIFY_USAGE_OFFLINE = (int)(0x80092029 - 0x100000000);
        /// <summary>
        /// The subject was not found in a Certificate Trust List (CTL).
        /// </summary>
        public const int CRYPT_E_NOT_IN_CTL = (int)(0x8009202A - 0x100000000);
        /// <summary>
        /// None of the signers of the cryptographic message or certificate trust list is trusted.
        /// </summary>
        public const int CRYPT_E_NO_TRUSTED_SIGNER = (int)(0x8009202B - 0x100000000);
        /// <summary>
        /// The public key's algorithm parameters are missing.
        /// </summary>
        public const int CRYPT_E_MISSING_PUBKEY_PARA = (int)(0x8009202C - 0x100000000);
        /// <summary>
        /// OSS Certificate encode/decode error code base
        ///
        /// See asn1code.h for a definition of the OSS runtime errors. The OSS
        /// error values are offset by CRYPT_E_OSS_ERROR.
        /// </summary>
        public const int CRYPT_E_OSS_ERROR = (int)(0x80093000 - 0x100000000);
        /// <summary>
        /// OSS ASN.1 Error: Output Buffer is too small.
        /// </summary>
        public const int OSS_MORE_BUF = (int)(0x80093001 - 0x100000000);
        /// <summary>
        /// OSS ASN.1 Error: Signed integer is encoded as a unsigned integer.
        /// </summary>
        public const int OSS_NEGATIVE_UINTEGER = (int)(0x80093002 - 0x100000000);
        /// <summary>
        /// OSS ASN.1 Error: Unknown ASN.1 data type.
        /// </summary>
        public const int OSS_PDU_RANGE = (int)(0x80093003 - 0x100000000);
        /// <summary>
        /// OSS ASN.1 Error: Output buffer is too small, the decoded data has been truncated.
        /// </summary>
        public const int OSS_MORE_INPUT = (int)(0x80093004 - 0x100000000);
        /// <summary>
        /// OSS ASN.1 Error: Invalid data.
        /// </summary>
        public const int OSS_DATA_ERROR = (int)(0x80093005 - 0x100000000);
        /// <summary>
        /// OSS ASN.1 Error: Invalid argument.
        /// </summary>
        public const int OSS_BAD_ARG = (int)(0x80093006 - 0x100000000);
        /// <summary>
        /// OSS ASN.1 Error: Encode/Decode version mismatch.
        /// </summary>
        public const int OSS_BAD_VERSION = (int)(0x80093007 - 0x100000000);
        /// <summary>
        /// OSS ASN.1 Error: Out of memory.
        /// </summary>
        public const int OSS_OUT_MEMORY = (int)(0x80093008 - 0x100000000);
        /// <summary>
        /// OSS ASN.1 Error: Encode/Decode Error.
        /// </summary>
        public const int OSS_PDU_MISMATCH = (int)(0x80093009 - 0x100000000);
        /// <summary>
        /// OSS ASN.1 Error: Internal Error.
        /// </summary>
        public const int OSS_LIMITED = (int)(0x8009300A - 0x100000000);
        /// <summary>
        /// OSS ASN.1 Error: Invalid data.
        /// </summary>
        public const int OSS_BAD_PTR = (int)(0x8009300B - 0x100000000);
        /// <summary>
        /// OSS ASN.1 Error: Invalid data.
        /// </summary>
        public const int OSS_BAD_TIME = (int)(0x8009300C - 0x100000000);
        /// <summary>
        /// OSS ASN.1 Error: Unsupported BER indefinite-length encoding.
        /// </summary>
        public const int OSS_INDEFINITE_NOT_SUPPORTED = (int)(0x8009300D - 0x100000000);
        /// <summary>
        /// OSS ASN.1 Error: Access violation.
        /// </summary>
        public const int OSS_MEM_ERROR = (int)(0x8009300E - 0x100000000);
        /// <summary>
        /// OSS ASN.1 Error: Invalid data.
        /// </summary>
        public const int OSS_BAD_TABLE = (int)(0x8009300F - 0x100000000);
        /// <summary>
        /// OSS ASN.1 Error: Invalid data.
        /// </summary>
        public const int OSS_TOO_Int32 = (int)(0x80093010 - 0x100000000);
        /// <summary>
        /// OSS ASN.1 Error: Invalid data.
        /// </summary>
        public const int OSS_CONSTRAINT_VIOLATED = (int)(0x80093011 - 0x100000000);
        /// <summary>
        /// OSS ASN.1 Error: Internal Error.
        /// </summary>
        public const int OSS_FATAL_ERROR = (int)(0x80093012 - 0x100000000);
        /// <summary>
        /// OSS ASN.1 Error: Multi-threading conflict.
        /// </summary>
        public const int OSS_ACCESS_SERIALIZATION_ERROR = (int)(0x80093013 - 0x100000000);
        /// <summary>
        /// OSS ASN.1 Error: Invalid data.
        /// </summary>
        public const int OSS_NULL_TBL = (int)(0x80093014 - 0x100000000);
        /// <summary>
        /// OSS ASN.1 Error: Invalid data.
        /// </summary>
        public const int OSS_NULL_FCN = (int)(0x80093015 - 0x100000000);
        /// <summary>
        /// OSS ASN.1 Error: Invalid data.
        /// </summary>
        public const int OSS_BAD_ENCRULES = (int)(0x80093016 - 0x100000000);
        /// <summary>
        /// OSS ASN.1 Error: Encode/Decode function not implemented.
        /// </summary>
        public const int OSS_UNAVAIL_ENCRULES = (int)(0x80093017 - 0x100000000);
        /// <summary>
        /// OSS ASN.1 Error: Trace file error.
        /// </summary>
        public const int OSS_CANT_OPEN_TRACE_WINDOW = (int)(0x80093018 - 0x100000000);
        /// <summary>
        /// OSS ASN.1 Error: Function not implemented.
        /// </summary>
        public const int OSS_UNIMPLEMENTED = (int)(0x80093019 - 0x100000000);
        /// <summary>
        /// OSS ASN.1 Error: Program link error.
        /// </summary>
        public const int OSS_OID_DLL_NOT_LINKED = (int)(0x8009301A - 0x100000000);
        /// <summary>
        /// OSS ASN.1 Error: Trace file error.
        /// </summary>
        public const int OSS_CANT_OPEN_TRACE_FILE = (int)(0x8009301B - 0x100000000);
        /// <summary>
        /// OSS ASN.1 Error: Trace file error.
        /// </summary>
        public const int OSS_TRACE_FILE_ALREADY_OPEN = (int)(0x8009301C - 0x100000000);
        /// <summary>
        /// OSS ASN.1 Error: Invalid data.
        /// </summary>
        public const int OSS_TABLE_MISMATCH = (int)(0x8009301D - 0x100000000);
        /// <summary>
        /// OSS ASN.1 Error: Invalid data.
        /// </summary>
        public const int OSS_TYPE_NOT_SUPPORTED = (int)(0x8009301E - 0x100000000);
        /// <summary>
        /// OSS ASN.1 Error: Program link error.
        /// </summary>
        public const int OSS_REAL_DLL_NOT_LINKED = (int)(0x8009301F - 0x100000000);
        /// <summary>
        /// OSS ASN.1 Error: Program link error.
        /// </summary>
        public const int OSS_REAL_CODE_NOT_LINKED = (int)(0x80093020 - 0x100000000);
        /// <summary>
        /// OSS ASN.1 Error: Program link error.
        /// </summary>
        public const int OSS_OUT_OF_RANGE = (int)(0x80093021 - 0x100000000);
        /// <summary>
        /// OSS ASN.1 Error: Program link error.
        /// </summary>
        public const int OSS_COPIER_DLL_NOT_LINKED = (int)(0x80093022 - 0x100000000);
        /// <summary>
        /// OSS ASN.1 Error: Program link error.
        /// </summary>
        public const int OSS_CONSTRAINT_DLL_NOT_LINKED = (int)(0x80093023 - 0x100000000);
        /// <summary>
        /// OSS ASN.1 Error: Program link error.
        /// </summary>
        public const int OSS_COMPARATOR_DLL_NOT_LINKED = (int)(0x80093024 - 0x100000000);
        /// <summary>
        /// OSS ASN.1 Error: Program link error.
        /// </summary>
        public const int OSS_COMPARATOR_CODE_NOT_LINKED = (int)(0x80093025 - 0x100000000);
        /// <summary>
        /// OSS ASN.1 Error: Program link error.
        /// </summary>
        public const int OSS_MEM_MGR_DLL_NOT_LINKED = (int)(0x80093026 - 0x100000000);
        /// <summary>
        /// OSS ASN.1 Error: Program link error.
        /// </summary>
        public const int OSS_PDV_DLL_NOT_LINKED = (int)(0x80093027 - 0x100000000);
        /// <summary>
        /// OSS ASN.1 Error: Program link error.
        /// </summary>
        public const int OSS_PDV_CODE_NOT_LINKED = (int)(0x80093028 - 0x100000000);
        /// <summary>
        /// OSS ASN.1 Error: Program link error.
        /// </summary>
        public const int OSS_API_DLL_NOT_LINKED = (int)(0x80093029 - 0x100000000);
        /// <summary>
        /// OSS ASN.1 Error: Program link error.
        /// </summary>
        public const int OSS_BERDER_DLL_NOT_LINKED = (int)(0x8009302A - 0x100000000);
        /// <summary>
        /// OSS ASN.1 Error: Program link error.
        /// </summary>
        public const int OSS_PER_DLL_NOT_LINKED = (int)(0x8009302B - 0x100000000);
        /// <summary>
        /// OSS ASN.1 Error: Program link error.
        /// </summary>
        public const int OSS_OPEN_TYPE_ERROR = (int)(0x8009302C - 0x100000000);
        /// <summary>
        /// OSS ASN.1 Error: System resource error.
        /// </summary>
        public const int OSS_MUTEX_NOT_CREATED = (int)(0x8009302D - 0x100000000);
        /// <summary>
        /// OSS ASN.1 Error: Trace file error.
        /// </summary>
        public const int OSS_CANT_CLOSE_TRACE_FILE = (int)(0x8009302E - 0x100000000);
        /// <summary>
        /// ASN1 Certificate encode/decode error code base.
        ///
        /// The ASN1 error values are offset by CRYPT_E_ASN1_ERROR.
        /// </summary>
        public const int CRYPT_E_ASN1_ERROR = (int)(0x80093100 - 0x100000000);
        /// <summary>
        /// ASN1 internal encode or decode error.
        /// </summary>
        public const int CRYPT_E_ASN1_INTERNAL = (int)(0x80093101 - 0x100000000);
        /// <summary>
        /// ASN1 unexpected end of data.
        /// </summary>
        public const int CRYPT_E_ASN1_EOD = (int)(0x80093102 - 0x100000000);
        /// <summary>
        /// ASN1 corrupted data.
        /// </summary>
        public const int CRYPT_E_ASN1_CORRUPT = (int)(0x80093103 - 0x100000000);
        /// <summary>
        /// ASN1 value too large.
        /// </summary>
        public const int CRYPT_E_ASN1_LARGE = (int)(0x80093104 - 0x100000000);
        /// <summary>
        /// ASN1 constraint violated.
        /// </summary>
        public const int CRYPT_E_ASN1_CONSTRAINT = (int)(0x80093105 - 0x100000000);
        /// <summary>
        /// ASN1 out of memory.
        /// </summary>
        public const int CRYPT_E_ASN1_MEMORY = (int)(0x80093106 - 0x100000000);
        /// <summary>
        /// ASN1 buffer overflow.
        /// </summary>
        public const int CRYPT_E_ASN1_OVERFLOW = (int)(0x80093107 - 0x100000000);
        /// <summary>
        /// ASN1 function not supported for this PDU.
        /// </summary>
        public const int CRYPT_E_ASN1_BADPDU = (int)(0x80093108 - 0x100000000);
        /// <summary>
        /// ASN1 bad arguments to function call.
        /// </summary>
        public const int CRYPT_E_ASN1_BADARGS = (int)(0x80093109 - 0x100000000);
        /// <summary>
        /// ASN1 bad real value.
        /// </summary>
        public const int CRYPT_E_ASN1_BADREAL = (int)(0x8009310A - 0x100000000);
        /// <summary>
        /// ASN1 bad tag value met.
        /// </summary>
        public const int CRYPT_E_ASN1_BADTAG = (int)(0x8009310B - 0x100000000);
        /// <summary>
        /// ASN1 bad choice value.
        /// </summary>
        public const int CRYPT_E_ASN1_CHOICE = (int)(0x8009310C - 0x100000000);
        /// <summary>
        /// ASN1 bad encoding rule.
        /// </summary>
        public const int CRYPT_E_ASN1_RULE = (int)(0x8009310D - 0x100000000);
        /// <summary>
        /// ASN1 bad unicode (UTF8).
        /// </summary>
        public const int CRYPT_E_ASN1_UTF8 = (int)(0x8009310E - 0x100000000);
        /// <summary>
        /// ASN1 bad PDU type.
        /// </summary>
        public const int CRYPT_E_ASN1_PDU_TYPE = (int)(0x80093133 - 0x100000000);
        /// <summary>
        /// ASN1 not yet implemented.
        /// </summary>
        public const int CRYPT_E_ASN1_NYI = (int)(0x80093134 - 0x100000000);
        /// <summary>
        /// ASN1 skipped unknown extension(s).
        /// </summary>
        public const int CRYPT_E_ASN1_EXTENDED = (int)(0x80093201 - 0x100000000);
        /// <summary>
        /// ASN1 end of data expected
        /// </summary>
        public const int CRYPT_E_ASN1_NOEOD = (int)(0x80093202 - 0x100000000);
        /// <summary>
        /// The request subject name is invalid or too long.
        /// </summary>
        public const int CERTSRV_E_BAD_REQUESTSUBJECT = (int)(0x80094001 - 0x100000000);
        /// <summary>
        /// The request does not exist.
        /// </summary>
        public const int CERTSRV_E_NO_REQUEST = (int)(0x80094002 - 0x100000000);
        /// <summary>
        /// The request's current status does not allow this operation.
        /// </summary>
        public const int CERTSRV_E_BAD_REQUESTSTATUS = (int)(0x80094003 - 0x100000000);
        /// <summary>
        /// The requested property value is empty.
        /// </summary>
        public const int CERTSRV_E_PROPERTY_EMPTY = (int)(0x80094004 - 0x100000000);
        /// <summary>
        /// The certification authority's certificate contains invalid data.
        /// </summary>
        public const int CERTSRV_E_INVALID_CA_CERTIFICATE = (int)(0x80094005 - 0x100000000);
        /// <summary>
        /// Certificate service has been suspended for a database restore operation.
        /// </summary>
        public const int CERTSRV_E_SERVER_SUSPENDED = (int)(0x80094006 - 0x100000000);
        /// <summary>
        /// The certificate contains an encoded length that is potentially incompatible with older enrollment software.
        /// </summary>
        public const int CERTSRV_E_ENCODING_LENGTH = (int)(0x80094007 - 0x100000000);
        /// <summary>
        /// The operation is denied. The user has multiple roles assigned and the certification authority is configured to enforce role separation.
        /// </summary>
        public const int CERTSRV_E_ROLECONFLICT = (int)(0x80094008 - 0x100000000);
        /// <summary>
        /// The operation is denied. It can only be performed by a certificate manager that is allowed to manage certificates for the current requester.
        /// </summary>
        public const int CERTSRV_E_RESTRICTEDOFFICER = (int)(0x80094009 - 0x100000000);
        /// <summary>
        /// Cannot archive private key.  The certification authority is not configured for key archival.
        /// </summary>
        public const int CERTSRV_E_KEY_ARCHIVAL_NOT_CONFIGURED = (int)(0x8009400A - 0x100000000);
        /// <summary>
        /// Cannot archive private key.  The certification authority could not verify one or more key recovery certificates.
        /// </summary>
        public const int CERTSRV_E_NO_VALID_KRA = (int)(0x8009400B - 0x100000000);
        /// <summary>
        /// The request is incorrectly formatted.  The encrypted private key must be in an unauthenticated attribute in an outermost signature.
        /// </summary>
        public const int CERTSRV_E_BAD_REQUEST_KEY_ARCHIVAL = (int)(0x8009400C - 0x100000000);
        /// <summary>
        /// At least one security principal must have the permission to manage this CA.
        /// </summary>
        public const int CERTSRV_E_NO_CAADMIN_DEFINED = (int)(0x8009400D - 0x100000000);
        /// <summary>
        /// The request contains an invalid renewal certificate attribute.
        /// </summary>
        public const int CERTSRV_E_BAD_RENEWAL_CERT_ATTRIBUTE = (int)(0x8009400E - 0x100000000);
        /// <summary>
        /// An attempt was made to open a Certification Authority database session, but there are already too many active sessions.  The server may need to be configured to allow additional sessions.
        /// </summary>
        public const int CERTSRV_E_NO_DB_SESSIONS = (int)(0x8009400F - 0x100000000);
        /// <summary>
        /// A memory reference caused a data alignment fault.
        /// </summary>
        public const int CERTSRV_E_ALIGNMENT_FAULT = (int)(0x80094010 - 0x100000000);
        /// <summary>
        /// The permissions on this certification authority do not allow the current user to enroll for certificates.
        /// </summary>
        public const int CERTSRV_E_ENROLL_DENIED = (int)(0x80094011 - 0x100000000);
        /// <summary>
        /// The permissions on the certificate template do not allow the current user to enroll for this type of certificate.
        /// </summary>
        public const int CERTSRV_E_TEMPLATE_DENIED = (int)(0x80094012 - 0x100000000);
        /// <summary>
        /// No information avialable.
        /// </summary>
        public const int CERTSRV_E_DOWNLEVEL_DC_SSL_OR_UPGRADE = (int)(0x80094013 - 0x100000000);
        /// <summary>
        /// The requested certificate template is not supported by this CA.
        /// </summary>
        public const int CERTSRV_E_UNSUPPORTED_CERT_TYPE = (int)(0x80094800 - 0x100000000);
        /// <summary>
        /// The request contains no certificate template information.
        /// </summary>
        public const int CERTSRV_E_NO_CERT_TYPE = (int)(0x80094801 - 0x100000000);
        /// <summary>
        /// The request contains conflicting template information.
        /// </summary>
        public const int CERTSRV_E_TEMPLATE_CONFLICT = (int)(0x80094802 - 0x100000000);
        /// <summary>
        /// The request is missing a required Subject Alternate name extension.
        /// </summary>
        public const int CERTSRV_E_SUBJECT_ALT_NAME_REQUIRED = (int)(0x80094803 - 0x100000000);
        /// <summary>
        /// The request is missing a required private key for archival by the server.
        /// </summary>
        public const int CERTSRV_E_ARCHIVED_KEY_REQUIRED = (int)(0x80094804 - 0x100000000);
        /// <summary>
        /// The request is missing a required SMIME capabilities extension.
        /// </summary>
        public const int CERTSRV_E_SMIME_REQUIRED = (int)(0x80094805 - 0x100000000);
        /// <summary>
        /// The request was made on behalf of a subject other than the caller.  The certificate template must be configured to require at least one signature to authorize the request.
        /// </summary>
        public const int CERTSRV_E_BAD_RENEWAL_SUBJECT = (int)(0x80094806 - 0x100000000);
        /// <summary>
        /// The request template version is newer than the supported template version.
        /// </summary>
        public const int CERTSRV_E_BAD_TEMPLATE_VERSION = (int)(0x80094807 - 0x100000000);
        /// <summary>
        /// The template is missing a required signature policy attribute.
        /// </summary>
        public const int CERTSRV_E_TEMPLATE_POLICY_REQUIRED = (int)(0x80094808 - 0x100000000);
        /// <summary>
        /// The request is missing required signature policy information.
        /// </summary>
        public const int CERTSRV_E_SIGNATURE_POLICY_REQUIRED = (int)(0x80094809 - 0x100000000);
        /// <summary>
        /// The request is missing one or more required signatures.
        /// </summary>
        public const int CERTSRV_E_SIGNATURE_COUNT = (int)(0x8009480A - 0x100000000);
        /// <summary>
        /// One or more signatures did not include the required application or issuance policies.  The request is missing one or more required valid signatures.
        /// </summary>
        public const int CERTSRV_E_SIGNATURE_REJECTED = (int)(0x8009480B - 0x100000000);
        /// <summary>
        /// The request is missing one or more required signature issuance policies.
        /// </summary>
        public const int CERTSRV_E_ISSUANCE_POLICY_REQUIRED = (int)(0x8009480C - 0x100000000);
        /// <summary>
        /// The UPN is unavailable and cannot be added to the Subject Alternate name.
        /// </summary>
        public const int CERTSRV_E_SUBJECT_UPN_REQUIRED = (int)(0x8009480D - 0x100000000);
        /// <summary>
        /// The Active Directory GUID is unavailable and cannot be added to the Subject Alternate name.
        /// </summary>
        public const int CERTSRV_E_SUBJECT_DIRECTORY_GUID_REQUIRED = (int)(0x8009480E - 0x100000000);
        /// <summary>
        /// The DNS name is unavailable and cannot be added to the Subject Alternate name.
        /// </summary>
        public const int CERTSRV_E_SUBJECT_DNS_REQUIRED = (int)(0x8009480F - 0x100000000);
        /// <summary>
        /// The request includes a private key for archival by the server, but key archival is not enabled for the specified certificate template.
        /// </summary>
        public const int CERTSRV_E_ARCHIVED_KEY_UNEXPECTED = (int)(0x80094810 - 0x100000000);
        /// <summary>
        /// The public key does not meet the minimum size required by the specified certificate template.
        /// </summary>
        public const int CERTSRV_E_KEY_LENGTH = (int)(0x80094811 - 0x100000000);
        /// <summary>
        /// No information avialable.
        /// </summary>
        public const int CERTSRV_E_SUBJECT_EMAIL_REQUIRED = (int)(0x80094812 - 0x100000000);
        /// <summary>
        /// No information avialable.
        /// </summary>
        public const int CERTSRV_E_UNKNOWN_CERT_TYPE = (int)(0x80094813 - 0x100000000);
        /// <summary>
        /// No information avialable.
        /// </summary>
        public const int CERTSRV_E_CERT_TYPE_OVERLAP = (int)(0x80094814 - 0x100000000);
        /// <summary>
        /// The key is not exportable.
        /// </summary>
        public const int XENROLL_E_KEY_NOT_EXPORTABLE = (int)(0x80095000 - 0x100000000);
        /// <summary>
        /// You cannot add the root CA certificate into your local store.
        /// </summary>
        public const int XENROLL_E_CANNOT_ADD_ROOT_CERT = (int)(0x80095001 - 0x100000000);
        /// <summary>
        /// The key archival hash attribute was not found in the response.
        /// </summary>
        public const int XENROLL_E_RESPONSE_KA_HASH_NOT_FOUND = (int)(0x80095002 - 0x100000000);
        /// <summary>
        /// An unexpetced key archival hash attribute was found in the response.
        /// </summary>
        public const int XENROLL_E_RESPONSE_UNEXPECTED_KA_HASH = (int)(0x80095003 - 0x100000000);
        /// <summary>
        /// There is a key archival hash mismatch between the request and the response.
        /// </summary>
        public const int XENROLL_E_RESPONSE_KA_HASH_MISMATCH = (int)(0x80095004 - 0x100000000);
        /// <summary>
        /// Signing certificate cannot include SMIME extension.
        /// </summary>
        public const int XENROLL_E_KEYSPEC_SMIME_MISMATCH = (int)(0x80095005 - 0x100000000);
        /// <summary>
        /// A system-level error occurred while verifying trust.
        /// </summary>
        public const int TRUST_E_SYSTEM_ERROR = (int)(0x80096001 - 0x100000000);
        /// <summary>
        /// The certificate for the signer of the message is invalid or not found.
        /// </summary>
        public const int TRUST_E_NO_SIGNER_CERT = (int)(0x80096002 - 0x100000000);
        /// <summary>
        /// One of the counter signatures was invalid.
        /// </summary>
        public const int TRUST_E_COUNTER_SIGNER = (int)(0x80096003 - 0x100000000);
        /// <summary>
        /// The signature of the certificate can not be verified.
        /// </summary>
        public const int TRUST_E_CERT_SIGNATURE = (int)(0x80096004 - 0x100000000);
        /// <summary>
        /// The timestamp signature and/or certificate could not be verified or is malformed.
        /// </summary>
        public const int TRUST_E_TIME_STAMP = (int)(0x80096005 - 0x100000000);
        /// <summary>
        /// The digital signature of the object did not verify.
        /// </summary>
        public const int TRUST_E_BAD_DIGEST = (int)(0x80096010 - 0x100000000);
        /// <summary>
        /// A certificate's basic constraint extension has not been observed.
        /// </summary>
        public const int TRUST_E_BASIC_CONSTRAINTS = (int)(0x80096019 - 0x100000000);
        /// <summary>
        /// The certificate does not meet or contain the Authenticode financial extensions.
        /// </summary>
        public const int TRUST_E_FINANCIAL_CRITERIA = (int)(0x8009601E - 0x100000000);
        /// <summary>
        /// Tried to reference a part of the file outside the proper range.
        /// </summary>
        public const int MSSIPOTF_E_OUTOFMEMRANGE = (int)(0x80097001 - 0x100000000);
        /// <summary>
        /// Could not retrieve an object from the file.
        /// </summary>
        public const int MSSIPOTF_E_CANTGETOBJECT = (int)(0x80097002 - 0x100000000);
        /// <summary>
        /// Could not find the head table in the file.
        /// </summary>
        public const int MSSIPOTF_E_NOHEADTABLE = (int)(0x80097003 - 0x100000000);
        /// <summary>
        /// The magic number in the head table is incorrect.
        /// </summary>
        public const int MSSIPOTF_E_BAD_MAGICNUMBER = (int)(0x80097004 - 0x100000000);
        /// <summary>
        /// The offset table has incorrect values.
        /// </summary>
        public const int MSSIPOTF_E_BAD_OFFSET_TABLE = (int)(0x80097005 - 0x100000000);
        /// <summary>
        /// Duplicate table tags or tags out of alphabetical order.
        /// </summary>
        public const int MSSIPOTF_E_TABLE_TAGORDER = (int)(0x80097006 - 0x100000000);
        /// <summary>
        /// A table does not start on a long word boundary.
        /// </summary>
        public const int MSSIPOTF_E_TABLE_Int32UInt16 = (int)(0x80097007 - 0x100000000);
        /// <summary>
        /// First table does not appear after header information.
        /// </summary>
        public const int MSSIPOTF_E_BAD_FIRST_TABLE_PLACEMENT = (int)(0x80097008 - 0x100000000);
        /// <summary>
        /// Two or more tables overlap.
        /// </summary>
        public const int MSSIPOTF_E_TABLES_OVERLAP = (int)(0x80097009 - 0x100000000);
        /// <summary>
        /// Too many pad bytes between tables or pad bytes are not 0.
        /// </summary>
        public const int MSSIPOTF_E_TABLE_PADBYTES = (int)(0x8009700A - 0x100000000);
        /// <summary>
        /// File is too small to contain the last table.
        /// </summary>
        public const int MSSIPOTF_E_FILETOOSMALL = (int)(0x8009700B - 0x100000000);
        /// <summary>
        /// A table checksum is incorrect.
        /// </summary>
        public const int MSSIPOTF_E_TABLE_CHECKSUM = (int)(0x8009700C - 0x100000000);
        /// <summary>
        /// The file checksum is incorrect.
        /// </summary>
        public const int MSSIPOTF_E_FILE_CHECKSUM = (int)(0x8009700D - 0x100000000);
        /// <summary>
        /// The signature does not have the correct attributes for the policy.
        /// </summary>
        public const int MSSIPOTF_E_FAILED_POLICY = (int)(0x80097010 - 0x100000000);
        /// <summary>
        /// The file did not pass the hints check.
        /// </summary>
        public const int MSSIPOTF_E_FAILED_HINTS_CHECK = (int)(0x80097011 - 0x100000000);
        /// <summary>
        /// The file is not an OpenType file.
        /// </summary>
        public const int MSSIPOTF_E_NOT_OPENTYPE = (int)(0x80097012 - 0x100000000);
        /// <summary>
        /// Failed on a file operation (open, map, read, write).
        /// </summary>
        public const int MSSIPOTF_E_FILE = (int)(0x80097013 - 0x100000000);
        /// <summary>
        /// A call to a CryptoAPI function failed.
        /// </summary>
        public const int MSSIPOTF_E_CRYPT = (int)(0x80097014 - 0x100000000);
        /// <summary>
        /// There is a bad version number in the file.
        /// </summary>
        public const int MSSIPOTF_E_BADVERSION = (int)(0x80097015 - 0x100000000);
        /// <summary>
        /// The structure of the DSIG table is incorrect.
        /// </summary>
        public const int MSSIPOTF_E_DSIG_STRUCTURE = (int)(0x80097016 - 0x100000000);
        /// <summary>
        /// A check failed in a partially constant table.
        /// </summary>
        public const int MSSIPOTF_E_PCONST_CHECK = (int)(0x80097017 - 0x100000000);
        /// <summary>
        /// Some kind of structural error.
        /// </summary>
        public const int MSSIPOTF_E_STRUCTURE = (int)(0x80097018 - 0x100000000);
        /// <summary>
        /// The operation completed successfully.
        /// </summary>
        public const int NTE_OP_OK = 0;
        /// <summary>
        /// Unknown trust provider.
        /// </summary>
        public const int TRUST_E_PROVIDER_UNKNOWN = (int)(0x800B0001 - 0x100000000);
        /// <summary>
        /// The trust verification action specified is not supported by the specified trust provider.
        /// </summary>
        public const int TRUST_E_ACTION_UNKNOWN = (int)(0x800B0002 - 0x100000000);
        /// <summary>
        /// The form specified for the subject is not one supported or known by the specified trust provider.
        /// </summary>
        public const int TRUST_E_SUBJECT_FORM_UNKNOWN = (int)(0x800B0003 - 0x100000000);
        /// <summary>
        /// The subject is not trusted for the specified action.
        /// </summary>
        public const int TRUST_E_SUBJECT_NOT_TRUSTED = (int)(0x800B0004 - 0x100000000);
        /// <summary>
        /// Error due to problem in ASN.1 encoding process.
        /// </summary>
        public const int DIGSIG_E_ENCODE = (int)(0x800B0005 - 0x100000000);
        /// <summary>
        /// Error due to problem in ASN.1 decoding process.
        /// </summary>
        public const int DIGSIG_E_DECODE = (int)(0x800B0006 - 0x100000000);
        /// <summary>
        /// Reading / writing Extensions where Attributes are appropriate, and visa versa.
        /// </summary>
        public const int DIGSIG_E_EXTENSIBILITY = (int)(0x800B0007 - 0x100000000);
        /// <summary>
        /// Unspecified cryptographic failure.
        /// </summary>
        public const int DIGSIG_E_CRYPTO = (int)(0x800B0008 - 0x100000000);
        /// <summary>
        /// The size of the data could not be determined.
        /// </summary>
        public const int PERSIST_E_SIZEDEFINITE = (int)(0x800B0009 - 0x100000000);
        /// <summary>
        /// The size of the indefinite-sized data could not be determined.
        /// </summary>
        public const int PERSIST_E_SIZEINDEFINITE = (int)(0x800B000A - 0x100000000);
        /// <summary>
        /// This object does not read and write self-sizing data.
        /// </summary>
        public const int PERSIST_E_NOTSELFSIZING = (int)(0x800B000B - 0x100000000);
        /// <summary>
        /// No signature was present in the subject.
        /// </summary>
        public const int TRUST_E_NOSIGNATURE = (int)(0x800B0100 - 0x100000000);
        /// <summary>
        /// A required certificate is not within its validity period when verifying against the current system clock or the timestamp in the signed file.
        /// </summary>
        public const int CERT_E_EXPIRED = (int)(0x800B0101 - 0x100000000);
        /// <summary>
        /// The validity periods of the certification chain do not nest correctly.
        /// </summary>
        public const int CERT_E_VALIDITYPERIODNESTING = (int)(0x800B0102 - 0x100000000);
        /// <summary>
        /// A certificate that can only be used as an end-entity is being used as a CA or visa versa.
        /// </summary>
        public const int CERT_E_ROLE = (int)(0x800B0103 - 0x100000000);
        /// <summary>
        /// A path length constraint in the certification chain has been violated.
        /// </summary>
        public const int CERT_E_PATHLENCONST = (int)(0x800B0104 - 0x100000000);
        /// <summary>
        /// A certificate contains an unknown extension that is marked 'critical'.
        /// </summary>
        public const int CERT_E_CRITICAL = (int)(0x800B0105 - 0x100000000);
        /// <summary>
        /// A certificate being used for a purpose other than the ones specified by its CA.
        /// </summary>
        public const int CERT_E_PURPOSE = (int)(0x800B0106 - 0x100000000);
        /// <summary>
        /// A parent of a given certificate in fact did not issue that child certificate.
        /// </summary>
        public const int CERT_E_ISSUERCHAINING = (int)(0x800B0107 - 0x100000000);
        /// <summary>
        /// A certificate is missing or has an empty value for an important field, such as a subject or issuer name.
        /// </summary>
        public const int CERT_E_MALFORMED = (int)(0x800B0108 - 0x100000000);
        /// <summary>
        /// A certificate chain processed, but terminated in a root certificate which is not trusted by the trust provider.
        /// </summary>
        public const int CERT_E_UNTRUSTEDROOT = (int)(0x800B0109 - 0x100000000);
        /// <summary>
        /// An internal certificate chaining error has occurred.
        /// </summary>
        public const int CERT_E_CHAINING = (int)(0x800B010A - 0x100000000);
        /// <summary>
        /// Generic trust failure.
        /// </summary>
        public const int TRUST_E_FAIL = (int)(0x800B010B - 0x100000000);
        /// <summary>
        /// A certificate was explicitly revoked by its issuer.
        /// </summary>
        public const int CERT_E_REVOKED = (int)(0x800B010C - 0x100000000);
        /// <summary>
        /// The certification path terminates with the test root which is not trusted with the current policy settings.
        /// </summary>
        public const int CERT_E_UNTRUSTEDTESTROOT = (int)(0x800B010D - 0x100000000);
        /// <summary>
        /// The revocation process could not continue - the certificate(s) could not be checked.
        /// </summary>
        public const int CERT_E_REVOCATION_FAILURE = (int)(0x800B010E - 0x100000000);
        /// <summary>
        /// The certificate's CN name does not match the passed value.
        /// </summary>
        public const int CERT_E_CN_NO_MATCH = (int)(0x800B010F - 0x100000000);
        /// <summary>
        /// The certificate is not valid for the requested usage.
        /// </summary>
        public const int CERT_E_WRONG_USAGE = (int)(0x800B0110 - 0x100000000);
        /// <summary>
        /// The certificate was explicitly marked as untrusted by the user.
        /// </summary>
        public const int TRUST_E_EXPLICIT_DISTRUST = (int)(0x800B0111 - 0x100000000);
        /// <summary>
        /// A certification chain processed correctly, but one of the CA certificates is not trusted by the policy provider.
        /// </summary>
        public const int CERT_E_UNTRUSTEDCA = (int)(0x800B0112 - 0x100000000);
        /// <summary>
        /// The certificate has invalid policy.
        /// </summary>
        public const int CERT_E_INVALID_POLICY = (int)(0x800B0113 - 0x100000000);
        /// <summary>
        /// The certificate has an invalid name. The name is not included in the permitted list or is explicitly excluded.
        /// </summary>
        public const int CERT_E_INVALID_NAME = (int)(0x800B0114 - 0x100000000);
        /// <summary>
        /// A non-empty line was encountered in the INF before the start of a section.
        /// </summary>
        public const int SPAPI_E_EXPECTED_SECTION_NAME = (int)(0x800F0000 - 0x100000000);
        /// <summary>
        /// A section name marker in the INF is not complete, or does not exist on a line by itself.
        /// </summary>
        public const int SPAPI_E_BAD_SECTION_NAME_LINE = (int)(0x800F0001 - 0x100000000);
        /// <summary>
        /// An INF section was encountered whose name exceeds the maximum section name length.
        /// </summary>
        public const int SPAPI_E_SECTION_NAME_TOO_Int32 = (int)(0x800F0002 - 0x100000000);
        /// <summary>
        /// The syntax of the INF is invalid.
        /// </summary>
        public const int SPAPI_E_GENERAL_SYNTAX = (int)(0x800F0003 - 0x100000000);
        /// <summary>
        /// The style of the INF is different than what was requested.
        /// </summary>
        public const int SPAPI_E_WRONG_INF_STYLE = (int)(0x800F0100 - 0x100000000);
        /// <summary>
        /// The required section was not found in the INF.
        /// </summary>
        public const int SPAPI_E_SECTION_NOT_FOUND = (int)(0x800F0101 - 0x100000000);
        /// <summary>
        /// The required line was not found in the INF.
        /// </summary>
        public const int SPAPI_E_LINE_NOT_FOUND = (int)(0x800F0102 - 0x100000000);
        /// <summary>
        /// The files affected by the installation of this file queue have not been backed up for uninstall.
        /// </summary>
        public const int SPAPI_E_NO_BACKUP = (int)(0x800F0103 - 0x100000000);
        /// <summary>
        /// The INF or the device information set or element does not have an associated install class.
        /// </summary>
        public const int SPAPI_E_NO_ASSOCIATED_CLASS = (int)(0x800F0200 - 0x100000000);
        /// <summary>
        /// The INF or the device information set or element does not match the specified install class.
        /// </summary>
        public const int SPAPI_E_CLASS_MISMATCH = (int)(0x800F0201 - 0x100000000);
        /// <summary>
        /// An existing device was found that is a duplicate of the device being manually installed.
        /// </summary>
        public const int SPAPI_E_DUPLICATE_FOUND = (int)(0x800F0202 - 0x100000000);
        /// <summary>
        /// There is no driver selected for the device information set or element.
        /// </summary>
        public const int SPAPI_E_NO_DRIVER_SELECTED = (int)(0x800F0203 - 0x100000000);
        /// <summary>
        /// The requested device registry key does not exist.
        /// </summary>
        public const int SPAPI_E_KEY_DOES_NOT_EXIST = (int)(0x800F0204 - 0x100000000);
        /// <summary>
        /// The device instance name is invalid.
        /// </summary>
        public const int SPAPI_E_INVALID_DEVINST_NAME = (int)(0x800F0205 - 0x100000000);
        /// <summary>
        /// The install class is not present or is invalid.
        /// </summary>
        public const int SPAPI_E_INVALID_CLASS = (int)(0x800F0206 - 0x100000000);
        /// <summary>
        /// The device instance cannot be created because it already exists.
        /// </summary>
        public const int SPAPI_E_DEVINST_ALREADY_EXISTS = (int)(0x800F0207 - 0x100000000);
        /// <summary>
        /// The operation cannot be performed on a device information element that has not been registered.
        /// </summary>
        public const int SPAPI_E_DEVINFO_NOT_REGISTERED = (int)(0x800F0208 - 0x100000000);
        /// <summary>
        /// The device property code is invalid.
        /// </summary>
        public const int SPAPI_E_INVALID_REG_PROPERTY = (int)(0x800F0209 - 0x100000000);
        /// <summary>
        /// The INF from which a driver list is to be built does not exist.
        /// </summary>
        public const int SPAPI_E_NO_INF = (int)(0x800F020A - 0x100000000);
        /// <summary>
        /// The device instance does not exist in the hardware tree.
        /// </summary>
        public const int SPAPI_E_NO_SUCH_DEVINST = (int)(0x800F020B - 0x100000000);
        /// <summary>
        /// The icon representing this install class cannot be loaded.
        /// </summary>
        public const int SPAPI_E_CANT_LOAD_CLASS_ICON = (int)(0x800F020C - 0x100000000);
        /// <summary>
        /// The class installer registry entry is invalid.
        /// </summary>
        public const int SPAPI_E_INVALID_CLASS_INSTALLER = (int)(0x800F020D - 0x100000000);
        /// <summary>
        /// The class installer has indicated that the default action should be performed for this installation request.
        /// </summary>
        public const int SPAPI_E_DI_DO_DEFAULT = (int)(0x800F020E - 0x100000000);
        /// <summary>
        /// The operation does not require any files to be copied.
        /// </summary>
        public const int SPAPI_E_DI_NOFILECOPY = (int)(0x800F020F - 0x100000000);
        /// <summary>
        /// The specified hardware profile does not exist.
        /// </summary>
        public const int SPAPI_E_INVALID_HWPROFILE = (int)(0x800F0210 - 0x100000000);
        /// <summary>
        /// There is no device information element currently selected for this device information set.
        /// </summary>
        public const int SPAPI_E_NO_DEVICE_SELECTED = (int)(0x800F0211 - 0x100000000);
        /// <summary>
        /// The operation cannot be performed because the device information set is locked.
        /// </summary>
        public const int SPAPI_E_DEVINFO_LIST_LOCKED = (int)(0x800F0212 - 0x100000000);
        /// <summary>
        /// The operation cannot be performed because the device information element is locked.
        /// </summary>
        public const int SPAPI_E_DEVINFO_DATA_LOCKED = (int)(0x800F0213 - 0x100000000);
        /// <summary>
        /// The specified path does not contain any applicable device INFs.
        /// </summary>
        public const int SPAPI_E_DI_BAD_PATH = (int)(0x800F0214 - 0x100000000);
        /// <summary>
        /// No class installer parameters have been set for the device information set or element.
        /// </summary>
        public const int SPAPI_E_NO_CLASSINSTALL_PARAMS = (int)(0x800F0215 - 0x100000000);
        /// <summary>
        /// The operation cannot be performed because the file queue is locked.
        /// </summary>
        public const int SPAPI_E_FILEQUEUE_LOCKED = (int)(0x800F0216 - 0x100000000);
        /// <summary>
        /// A service installation section in this INF is invalid.
        /// </summary>
        public const int SPAPI_E_BAD_SERVICE_INSTALLSECT = (int)(0x800F0217 - 0x100000000);
        /// <summary>
        /// There is no class driver list for the device information element.
        /// </summary>
        public const int SPAPI_E_NO_CLASS_DRIVER_LIST = (int)(0x800F0218 - 0x100000000);
        /// <summary>
        /// The installation failed because a function driver was not specified for this device instance.
        /// </summary>
        public const int SPAPI_E_NO_ASSOCIATED_SERVICE = (int)(0x800F0219 - 0x100000000);
        /// <summary>
        /// There is presently no default device interface designated for this interface class.
        /// </summary>
        public const int SPAPI_E_NO_DEFAULT_DEVICE_INTERFACE = (int)(0x800F021A - 0x100000000);
        /// <summary>
        /// The operation cannot be performed because the device interface is currently active.
        /// </summary>
        public const int SPAPI_E_DEVICE_INTERFACE_ACTIVE = (int)(0x800F021B - 0x100000000);
        /// <summary>
        /// The operation cannot be performed because the device interface has been removed from the system.
        /// </summary>
        public const int SPAPI_E_DEVICE_INTERFACE_REMOVED = (int)(0x800F021C - 0x100000000);
        /// <summary>
        /// An interface installation section in this INF is invalid.
        /// </summary>
        public const int SPAPI_E_BAD_INTERFACE_INSTALLSECT = (int)(0x800F021D - 0x100000000);
        /// <summary>
        /// This interface class does not exist in the system.
        /// </summary>
        public const int SPAPI_E_NO_SUCH_INTERFACE_CLASS = (int)(0x800F021E - 0x100000000);
        /// <summary>
        /// The reference string supplied for this interface device is invalid.
        /// </summary>
        public const int SPAPI_E_INVALID_REFERENCE_STRING = (int)(0x800F021F - 0x100000000);
        /// <summary>
        /// The specified machine name does not conform to UNC naming conventions.
        /// </summary>
        public const int SPAPI_E_INVALID_MACHINENAME = (int)(0x800F0220 - 0x100000000);
        /// <summary>
        /// A general remote communication error occurred.
        /// </summary>
        public const int SPAPI_E_REMOTE_COMM_FAILURE = (int)(0x800F0221 - 0x100000000);
        /// <summary>
        /// The machine selected for remote communication is not available at this time.
        /// </summary>
        public const int SPAPI_E_MACHINE_UNAVAILABLE = (int)(0x800F0222 - 0x100000000);
        /// <summary>
        /// The Plug and Play service is not available on the remote machine.
        /// </summary>
        public const int SPAPI_E_NO_CONFIGMGR_SERVICES = (int)(0x800F0223 - 0x100000000);
        /// <summary>
        /// The property page provider registry entry is invalid.
        /// </summary>
        public const int SPAPI_E_INVALID_PROPPAGE_PROVIDER = (int)(0x800F0224 - 0x100000000);
        /// <summary>
        /// The requested device interface is not present in the system.
        /// </summary>
        public const int SPAPI_E_NO_SUCH_DEVICE_INTERFACE = (int)(0x800F0225 - 0x100000000);
        /// <summary>
        /// The device's co-installer has additional work to perform after installation is complete.
        /// </summary>
        public const int SPAPI_E_DI_POSTPROCESSING_REQUIRED = (int)(0x800F0226 - 0x100000000);
        /// <summary>
        /// The device's co-installer is invalid.
        /// </summary>
        public const int SPAPI_E_INVALID_COINSTALLER = (int)(0x800F0227 - 0x100000000);
        /// <summary>
        /// There are no compatible drivers for this device.
        /// </summary>
        public const int SPAPI_E_NO_COMPAT_DRIVERS = (int)(0x800F0228 - 0x100000000);
        /// <summary>
        /// There is no icon that represents this device or device type.
        /// </summary>
        public const int SPAPI_E_NO_DEVICE_ICON = (int)(0x800F0229 - 0x100000000);
        /// <summary>
        /// A logical configuration specified in this INF is invalid.
        /// </summary>
        public const int SPAPI_E_INVALID_INF_LOGCONFIG = (int)(0x800F022A - 0x100000000);
        /// <summary>
        /// The class installer has denied the request to install or upgrade this device.
        /// </summary>
        public const int SPAPI_E_DI_DONT_INSTALL = (int)(0x800F022B - 0x100000000);
        /// <summary>
        /// One of the filter drivers installed for this device is invalid.
        /// </summary>
        public const int SPAPI_E_INVALID_FILTER_DRIVER = (int)(0x800F022C - 0x100000000);
        /// <summary>
        /// The driver selected for this device does not support Windows XP.
        /// </summary>
        public const int SPAPI_E_NON_WINDOWS_NT_DRIVER = (int)(0x800F022D - 0x100000000);
        /// <summary>
        /// The driver selected for this device does not support Windows.
        /// </summary>
        public const int SPAPI_E_NON_WINDOWS_DRIVER = (int)(0x800F022E - 0x100000000);
        /// <summary>
        /// The third-party INF does not contain digital signature information.
        /// </summary>
        public const int SPAPI_E_NO_CATALOG_FOR_OEM_INF = (int)(0x800F022F - 0x100000000);
        /// <summary>
        /// An invalid attempt was made to use a device installation file queue for verification of digital signatures relative to other platforms.
        /// </summary>
        public const int SPAPI_E_DEVINSTALL_QUEUE_NONNATIVE = (int)(0x800F0230 - 0x100000000);
        /// <summary>
        /// The device cannot be disabled.
        /// </summary>
        public const int SPAPI_E_NOT_DISABLEABLE = (int)(0x800F0231 - 0x100000000);
        /// <summary>
        /// The device could not be dynamically removed.
        /// </summary>
        public const int SPAPI_E_CANT_REMOVE_DEVINST = (int)(0x800F0232 - 0x100000000);
        /// <summary>
        /// Cannot copy to specified target.
        /// </summary>
        public const int SPAPI_E_INVALID_TARGET = (int)(0x800F0233 - 0x100000000);
        /// <summary>
        /// Driver is not intended for this platform.
        /// </summary>
        public const int SPAPI_E_DRIVER_NONNATIVE = (int)(0x800F0234 - 0x100000000);
        /// <summary>
        /// Operation not allowed in WOW64.
        /// </summary>
        public const int SPAPI_E_IN_WOW64 = (int)(0x800F0235 - 0x100000000);
        /// <summary>
        /// The operation involving unsigned file copying was rolled back, so that a system restore point could be set.
        /// </summary>
        public const int SPAPI_E_SET_SYSTEM_RESTORE_POINT = (int)(0x800F0236 - 0x100000000);
        /// <summary>
        /// An INF was copied into the Windows INF directory in an improper manner.
        /// </summary>
        public const int SPAPI_E_INCORRECTLY_COPIED_INF = (int)(0x800F0237 - 0x100000000);
        /// <summary>
        /// The Security Configuration Editor (SCE) APIs have been disabled on this Embedded product.
        /// </summary>
        public const int SPAPI_E_SCE_DISABLED = (int)(0x800F0238 - 0x100000000);
        /// <summary>
        /// No installed components were detected.
        /// </summary>
        public const int SPAPI_E_ERROR_NOT_INSTALLED = (int)(0x800F1000 - 0x100000000);
        /// <summary>
        /// An internal consistency check failed.
        /// </summary>
        public const int SCARD_F_INTERNAL_ERROR = (int)(0x80100001 - 0x100000000);
        /// <summary>
        /// The action was cancelled by an SCardCancel request.
        /// </summary>
        public const int SCARD_E_CANCELLED = (int)(0x80100002 - 0x100000000);
        /// <summary>
        /// The supplied handle was invalid.
        /// </summary>
        public const int SCARD_E_INVALID_HANDLE = (int)(0x80100003 - 0x100000000);
        /// <summary>
        /// One or more of the supplied parameters could not be properly interpreted.
        /// </summary>
        public const int SCARD_E_INVALID_PARAMETER = (int)(0x80100004 - 0x100000000);
        /// <summary>
        /// Registry startup information is missing or invalid.
        /// </summary>
        public const int SCARD_E_INVALID_TARGET = (int)(0x80100005 - 0x100000000);
        /// <summary>
        /// Not enough memory available to complete this command.
        /// </summary>
        public const int SCARD_E_NO_MEMORY = (int)(0x80100006 - 0x100000000);
        /// <summary>
        /// An internal consistency timer has expired.
        /// </summary>
        public const int SCARD_F_WAITED_TOO_Int32 = (int)(0x80100007 - 0x100000000);
        /// <summary>
        /// The data buffer to receive returned data is too small for the returned data.
        /// </summary>
        public const int SCARD_E_INSUFFICIENT_BUFFER = (int)(0x80100008 - 0x100000000);
        /// <summary>
        /// The specified reader name is not recognized.
        /// </summary>
        public const int SCARD_E_UNKNOWN_READER = (int)(0x80100009 - 0x100000000);
        /// <summary>
        /// The user-specified timeout value has expired.
        /// </summary>
        public const int SCARD_E_TIMEOUT = (int)(0x8010000A - 0x100000000);
        /// <summary>
        /// The smart card cannot be accessed because of other connections outstanding.
        /// </summary>
        public const int SCARD_E_SHARING_VIOLATION = (int)(0x8010000B - 0x100000000);
        /// <summary>
        /// The operation requires a Smart Card, but no Smart Card is currently in the device.
        /// </summary>
        public const int SCARD_E_NO_SMARTCARD = (int)(0x8010000C - 0x100000000);
        /// <summary>
        /// The specified smart card name is not recognized.
        /// </summary>
        public const int SCARD_E_UNKNOWN_CARD = (int)(0x8010000D - 0x100000000);
        /// <summary>
        /// The system could not dispose of the media in the requested manner.
        /// </summary>
        public const int SCARD_E_CANT_DISPOSE = (int)(0x8010000E - 0x100000000);
        /// <summary>
        /// The requested protocols are incompatible with the protocol currently in use with the smart card.
        /// </summary>
        public const int SCARD_E_PROTO_MISMATCH = (int)(0x8010000F - 0x100000000);
        /// <summary>
        /// The reader or smart card is not ready to accept commands.
        /// </summary>
        public const int SCARD_E_NOT_READY = (int)(0x80100010 - 0x100000000);
        /// <summary>
        /// One or more of the supplied parameters values could not be properly interpreted.
        /// </summary>
        public const int SCARD_E_INVALID_VALUE = (int)(0x80100011 - 0x100000000);
        /// <summary>
        /// The action was cancelled by the system, presumably to log off or shut down.
        /// </summary>
        public const int SCARD_E_SYSTEM_CANCELLED = (int)(0x80100012 - 0x100000000);
        /// <summary>
        /// An internal communications error has been detected.
        /// </summary>
        public const int SCARD_F_COMM_ERROR = (int)(0x80100013 - 0x100000000);
        /// <summary>
        /// An internal error has been detected, but the source is unknown.
        /// </summary>
        public const int SCARD_F_UNKNOWN_ERROR = (int)(0x80100014 - 0x100000000);
        /// <summary>
        /// An ATR obtained from the registry is not a valid ATR string.
        /// </summary>
        public const int SCARD_E_INVALID_ATR = (int)(0x80100015 - 0x100000000);
        /// <summary>
        /// An attempt was made to end a non-existent transaction.
        /// </summary>
        public const int SCARD_E_NOT_TRANSACTED = (int)(0x80100016 - 0x100000000);
        /// <summary>
        /// The specified reader is not currently available for use.
        /// </summary>
        public const int SCARD_E_READER_UNAVAILABLE = (int)(0x80100017 - 0x100000000);
        /// <summary>
        /// The operation has been aborted to allow the server application to exit.
        /// </summary>
        public const int SCARD_P_SHUTDOWN = (int)(0x80100018 - 0x100000000);
        /// <summary>
        /// The PCI Receive buffer was too small.
        /// </summary>
        public const int SCARD_E_PCI_TOO_SMALL = (int)(0x80100019 - 0x100000000);
        /// <summary>
        /// The reader driver does not meet minimal requirements for support.
        /// </summary>
        public const int SCARD_E_READER_UNSUPPORTED = (int)(0x8010001A - 0x100000000);
        /// <summary>
        /// The reader driver did not produce a unique reader name.
        /// </summary>
        public const int SCARD_E_DUPLICATE_READER = (int)(0x8010001B - 0x100000000);
        /// <summary>
        /// The smart card does not meet minimal requirements for support.
        /// </summary>
        public const int SCARD_E_CARD_UNSUPPORTED = (int)(0x8010001C - 0x100000000);
        /// <summary>
        /// The Smart card resource manager is not running.
        /// </summary>
        public const int SCARD_E_NO_SERVICE = (int)(0x8010001D - 0x100000000);
        /// <summary>
        /// The Smart card resource manager has shut down.
        /// </summary>
        public const int SCARD_E_SERVICE_STOPPED = (int)(0x8010001E - 0x100000000);
        /// <summary>
        /// An unexpected card error has occurred.
        /// </summary>
        public const int SCARD_E_UNEXPECTED = (int)(0x8010001F - 0x100000000);
        /// <summary>
        /// No Primary Provider can be found for the smart card.
        /// </summary>
        public const int SCARD_E_ICC_INSTALLATION = (int)(0x80100020 - 0x100000000);
        /// <summary>
        /// The requested order of object creation is not supported.
        /// </summary>
        public const int SCARD_E_ICC_CREATEORDER = (int)(0x80100021 - 0x100000000);
        /// <summary>
        /// This smart card does not support the requested feature.
        /// </summary>
        public const int SCARD_E_UNSUPPORTED_FEATURE = (int)(0x80100022 - 0x100000000);
        /// <summary>
        /// The identified directory does not exist in the smart card.
        /// </summary>
        public const int SCARD_E_DIR_NOT_FOUND = (int)(0x80100023 - 0x100000000);
        /// <summary>
        /// The identified file does not exist in the smart card.
        /// </summary>
        public const int SCARD_E_FILE_NOT_FOUND = (int)(0x80100024 - 0x100000000);
        /// <summary>
        /// The supplied path does not represent a smart card directory.
        /// </summary>
        public const int SCARD_E_NO_DIR = (int)(0x80100025 - 0x100000000);
        /// <summary>
        /// The supplied path does not represent a smart card file.
        /// </summary>
        public const int SCARD_E_NO_FILE = (int)(0x80100026 - 0x100000000);
        /// <summary>
        /// Access is denied to this file.
        /// </summary>
        public const int SCARD_E_NO_ACCESS = (int)(0x80100027 - 0x100000000);
        /// <summary>
        /// The smartcard does not have enough memory to store the information.
        /// </summary>
        public const int SCARD_E_WRITE_TOO_MANY = (int)(0x80100028 - 0x100000000);
        /// <summary>
        /// There was an error trying to set the smart card file object pointer.
        /// </summary>
        public const int SCARD_E_BAD_SEEK = (int)(0x80100029 - 0x100000000);
        /// <summary>
        /// The supplied PIN is incorrect.
        /// </summary>
        public const int SCARD_E_INVALID_CHV = (int)(0x8010002A - 0x100000000);
        /// <summary>
        /// An unrecognized error code was returned from a layered component.
        /// </summary>
        public const int SCARD_E_UNKNOWN_RES_MNG = (int)(0x8010002B - 0x100000000);
        /// <summary>
        /// The requested certificate does not exist.
        /// </summary>
        public const int SCARD_E_NO_SUCH_CERTIFICATE = (int)(0x8010002C - 0x100000000);
        /// <summary>
        /// The requested certificate could not be obtained.
        /// </summary>
        public const int SCARD_E_CERTIFICATE_UNAVAILABLE = (int)(0x8010002D - 0x100000000);
        /// <summary>
        /// Cannot find a smart card reader.
        /// </summary>
        public const int SCARD_E_NO_READERS_AVAILABLE = (int)(0x8010002E - 0x100000000);
        /// <summary>
        /// A communications error with the smart card has been detected.  Retry the operation.
        /// </summary>
        public const int SCARD_E_COMM_DATA_LOST = (int)(0x8010002F - 0x100000000);
        /// <summary>
        /// The requested key container does not exist on the smart card.
        /// </summary>
        public const int SCARD_E_NO_KEY_CONTAINER = (int)(0x80100030 - 0x100000000);
        /// <summary>
        /// No information avialable.
        /// </summary>
        public const int SCARD_E_SERVER_TOO_BUSY = (int)(0x80100031 - 0x100000000);
        /// <summary>
        /// The reader cannot communicate with the smart card, due to ATR configuration conflicts.
        /// </summary>
        public const int SCARD_W_UNSUPPORTED_CARD = (int)(0x80100065 - 0x100000000);
        /// <summary>
        /// The smart card is not responding to a reset.
        /// </summary>
        public const int SCARD_W_UNRESPONSIVE_CARD = (int)(0x80100066 - 0x100000000);
        /// <summary>
        /// Power has been removed from the smart card, so that further communication is not possible.
        /// </summary>
        public const int SCARD_W_UNPOWERED_CARD = (int)(0x80100067 - 0x100000000);
        /// <summary>
        /// The smart card has been reset, so any shared state information is invalid.
        /// </summary>
        public const int SCARD_W_RESET_CARD = (int)(0x80100068 - 0x100000000);
        /// <summary>
        /// The smart card has been removed, so that further communication is not possible.
        /// </summary>
        public const int SCARD_W_REMOVED_CARD = (int)(0x80100069 - 0x100000000);
        /// <summary>
        /// Access was denied because of a security violation.
        /// </summary>
        public const int SCARD_W_SECURITY_VIOLATION = (int)(0x8010006A - 0x100000000);
        /// <summary>
        /// The card cannot be accessed because the wrong PIN was presented.
        /// </summary>
        public const int SCARD_W_WRONG_CHV = (int)(0x8010006B - 0x100000000);
        /// <summary>
        /// The card cannot be accessed because the maximum number of PIN entry attempts has been reached.
        /// </summary>
        public const int SCARD_W_CHV_BLOCKED = (int)(0x8010006C - 0x100000000);
        /// <summary>
        /// The end of the smart card file has been reached.
        /// </summary>
        public const int SCARD_W_EOF = (int)(0x8010006D - 0x100000000);
        /// <summary>
        /// The action was cancelled by the user.
        /// </summary>
        public const int SCARD_W_CANCELLED_BY_USER = (int)(0x8010006E - 0x100000000);
        /// <summary>
        /// No PIN was presented to the smart card.
        /// </summary>
        public const int SCARD_W_CARD_NOT_AUTHENTICATED = (int)(0x8010006F - 0x100000000);
        /// <summary>
        /// Errors occurred accessing one or more objects - the ErrorInfo collection may have more detail
        /// </summary>
        public const int COMADMIN_E_OBJECTERRORS = (int)(0x80110401 - 0x100000000);
        /// <summary>
        /// One or more of the object's properties are missing or invalid
        /// </summary>
        public const int COMADMIN_E_OBJECTINVALID = (int)(0x80110402 - 0x100000000);
        /// <summary>
        /// The object was not found in the catalog
        /// </summary>
        public const int COMADMIN_E_KEYMISSING = (int)(0x80110403 - 0x100000000);
        /// <summary>
        /// The object is already registered
        /// </summary>
        public const int COMADMIN_E_ALREADYINSTALLED = (int)(0x80110404 - 0x100000000);
        /// <summary>
        /// Error occurred writing to the application file
        /// </summary>
        public const int COMADMIN_E_APP_FILE_WRITEFAIL = (int)(0x80110407 - 0x100000000);
        /// <summary>
        /// Error occurred reading the application file
        /// </summary>
        public const int COMADMIN_E_APP_FILE_READFAIL = (int)(0x80110408 - 0x100000000);
        /// <summary>
        /// Invalid version number in application file
        /// </summary>
        public const int COMADMIN_E_APP_FILE_VERSION = (int)(0x80110409 - 0x100000000);
        /// <summary>
        /// The file path is invalid
        /// </summary>
        public const int COMADMIN_E_BADPATH = (int)(0x8011040A - 0x100000000);
        /// <summary>
        /// The application is already installed
        /// </summary>
        public const int COMADMIN_E_APPLICATIONEXISTS = (int)(0x8011040B - 0x100000000);
        /// <summary>
        /// The role already exists
        /// </summary>
        public const int COMADMIN_E_ROLEEXISTS = (int)(0x8011040C - 0x100000000);
        /// <summary>
        /// An error occurred copying the file
        /// </summary>
        public const int COMADMIN_E_CANTCOPYFILE = (int)(0x8011040D - 0x100000000);
        /// <summary>
        /// One or more users are not valid
        /// </summary>
        public const int COMADMIN_E_NOUSER = (int)(0x8011040F - 0x100000000);
        /// <summary>
        /// One or more users in the application file are not valid
        /// </summary>
        public const int COMADMIN_E_INVALIDUSERIDS = (int)(0x80110410 - 0x100000000);
        /// <summary>
        /// The component's CLSID is missing or corrupt
        /// </summary>
        public const int COMADMIN_E_NOREGISTRYCLSID = (int)(0x80110411 - 0x100000000);
        /// <summary>
        /// The component's progID is missing or corrupt
        /// </summary>
        public const int COMADMIN_E_BADREGISTRYPROGID = (int)(0x80110412 - 0x100000000);
        /// <summary>
        /// Unable to set required authentication level for update request
        /// </summary>
        public const int COMADMIN_E_AUTHENTICATIONLEVEL = (int)(0x80110413 - 0x100000000);
        /// <summary>
        /// The identity or password set on the application is not valid
        /// </summary>
        public const int COMADMIN_E_USERPASSWDNOTVALID = (int)(0x80110414 - 0x100000000);
        /// <summary>
        /// Application file CLSIDs or IIDs do not match corresponding DLLs
        /// </summary>
        public const int COMADMIN_E_CLSIDORIIDMISMATCH = (int)(0x80110418 - 0x100000000);
        /// <summary>
        /// Interface information is either missing or changed
        /// </summary>
        public const int COMADMIN_E_REMOTEINTERFACE = (int)(0x80110419 - 0x100000000);
        /// <summary>
        /// DllRegisterServer failed on component install
        /// </summary>
        public const int COMADMIN_E_DLLREGISTERSERVER = (int)(0x8011041A - 0x100000000);
        /// <summary>
        /// No server file share available
        /// </summary>
        public const int COMADMIN_E_NOSERVERSHARE = (int)(0x8011041B - 0x100000000);
        /// <summary>
        /// DLL could not be loaded
        /// </summary>
        public const int COMADMIN_E_DLLLOADFAILED = (int)(0x8011041D - 0x100000000);
        /// <summary>
        /// The registered TypeLib ID is not valid
        /// </summary>
        public const int COMADMIN_E_BADREGISTRYLIBID = (int)(0x8011041E - 0x100000000);
        /// <summary>
        /// Application install directory not found
        /// </summary>
        public const int COMADMIN_E_APPDIRNOTFOUND = (int)(0x8011041F - 0x100000000);
        /// <summary>
        /// Errors occurred while in the component registrar
        /// </summary>
        public const int COMADMIN_E_REGISTRARFAILED = (int)(0x80110423 - 0x100000000);
        /// <summary>
        /// The file does not exist
        /// </summary>
        public const int COMADMIN_E_COMPFILE_DOESNOTEXIST = (int)(0x80110424 - 0x100000000);
        /// <summary>
        /// The DLL could not be loaded
        /// </summary>
        public const int COMADMIN_E_COMPFILE_LOADDLLFAIL = (int)(0x80110425 - 0x100000000);
        /// <summary>
        /// GetClassObject failed in the DLL
        /// </summary>
        public const int COMADMIN_E_COMPFILE_GETCLASSOBJ = (int)(0x80110426 - 0x100000000);
        /// <summary>
        /// The DLL does not support the components listed in the TypeLib
        /// </summary>
        public const int COMADMIN_E_COMPFILE_CLASSNOTAVAIL = (int)(0x80110427 - 0x100000000);
        /// <summary>
        /// The TypeLib could not be loaded
        /// </summary>
        public const int COMADMIN_E_COMPFILE_BADTLB = (int)(0x80110428 - 0x100000000);
        /// <summary>
        /// The file does not contain components or component information
        /// </summary>
        public const int COMADMIN_E_COMPFILE_NOTINSTALLABLE = (int)(0x80110429 - 0x100000000);
        /// <summary>
        /// Changes to this object and its sub-objects have been disabled
        /// </summary>
        public const int COMADMIN_E_NOTCHANGEABLE = (int)(0x8011042A - 0x100000000);
        /// <summary>
        /// The delete function has been disabled for this object
        /// </summary>
        public const int COMADMIN_E_NOTDELETEABLE = (int)(0x8011042B - 0x100000000);
        /// <summary>
        /// The server catalog version is not supported
        /// </summary>
        public const int COMADMIN_E_SESSION = (int)(0x8011042C - 0x100000000);
        /// <summary>
        /// The component move was disallowed, because the source or destination application is either a system application or currently locked against changes
        /// </summary>
        public const int COMADMIN_E_COMP_MOVE_LOCKED = (int)(0x8011042D - 0x100000000);
        /// <summary>
        /// The component move failed because the destination application no longer exists
        /// </summary>
        public const int COMADMIN_E_COMP_MOVE_BAD_DEST = (int)(0x8011042E - 0x100000000);
        /// <summary>
        /// The system was unable to register the TypeLib
        /// </summary>
        public const int COMADMIN_E_REGISTERTLB = (int)(0x80110430 - 0x100000000);
        /// <summary>
        /// This operation can not be performed on the system application
        /// </summary>
        public const int COMADMIN_E_SYSTEMAPP = (int)(0x80110433 - 0x100000000);
        /// <summary>
        /// The component registrar referenced in this file is not available
        /// </summary>
        public const int COMADMIN_E_COMPFILE_NOREGISTRAR = (int)(0x80110434 - 0x100000000);
        /// <summary>
        /// A component in the same DLL is already installed
        /// </summary>
        public const int COMADMIN_E_COREQCOMPINSTALLED = (int)(0x80110435 - 0x100000000);
        /// <summary>
        /// The service is not installed
        /// </summary>
        public const int COMADMIN_E_SERVICENOTINSTALLED = (int)(0x80110436 - 0x100000000);
        /// <summary>
        /// One or more property settings are either invalid or in conflict with each other
        /// </summary>
        public const int COMADMIN_E_PROPERTYSAVEFAILED = (int)(0x80110437 - 0x100000000);
        /// <summary>
        /// The object you are attempting to add or rename already exists
        /// </summary>
        public const int COMADMIN_E_OBJECTEXISTS = (int)(0x80110438 - 0x100000000);
        /// <summary>
        /// The component already exists
        /// </summary>
        public const int COMADMIN_E_COMPONENTEXISTS = (int)(0x80110439 - 0x100000000);
        /// <summary>
        /// The registration file is corrupt
        /// </summary>
        public const int COMADMIN_E_REGFILE_CORRUPT = (int)(0x8011043B - 0x100000000);
        /// <summary>
        /// The property value is too large
        /// </summary>
        public const int COMADMIN_E_PROPERTY_OVERFLOW = (int)(0x8011043C - 0x100000000);
        /// <summary>
        /// Object was not found in registry
        /// </summary>
        public const int COMADMIN_E_NOTINREGISTRY = (int)(0x8011043E - 0x100000000);
        /// <summary>
        /// This object is not poolable
        /// </summary>
        public const int COMADMIN_E_OBJECTNOTPOOLABLE = (int)(0x8011043F - 0x100000000);
        /// <summary>
        /// A CLSID with the same GUID as the new application ID is already installed on this machine
        /// </summary>
        public const int COMADMIN_E_APPLID_MATCHES_CLSID = (int)(0x80110446 - 0x100000000);
        /// <summary>
        /// A role assigned to a component, interface, or method did not exist in the application
        /// </summary>
        public const int COMADMIN_E_ROLE_DOES_NOT_EXIST = (int)(0x80110447 - 0x100000000);
        /// <summary>
        /// You must have components in an application in order to start the application
        /// </summary>
        public const int COMADMIN_E_START_APP_NEEDS_COMPONENTS = (int)(0x80110448 - 0x100000000);
        /// <summary>
        /// This operation is not enabled on this platform
        /// </summary>
        public const int COMADMIN_E_REQUIRES_DIFFERENT_PLATFORM = (int)(0x80110449 - 0x100000000);
        /// <summary>
        /// Application Proxy is not exportable
        /// </summary>
        public const int COMADMIN_E_CAN_NOT_EXPORT_APP_PROXY = (int)(0x8011044A - 0x100000000);
        /// <summary>
        /// Failed to start application because it is either a library application or an application proxy
        /// </summary>
        public const int COMADMIN_E_CAN_NOT_START_APP = (int)(0x8011044B - 0x100000000);
        /// <summary>
        /// System application is not exportable
        /// </summary>
        public const int COMADMIN_E_CAN_NOT_EXPORT_SYS_APP = (int)(0x8011044C - 0x100000000);
        /// <summary>
        /// Can not subscribe to this component (the component may have been imported)
        /// </summary>
        public const int COMADMIN_E_CANT_SUBSCRIBE_TO_COMPONENT = (int)(0x8011044D - 0x100000000);
        /// <summary>
        /// An event class cannot also be a subscriber component
        /// </summary>
        public const int COMADMIN_E_EVENTCLASS_CANT_BE_SUBSCRIBER = (int)(0x8011044E - 0x100000000);
        /// <summary>
        /// Library applications and application proxies are incompatible
        /// </summary>
        public const int COMADMIN_E_LIB_APP_PROXY_INCOMPATIBLE = (int)(0x8011044F - 0x100000000);
        /// <summary>
        /// This function is valid for the base partition only
        /// </summary>
        public const int COMADMIN_E_BASE_PARTITION_ONLY = (int)(0x80110450 - 0x100000000);
        /// <summary>
        /// You cannot start an application that has been disabled
        /// </summary>
        public const int COMADMIN_E_START_APP_DISABLED = (int)(0x80110451 - 0x100000000);
        /// <summary>
        /// The specified partition name is already in use on this computer
        /// </summary>
        public const int COMADMIN_E_CAT_DUPLICATE_PARTITION_NAME = (int)(0x80110457 - 0x100000000);
        /// <summary>
        /// The specified partition name is invalid. Check that the name contains at least one visible character
        /// </summary>
        public const int COMADMIN_E_CAT_INVALID_PARTITION_NAME = (int)(0x80110458 - 0x100000000);
        /// <summary>
        /// The partition cannot be deleted because it is the default partition for one or more users
        /// </summary>
        public const int COMADMIN_E_CAT_PARTITION_IN_USE = (int)(0x80110459 - 0x100000000);
        /// <summary>
        /// The partition cannot be exported, because one or more components in the partition have the same file name
        /// </summary>
        public const int COMADMIN_E_FILE_PARTITION_DUPLICATE_FILES = (int)(0x8011045A - 0x100000000);
        /// <summary>
        /// Applications that contain one or more imported components cannot be installed into a non-base partition
        /// </summary>
        public const int COMADMIN_E_CAT_IMPORTED_COMPONENTS_NOT_ALLOWED = (int)(0x8011045B - 0x100000000);
        /// <summary>
        /// The application name is not unique and cannot be resolved to an application id
        /// </summary>
        public const int COMADMIN_E_AMBIGUOUS_APPLICATION_NAME = (int)(0x8011045C - 0x100000000);
        /// <summary>
        /// The partition name is not unique and cannot be resolved to a partition id
        /// </summary>
        public const int COMADMIN_E_AMBIGUOUS_PARTITION_NAME = (int)(0x8011045D - 0x100000000);
        /// <summary>
        /// The COM+ registry database has not been initialized
        /// </summary>
        public const int COMADMIN_E_REGDB_NOTINITIALIZED = (int)(0x80110472 - 0x100000000);
        /// <summary>
        /// The COM+ registry database is not open
        /// </summary>
        public const int COMADMIN_E_REGDB_NOTOPEN = (int)(0x80110473 - 0x100000000);
        /// <summary>
        /// The COM+ registry database detected a system error
        /// </summary>
        public const int COMADMIN_E_REGDB_SYSTEMERR = (int)(0x80110474 - 0x100000000);
        /// <summary>
        /// The COM+ registry database is already running
        /// </summary>
        public const int COMADMIN_E_REGDB_ALREADYRUNNING = (int)(0x80110475 - 0x100000000);
        /// <summary>
        /// This version of the COM+ registry database cannot be migrated
        /// </summary>
        public const int COMADMIN_E_MIG_VERSIONNOTSUPPORTED = (int)(0x80110480 - 0x100000000);
        /// <summary>
        /// The schema version to be migrated could not be found in the COM+ registry database
        /// </summary>
        public const int COMADMIN_E_MIG_SCHEMANOTFOUND = (int)(0x80110481 - 0x100000000);
        /// <summary>
        /// There was a type mismatch between binaries
        /// </summary>
        public const int COMADMIN_E_CAT_BITNESSMISMATCH = (int)(0x80110482 - 0x100000000);
        /// <summary>
        /// A binary of unknown or invalid type was provided
        /// </summary>
        public const int COMADMIN_E_CAT_UNACCEPTABLEBITNESS = (int)(0x80110483 - 0x100000000);
        /// <summary>
        /// There was a type mismatch between a binary and an application
        /// </summary>
        public const int COMADMIN_E_CAT_WRONGAPPBITNESS = (int)(0x80110484 - 0x100000000);
        /// <summary>
        /// The application cannot be paused or resumed
        /// </summary>
        public const int COMADMIN_E_CAT_PAUSE_RESUME_NOT_SUPPORTED = (int)(0x80110485 - 0x100000000);
        /// <summary>
        /// The COM+ Catalog Server threw an exception during execution
        /// </summary>
        public const int COMADMIN_E_CAT_SERVERFAULT = (int)(0x80110486 - 0x100000000);
        /// <summary>
        /// Only COM+ Applications marked "queued" can be invoked using the "queue" moniker
        /// </summary>
        public const int COMQC_E_APPLICATION_NOT_QUEUED = (int)(0x80110600 - 0x100000000);
        /// <summary>
        /// At least one interface must be marked "queued" in order to create a queued component instance with the "queue" moniker
        /// </summary>
        public const int COMQC_E_NO_QUEUEABLE_INTERFACES = (int)(0x80110601 - 0x100000000);
        /// <summary>
        /// MSMQ is required for the requested operation and is not installed
        /// </summary>
        public const int COMQC_E_QUEUING_SERVICE_NOT_AVAILABLE = (int)(0x80110602 - 0x100000000);
        /// <summary>
        /// Unable to marshal an interface that does not support IPersistStream
        /// </summary>
        public const int COMQC_E_NO_IPERSISTSTREAM = (int)(0x80110603 - 0x100000000);
        /// <summary>
        /// The message is improperly formatted or was damaged in transit
        /// </summary>
        public const int COMQC_E_BAD_MESSAGE = (int)(0x80110604 - 0x100000000);
        /// <summary>
        /// An unauthenticated message was received by an application that accepts only authenticated messages
        /// </summary>
        public const int COMQC_E_UNAUTHENTICATED = (int)(0x80110605 - 0x100000000);
        /// <summary>
        /// The message was requeued or moved by a user not in the "QC Trusted User" role
        /// </summary>
        public const int COMQC_E_UNTRUSTED_ENQUEUER = (int)(0x80110606 - 0x100000000);
        /// <summary>
        /// Cannot create a duplicate resource of type Distributed Transaction Coordinator
        /// </summary>
        public const int MSDTC_E_DUPLICATE_RESOURCE = (int)(0x80110701 - 0x100000000);
        /// <summary>
        /// One of the objects being inserted or updated does not belong to a valid parent collection
        /// </summary>
        public const int COMADMIN_E_OBJECT_PARENT_MISSING = (int)(0x80110808 - 0x100000000);
        /// <summary>
        /// One of the specified objects cannot be found
        /// </summary>
        public const int COMADMIN_E_OBJECT_DOES_NOT_EXIST = (int)(0x80110809 - 0x100000000);
        /// <summary>
        /// The specified application is not currently running
        /// </summary>
        public const int COMADMIN_E_APP_NOT_RUNNING = (int)(0x8011080A - 0x100000000);
        /// <summary>
        /// The partition(s) specified are not valid.
        /// </summary>
        public const int COMADMIN_E_INVALID_PARTITION = (int)(0x8011080B - 0x100000000);
        /// <summary>
        /// COM+ applications that run as NT service may not be pooled or recycled
        /// </summary>
        public const int COMADMIN_E_SVCAPP_NOT_POOLABLE_OR_RECYCLABLE = (int)(0x8011080D - 0x100000000);
        /// <summary>
        /// One or more users are already assigned to a local partition set.
        /// </summary>
        public const int COMADMIN_E_USER_IN_SET = (int)(0x8011080E - 0x100000000);
        /// <summary>
        /// Library applications may not be recycled.
        /// </summary>
        public const int COMADMIN_E_CANTRECYCLELIBRARYAPPS = (int)(0x8011080F - 0x100000000);
        /// <summary>
        /// Applications running as NT services may not be recycled.
        /// </summary>
        public const int COMADMIN_E_CANTRECYCLESERVICEAPPS = (int)(0x80110811 - 0x100000000);
        /// <summary>
        /// The process has already been recycled.
        /// </summary>
        public const int COMADMIN_E_PROCESSALREADYRECYCLED = (int)(0x80110812 - 0x100000000);
        /// <summary>
        /// A paused process may not be recycled.
        /// </summary>
        public const int COMADMIN_E_PAUSEDPROCESSMAYNOTBERECYCLED = (int)(0x80110813 - 0x100000000);
        /// <summary>
        /// Library applications may not be NT services.
        /// </summary>
        public const int COMADMIN_E_CANTMAKEINPROCSERVICE = (int)(0x80110814 - 0x100000000);
        /// <summary>
        /// The ProgID provided to the copy operation is invalid. The ProgID is in use by another registered CLSID.
        /// </summary>
        public const int COMADMIN_E_PROGIDINUSEBYCLSID = (int)(0x80110815 - 0x100000000);
        /// <summary>
        /// The partition specified as default is not a member of the partition set.
        /// </summary>
        public const int COMADMIN_E_DEFAULT_PARTITION_NOT_IN_SET = (int)(0x80110816 - 0x100000000);
        /// <summary>
        /// A recycled process may not be paused.
        /// </summary>
        public const int COMADMIN_E_RECYCLEDPROCESSMAYNOTBEPAUSED = (int)(0x80110817 - 0x100000000);
        /// <summary>
        /// Access to the specified partition is denied.
        /// </summary>
        public const int COMADMIN_E_PARTITION_ACCESSDENIED = (int)(0x80110818 - 0x100000000);
        /// <summary>
        /// Only Application Files (*.MSI files) can be installed into partitions.
        /// </summary>
        public const int COMADMIN_E_PARTITION_MSI_ONLY = (int)(0x80110819 - 0x100000000);
        /// <summary>
        /// Applications containing one or more legacy components may not be exported to 1.0 format.
        /// </summary>
        public const int COMADMIN_E_LEGACYCOMPS_NOT_ALLOWED_IN_1_0_FORMAT = (int)(0x8011081A - 0x100000000);
        /// <summary>
        /// Legacy components may not exist in non-base partitions.
        /// </summary>
        public const int COMADMIN_E_LEGACYCOMPS_NOT_ALLOWED_IN_NONBASE_PARTITIONS = (int)(0x8011081B - 0x100000000);
        /// <summary>
        /// A component cannot be moved (or copied) from the System Application, an application proxy or a non-changeable application
        /// </summary>
        public const int COMADMIN_E_COMP_MOVE_SOURCE = (int)(0x8011081C - 0x100000000);
        /// <summary>
        /// A component cannot be moved (or copied) to the System Application, an application proxy or a non-changeable application
        /// </summary>
        public const int COMADMIN_E_COMP_MOVE_DEST = (int)(0x8011081D - 0x100000000);
        /// <summary>
        /// A private component cannot be moved (or copied) to a library application or to the base partition
        /// </summary>
        public const int COMADMIN_E_COMP_MOVE_PRIVATE = (int)(0x8011081E - 0x100000000);
        /// <summary>
        /// The Base Application Partition exists in all partition sets and cannot be removed.
        /// </summary>
        public const int COMADMIN_E_BASEPARTITION_REQUIRED_IN_SET = (int)(0x8011081F - 0x100000000);
        /// <summary>
        /// Alas, Event Class components cannot be aliased.
        /// </summary>
        public const int COMADMIN_E_CANNOT_ALIAS_EVENTCLASS = (int)(0x80110820 - 0x100000000);
        /// <summary>
        /// Access is denied because the component is private.
        /// </summary>
        public const int COMADMIN_E_PRIVATE_ACCESSDENIED = (int)(0x80110821 - 0x100000000);
        /// <summary>
        /// The specified SAFER level is invalid.
        /// </summary>
        public const int COMADMIN_E_SAFERINVALID = (int)(0x80110822 - 0x100000000);
        /// <summary>
        /// The specified user cannot write to the system registry
        /// </summary>
        public const int COMADMIN_E_REGISTRY_ACCESSDENIED = (int)(0x80110823 - 0x100000000);
        /// <summary>
        /// No information avialable.
        /// </summary>
        public const int COMADMIN_E_PARTITIONS_DISABLED = (int)(0x80110824 - 0x100000000);
        /// <summary>
        /// Failed to open a file.
        /// </summary>
        public const int NS_E_FILE_OPEN_FAILED = (int)(0xC00D001DL - 0x100000000);

        public static bool Succeeded(int result)
        {
            return result >= 0;
        }

        public static bool Failed(int result)
        {
            return result < 0;
        }
    }
}
/******************************************************************************/
/*                END OF FILE                 */
/******************************************************************************/
