using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETS.SwitchFramework
{
    public class EptDeviceEnum
    {
    }

    public enum TEMSModuleType
    {
        EMSType_Unused = 0,
        EMSType_2XSP2T,
        EMSType_4XSP2T,
        EMSType_2XSP6T,
        EMSType_EMControl,
        EMSType_1XSP6T,
        EMSType_1XSP2T
    }
    public enum TDataAwareTypes
    {
        //Append string types to the end of this section
        zzNothing = 0,
        //STRING SECTION START
        szTestMethod,
        szAnalyzerType,
        szAnalyzerSelection,
        szNSAFile,
        szRawDataDir,
        szFinalDataDir,
        szStandardFile,
        szDataOutFormatFile,
        szCertificateFile,
        szEquipmentPackageDescription,
        szEquipmentModuleDescription,
        szOperator,
        szTransmitAF,
        szReceiveAF,
        szIUTManufacturer,
        szIUTModel,
        szIUTSerialNo,
        szIUTType,
        szESAntennaMast,
        szESSigGenRecv,
        szESSpectAnal,
        szESSigGen,
        szOpComments,
        szAppMessage,
        szNetworkAnalyzer,
        szIdString,
        szIUTFrame,
        szRangeOwner,
        szTestTime,
        szEquipSelect,
        szESTurnTable,
        szNetworkAnalyzer2,
        szESSpectAnal2,
        szESSigGen2,
        szESSigGenRecv2,
        szESPowerMeter,
        szESPowerMeter2,
        szESHybridType,
        szESHybridType2,
        szCorFiles,
        szNodeTitle,
        szGraphPrintDocument,
        szLicenseType,
        szCorFilesH,
        szCorFilesV,
        szTestEventLog,
        szPositioner1,
        szPositioner2,
        szTestEndTime,
        szAbsRelPortDefs,    // used to define A/R, B/R, A/B, A, & B for 8510
        szTemperature,       // replaces dTemperature to allow use of units.
        szHumidity,          // replaces dHumidity to allow use of units.
        szUserDef,           // User Defined Parameters for History Display
        szUserDefBtns,       // Hidden Field used to hold Selected Checkboxes
        BSS_szMSID, // this could be a 50 bit integer, so let's store it as a string!  1125899906842624
        szSwitchSettings,    // Switch settings will to stored as 100111|000111| ... etc.
        szSwitchStateDelay,  // Pause after switch state change to be stored as 0|25|36|...etc.
        szUserInitConfig,    // Holds user initial configuration parameters for defined ranges and such
        szAppVersion,        // Version Info saved in all data files
        szParmFileName,
        szEmailContacts,
        szWaveFile,
        szConfigPresetLabel,
        szAncillaryEquipSelections,
        szBatchFiles,        // Batch files list for batch test parm
        BSS_szCDMA_MSID,     // CDMA MIN or IMSI Mobile ID
        szHybridEquipName1,
        szHybridModuleName1,
        szHybridEquipName2,
        szHybridModuleName2,
        szHybridEquipName3,
        szHybridModuleName3,
        szOutputFilePrefix,
        szAncillaryConfigLabel,
        szPwrMeterFunction,
        szChariotINIPath,
        szChariotERRPath,
        szChariotDataPath,
        szChariotINIData,
        szChariotEndpoint1,
        szChariotEndpoint2,
        szChariotScript,
        szAncillaryListStates,
        BSS_szIMSI_11_12,        // IMSI Digits 11 & 12
        BSS_szAuthChallenge,     // Authentication Challenge
        szTestSummary,
        szTestElapsedTime,
        szServerAddress,
        szUserDefinedTestPrompt,
        szUserDefinedLabels,
        szUserDefString_01,
        szUserDefString_02,
        szUserDefString_03,
        szUserDefString_04,
        szUserDefString_05,
        szUserDefString_06,
        szUserDefString_07,
        szUserDefString_08,
        szUserDefString_09,
        szUserDefString_10,
        szUserDefString_11,
        szUserDefString_12,
        szUserDefString_13,
        szUserDefString_14,
        szUserDefString_15,
        szUserDefString_16,
        szUserDefString_17,
        szUserDefString_18,
        szUserDefString_19,
        szUserDefString_20,
        szSerialNumberBuffer,
        szTestFailPath,
        szTestPassPath,
        szTestTimeStamp,
        BSS_szPagingMSIN,   //CDMA IMSI Paging MSIN
        BSS_szPagingMCC,    //CDMA IMSI Paging MCC
        BSS_szPagingMNC,    //CDMA IMSI Paging MNC
        BSS_szFixedPattern, //CDMA200 TDSO F-SCH Fixed Pattern
        szIPAddress,        //Added for NI VISA -- Also using as a parm for DUT IP address for MT8860 (could use ChariotEndpoint)
        BSS_szUEReqSecKey, //UE Data Security Keys 1/2
        BSS_szUEIDIMSI,   //Network ID UEID-IMSI
        BSS_szBaseIPAddress,  // IP address of tester           (could use ChariotEndpoint)
        BSS_szBaseSubnetMask,  // IP subnet mask of tester
        BSS_szMACAddress,      // MAC Address of DUT
        BSS_szSSID,            // Network SSID
        BSS_szSoftAPModule,    // Azimuth systems specific AP Configuration module
        BSS_szCaptureModule,   // Azimuth systems specific Traffic Configuration module
        AZ_szTclInterface,     // Azimuth systems Tcl interface dll path
        BSS_szWCDMA_RVSeq,       //RV Sequence
        BSS_szWCDMA_HrntiPri,  //HSPDA Primary H-RNTI
        BSS_szWCDMA_HrntiAlt,  //HSPDA Alternate H-RNTI
        BSS_szPrachSign,        //PRACH Signature
        BSS_szRandKey,          //RAND value
        BSS_szAMF,              //AMF Value
        BSS_sziOPVAlg,          //Operator Variant Auth Alg
        szMacAddressTester,     //MAC Address of test equipment
        szSSID_DUT,             //SSID of AP under test
        szExePathName,
        szWindowName,
        szMeasurementIDNs,      //list of measurement equipment used
        szDeviceOpt01,           //generic variable string variable
        szDeviceOpt02,           //generic variable string variable
        szDeviceOpt03,           //generic variable string variable
        szDeviceOpt04,           //generic variable string variable
        szDeviceOpt05,           //generic variable string variable
        szDeviceOpt06,           //generic variable string variable
        szDeviceOpt07,           //generic variable string variable
        szDeviceOpt08,           //generic variable string variable
        szDeviceOpt09,           //generic variable string variable
        szDeviceOpt10,          //generic variable string variable
        szRangeExtender,
        BSS_szBSID,             // E6651 Base station ID
        BSS_szProfileID,        // E6651 profile descriptor
        BSS_szSSIPDestination,  // E6651 SS IP Address
        BSS_szDummy1,           // Placeholder for E6651 values
        BSS_szDummy2,           // Placeholder for E6651 values
        szEquipSelect1,           //More equipment selection parms
        szEquipSelect2,           //More equipment selection parms
        szAxisType,              //Axis is Theta, Phi, etc.
        szLimitLines,            //Correction limit lines
        szSGScenarioFile,       //A-GPS Signal Generator Scenario File
        szSGScenarioFileTIS,    //A-GPS Signal Generator Scenario File for sensitivity measurements
        szATP_SPOT,             //Alt. Test Proc - Single Pt. Offset Test
        szATP_PatternFile1,     //Pattern files that can be arguments to ATP tests (3 channels could come from 3 different tests)
        szATP_PatternFile2,
        szATP_PatternFile3,
        szAgilentCOMDriverPath,
        szAgilentCOMAssistStrings,
        szAgilentCOMHRAssistStrings,
        szUEBasedGPSPatternFile,
        szCurrentDUT,
        szCellFormat,
        szTestPlan,
        szHybridEquipName4,
        szHybridModuleName4,
        szF8SimFile,
        szOutAngularCorrectFile,
        szInCorrectionFile1,
        szF8Dummy2,
        szF8Dummy3,
        szF8Dummy4,
        szF8Dummy5,
        szF8Dummy6,
        szF8Dummy7,
        szF8Dummy8,
        szDUT_IP_Address,
        szExt_PDSN_IP_Address,
        szDUT_Pri_DNS_IP_Address,
        szDUT_Sec_DNS_IP_Address,
        szTDSCDMA_SyncULCodeBitmap,//Sync UL Code Bitmap
        szF8SimFileNoPath,
        szEquipSelect3,   //hopefully I won't have to add anymore for a while
        szEquipSelect4,
        szEquipSelect5,
        szThetaPositionerSelect,  //silly me and my assumptions.
        szPhiPositionerSelect,
        // Starting new naming convention from here on.  TDataAwareTypes (parameters)
        // are now labeled as <type>prmParameterName, e.g. szprmPhiPositionerSelect
        szprmNodeTag,
        szHSPA_OCNS_ConfigState,      //call:ocnsource:config:state:hsdpa
        szHSPA_OCNSCode,              //call:ocnsource:ccode:code:hsdpa
                                      //LTE (CMW 500)
        szprmLTE_EUTRAN_CellIdent,  //E-UTRAN Cell Identifier
        szprmLTE_RMC_DL_Mod,        //RMC Downlink Modulation
        szprmLTE_RMC_UL_Mod,        //RMC Uplink Modulation
        szprmLTE_UDCH_DL_Mod,       //User Defined Channels Downlink Modulation
        szprmLTE_UDCH_UL_Mod,       //User Defined Channels Uplink Modulation

        //LTE (MT8820C)
        szprmLTE_AuthKey_1,         //Authentication key part 1
        szprmLTE_AuthKey_2,         //Authentication key part 2
        szprmLTE_AuthKey_3,         //Authentication key part 3
        szprmLTE_AuthKey_4,         //Authentication key part 4

        szGoniometer,               //Goniometer Equipment

        szMultiSwitchIdString,      // Multi Switch Equipment - will be stored delimited by |
        szMultiSwitchEquipModDesc,

        szprmPostProcessOptions,       // array of flags for post processing.  For CE validation test currently

        //LTE (CMW 500)
        szprmLTE_RMC_DL2_Mod,      //RMC Downlink Stream 2 Modulation
        szprmLTE_UDCH_DL2_Mod,     //UDCH Downlink Stream 2 Modulation

        szNewOutAngularCorrectFile,
        szSMSMsgExercise,
        szPatternFile1,            //Pattern File for Antenna Correlation Calculation
        szPatternFile2,            //Pattern File for Antenna Correlation Calculation
        szModelPatternFile,        //Model Pattern Data File for Antenna Correlation Calculation
        szModelData,               //String containing modeled data in csv format for antenna correlation

        szCMU_GPSIPAddress,        //CMU-K90  XML-RPC IP Address
        szCMU_GPSTestName,         //CMU-K90  XML-RPC Test Client Name

        szprmLTE_UDTTI_DL_Mod_0,         //User Defined TTI Based Downlink Modulation, TTI 0
        szprmLTE_UDTTI_DL_Mod_5,         //User Defined TTI Based Downlink Modulation, TTI 5
        szprmLTE_UDTTI_DL_Mod_1469,      //User Defined TTI Based Downlink Modulation, TTI 1-4,6-9
        szprmLTE_UDTTI_DL2_Mod_0,        //User Defined TTI Based Downlink2 Modulation, TTI 0
        szprmLTE_UDTTI_DL2_Mod_5,        //User Defined TTI Based Downlink2 Modulation, TTI 5
        szprmLTE_UDTTI_DL2_Mod_1469,     //User Defined TTI Based Downlink2 Modulation, TTI 1-4,6-9
        szprmLTE_UDTTI_UL_Mod_0,         //User Defined TTI Based Uplink Modulation, TTI 0
        szprmLTE_UDTTI_UL_Mod_5,         //User Defined TTI Based Uplink Modulation, TTI 5
        szprmLTE_UDTTI_UL_Mod_1469,      //User Defined TTI Based Uplink Modulation, TTI 1-4,6-9

        szprmLTE_AuthOPc_1,              //Authentication OPc key part 1
        szprmLTE_AuthOPc_2,              //Authentication OPc key part 2
        szprmLTE_AuthOPc_3,              //Authentication OPc key part 3
        szprmLTE_AuthOPc_4,              //Authentication OPc key part 4
        szprmLTE_DefaultGateWay,         //LTE default gateway

        szprmUEBasedPatternFile,        // Pattern data file for UEBased A-GPS
        szprmUEBasedCurveICDFile,       // Curve and ICD data file for UEBased A-GPS
        szprmUEBasedICDFile,            // ICD data file for UEBased A-GPS

        szRSSPatImport,
        szRSSLinImport,
        szRSSEisImport,
        szRSSIcdImport,

        //lTE Agilent PXT E6621
        szScenarioFileName,             // E6621 Scenario File Name
        szSpecVersion,                  // E6621 Spec Version

        //Placeholders for future MT8820C settings
        szprmMT8820Cdummy1,
        szprmMT8820Cdummy2,
        szprmMT8820Cdummy3,
        szprmMT8820Cdummy4,
        szprmMT8820Cdummy5,
        szprmMT8820Cdummy6,
        szprmMT8820Cdummy7,
        szprmMT8820Cdummy8,

        szEtherSwitchAmpBypass,        // Allow control over the bypass mode for each amp/switch combination
        szEtherSwitchDummy0,           // Place holders for EtherSwitch expansion
        szEtherSwitchDummy1,           // Place holders for EtherSwitch expansion
        szEtherSwitchDummy2,           // Place holders for EtherSwitch expansion
        szEtherSwitchDummy3,           // Place holders for EtherSwitch expansion

        szPolarizationLabel,

        //HSPA CMU

        szBSS_HSPD_LEV,         //" HS-PDSCH  Level "
        szBSS_HSSC_SELECTION,   // " HS-SCCH Selection"
        szBSS_HSPA_ISGRANT,     // "HSUPA Initial Serving Grant Value"
        szBSS_HSPA_PDATA_GAIN1, // " UE Gain Factors HSUPA 1"
        szBSS_HSPA_PDATA_GAIN2, // " UE Gain Factors HSUPA 1"
        szBSS_HSPA_PDATA_GAIN3, // " UE Gain Factors HSUPA 1"
        szBSS_HSPA_PDATA_GAIN4, // " UE Gain Factors HSUPA 1"
        szBSS_HSPA_PDATA_GAIN5, // " UE Gain Factors HSUPA 1"
        szBSS_HSPA_GAIN_ACKNACKCQI, // " UE Gain Factors ACK"
        szBSS_HSPA_HSUPA_ULRCL_SDUSIZE, //"Packet Switched HSUPA Test Mode UL RLC SDU size"
        szUserSlockLicense,     // this is the slock license of the user, updates everytime file is saved
        szCreatorSlockLicense,  // this is the slock license of the user that originated the file, is never updated.

        szprmESN,               // ESN
        szprmIMSIType,          // IMSI Type
        szprmIMSI_MCC,          // IMSI (MCC part)
        szprmIMSI_MNC,          // IMSI (MNC part)
        szprmIMSI_MSIN,         // IMSI (MSIN part)

        szprmLongCodeMask,             // MT8820C EVDO Long Code Mask

        szprmUDPConnAddress,    // UDP Connection IP Address
        szprmTestPlanVersion,   // Version of the test plan

        szAccuracy_AAFile,
        szAccuracy_HRFile,
        szSensitiv_AAFile,
        szSensitiv_HRFile,
        szCHMModel,
        szPositioner3,

        szprmTestPlanName,             // Name of the test plan (UDP multi-Antenna Test)
        szprmComplexPatternResFile,    // Complex Pattern Results File

        szprmRefAntennaFile,           // Two Antenna Method - Reference antenna file name

        szprmLTE_TDD_UDTTI_DL_Mod_0,         //User Defined TTI Based Downlink Modulation, TTI 0
        szprmLTE_TDD_UDTTI_DL_Mod_5,         //User Defined TTI Based Downlink Modulation, TTI 5
        szprmLTE_TDD_UDTTI_DL_Mod_S,         //User Defined TTI Based Downlink Modulation, TTI Special Frame
        szprmLTE_TDD_UDTTI_DL_Mod_Left,      //User Defined TTI Based Downlink Modulation, TTI Left

        szprmLTE_TDD_UDTTI_DL2_Mod_0,        //User Defined TTI Based Downlink2 Modulation, TTI 0
        szprmLTE_TDD_UDTTI_DL2_Mod_5,        //User Defined TTI Based Downlink2 Modulation, TTI 5
        szprmLTE_TDD_UDTTI_DL2_Mod_S,        //User Defined TTI Based Downlink2 Modulation, TTI Special Frame
        szprmLTE_TDD_UDTTI_DL2_Mod_Left,     //User Defined TTI Based Downlink2 Modulation, TTI Left

        szprmLTE_TDD_UDTTI_UL_Mod_A,         //User Defined TTI Based Uplink Modulation, TTI All
        szCableCalFile, //PTW70 DRE

        szCSVExportExternalProc,

        szClientIPAddress2,                  //Client IP Address 2

        szprmCountryCode,                    //Country Code Value
        szprmLTE_PDN1APN,                 // PDN 1 APN
        szprmLTE_PDN2APN,                 // PDN 2 APN
        szprmBaseStationArray,

        szIdStringAlternateLabel,   // alternate label for parameter nodes
        szNSA_Reflectivity1,        //  Absorber Reflectivity files 1 � 6
        szNSA_Reflectivity2,        //  Absorber Reflectivity files 1 � 6
        szNSA_Reflectivity3,        //  Absorber Reflectivity files 1 � 6
        szNSA_Reflectivity4,        //  Absorber Reflectivity files 1 � 6
        szNSA_Reflectivity5,        //  Absorber Reflectivity files 1 � 6
        szNSA_Reflectivity6,        //  Absorber Reflectivity files 1 � 6
        szNSA_BackOrTips,           //  Reflect off of �back� or �tips� (back, tips)
        szNSA_Outfile,              //  Output file name
        szprm_CalCoefFile,          //  Saved calibration file
        szNSA_ReflectivityPath1,        //  Absorber Reflectivity files 1 � 6
        szNSA_ReflectivityPath2,        //  Absorber Reflectivity files 1 � 6
        szNSA_ReflectivityPath3,        //  Absorber Reflectivity files 1 � 6
        szNSA_ReflectivityPath4,        //  Absorber Reflectivity files 1 � 6
        szNSA_ReflectivityPath5,        //  Absorber Reflectivity files 1 � 6
        szNSA_ReflectivityPath6,        //  Absorber Reflectivity files 1 � 6

        szParmPresetName,           // Tracking of parameter presets...

        szReverbPositioner1,        // Reverberation Chamber Positioner 1
        szReverbPositioner2,        // Reverberation Chamber Positioner 2
        szReverbPositioner3,        // Reverberation Chamber Positioner 3
        szReverbPositioner4,        // Reverberation Chamber Positioner 4

        //HSPA+
        BSS_szHSPA_EAGCH_AGIndexLev,    // AG Index Command dString
        BSS_szHSPA_EAGCH_AGScopeOnOff,  // AG Scope Command String
        BSS_szHSPA_EAGCH_IDTypeOnOff,   // ID Type Command String
        BSS_szHSPA_ETFCI_MSET,          // Min Set H-TFCI
        BSS_szHSPA_PH_EAGCH,            // DL Physical Channel
        BSS_szHSPA_PH_EHICH,            // DL Physical Channel
        BSS_szHSPA_PH_ERGCH,            // DL Physical Channel
        BSS_szHSPA_ISGR,                // Initial Serving Grant
        BSS_szHSPA_EAGCH_EID,
        BSS_szHSPA_ERGCH_Pattern,

        szIPAddress2,                   //For MT8820C CA
        szIPAddress3,
        szIPAddress4,
        szIPAddress5,
        szIPAddress6,

        // For MS2830A Demodulator
        szDeModulator_SyncWord1,
        szDeModulator_SyncWord2,

        // For Reverb Characterizing tool
        szprmCalFile_Orientation_1,
        szprmCalFile_Orientation_2,
        szprmCalFile_Orientation_3,
        szprmHARQRedundancy,

        // Parameters for TD-SCDMA
        // HSUPA
        szHSUPA_HSPA_PDSCHTmslotConfig, //E-AGCH Absolute Grant Value

        //CMW500 Carrier Aggregation
        szprmLTE_EUTRAN_CellIdent_CMW_SCC1,
        szprmLTE_EUTRAN_CellIdent_CMW_SCC2,
        szprmLTE_RMC_DL_Mod_CMW_SCC1,
        szprmLTE_RMC_DL_Mod_CMW_SCC2,
        szprmLTE_UDCH_DL_Mod_CMW_SCC1,
        szprmLTE_UDCH_DL_Mod_CMW_SCC2,
        szprmLTE_RMC_DL2_Mod_CMW_SCC1,
        szprmLTE_RMC_DL2_Mod_CMW_SCC2,
        szprmLTE_UDCH_DL2_Mod_CMW_SCC1,
        szprmLTE_UDCH_DL2_Mod_CMW_SCC2,
        szprmLTE_UDTTI_DL2_Mod_0_CMW_SCC1,
        szprmLTE_UDTTI_DL2_Mod_0_CMW_SCC2,
        szprmLTE_UDTTI_DL2_Mod_5_CMW_SCC1,
        szprmLTE_UDTTI_DL2_Mod_5_CMW_SCC2,
        szprmLTE_UDTTI_DL2_Mod_1469_CMW_SCC1,
        szprmLTE_UDTTI_DL2_Mod_1469_CMW_SCC2,
        szprmLTE_UDTTI_DL_Mod_0_CMW_SCC1,
        szprmLTE_UDTTI_DL_Mod_0_CMW_SCC2,
        szprmLTE_UDTTI_DL_Mod_5_CMW_SCC1,
        szprmLTE_UDTTI_DL_Mod_5_CMW_SCC2,
        szprmLTE_UDTTI_DL_Mod_1469_CMW_SCC1,
        szprmLTE_UDTTI_DL_Mod_1469_CMW_SCC2,
        szprmLTE_TDD_UDTTI_DL_Mod_0_CMW_SCC1,
        szprmLTE_TDD_UDTTI_DL_Mod_0_CMW_SCC2,
        szprmLTE_TDD_UDTTI_DL_Mod_5_CMW_SCC1,
        szprmLTE_TDD_UDTTI_DL_Mod_5_CMW_SCC2,
        szprmLTE_TDD_UDTTI_DL_Mod_S_CMW_SCC1,
        szprmLTE_TDD_UDTTI_DL_Mod_S_CMW_SCC2,
        szprmLTE_TDD_UDTTI_DL_Mod_Left_CMW_SCC1,
        szprmLTE_TDD_UDTTI_DL_Mod_Left_CMW_SCC2,
        szprmLTE_TDD_UDTTI_DL2_Mod_0_CMW_SCC1,
        szprmLTE_TDD_UDTTI_DL2_Mod_0_CMW_SCC2,
        szprmLTE_TDD_UDTTI_DL2_Mod_5_CMW_SCC1,
        szprmLTE_TDD_UDTTI_DL2_Mod_5_CMW_SCC2,
        szprmLTE_TDD_UDTTI_DL2_Mod_S_CMW_SCC1,
        szprmLTE_TDD_UDTTI_DL2_Mod_S_CMW_SCC2,
        szprmLTE_TDD_UDTTI_DL2_Mod_Left_CMW_SCC1,
        szprmLTE_TDD_UDTTI_DL2_Mod_Left_CMW_SCC2,
        szSigGen_AWF_CWD,
        szSigGen_AWF_File,

        szReverbAFS_Power_FER_1,
        szReverbAFS_Power_FER_2,
        szReverbAFS_Power_FER_3,
        szCAFrequencyPageGUI,
        szDRE_Name,
        szprmCompressionOutputCableCorrectionPath,
        szprmCompressionTotalCableCorrectionPath,
        szprmAGNSSRefFileName,
        szprmEquipSelect1_B,
        szprmEquipSelect2_B,

        szprmGainUpperLimit,
        szprmGainLowerLimit,
        szprmRelativeGainUpperLimit,
        szprmRelativeGainLowerLimit,
        szprmP1dBUpperLimit,
        szprmP1dBLowerLimit,
        szprmTestSteps,
        //for UEBased GPS
        szprmDUTUEPattern,
        szprmDUTEULinearize,
        szprmDUTUEICD,
        szprmTestUEPattern,
        szprmTestUELinearize,
        szprmTestUEICD,
        szprmVertexPortConfig,

        szprmEBID5_IP_Address,
        szprmEBID6_IP_Address,
        szprmEBID7_IP_Address,
        szprmEBID8_IP_Address,

        szprmAGNSSRefFileName2,

        szprmMobileEquipmentIdentityLabel,
        szprmMobileEquipmentIdentity,
        szprmIUTIdentityLabel,
        szprmIUTIdentity,

        szprmIMSPrivateUserID,
        szprmIMSKey,
        szprmIMSAMF,
        szprmIMSOPC,

        szprmEffectiveAFS,
        szprmSMSCallDropping,

        szprmAttenuatorCorrectionFile1,
        szprmDynamicEquipSelect1,
        szprmDynamicEquipSelect2,
        szprmDynamicEquipSelect3,

        szprmLTE_UDCH_DL_Mod_eMTC,
        szprmLTE_UDCH_UL_Mod_eMTC,
        szprmLTE_LAA_ModulationInitialSF_SCC1,
        szprmLTE_LAA_ModulationEndingSF_SCC1,
        szprmLTE_LAA_ModulationInitialSF_SCC2,
        szprmLTE_LAA_ModulationEndingSF_SCC2,


        //LAA
        szprmLTE_LAA_ModulationInitialSF_SCC3,
        szprmLTE_LAA_ModulationEndingSF_SCC3,

        szprmLTE_EUTRAN_CellIdent_CMW_SCC3,
        szprmLTE_RMC_DL_Mod_CMW_SCC3,
        szprmLTE_UDCH_DL_Mod_CMW_SCC3,
        szprmLTE_RMC_DL2_Mod_CMW_SCC3,
        szprmLTE_UDCH_DL2_Mod_CMW_SCC3,
        szprmLTE_UDTTI_DL2_Mod_0_CMW_SCC3,
        szprmLTE_UDTTI_DL2_Mod_5_CMW_SCC3,
        szprmLTE_UDTTI_DL2_Mod_1469_CMW_SCC3,
        szprmLTE_UDTTI_DL_Mod_0_CMW_SCC3,
        szprmLTE_UDTTI_DL_Mod_5_CMW_SCC3,
        szprmLTE_UDTTI_DL_Mod_1469_CMW_SCC3,
        szprmLTE_TDD_UDTTI_DL_Mod_0_CMW_SCC3,
        szprmLTE_TDD_UDTTI_DL_Mod_5_CMW_SCC3,
        szprmLTE_TDD_UDTTI_DL_Mod_S_CMW_SCC3,
        szprmLTE_TDD_UDTTI_DL_Mod_Left_CMW_SCC3,
        szprmLTE_TDD_UDTTI_DL2_Mod_0_CMW_SCC3,
        szprmLTE_TDD_UDTTI_DL2_Mod_5_CMW_SCC3,
        szprmLTE_TDD_UDTTI_DL2_Mod_S_CMW_SCC3,
        szprmLTE_TDD_UDTTI_DL2_Mod_Left_CMW_SCC3,
        szprmRemoteConnectionUserName,
        szprmRemoteConnectionPassword,
        szprmNR_SBBConfigMap,
        szprm_VNA_SParameterMapping,
        szprm_VNA_PortMapping,

        szprmTDD_Config_Dedicated_Scheduling,               //The format is like 0:DL:0,1:UL:0, ...   79:SP:45
        szprmSS_Block_Position_Bitmap,
        szprmInnerBaseStation,
        szprmLTE_UDCH_DL_Mod_eMTC_RMC,          //User Defined Channels Downlink Modulation
        szprmLTE_UDCH_UL_Mod_eMTC_RMC,          //User Defined Channels Uplink Modulation
        szprmTputExtendedOptions,
        szprmNR_PUSCH_Allocation_K2,
        szprmInterlockEquipment,                   //special equipment select label

        // UXM 5G SA NR Procs Message
        szprmNR5G_SA_MIB,
        szprmNR5G_SA_SIB,
        szprmNR5G_SA_REG_RSETup,
        szprmNR5G_SA_REG_NIDReques,
        szprmNR5G_SA_REG_NAURequest,
        szprmNR5G_SA_REG_NSMCommand,
        szprmNR5G_SA_REG_RSMCommand,
        szprmNR5G_SA_REG_RUECEnquiry,
        szprmNR5G_SA_REG_NRACcept,
        szprmNR5G_SA_PSCON_NPSEAccept,

        szprmSS_Block_Position_Bitmap_IND_ONLY_SCC1,
        szprmSS_Block_Position_Bitmap_IND_ONLY_SCC2,
        szprmSS_Block_Position_Bitmap_IND_ONLY_SCC3,

        szprmNR_FreqBandListFilter,
        szprmLTE_FreqBandListFilter,
        szprmRevisionTime,
        szprmRawfileParmText,

        szprmVPINF2FFProbeFilePath,

        //
        //  PLEASE add all new parameters above this line using the szprmXxxx naming convention
        //

        // comment these out as used, don't delete!
        szDummy0,            // placeholder--  comment/delete as we add
        szDummy1,            // placeholder--  comment/delete as we add
        szDummy2,            // placeholder--  comment/delete as we add
        szDummy3,            // placeholder--  comment/delete as we add
        szDummy4,            // placeholder--  comment/delete as we add
        szDummy5,            // placeholder--  comment/delete as we add
        szDummy6,            // placeholder--  comment/delete as we add
        szDummy7,            // placeholder--  comment/delete as we add
        szDummy8,            // placeholder--  comment/delete as we add
        szDummy9,            // placeholder--  comment/delete as we add
        szDummy10,           // placeholder--  comment/delete as we add
        szDummy11,           // placeholder--  comment/delete as we add
        szDummy12,           // placeholder--  comment/delete as we add
        szDummy13,           // placeholder--  comment/delete as we add
        szDummy14,           // placeholder--  comment/delete as we add

        //STRING SECTION END
        //Append integer types to the end of this section
        //INTEGER SECTION START
        iPointsPerTrace,
        iBandWidth,
        iAveFactor,
        iGateShape,
        iSParameter,// Test parameter; equip parm = iChannel1MeasType and iChannel2MeasType
        iSweepType,
        iCalibAttenuationdB1,
        iCalibAttenuationdB2,
        iMeasureAttenuationdB1,
        iMeasureAttenuationdB2,
        iRangePauseSec,
        iFreqPauseSec,
        iPolarizationHV,
        iDataSpans,
        iDisplayFormat,
        iCalkit,
        iCaltype,
        iDataFileType,
        iGPIBBoard,
        iGPIBAddress,
        iGPIBSecAddress,
        iDeviceType,
        iCtrlMessage,
        iVideoBandWidth,
        iChannel,// being replaced with iChannel1MeasType and iChannel2MeasType
        iPriAzimElev,
        iSecAzimElev,
        iSecStepped,
        iChannelPolarization,
        iFrameType,
        iSib,   //these last two may go somewhere else
        iChild,   //these last two aren't the last two anymore
        iPosContinuousScanSpeed,
        iPosSteppedSpeed,
        iPosReturnSpeed,
        iFreqSpanType,
        iTriggerMode,
        iFileCorrectType,
        iSweepMode,
        iChannel1MeasType,  // indicates measurement type (S-parameter, etc.) for channel 1
        iChannel2MeasType,  // indicates measurement type (S-parameter, etc.) for channel 2
        iDisplayFormat2,    // indicates display format for second channel
        iTraceMarkerType,   // 0 = GetMaxMarker, 1 = Center Freq, 2 = Frequency Span
        iVectorMode,        // 0 = Real/Imaginary, 1 = LogMag/Phase
        iCalTypeChannel2,   // allow channel 2 to have different cal from channel 1
        iCalStandard1,      // calibration standard selection for channel 1
        iCalStandard2,      // calibration standard selection for channel 2
        iCalPort1Gender,    // calibration port 1 connector type (0/M/F) selection
        iCalPort2Gender,    // calibration port 2 connector type (0/M/F) selection
        iPatternType,       // For 2 Axis 0 = Spherical, 1 = Planar, 2 = Cylindrical; For 1 Axis 0 = Polar, 1 = Linear
        BSS_iSS_SUFF,
        BSS_iRSS_AC_MIN,
        BSS_iScanInterval,
        BSS_iDelay,
        BSS_iDCCH_MAC,        // Control channel MAC
        BSS_iDTC_MAC,         // Traffic channel MAC
        BSS_iOCH_DTC_MAC,
        BSS_iTriggerLevel,
        BSS_iDCCHRFChannel,   // Control Channel
        BSS_iDTCRFChannel,    // Traffic Channel
        BSS_iOCRFChannel,     // Handoff traffic channel
        BSS_iSOC,
        BSS_iMCC,
        BSS_iSID,
        BSS_iEBCCHSlots,
        BSS_iSATDVCC,
        BSS_iFBCCHSlots,
        BSS_iRegistrationTimeout,
        BSS_iRadiolinkTimeout,  //  radio link timeout of testset or both testset and mobile
        BSS_iDICAppDomain,
        BSS_iRAL_RFMode,
        BSS_iRAL_RFAttenuation,
        BSS_iTriggerSource,
        BSS_iDTCSlotConfig,
        BSS_iDTCSpeechMode,
        BSS_iDTCVoiceCoder,
        BSS_iOCSlotConfig,
        BSS_iMSIDType,
        BSS_iRFOutputPort,
        BSS_iRFInputPort,
        iFilterType,         // Index into Filter Type 0 = Analog, 1 = TDMA, 2 = GSM
        iPresetDelay,      // Number of seconds delay time after instrument preset
        iFinalDataFormat,    // allows user to select format of final data
        iSwitchArrayCount,   //Number of switches for switch driver array
        iS11OutputFlags,    // flags type of data to generate for S-parameter meas.
        iS12OutputFlags,    // flags type of data to generate for S-parameter meas.
        iS21OutputFlags,    // flags type of data to generate for S-parameter meas.
        iS22OutputFlags,    // flags type of data to generate for S-parameter meas.
        iSweepAutoRetry,
        iTransposeData,
        iAnalyzerResetIdx,
        iYAxisWidth,
        iYAxisPrecision,
        iExclusiveRelayPinState,
        iGenericConfigIdx,   //Catch-all for odd pieces of equipment
        iUseMeasuredVSWR,
        iDetectionMode,
        iTransposeResults,
        iShowPoleAttributes,
        iTabSelection,     // tab selection setting for FormInfo
        BSS_iOptionSelect, // option selection for CMU
        iRangeStepSec,
        iRangeRetSec,
        BSS_iMaxPCL,         // Maximum power control level setting
        BSS_iSlotMode,       // GSM single/multi slot
        BSS_iTimingAdvance,  // GSM timing advance (symbols)
        BSS_iSingleSlotLoop, // GSM single slot loop setting
        BSS_iTCHTimeSlot,    // GSM single slot loop setting
        BSS_iFrequencyOffset,// GSM frequency offset in Hz
        BSS_iBCCHMode,       // GSM BCCH and/or TCH
        BSS_iMNC,            // GSM MNC Network ID
        BSS_iNCC,            // GSM NCC Network ID
        BSS_iBCC,            // GSM BCC Network ID
        BSS_iLocationArea,   // GSM Location Area (LAI) Network ID
        BSS_iRAC,            // GSM RAC Network ID
        BSS_iMobileRLTimeout,// GSM Mobile radiolink timeout
        BSS_iTestSetRLTimeout,// GSM Test set radiolink timeout
        BSS_iMTCTimeout,     // GSM timeout for attempting to establish a call
        BSS_iPCL,            // Traffic channel PCL (different from MAC due to GPIB command differences)
        BSS_iSignallingMode, // Flags signaling/non-signalling mode
        BSS_iRAL_GSMRFMode,  // same as RAL_RFMode, but GSM has slightly different command
        BSS_iGSMCCHRFChannel,// same as DCCHRFChannel, but GSM has slightly different command
        BSS_iGSM_MCC,        // GSM MCC Network ID (No off setting)
        BSS_iSAT_SCC,        // AMPS Supervisory Audio Tone color code.
        BSS_iSAT_PeakDev,    // AMPS Supervisory Audio Tone peak deviation
        BSS_iOCH_SAT_SCC,    // AMPS Supervisory Audio Tone color code for handoff.
        BSS_iOCH_SAT_PeakDev,// AMPS Supervisory Audio Tone peak deviation
        BSS_iDCC,            // AMPS DCC Network ID
        BSS_iSID1,           // AMPS Network SID 1
        BSS_iRAL_AMPSRFMode, // same as RAL_RFMode, but AMPS has slightly different command
        BSS_iAFAL_AFMode,    // AF Analyzer mode
        BSS_iACCRFChannel,   // AMPS control channel
        BSS_iCMAC,           // AMPS control channel MAC
        BSS_iVMAC,           // AMPS voice channel MAC
        BSS_iOCH_VMAC,       // AMPS other call/handoff voice channel MAC
        BSS_iCDMA_TCH,       // CDMA Traffic Channel
        BSS_iCDMA_RFCH,      // CDMA RF Channel
        BSS_iPNOffset,       // CDMA PN Offset
        BSS_iFOffset,        // CDMA Frame Offset
        BSS_iCallMode,       // CDMA Call Mode
        BSS_iFrameRate,      // CDMA Frame Rate
        BSS_iCDMA_MSIDType,  // CDMA MSID Type
        BSS_iProtocolRev,    // CDMA Protocol Revision
        BSS_iTBReg,          // CDMA Time Based Registration
        BSS_iBaseStationID,  // CDMA Base Station ID
        BSS_iSlotCycIdx,     // CDMA Slot Cycle Index
        BSS_iNID,            // CDMA Network ID
        BSS_iSenseLevel_DTC_PCL, // Traffic channel MAC/PCL/Power Bit settings while doing sensitivity level measurement (Was BSS_iPCBits -- CDMA Power Control Bits)
        BSS_iCallLossDetect, // CDMA Call Loss Detect timer
        BSS_iAWGN_Bandwidth, // CDMA AWGN Bandwidth
        BSS_iCDMA_NetworkStd,// CDMA Network Standard
        iDeviceOpt1,
        iDeviceOpt2,
        iDeviceOpt3,
        iDeviceOpt4,
        iDeviceOpt5,
        iDeviceOpt6,
        iDeviceOpt7,
        iDeviceOpt8,
        iDeviceOpt9,
        iDeviceOpt10,
        BSS_iInCall_DTC_PCL, // Traffic channel MAC/PCL/Power Bit settings once call is established
        iCalibAttenuationdB3,
        iCalibAttenuationdB4,
        iMeasureAttenuationdB3,
        iMeasureAttenuationdB4,
        iFreqRangeDomainFilter,
        iAncillaryConfigDefaultIdx,
        iEquipConfigDefaultIdx,
        BSS_iSettlingTime, // Time to wait after OCE settings have been sent once call is established
        BSS_iMaxFrames,    // Maximum number of frames/bits to measure for a sensitivity step
        BSS_iMinFrames,    // Minimum number of frames/bits to measure for a sensitivity step
        BSS_iMaxFrameBlock,// Maximum number of frames/bits to measure in a single block (added to make total)
        BSS_iMinFrameBlock,// Minimum number of frames/bits to measure in a single block (added to make total)
        iCentigradeOrFahrenheit, //0 = Centigrade 1 = Fahrenheit
        iPwrMeterFilterState,
        iPwrMeterFilterSelect,
        iPwrMeterRangeAutoIdx,
        iPwrMeterZero,
        iAttSettlingTimeMS,
        BSS_iGSM_BER_FER_Class,      // flag for selecting desired error class to measure in GSM response (intermediate channel) tests
        BSS_iSenseMode,          // Controls possible different data acquisition modes
        BSS_iPSRBitStream,       // Controls pseudo-random bitstream for BER tests.
        iChariotProtocol,
        BSS_iConfidencePass,     // passing confidence level for GSM
        BSS_iConfidenceFail,     // failing confidence level for GSM
        BSS_iConfidenceWindow,   // confidence window for dual-limit GSM
        BSS_iCDMA2k_NetworkStd,  // CDMA2k Network Standard
        BSS_iCDMA2k_PrimarySvcClass, // CDMA2k primary service class
        BSS_iCDMA2k_AcceptMSCall,    // CDMA2k accept MS originated call option
        BSS_iCDMA2k_LoopbackSOpt,    // CDMA2k loopback service option
        BSS_iCDMA2k_SpeechSOpt,      // CDMA2k speech service option
        BSS_iCDMA2k_PCBits,          // CDMA2k Power Control Bits
        BSS_iCDMA2k_TCH,             // CDMA2k Traffic Channel
        BSS_iCDMA2k_RFCH,            // CDMA2k RF Channel
        BSS_iCDMA2k_FPCH,            // CDMA2k Paging Channel
        BSS_iCDMA2k_FOffset,         // CDMA2k Frame Offset
        BSS_iCDMA2k_PNOffset,        // CDMA2k PN Offset
        BSS_iCDMA2k_SID,             // CDMA2k Network SID
        BSS_iMinProtocolRev,         // Minimum Protocol Revision
        BSS_iIMSI_11_12,             // IMSI Digits 11 & 12
        BSS_iAuthChallenge,          // Authentication Challenge
        BSS_iCDMA2k_TBReg,           // CDMA2k Time Based Registration
        BSS_iPageChanRate,           // CDMA2k Paging Channel data rate
        BSS_iMaxSlotCycIdx,          // CDMA2k Max Slot Cycle index
        BSS_iWirelessBandSelect,
        BSS_iWirelessLinkDir,
        iTestParmsVersion,
        BSS_iBasePowerSettlingTime,   // time to wait before taking a reading after setting base station power
        BSS_iMobilePowerSettlingTime, // time to wait before taking a reading after setting mobile power
        BSS_iTrafficMode,       // GSM traffic mode
        iTPTransactionsize,
        iTPTransactioncount,
        iTPBuffersize,
        iServerConfiguration,
        iTPReconnectDelaySecs,
        iPointAutoRetry,               // separate retry per data point (for BSS right now)
        iTestResults,
        BSS_iAbsMeasMode,                      // measurement mode for MEAS_A (absolute power) measurements
        iCalibAttenuationdA1,
        iCalibAttenuationdA2,
        iMeasureAttenuationdA1,
        iMeasureAttenuationdA2,
        iMinPosSpeed,
        iMaxPosSpeed,
        iToleranceAvgOrMedian,
        iGateType,                //Bandpass = 0; Notch = 1
        iUseDefaultVectorHandling,
        BSS_iGSM_NetworkSupport,       // GSM Network Support (GSM,GSM+GPRS,GSM+EGPRS)
        BSS_iGSM_CodingScheme,         // GSM PData Coding Scheme
        BSS_iGSM_MainService,      //Circuit Switched or Packet Data
        BSS_iGSM_ServiceSelection,   //Test Mode A, Test Mode B, BLER, etc
        BSS_iGSM_CSMainTimeslot,      //Main timeslot Circuit Switched Multi-slot
        BSS_iGSM_PDMainTimeslot,      //Main timeslot Packet Data
        BSS_iGSM_MSLotLevelMode,      //multi-slot level mode (Used/Unused - Individual)
        BSS_iGSM_ForceUTSUUTINDLevels,//forces parm levels to Used/Unused levels (Always Ind. Mode is why)
        iModCheckFilter,         //0 = none, 1 = GMSK/ < tolerance, 2 = 8PSK/ > tolerance
        iFilterTimeSlots,         //applied on analyzer filter section
        iAllowLongerPulse,         //flag to allow a longer pulsewidth than user specified
        BSS_iGSM_PtMeasureType,      //GMSK,8PSK,Multislot
        BSS_iGSM_PtMTS_TSElement,   //Timeslot element AvgBurstPwrCurrent,AvgBurstPwrAvg,PeakBurstPwrCurrent
        BSS_iGSM_PtMTS0,         //Main Timeslot (0)
        BSS_iGSM_PtMTSN1,         //MTS -1
        BSS_iGSM_PtMTS1,              //MTS +1
        BSS_iGSM_PtMTS2,              //MTS +2
        BSS_iGSM_ptMTSAnalysis,      //Default,Average,Peak,Minimum
        BSS_iRSSIMeasure,         //Use RSSI value in sensitivity measurement
        BSS_iAutoReconnectTime,      //Maximum time to check for reconnection
        BSS_iMNCdigits,           // index of number of digits to use for MNC
        BSS_iTPCMode,             // WCDMA Transmit Power Control (TPC) Mode
        BSS_iTPCStepSize,         // WCDMA TPC step size
        BSS_iTPCPatternSet,       // WCDMA TPC pattern set selection
        BSS_iTPCPatternType,      // WCDMA TPC pattern type selection  (equivalent to PCBits setting)
        BSS_iUL_TargetPwrRef,     // WCDMA Uplink Target Power Reference
        BSS_iDChannelType,        // WCDMA Dedicated Channel Type
        BSS_iRChannelType,        // WCDMA Reference Channel Type
        BSS_iDL_DTCH_TransFormat, // WCDMA DL DTCH Transport Format
        BSS_iDL_ResourcesInUse,     // WCDMA DL Resources in Use
        BSS_iWCDMATestMode,         // WCDMA Test Mode
        BSS_iChanDataSrcDTCH,     // WCDMA Channel Data Source DTCH
        BSS_iVoiceSource,         // WCDMA Voice Source
        BSS_iActiveCodecSet,         // WCDMA Active Codec Set
        BSS_iSignallingRAB,         // WCDMA Signalling Radio Access Bearer
        BSS_iWCDMA_DPDCH,         // WCDMA Dedicated Physical Data Channel (DPDCH) Channelization Code
        BSS_iPriScrambleCode,     // WCDMA Primary Scrambling Code
        BSS_iSecScrambleCode,     // WCDMA Secondary Scrambling Code
        BSS_iLevelReference,      // WCDMA Level Reference
        BSS_iHRSpeechChan,       // GSM (8960) Half-Rate Speech Channel
        BSS_iTCH_PRLUsedBurst,     // TCH Power Reduction Level Used Burst
        BSS_iTCH_PRLAdjBursts,     // TCH Power Reduction Level Adjacent Bursts
        BSS_iPDTCH_PRLBurst1,    // PDTCH Power Reduction Level Burst 1
        BSS_iPDTCH_PRLBurst2,    // PDTCH Power Reduction Level Burst 2
        BSS_iPDTCH_PRLBurst3,    // PDTCH Power Reduction Level Burst 3
        BSS_iPDTCH_PRLBurst4,    // PDTCH Power Reduction Level Burst 4
        BSS_iPDTCH_PRLAdjBursts,  // PDTCH Power Reduction Level Adjacent Bursts
        BSS_iPDTCH_1stBurst,    // PDTCH 1st Burst to Loop
        BSS_iRecPwrContAuto,    // Receiver Power Control Manual/Auto
        iFilterAutoRetry,      // separate retry for filter errors
        BSS_iHndOvrBandIIPCL,
        BSS_iHndOvrBandIISensPCL,
        BSS_iHndOvrBandIIDefault,
        BSS_iHndOvrBandIIIPCL,
        BSS_iHndOvrBandIIISensPCL,
        BSS_iHndOvrBandIIIDefault,
        BSS_iTrafficDataRate,   //CDMA Traffic Data Rate
        BSS_iTransientSteps,     //CDMA Transient Steps
        BSS_iTransientMode,      //CDMA Transient Mode
        BSS_iEscapeMode,         //CDMA Cell Parm Escape Mode (8960 specific)
        BSS_iAPAR_Nom,           //CDMA Access Parameter Nominal Power
        BSS_iAPAR_Ext,           //CDMA Access Parameter Nom Pow Extended
        BSS_iAPAR_Init,          //CDMA Access Parameter Initial Power
        BSS_iAPAR_Step,          //CDMA Access Parameter Power Step
        BSS_iAPAR_StepCnt,       //CDMA Access Parameter Number of Steps
        BSS_iAPAR_ReqMax,        //CDMA Access Parameter Maximum Request Sequence
        BSS_iAPAR_RespMax,       //CDMA Access Parameter Maximum Response Sequence
        BSS_iAPAR_Preamble,      //CDMA Access Parameter Preamble Size
        BSS_iWalshCode,          //CDMA Traffic Walsh Code
        BSS_iOCNSWalsh,      //CDMA OCNS Walsh Code
        BSS_iPagingType,      //CMDA Paging Type
        BSS_iStatusReqQuery,   //CDMA Paging Status Req. Query
        iIgnoreFilterFailureFlags,   // flags for pre-ignoring various filter failures...
        BSS_iTrafficToPilotGain,   //CDMA2000 Cell Parm Traffic to Pilot Gain
        BSS_iFQPCH_State,        //CDMA2000 Code Channel Parm F_QPCH State
        BSS_iFQPCH_RelPilot,     //CDMA2000 Code Channel Parm F_QPCH Relative To Pilot Level
        BSS_iFQPCH_DRate,        //CDMA2000 Code Channel Parm F_QPCH Data Rate
        BSS_iFSCH_DRate,         //CDMA2000 TDSO FSCH Data Rate
        BSS_iFSCH_Encoder,       //CDMA2000 TDSO FSCH Encoder Type
        BSS_iFSCH_DSource,       //CDMA2000 TDSO Data Source
        BSS_iRSCH_DRate,         //CDMA2000 TDSO RSCH Data Rate
        BSS_iRSCH_Encoder,       //CDMA2000 TDSO RSCH Encoder Type
        BSS_iRSCH_ServMaxRate,   //CDMA2000 TDSO RSCH Service Config. Max Rate
        BSS_iAmps_AudioOutPort,
        BSS_iAmps_UseFMDev,
        BSS_iAmps_ExtFMState,
        BSS_iULSeparation,      //Uplink Separation
        BSS_iULChannelAuto,      //Auto Set UL Channel
        BSS_iSecurityOperation,  //Security Operations
        BSS_iChannelSettlingTime, // Time to wait after channel has been changed
        BSS_iAuxTxChannelType,    // Channel type/enable for CMU auxiliary transmitter
        iSweepFilterTraceAvgLoop, // Sweep Filter Trace Avg loop count
        iSeriesAttenOrder,       // Change Max or Min Attenuator First
        iThruPutVerbose,
        BSS_iUEReqAuth,    //UE Data Authentication
        BSS_iUEReqSecurity,//UE Data Security
        BSS_iUEReqACAP,    //UE Data Radio Access Capability
        BSS_iUEReqIMEI,    //UE Data IMEI
        BSS_iUEReqRRCC,    //UE Data Keep RCC Connection
        BSS_iUEReqSRAB,    //UE Data Skip RAB Release
        BSS_iUEReqHACTime, //UE Data Handover Timeout
        BSS_iUEReqT3212,   //UE Data T3212 Timeout
        BSS_iUEReqT313,    //UE Data T313 Timeout
        BSS_iUEReqSyncTO,  //UE Data Out of Sync Timeout
        BSS_iUEReqPageTO,  //UE Data Paging Timeout
        BSS_iRSSI_Bias,    //RSSI Sensitivity Bias (fineStep * N)
        BSS_iProbeMeasFrames, //number of frames for probe measurement
        BSS_iMaxConnectAttempts, //maximum connection attempts
        iPwrMeterMeasMode,   //replaces szPwrMeterFunction, index into pwr meter function
        iPwrMeterRangeIdx,  //going to use an index to calculate dPwrMeterRange in the parm page
        BSS_iAutoRangeMode,    // MT8860 auto range mode index
        BSS_iBeaconInterval,   // Wi-Fi beacon interval in ms
        BSS_iMeasurementMode,  // TX/RX (MT8860)
        BSS_iModulationType,   // MT8860 modulation type
        BSS_iNetworkType,      // Infrastructure or AdHoc
        BSS_iPacketLength,     // packet length for test data
        BSS_iPacketLoopBack,   // loopback on/off
        BSS_iPreamble,         // long/short
        BSS_iTransmitInterval, // time between transmissions in ms
        BSS_iTransmitRateIdx,  // index of desired transmission rate
        BSS_iWLANStandard,     // index of the standard to test (A/B/G)
        BSS_iWhoConnects,      // control over connection order
        BSS_iConnectionControl, // combined parm (just in case needed)
        BSS_iShortSlotTime,     // Azimuth systems AP Configuration false/true
        BSS_iSupportedRateIdx,  // Azimuth systems AP Configuration
        BSS_iSourceMacType,     // Azimuth systems traffic config idx (AZ_BSSID, AZ_SPOOFED)
        iMeasureTrpTisBoth,       // flag for TRP/TIS test on which axes to measure
        BSS_iWCDMA_FBI,      //Freq Band Indicator (8960 specific)
        BSS_iWCDMA_HSDPA_FRC,   //HSPDA FRC Type
        BSS_iWCDMA_HSDPA_CNDom, //HSPDA CN Domain
        BSS_i64K_DTCHLoopback,  //HSPDA Uplink 64k DTCH Loopback State
        BSS_iHSDSCHPattern,     //HSPDA HS-DSCH Data Pattern
        BSS_iWCDMA_RLCHeader,   //HSPDA RLC Header on HS_DSCH
        BSS_iWCDMA_MacNumTX,    //MAC-hs Number of Transmissions
        BSS_iWCDMA_MAChsWinSz,  //MAC-hs Window Size
        BSS_iWCDMA_MAChsT1,     //MAC-hs T1
        BSS_iWCDMA_statDTX,     //statDTX Reception Behavior
        BSS_iWCDMA_DACK,        //HSDPA Uplink DeltaAck
        BSS_iWCDMA_DNACK,       //HSDPA Uplink DeltaNack
        BSS_iWCDMA_DCQI,        //HSDPA Uplink DeltaCQI
        BSS_iWCDMA_AckNackRep,  //HSDPA Uplink Ack-Nack Repetition Factor
        BSS_iWCDMA_CQIFeedback, //HSDPA Uplink CQI Feedback Cycle
        BSS_iWCDMA_CQIRep,      //HSDPA Uplink CQI Repetition Factor
        BSS_iBCCH_UDPage,       //BCCH Update Page
        BSS_iPS_Domain,         //PS Domain Information
        BSS_iCellID,            //Cell Identity
        BSS_iATTFlag,           //ATT (IMSI Attach) Flag State
        BSS_iTMSIAssign,        //TMSI Assignment
        BSS_iTMSIVal,           //TMSI
        BSS_iDRXLength,         //DRX Cycle Length
        BSS_iPageRepeat,        //Repeat Paging
        BSS_iN313Sync,          //N313 UE Out-of-sync counter
        BSS_iN315Sync,          //N315 UE In-sync counter
        BSS_iRBTiming,          //RB Setup Timing Indication
        BSS_iPrachRamp,         //PRACH Power Ramp Step
        BSS_iPrachCodeword,     //PRACH Scrambling Codeword
        BSS_iPrachBcBdAuto,     //PRACH Bc/Bd Control
        BSS_iPrachBc,           //Manual PRACH Bc
        BSS_iPrachBd,           //Manual PRACK Bd
        BSS_iPrachRampCyc,      //PRACH Ramping Cycles
        BSS_iPrachSubChan,      //Available Subchannels
        BSS_iDPCHScrambleCode,  //Uplink DPCH Scrambling Code
        BSS_iUL_DPCHAuto,       //Uplink DPCH Bc/Bd Control
        BSS_iUL_DPCHBc,         //Manual Uplink DPCH Bc
        BSS_iUL_DPCHBd,         //Manual Uplink DPCH Bd
        BSS_iREPType,           //Rep Meas Type
        BSS_iPICHCode,          //PICH Chan Code
        BSS_iAICHCode,          //AICH Chan Code
        BSS_iRMC12Code,         //DPCH 12.2k RMC Chan Code
        BSS_iRMC64Code,         //DPCH 64k RMC Chan Code
        BSS_iRMC144Code,        //DPCH 144k RMC Chan Code
        BSS_iRMC384Code,        //DPCH 384k RMC Chan Code
        BSS_iHsdpaRCM12,        //HSDPA 12.2k RMC Chan Code
        BSS_iHsdpaRBTest,       //RB Testmode 1st HS-PDSCH Chan Code
        BSS_iHsdpaChCod1,       //HS-SCCH 1 Chan Code
        BSS_iHsdpaChCod2,       //HS-SCCH 2 Chan Code
        BSS_iHsdpaChCod3,       //HS-SCCH 3 Chan Code
        BSS_iHsdpaChCod4,       //HS-SCCH 4 Chan Code
        BSS_iAMRRAB,            //AMR RAB
        BSS_iCRCPresent,        //UL DTCH RMC CRC Presense
        BSS_iDCDHDummy,         //Uplink Dummy DCCH Data
        BSS_iUELoop,            //UE Loopback Type
        BSS_iAsymLoopMsg,       //Asymmetric RMC Loopback Messaging
        BSS_iAuthAlg,           //Authenication Algorithm
        BSS_iOPVarType,         //Operator Variant Parm Type
        iRenameMe,              //UNUSED parameter - change and use anywhere       <<---FREE PARAMETER COME GET IT WHILE IT'S HOT
        iSamplingMode,          // data sampling mode for time dependent response
        iSampleCount,           // data sampling count for time dependent response
        BSS_iRF1RF2HiLevMode,   //CMU Level Range Enhancement (Opt. B-96 version >= 4.0)
        BSS_iSensitivityOptionFlags,  // flags to turn on and off various options
        BSS_iInitialProbeRetries,     // number of retries for initial probe failures
        BSS_iProbeMaxDrops,           // number of times to reconnect in probing search before deciding a dropped call is a failing point
        BSS_iFloorMaxDrops,           // number of times to reconnect in sensitivity search before deciding a dropped call is a failing point
        BSS_iPromptOnFailure,         // make this an int instead of boolean.  May not even use
        BSS_iTrpTisOptFlag,           // Modifies TRP/TIS Measurement Test - 0 = TRP Only, 1 = TIS Only, 2 = TRP|TIS
        BSS_iGSMPacketTestWAck,       // GSM Packet Testmode w/Ack
        BSS_iGSMPacketRLCMode,        // GSM Packet downlink RLC mode for a packet data connection in test mode B
        BSS_iGSMNetLoopCmd,         // GSM Network:Circuit Switched:Signal Modes Loop Command
        BSS_iGSMProbingEarlyExit,   // GSM probing early exit on First limit or Confidence level
        BSS_iMultiSlotLoop,           // GSM loop type for Multi-Slot
        i2090AuxTest,            // run AUX test
        i2090AuxTestMaxCount,         // maximum AUX tests
        i2090AuxTestPeriod,         // AUX test frequency
        iFilterSmoothing,         // SA Filter Smoothing Flag
        iBSS_EnableHandover,      // enable band handover
        iBSS_ActiveHOBand,         // active handover band (GUI view)
        iBSS_HOBandList,         // list of handover bands to select from (GUI and equipment)
        iBSS_HandoverID,         // specific handover ID for each paHandoverBands type
        iExtendedSweepType,           // extends sweep type for wireless functionality in Range form, re-maps iSweepType that's still used in tests
        BSS_iTestApp,                 //EVDO - Test Application Protocol
        BSS_iLimTap,                  //EVDO - Limited TAP
        BSS_iATDirPackets,            //EVDO - AT Directed Packets
        BSS_iAckAtrib,                //EVDO - ACK Chan Bit Fixed Mode Attr.
        BSS_iFTAPRate,                //EVDO - FTAP Rate
        BSS_iRTAPRate,                //EVDO - RTAP Rate
        BSS_iSessionClose,            //EVDO - Session Close Timeout
        BSS_iMeasFreqMode,            //EVDO - Meas Frequency Mode
        BSS_iATMaxPower,              //EVDO = AT Max Power
        BSS_iSMask,                   //EVDO - Subnet Mask
        BSS_iPCCCycleAuto,            //EVDO - CCH Cycle Auto
        BSS_iPCCCycle,                //EVDO - CCH Cycle
        BSS_iPilotDrop,               //EVDO - Pilot Drop
        BSS_iOLADjust,                //EVDO - Open Loop Adj
        BSS_iPrefCCHCycle,            //EVDO - Preferred Control Channel Cycle Control
        iSocketPort1,                 //Communication Port (implemented for PTW70 socket comm.)
        iSocketPort2,                 //Communication Port (implemented for PTW70 socket comm.)
        TD_iWindowShape,              // Vector test time domain window shape
        TD_iGateShape,                // Vector test time domain gate shape
        TD_iGateType,                 // Vector test time domain gate type (band pass/notch)
        TD_iTracePoints,              // Vector test time domain allowing possibility of different number of trace points
        TD_iTDMultiplier,             // Vector test time domain unit multiplier
        TD_iGateMultiplier,           // Vector test time domain gate multiplier
        TD_iTDUnits,                  // Vector test time domain units (time, distance, reflected distance, etc?)
        BSS_iUseWCDMABER,             // Prefer WCDMA BER when calling GetWCDMA_BER (CMU)
        BSS_iUseWCDMABLER,            // Prefer WCDMA BLER when calling GetWCDMA_BER (CMU)
        BSS_iUseWCDMADBLER,           // Prefer WCDMA DBLER when calling GetWCDMA_BER (CMU)
        iTraceSegments,               // Segmented sweep (hybrid) count.
        BSS_GPRS_NumOfPDUs,           // No of PDU's sent for GPRS Testmode A 1 to 4095 according to documentation but 0 appears to make it infinite
        BSS_TestModeWithAck,          // Enable or disable test mode B with ACK
        BSS_iHsdpaDataRate,
        BSS_iFTAPOpt,
        BSS_iRTAPOpt,
        BSS_iRadioBearer,
        iUseETSPowerControl,
        BSS_iRTAPRateMax,
        BSS_iFETAPRate,
        BSS_iRETAPRate,
        BSS_iRETAPRateMax,
        BSS_iNetworkRel,
        BSS_iAccessProbes,
        BSS_iTestAppSelect,
        BSS_iVMACRevA,
        BSS_iSectorFormat,
        BSS_iNPBits,
        BSS_iDRCCover,
        BSS_iDRCLength,
        BSS_iFilterDRC,
        BSS_iFilterACK,
        BSS_iFilterData,
        iRangeExtanderAncillarySettings,
        BSS_iTRPConnectPwr,
        BSS_iTRPConnectPwrOpt,
        BSS_iFERMeasureType,
        BSS_iUPLDataTimeout,
        // E6651 General
        BSS_iLNASwitch,
        BSS_iAttenuate,
        // E6651 SPECTRUM MODE
        BSS_iSPAverage,
        BSS_idwSPCBW,
        BSS_iSPREF,
        BSS_idwSPRBW,
        BSS_iSPScale,
        BSS_iSPSpan,
        BSS_idwFFTPosition,
        BSS_iRFAttenuate,
        BSS_iIFAttenuate,
        // E6651 BS EMULATOR MODE
        BSS_ibBSPreamble,
        BSS_iBSUlPermbase,
        BSS_iBSRngTimeOffset,
        BSS_iBSFrameOffset,
        BSS_iBSRepetition,
        BSS_iBSRNGRSP_PowerOffset,
        BSS_iBSRNGRSP_FreqOffset,
        BSS_iBSRNGRSP_Status,
        BSS_iDLMAPRepetition,
        BSS_iULMAPRepetition,
        BSS_iDLBurstRepetition,
        BSS_iULBurstRepetition,
        BSS_iBSSymbolRatio,
        BSS_iDLPayloadPattern,
        // E6651 UL PADDING TEST /////////////////////////////////////////////////////////
        BSS_iBSULPadUlMod,
        BSS_iBSULPadUlSlot,
        // E6651 DL UDP TEST /////////////////////////////////////////////////////////
        BSS_iBSDLUdpDlMod,
        BSS_iBSDLUdpLength,
        BSS_iBSDLUdpRate,
        BSS_iBSDLUdpTotal,
        // E6651 DL PING TEST /////////////////////////////////////////////////////////
        BSS_iBSDLPingDlMod,
        BSS_iBSDLPingLength,
        BSS_iBSDLPingRate,
        BSS_iBSDLPingTotal,
        // E6651 Power Control Test //////////////////////////////////////////////////////
        BSS_iPCEIRP,
        BSS_iPCEIRxP,
        BSS_iPCNIEnable,
        BSS_iPCNIPUSC,
        BSS_iBSRNGRSPOffset,
        BSS_iBSREPREQEnable,
        BSS_iBSREPREQFrameRate,
        BSS_iPCTestMode,
        BSS_iPCRNGRSPPowerAdjust,
        BSS_iPCIEPowerAdjust,
        BSS_iPCFPCPowerAdjust,
        BSS_iPCPMCLoopMode,
        BSS_iPCPMCPowerAdjust,
        BSS_iBSFullOccupied,
        // E6651 Maximum transmit Power
        BSS_iBSHOOperatorID,
        BSS_iBSHOMOB_NBR_ADVEnable,
        BSS_iBSHOMOB_NBR_ADVRate,
        // Positioner Trigger Options
        POS_iTriggerActive,     //positioner trigger ON|OFF
        POS_iTriggerSignalHiLo, //positioner trigger signal active High(Default) or Low
        iMaxHold,               //max hold option
        BSS_iBSULPadEnable,     //flags that uplink padding should be on (generate traffic from DUT) in E6651A
        iIQAnalyzerMode,        //Use IQ Analyzer Mode
                                // more E6651A settings
        BSS_iBSDLPingTestTimeOut,
        BSS_iBSDLTestTimeOut,
        BSS_iULZoneIEActive,
        BSS_iULZoneIEOpt,
        BSS_iBSDLPingTestBWLength,
        BSS_iAttenMode,
        BSS_iProfileBank,      // target profile bank
        BSS_iULModulation,     // E6651 Uplink Modulation (for ping test)
        BSS_iSSBWREQMode,      // E6651 Bandwidth requirement mode
        BSS_iCQICHMode,        // E6651 CQICH Mode
        BSS_iDLZoneIEOpt,      // DL Zone IE
        BSS_iBSReuseFactor,    // re-use factor
        BSS_iPeriodicTimeoutActive,
        BSS_iPeriodicTimeout,  // E6651 Periodic timeout
        BSS_iConnectionTimeoutActive,   // E6651 Connection Timeout Active
        BSS_iConnectionTimeout,         // E6651 Connection Timeout (secs)
        BSS_iDummy9,           // THIS IS BEING USED - MAKE A NEW PARAMETER
        iShowRealTimeTotal,    // Show real time total
        iShowRealTimeVect1,    // Show real time results vector test placeholder
        iShowRealTimeVect2,    // Show real time results vector test placeholder
        BSS_iHSDPAChannels,
        BSS_iUseRXQBler,
        BSS_iAckRDataAfter,
        BSS_iAccChanMACProt,
        BSS_iPhsyLayerSubtype,
        BSS_iSessAppType,
        iCLPCStep,             //TD_SCDMA Uplink Step
        iPwrUpStep,            //TD_SCDMA Mobile Power Up setting
        iPwrDnStep,            //TD_SCDMA Mobile Power Dn setting
        BSS_iTDSCDMA3,         //placeholder for SP6116 TDSCDMA analyzer
        BSS_iTDSCDMA4,         //placeholder for SP6116 TDSCDMA analyzer
        BSS_iTDSCDMA5,         //placeholder for SP6116 TDSCDMA analyzer
        BSS_iTDSCDMA6,         //placeholder for SP6116 TDSCDMA analyzer
        BSS_iTDSCDMA7,         //placeholder for SP6116 TDSCDMA analyzer
        BSS_iTDSCDMA8,         //placeholder for SP6116 TDSCDMA analyzer
        BSS_iTDSCDMA9,         //placeholder for SP6116 TDSCDMA analyzer
        BSS_iTDSCDMA10,         //placeholder for SP6116 TDSCDMA analyzer
        BSS_iTDSCDMA11,         //placeholder for SP6116 TDSCDMA analyzer
        BSS_iTDSCDMA12,         //placeholder for SP6116 TDSCDMA analyzer
        BSS_iTDSCDMA13,         //placeholder for SP6116 TDSCDMA analyzer
        BSS_iMeasChannel,         //Bluetooth channel to measure mode is single chan.
        BSS_iPollPeriod,         //Bluetooth slave signal polling period for tx test
        iFieldProbeAxis,
        iMaxStableCount,
        iStableInterval,
        iMinStableCounts,
        iFreqHopSchemeMaster,     //Frequency Hopping Scheme for Bluetooth
        iFreqHopSchemeSlaveConn,     //Frequency Hopping Scheme for Bluetooth
        iFreqHopSchemeSlaveTest,     //Frequency Hopping Scheme for Bluetooth
        iNumberOfResponses,     //Maximum number of responses from Bluetooth devices before the inquiry is halted.
        iSupervisionTimeout,     //Number of slots of non-communication between the CMU and the DUT that can
                                 //occur before the two devices detach
        iPacketType,            //Packet Type for Bluetooth.
        iUseWindowFilter,       // flag for using windowing on average filter, etc.
        iUserRXCalOpion,        //For WiFi DRE RX Cal. User Options
        iMultiSensorSweepUpDown, //Allow the multi-sensor array to read a sweep both ways, up and down, default will be 0 - Sweep UP only
        BSS_iBSHARQDLModulation, //E6651 HARQ PER
        BSS_iBSHARQSubBurst,     //E6651 HARQ PER
        BSS_iBSHARQTxPeriod,     //E6651 HARQ PER
        BSS_iBSHARQTxDuration,   //E6651 HARQ PER
        BSS_iBSHARQPayload01,    //E6651 HARQ PER
        BSS_iBSHARQCRCType,      //E6651 HARQ PER
        BSS_iBSHARQPayload02,    //E6651 HARQ PER
        BSS_iBSHARQRetransmission,    //E6651 HARQ PER
        REM_iMaxHoldType,        //Max Hold element for REM test
        REM_iMaxHoldCount,       //Max Hold element for REM test
        REM_iMaxHoldDwell,       //Max Hold element for REM test
        iCMU_HWO_B83,            //CMU HW Option check override
        iCMU_HWO_B95,            //CMU HW Option check override
        iCMU_HWO_B96,            //CMU HW Option check override
        iCMU_HWO_B89,            //CMU HW Option check override
        TD_iXScaleUnits,         // Vector test time domain X scale (time, distance, etc.)
        TD_iXScaleMode,          // Vector test time domain distance mode (actual, half (reflective), point-to-point)
        TD_iCorrectForDistance,  // Vector test time domain - multiply Y by distance (linear voltage units) to correct for path loss
        TD_iRemoveNoise,         // Vector test time domain - try to remove noise floor
        iSG_DwellTime,
        iAGPS_Option,            //gps measurement selected
        iAGPS_Dwell,             //GPS dwell limit (default 20000 ms)
        BSS_iTestMode,           //MT8860 Direct or Network
        iICPolarization1,        //intermediate channel meas polarization
        iICPolarization2,        //intermediate channel meas polarization
        iICPolarization3,        //intermediate channel meas polarization
        iICNormalizedTIS,        //intermediate channel normalized TIS measurement
        iICPassFailView,         //intermediate channel option to view pass/fail results
        BSS_iSigSRBState,        //SRB Configuration Control
        iRSS_Polarization,       //RSS Curve Position
        iCorrectionFreqOpt,      //Option flag, use given correction frequency instead of trace frequency
        iAGPS_TISMeasCounts,     //Number of AGPS measurements take at sensitivity level, defaults to 100
        iRSS_PowerDwellTmMs,     //Dwell time after changing basestation power in RSS Test
        iAxisControlOptions,     //Axis Control Theta/Phi, Phi/Theta, etc.
        iRSSPatEncapsulate,      //RSS linearization Curve Options
        iRSSUpperHemiFilter,     //RSS EIP check on upper hemisphere only
        iRTSwithActivePage,      //Active tab for switch used on RT exercise
        iReverseDirection,       //inverts sign of positioner location
        iTriggerSlope,           //Trigger on rising or falling slope
        iTriggerAutoLev,         //toggle auto leveling
        iVideoAveCount,          //video averaging size
        iAveragingMode,
        iSimulatedNoiseMode,     // mode control for simulated noise floor
        iATP_GSM_LessThanMaxTXPower, //Alternative Test Procedure - GSM Less Than Maximum TX Power CDMA 3.0 section 6.15
        iSimulatedRSSMode,       // mode control for simulated RSSI/SNR, etc.
        iSimulatedRSSOption1,    // dummy parameters for simulated RSSI/SNR, etc.  -- will be renamed as needed later
        iSimulatedRSSOption2,
        iSimulatedRSSOption3,
        iRSS_StartSteps,          //number of sets above masureemt power to begin RSS curve
        iRSS_NAveragesPattern,    //number of points averaged for each pattern measurement
        iRSS_NAveragesRSSCurve,    //number of points averaged for each RSS measurement
        iBSS_SearchAlgo,          //Sensitivity Search Algorithm cboice (not just RSSI)
        BSS_iULPadPwrCtlActive,   //Auto Power Control for E6651 UL Padding test (TRP)
        iSimulatedFieldVolumeMode,  // output mode selection for simulating a field volume
        iSimulatedFieldVolumeSourceMode,  // Source signal mode for simulating a field volume
        iSimulatedCircularArrayCount, // Simulated circular environment simulator array antenna count
        iprmSimulatedWavesPerState,     // Number of plane waves per modeled reverb state
        iprmSimulatedReverbStates,     // Number of reverb states to simulate
        iUseRTAGPSCorrectionOffset,//use realtime correction offset for aGPS
        iUseAgilentAGPSCOMDriver,
        iETAPApplication,
        iETAPRate,
        iUseBestOrientation,
        iAltMeasureOption,
        iICReceiveDegradation,         //desense option for reporting EIS delta
        iVectComponentMask1,           //bit mask for vector component selections 0-31
        iVectComponentMask2,           //bit mask for vector component selections 32-63
        iDoUEBasedGPSPattern,
        idoCodePH_Error,
        idoCodePHRel,
        idoPSDopplerError,
        idoPSRMSError,
        iTriggerCount,
        iSensorConfig,
        iGateMode,
        iGatePolarity,
        iVectorLinearMask,
        iVectorCircularMask,
        iVectorEllipticalMask,
        iRecallRegister,
        iIFTorRegister,
        iOutSignalStatus1,
        iOutSignalStatus2,
        iOutSignalStatus3,
        iOutSignalStatus4,
        iOutSignalStatus5,
        iOutSignalStatus6,
        iOutSignalStatus7,
        iOutSignalStatus8,
        iInpSignalStatus1,
        iInpSignalStatus2,
        iInpSignalStatus3,
        iInpSignalStatus4,
        iInpSignalStatus5,
        iInpSignalStatus6,
        iInpSignalStatus7,
        iInpSignalStatus8,
        iNRPDriverOption,    //
        iNRPTimeSlots,       //
        iNRPGateNumber,      //
        iNRP_Reserved1,      // placeholder--
        iNRP_Reserved2,      // placeholder--
        iNRP_Reserved3,      // placeholder--
        iNRP_Reserved4,      // placeholder--
        iUEBasedTrigger,     // UEBased pattern measurement
        iChanEmulMeasureSteps, //how many steps - 0 to whatever
        iInt_Mob_IP_State,
        iHome_Agent_Shared_Secret,//hex
        iExt_PDSN_State,
        iExt_PDSN_TCP_Port,
        iExt_PDSN_Con_Timeout,
        iDUT_Route_State,
        iHardwareInterface,
        iTestSteps,
        iChanEmulatorStepSize,
        iChanEmulatorCount,
        iChanEmulatorChannels,
        iChanEmulatorStepMode,
        iUseExtReference,
        iTDSCDMA_NetworkModeOp,    //Network Mode of Operation
        iTDSCDMA_T300,             //T300 RRC Connection Request Retransmit Timer
        iTDSCDMA_N300,             //N300 RRC Connection Request Max Retransmits
        iTDSCDMA_T312,             //T312 Link Establishment Timer (Idle)
        iTDSCDMA_N312,             //N312 Link Establishment In-Sync Count (Idle)
        iTDSCDMA_MaxSyncULTrans,   //Max Sync UL Transmissions
        iTDSCDMA_MaxSyncAttempts,  //Max Number of Sync Attempts
        iTDSCDMA_UpPCHRamp,        //UpPCH Power Ramp Step
        iTDSCDMA_UpPCHPower,       //Desired UpPCH Rx Power
        iSetInitialGain,
        iApplyGain,
        BSS_iFTrafficFormat,
        iMediaFLO_FlowID,          //MediaFLO FlowID
        iMediaFLO_ReedSolomon,     //MediaFLO Reed Solomon Statistics Type
        iMediaFLO_System,          //MediaFLO System Type
        iOrientalMotorModel,       //ASD1x Models of oriental motor controllers
        iF8RewindOnPowerChange,    //option for the f8 to rewind the simulator on power change
        iRSE_Cut1PolarOption,
        iRSE_Cut2PolarOption,
        iRSE_Cut3PolarOption,
        iUseChariotTestTimeOpt,
        iNRPContAvSmoothModSig,
        iNRPContAvUseDutyCycle,
        iNRPContAvUseAutoRange,
        iThroughputorErrorRateOpt,
        TD_iOption1,              // Vector test time domain - dummies for various options we might add -- probably MatLab code select
        TD_iOption2,              // Vector test time domain - dummies for various options we might add
        TD_iOption3,              // Vector test time domain - dummies for various options we might add
        iThetaPrimaryPhiSecondary,
        iRealTimeCorrections,
        iAutoAlignAnalyzerOpt,
        // Starting new naming convention from here on.  TDataAwareTypes (parameters)
        // are now labeled as <type>prmParameterName, e.g. iprmAutoAlignAnalyzerOpt
        // Carrying existing prefixes BSS_, TD_, etc. forward along with this is
        // acceptable, e.g. TD_iprmOption1
        iprmTriggerSetupDelay,    // delay between "Take Sweep" and start of triggered positioner motion
        iTransposeSpatialAxis,
        iprmUseChanEmulMobileSpeedDefault,//let the mobile speed float

        //Agilent 8960 HSPA+
        //---------------------
        iHSPA_UE_HSDSCH_Control,         //call:cell:rlc:rees
        iHSPA_S_CCPH_ConfigState,        //call:ccpchannel:secondary:connected:config:state
        iHSPA_DPCH15KSPS_Code,           //call:dpchannel:ksps15:code:hsdpa
        iHSPA_DPCH30KSPS_Code,           //call:dpchannel:ksps30:code:hsdpa
        iHSPA_EHIChannelCode,            //call:ehichannel:ccode:code
        iHSPA_EAGChannelCode,            //call:eagchannel:ccode:code
        iHSPA_PSDataCode,                //call:hsdpa:service:psdata:hspdschannel:ccode:code
        iHSPA_SCCPCH_HSDPA_PrimState,       //call:connected:ccpchannel:primary:state:hsdpa
        iHSPA_PICH_HSDPA_State,          //call:connected:pichannel:state:hsdpa
        iHSPA_SCCPCH_HSPA_PrimState,        //call:connected:ccpchannel:primary:state:hspa
        iHSPA_PICH_HSPA_State,           //call:connected:pichannel:state:hspa
        iHSPA_RBT_HSDSConfig,            //call:hsdp:serv:rbt:hsds:conf
        iHSPA_RBTUD_HSDS_MAC,            //call:hsdpa:service:rbtest:udefined:hsdschannel:mac
        iHSPA_RBTUD_QAM64,               //call:hsdpa:service:rbtest:udefined:qam64:state
        iHSPA_RBTUD_HSPDSCHCount,        //call:hsdpa:service:rbtest:udefined:hspdschannel:count
        iHSPA_RBTUD_TBSizeIdx,           //call:hsdpa:service:rbtest:udefined:tbsize:index
        iHSPA_RBTUD_Mod,                 //call:hsdpa:service:rbtest:udefined:modulation
        iHSPA_RBTUD_MACEHS,              //call:hsdpa:service:rbtest:udefined:macehs:rlc:sdu
        iHSPA_RBTUD_ITTI,                //call:hsdpa:service:rbtest:udefined:itti
        iHSPA_RBTUD_HARQCount,           //call:hsdpa:service:rbtest:udefined:harq:process:count
        iHSPA_PSD_HSDSCH_MAC,            //call:hsdpa:service:psdata:hsdschannel:mac
        iHSPA_PSD_QAM64,                 //call:hsdpa:service:psdata:qam64:state
        iHSPA_PSD_HSDSConfig,            //call:hsdpa:service:psdata:hsdschannel:config
        iHSPA_PSDUD_HSPDSCHCount,        //call:hsdpa:service:psdata:udefined:hspdschannel:count
        iHSPA_PSDUD_TBSizeIdx,           //call:hsdpa:service:psdata:udefined:tbsize:index
        iHSPA_PSDUD_Mod,                 //call:hsdpa:service:psdata:udefined:modulation
        iHSPA_PSD_PDUControl,            //call:hsdpa:service:psdata:macd:pdusize:control
        iHSPA_PSD_PDUSize,               //call:hsdp:serv:psd:macd:pdusize
        iHSPA_PSD_RCL_DwnLnkMode,        //call:hsdpa:service:psdata:rlc:downlink:mode
        iHSPA_PSD_CQI_Level,             //call:hsdp:serv:psd:cqi
        iHSPA_GPRS_RAB,                  //call:serv:gprs:rab
        iHSPA_RBTRAB,                    //call:serv:rbt:rab
        iHSPA_CPICHState,                //call:conn:cpic:stat:hspa
        iHSPA_CCPCH_SecState,            //call:conn:ccpc:sec:stat:hspa
        iHSPA_CCPCH_PrimState,           //call:conn:ccpc:prim:stat:hspa
        iHSPA_PICHstate,                 //call:conn:pich:stat:hspa
        iHSPA_DPCHstate,                 //call:conn:dpch:stat:hspa
        iHSPA_HSSC1state,                //call:conn:hssc1:stat:hspa
        iHSPA_HSSC2state,                //call:conn:hssc2:stat:hspa
        iHSPA_HSSC3state,                //call:conn:hssc3:stat:hspa
        iHSPA_HSSC4state,                //call:conn:hssc4:stat:hspa
        iHSPA_HSPDstate,                 //call:conn:hspd:stat:hspa
        iHSPA_ERGCstate,                 //call:conn:ergc:stat:hspa
        iHSPA_PSD_SRBmapp,               //call:serv:psd:srb:mapp
        iHSPA_PSD_EDPD_CCODmax,          //call:hsup:serv:psd:edpd:ccod:max
        iHSPA_HSUPA_EDCH_TTI,            //call:hsup:edch:tti
        iHSPA_PSD_ERGC_InfState,         //call:hsup:serv:psd:ergc:inf:stat
        iUseCurrentSettings,             //use current config settings in CheckConfig
        BSS_iMT8820C_Scenario,           //Scenario Selection for Anritsu MT8820C
        iLTEChannelBandwidth,            //LTE Channel Bandwidth Selection
        iStepPositionerType,             //Positioner type selection for Step Motor driver

        //LTE (CMW 500)
        iprmLTE_CyclicPrefix,            //Cyclic Prefix
        iprmLTE_PHICH_RsrcNg,            //PHICH Resource Ng
        iprmLTE_MNC_Digits,              //MNC Digits
        iprmLTE_PDSCH_OffsetPA,          //PDSCH Power Offset PA
        iprmLTE_PDSCH_RatioIdxPB,        //PDSCH Power Ratio Index PB
        iprmLTE_UETermConnType,          //UE Terminated Connection Type
        iprmLTE_RMC_DL_NumRB,            //RMC Downlink Number Resource Blocks
        iprmLTE_RMC_UL_NumRB,            //RMC Uplink Number Resource Blocks
        iprmLTE_RMC_DL_RBPos,            //RMC Downlink Resource Block Position
        iprmLTE_RMC_UL_RBPos,            //RMC Uplink Resource Block Position
        iprmLTE_UDCH_DL_NumRB,           //User Defined Channels Downlink Number Resource Blocks
        iprmLTE_UDCH_UL_NumRB,           //User Defined Channels Uplink Number Resource Blocks
        iprmLTE_UDCH_DL_StartRB,         //User Defined Channels Downlink Start Resource Block
        iprmLTE_UDCH_UL_StartRB,         //User Defined Channels Uplink Start Resource Block
        iprmLTE_UDCH_DL_TrnBlkSzIdx,     //User Defined Channels Downlink Transport Block Size Index
        iprmLTE_UDCH_UL_TrnBlkSzIdx,     //User Defined Channels Uplink Transport Block Size Index
        iprmLTE_DL_ErrorInsertion,       //Downlink Error Insertion
        iprmLTE_AddlSpectEmission,       //Additional Spectrum Emission
        iprmLTE_UEMeasFilterCoef,        //UE Meas. Filter Coefficient

        // LTE Anritsu MT8820C
        iprmLTE_FrameType,               //LTE Frame type (FDD, TDD)
        iprmLTE_ExternalLoss,            //LTE external loss
        iprmLTE_Antenna_Config,          //LTE Antenna Configuration
        iprmLTE_RMC_Config,              //LTE RMC Configuration
        iprmLTE_UE_Category,             //LTE UE Category
        iprmLTE_DTCH_Pattern,        //LTE DTCH Data Pattern
        iprmLTE_UL_MCS_Index,            //LTE Uplink MCS Index
        iprmLTE_DL_MCS_Index_1469,       //LTE Downlink MCS Index 1-4,6-9
        iprmLTE_DL_MCS_Index_5,          //LTE Uplink MCS Index 5
        iprmLTE_DL_MCS_Index_0,          //LTE Uplink MCS Index 0
        iprmLTE_Paging_IMSI,             //LTE Paging IMSI
        iprmLTE_CRNTI,                   //LTE cell radio network temporary ID
        iprmLTE_RMCTestMode,             //LTE RMC Test Mode
        iprmLTE_RRCRelReg,               //LTE RRC Release during registration
        iprmLTE_GroupHopping,            //LTE Group Hopping
        iprmLTE_MeasureReport,           //LTE Measurement Report
        iprmLTE_CallDrop,                //LTE Call drop switch
        iprmLTE_NOM_PUSCH,               //LTE p0-Nominal PUSCH
        iprmLTE_SIB2_NB,                 //LTE nB of SIB2
        iprmLTE_PreambleTrasMax,         //LTE preambleTransMax
        iprmLTE_RARespWindowSize,        //LTE ra-ResponseWindowSize
        iprmLTE_RABConnection,           //LTE RAB Connect
        iprmLTE_HARQMaxNumberTrans,      //LTE Max. Number of HARQ Transmissions
        iprmLTE_HARQ_RVCODING_1,         //LTE HARQ Redundancy and Constellation (1)
        iprmLTE_HARQ_RVCODING_2,         //LTE HARQ Redundancy and Constellation (2)
        iprmLTE_HARQ_RVCODING_3,         //LTE HARQ Redundancy and Constellation (3)
        iprmLTE_HARQ_RVCODING_4,         //LTE HARQ Redundancy and Constellation (4)
        iprmLTE_RACH_RecTargetPower,     //Preamble Initial Received Target Power
        iprmLTE_RACH_ConfigIndex,        //prach-ConfigIndex for SIB2
        iprmLTE_RACH_ResTiming,          //random access response timing
        iprmLTE_P2_ExternalLoss,         //LTE Phone-2 external loss

        //LTE (CMW 500)
        iprmLTE_RSSI_MsrType,            //RSSI Measurement Type - RSRP or RSRQ
        iprmLTE_RFOutputPort2,           //RF Output Port 2 Selection
        iprmLTE_PRACH_FreqOffset,        //PRACH Frequency Offset
        iprmLTE_PRACH_LogRootSeqIdx,     //PRACH Logical Root Sequence Index
        iprmLTE_PRACH_ZeroCorZoneCfg,    //PRACH Zero Correlation Zone Config
        iprmLTE_Scenario,                //Scenario selection for MIMO mode
        iprmLTE_StaticChModel_h11phi,    //Static Channel Model h11phi
        iprmLTE_StaticChModel_h12phi,    //Static Channel Model h12phi
        iprmLTE_StaticChModel_h21phi,    //Static Channel Model h21phi
        iprmLTE_StaticChModel_h22phi,    //Static Channel Model h22phi
        iprmLTE_RMC_DL2_NumRB,           //RMC Downlink Stream 2 Number Resource Blocks
        iprmLTE_RMC_DL2_RBPos,           //RMC Downlink Stream 2 Resource Block Position
        iprmLTE_UDCH_DL2_NumRB,          //UDCH Downlink Stream 2 Number Resource Blocks
        iprmLTE_UDCH_DL2_StartRB,        //UDCH Downlink Stream 2 Start Resource Block
        iprmLTE_UDCH_DL2_TrnBlkSzIdx,    //UDCH Downlink Stream 2 Transport Block Size Index

        //Theta ring
        iNumRingPositions,               //Number of ring sensors

        //Asd Moto Driver settings
        iAsdDefAccTime,                  //Default Acceleration Time
        iAsdMinAccTime,                  //Min Acceleration Time
        iAsdMaxAccTime,                  //Max Acceleration Time
        iSMSTimeoutMS,                   //SMS Msg Timeout

        iprmLTE_SensitivityMode,         //Sensitivity Mode- BLER vs. Throughput

        i8960LabAppTPMonitorOn,
        i8960LabAppTPMeasurement,
        i8960LabAppTimer,

        iHSPA_UE_HSDSCH_Category,
        iHSPA_UPA_RBTest_Throughput,
        iModelDataInputType,              //Model Input Format for Antenna Correlcation

        iCMU_GPSPortNumber,               //CMU-K90  XML-RPC Port Number
        iCMU_GPSScenario,                 //CMU-K90  GPS Scenario
        iCMU_GPSLevelSetting,             //CMU-K90  GPS Level Setting
        iCMU_GPSMode,                    //CMU-K90  GPS Mode
        iCMU_GPSResetReceiver,            //CMU-K90  Reset A-GPS Receiver
        iCMU_GPSSendRefTime,              //CMU-K90  Send Ref. Time
        iCMU_GPSSendRefLoc,               //CMU-K90  Send Ref. Location
        iCMU_GPSSendNaviModel,            //CMU-K90  Send Navigation Model
        iCMU_GPSSendIonoModel,            //CMU-K90  Send Ionospheric Model
        iCMU_GPSSendUTCModel,             //CMU-K90  Send UTC Model
        iCMU_GPSSendAlmanac,              //CMU-K90  Send Almanac
        iCMU_GPSSendAcqModel,             //CMU-K90  Send Acquistion Model

        iprmLTE_TransmissionScheme,       //Transmission Scheme
        iprmLTE_UDTTI_DL_NumRB_0,         //User Defined TTI Based Downlink Number Resource Blocks, TTI 0
        iprmLTE_UDTTI_DL_NumRB_5,         //User Defined TTI Based Downlink Number Resource Blocks, TTI 5
        iprmLTE_UDTTI_DL_NumRB_1469,      //User Defined TTI Based Downlink Number Resource Blocks, TTI 1-4,6-9
        iprmLTE_UDTTI_DL2_NumRB_0,        //User Defined TTI Based Downlink2 Number Resource Blocks, TTI 0
        iprmLTE_UDTTI_DL2_NumRB_5,        //User Defined TTI Based Downlink2 Number Resource Blocks, TTI 5
        iprmLTE_UDTTI_DL2_NumRB_1469,     //User Defined TTI Based Downlink2 Number Resource Blocks, TTI 1-4,6-9
        iprmLTE_UDTTI_UL_NumRB_0,         //User Defined TTI Based Uplink Number Resource Blocks, TTI 0
        iprmLTE_UDTTI_UL_NumRB_5,         //User Defined TTI Based Uplink Number Resource Blocks, TTI 5
        iprmLTE_UDTTI_UL_NumRB_1469,      //User Defined TTI Based Uplink Number Resource Blocks, TTI 1-4,6-9
        iprmLTE_UDTTI_DL_StartRB_0,       //User Defined TTI Based Downlink Start Resource Block, TTI 0
        iprmLTE_UDTTI_DL_StartRB_5,       //User Defined TTI Based Downlink Start Resource Block, TTI 5
        iprmLTE_UDTTI_DL_StartRB_1469,    //User Defined TTI Based Downlink Start Resource Block, TTI 1-4,6-9
        iprmLTE_UDTTI_DL2_StartRB_0,      //User Defined TTI Based Downlink2 Start Resource Block, TTI 0
        iprmLTE_UDTTI_DL2_StartRB_5,      //User Defined TTI Based Downlink2 Start Resource Block, TTI 5
        iprmLTE_UDTTI_DL2_StartRB_1469,   //User Defined TTI Based Downlink2 Start Resource Block, TTI 1-4,6-9
        iprmLTE_UDTTI_UL_StartRB_0,       //User Defined TTI Based Uplink Start Resource Block, TTI 0
        iprmLTE_UDTTI_UL_StartRB_5,       //User Defined TTI Based Uplink Start Resource Block, TTI 5
        iprmLTE_UDTTI_UL_StartRB_1469,    //User Defined TTI Based Uplink Start Resource Block, TTI 1-4,6-9
        iprmLTE_UDTTI_DL_TBSI_0,       //User Defined TTI Based Downlink Transport Blk Size Index, TTI 0
        iprmLTE_UDTTI_DL_TBSI_5,       //User Defined TTI Based Downlink Transport Blk Size Index, TTI 5
        iprmLTE_UDTTI_DL_TBSI_1469,    //User Defined TTI Based Downlink Transport Blk Size Index, TTI 1-4,6-9
        iprmLTE_UDTTI_DL2_TBSI_0,      //User Defined TTI Based Downlink2 Transport Blk Size Index, TTI 0
        iprmLTE_UDTTI_DL2_TBSI_5,      //User Defined TTI Based Downlink2 Transport Blk Size Index, TTI 5
        iprmLTE_UDTTI_DL2_TBSI_1469,   //User Defined TTI Based Downlink2 Transport Blk Size Index, TTI 1-4,6-9
        iprmLTE_UDTTI_UL_TBSI_0,       //User Defined TTI Based Uplink Transport Blk Size Index, TTI 0
        iprmLTE_UDTTI_UL_TBSI_5,       //User Defined TTI Based Uplink Transport Blk Size Index, TTI 5
        iprmLTE_UDTTI_UL_TBSI_1469,    //User Defined TTI Based Uplink Transport Blk Size Index, TTI 1-4,6-9
        iprmLTE_PRACH_PwrRampStep,     //PRACH Power Ramping Step
        iprmLTE_PRACH_CfgIndex,        //PRACH Configuration Index

        iCMU_GPSRFPort,                //CMU-K90 RF Port

        iprmLTE_PowerMethod,           //LTE Power Method- EPRE vs. Full Cell Power
        iprmLTE_SequenceHopping,       //LTE Sequence Hopping
        iprmLTE_RRCUpdate,             //LTE RRC update method
        iprmLTE_TempCRNTI,             //LTE TEMP C-RNTI for handover
        iprmLTE_AuthAMF,               //LTE Authentication AMF
        iprmLTE_ModifPeriodCoeff,      //LTE BCCH/PCCH modification Period Coeff.
        iprmLTE_nRB_CQI,               //LTE SIB 2 nRB-CQI for PUCCH
        iprmLTE_IntegrityPro,          //LTE Integrity Protection
        iUEBasedAPGS,
        iUEBasedTestState,
        iUEAssistedOrBasedEIS,
        iAgpsCNORetryAttempts,
        iCEParameterVersion,

        //lTE Agilent PXT E6621
        iprmLTE_DL_Freq,               //LTE Downlink Frequency
        iprmLTE_UL_Freq,               //LTE Uplink Frequency
        iprmLTE_PEC,                   //LTE PEC
        iprmLTE_ControlMode,           //LTE Control Mode
        iprmLTE_PHICH_Rsrc,            //LTE PHICH Resource
        iprmLTE_CFI,                   //LTE CFI
        iprmLTE_Security,              //LTE Security ON/OFF
        iprmLTE_KeyOption,             //LTE KEY Option
        iprmLTE_IMSI_Value,            //LTE IMSI Value Option
        iprmLTE_KeyValue,              //LTE KEY Value
        iprmLTE_DL_HARQMaxTrans,       //LTE Downlink HARQ Max Trans
        iprmLTE_UL_HARQMaxTrans,       //LTE Uplink HARQ Max Trans
        iprmLTE_MIMO_CodeBook,         //LTE MIMO Setting � Codebook
        iprmLTE_MIMO_Layer,            //LTE MIMO Setting � Layer

        iprmLTE_PowerControlDCI,       //LTE Power Control DCI
        iprmLTE_PowerControlAllUp,     //LTE Power Control All Up
        iprmLTE_PowerControlAllDown,   //LTE Power Control All Down
        iprmLTE_DL_AggregationCRNTI,   //LTE Downlink Aggregation CRNTI
        iprmLTE_DL_AggregationSI,      //LTE Downlink Aggregation SI
        iprmLTE_DL_RSCAllocationMode,  //LTE Downlink Resource Allocation Mode
        iprmLTE_DL_MCSBasedCQI,        //LTE Downlink MCS Based CQI
        iprmLTE_DL_Type0Bitmap,        //LTE Downlink Type0 Bitmap
        iprmLTE_DL_TXPattern,          //LTE Downlink TX Pattern
        iprmLTE_DL_SubFrame5Ctrl,      //LTE Downlink subframe control
        iprmLTE_UL_RSCAllocationMode,  //LTE Uplink resource Allocation Mode.
        iprmLTE_UL_IgnorePRACH,        //LTE Uplink Ignore PRACH
        iprmLTE_UL_AggregationLevel,   //LTE Uplink Aggregation Level
        iprmLTE_UL_TXPattern,          //LTE Uplink TX Pattern
        iprmLTE_DL_LMCSCtrl,           //LTE Downlink LMCS control
        iprmLTE_DL_LMCSAll,            //LTE Downlink LMCS
        iprmLTE_DL_LMCSSubFrame0,      //LTE Downlink LMCS subframe 0
        iprmLTE_DL_LMCSSubFrame1_9,    //LTE Downlink LMCS subframe 1-9

        //MT8820C WCDMA settings
        iprmBSS_LossOptMainUL,        //Enable/Disable External Loss on Main UL
        iprmBSS_LossOptMainDL,        //Enable/Disable External Loss on Main DL
        iprmBSS_LossOptAux,           //Enable/Disable External Loss on AUX
        iprmBSS_DCCHSecScrambleCode,  //DCCH Secondary Scrambling code
        iprmBSS_RABSecScrambleCode,   //RAB Secondary Scrambling code
        iprmBSS_DCCHChCode,           //DCCH Channelization Code
        iprmBSS_RABChCode,            //RAB Channelization code
        iprmBSS_SystemInfoType,       //System Information Type 5 (SIB5 Type)

        //Placeholders for future MT8820C settings
        iprmMT8820Cdummy1,
        iprmMT8820Cdummy2,
        iprmMT8820Cdummy3,
        iprmMT8820Cdummy4,
        iprmMT8820Cdummy5,
        iprmMT8820Cdummy6,
        iprmMT8820Cdummy7,
        iprmMT8820Cdummy8,
        iprmMT8820Cdummy9,
        iprmMT8820Cdummy10,
        iprmMT8820Cdummy11,
        iprmMT8820Cdummy12,
        iprmMT8820Cdummy13,
        iprmMT8820Cdummy14,
        iprmMT8820Cdummy15,

        iChanEmulatorIterateAcross,   // Flag for output cal to iterate across inputs or outputs

        iEtherSwitchMainframe,        // Selection of one of several possible mainframes for new EtherSwitch module driver
        iEtherSwitchDummy0,           // Place holders for EtherSwitch expansion
        iEtherSwitchDummy1,           // Place holders for EtherSwitch expansion
        iEtherSwitchDummy2,           // Place holders for EtherSwitch expansion
        iEtherSwitchDummy3,           // Place holders for EtherSwitch expansion
        iEtherSwitchDummy4,           // Place holders for EtherSwitch expansion
        iEtherSwitchDummy5,           // Place holders for EtherSwitch expansion

        //UE Blind Log Related.
        iprmUEBlindLogDelay,          // UE Blind Log Delay value

        iprmUseHSDPABlockErrRate,
        iprmUseHSDPAThroughput,
        iprmBSS_HSDPADataType,
        iprmHsdpaHS_SCCHTimeSlot,
        iprmRRCState,
        iprmHandOverType,
        iprmUplinkDPCHTimeSlot,
        iprmPeriodicLocationUpdate,
        iprmSIB7RepPeriod,
        iprmPCCPCHTxPwr,
        iprmHsdpaHS_SCCH_UE_ID1,
        iprmHsdpaHS_SCCH_UE_ID2,
        iprmHsdpaHS_SCCH_UE_ID3,
        iprmHsdpaHS_SCCH_UE_ID4,
        iprmHARQMemSize,
        iprmHsupaE_RNTI,
        iprmHsupaEAGCHAbsGrantValue,
        iprmHsupaEHICHPattern,
        iprmPeriodicRoutUpdateValue,
        iprmPeriodicRoutUpdateUnit,
        //HSPA CMU

        iBSS_HSPA_RMC_TEST_LOOP, //"Cirtuit Switched RMC Settings Test Loop"
        iBSS_HSPA_DCH_TYPE, //"Packet Switched RMC Settings Test Loop DCH Type"
        iBSS_HSPA_HSUPA_ULRCL_SDUSIZE, //"Packet Switched HSUPA Test Mode UL RLC SDU size"
        iBSS_HSPA_TTIMODE, //"TTIMode E-DCH Category"
        iBSS_HSPA_DPCH_TOFFSET, //"BS Signal DL DPCH Timing Offset"
        iBSS_HSPA_ETFCI_TINDEX, //"HSUPA E-TFCI Table Index"
        iBSS_HSPA_ETFCI_MSET, //"HSUPA E-TFCI Mnimum Set"
        iBSS_HSPA_HBDCONDITION, //"HSUPA Happy Bit Delay"
        iBSS_HSPA_CCODE_MAX, //"HSUPA Maximum Channelization Code"
        iBSS_HSPA_HARQ_POFFSET, //"HSUPA RAB H-ARQ Power Offset"
        iBSS_HSPA_HARQ_MAX_RETRAN, //"HSUPA H-ARQ Maximum Number of Retransmissions"
        iBSS_HSPA_ETFCI_NREFS, //"HSUPA Gain Factors Number of Reference E-TFCIs"
        iBSS_HSPA_ETFCI_REF1, //"Reference E-TFCI"
        iBSS_HSPA_ETFCI_REF2, //"Reference E-TFCI"
        iBSS_HSPA_ETFCI_REF3, //"Reference E-TFCI"
        iBSS_HSPA_ETFCI_REF4, //"Reference E-TFCI"
        iBSS_HSPA_ETFCI_REF5, //"Reference E-TFCI"
        iBSS_HSPA_ETFCI_REF6, //"Reference E-TFCI"
        iBSS_HSPA_ETFCI_REF7, //"Reference E-TFCI"
        iBSS_HSPA_ETFCI_REF8, //"Reference E-TFCI"
        iBSS_HSPUA_ETFCI_OFFSET1, //"Reference E-TFCI Power Offset"
        iBSS_HSPUA_ETFCI_OFFSET2, //"Reference E-TFCI Power Offset"
        iBSS_HSPUA_ETFCI_OFFSET3, //"Reference E-TFCI Power Offset"
        iBSS_HSPUA_ETFCI_OFFSET4, //"Reference E-TFCI Power Offset"
        iBSS_HSPUA_ETFCI_OFFSET5, //"Reference E-TFCI Power Offset"
        iBSS_HSPUA_ETFCI_OFFSET6, //"Reference E-TFCI Power Offset"
        iBSS_HSPUA_ETFCI_OFFSET7, //"Reference E-TFCI Power Offset"
        iBSS_HSPUA_ETFCI_OFFSET8, //"Reference E-TFCI Power Offset"
        iBSS_HSPA_TPC_SETTINGS, //"Reference E-TFCI Power Offset"
        iBSS_HSSC_NUMBER, //" Number of HS-SCCH"
        iBSS_HSSC_SUBFRAMES, //" HS-SCCH Selection"
        iBSS_HSUPA_ENABLE, //" HS-SCCH Selection"
        iBSS_HSUPA_ERGH_ACTIVE, //"E-RGCH Active "
        iBSS_HSSC_SELECTION,   // " HS-SCCH Selection"
        iBSS_HSUPA_RLCPDU, // "HSUPA RLC PDU Size"
        iBSS_AWGN_PWR_ONOFF, // "AWGN Noise Pwr."
        iBSS_HARQ_FEEDBACK, // "HARQ Feedback (E-HICH)"

        //Anritsu MT8820C GSM
        iprmBSSOutLvlCorrection, // Output Level Correction
        iprmBSSMeasuringObject,  // Measuring Object
        iprmBSSTrainingSequence, // Training Sequence
        iprmBSSUSFAllocation,    // USF Allocation
        iprmBSSDLLogicalChannel, // Downlink Logical Channel
        iprmBSSPuncturingScheme, // Puncturing Scheme

        //LTE (CMW 500, firmware 2.1.20)
        iprmLTE_UEMsrRpt_Interval,   //UE Measurement Report- Reporting Interval

        i8960ConfigAppSelect,
        i8960WCDMAFWVersions,

        iPXTCellSelection,   //Cell Selection
        iPXTSECurityREPLay,   //Security replay option
        iPXTPTIHandling,   //PTI Handling
        iPXTPZUE_PUSCh,   //UE PUSCH
        iPXTTMRESOUrce_TYpe,   //TM1 Bitmap Type
        iPXTOTHERPHych_RA,   //Other PHY RA
        iPXTOTHERPHych_RB,   //Other PHY RB
        iThroughputMaxTheory,  //Throughput Max Theory.

        iprmInputLevelSetMode,        // Input Level Set Mode
        iprmLossConfig,               // Loss config
        iprmF_PICHState,              // F_PICH Set State
        iprmF_SYNCHState,             // F_SYNCH Set State
        iprmF_PCHState,               // F_PCH Set State
        iprmF_FCHState,               // F_FCH Set State
        iprmF_FCHDataRate,            // F_FCH data rate
        iprmF_FCHWalshCode,           // F_FCH Walsh Code
        iprmF_DCCHState,              // F_DCCH state
        iprmF_DCCHWalshCode,          // F_DCCH Walsh Code
        iprmF_SCH1State,              // F_SCH1 state
        iprmF_SCH1DataRate,           // F_SCH1 data rate
        iprmF_SCH1Encoding,           // F_SCH1 encoding
        iprmR_SCH1State,              // R_SCH1 state
        iprmR_SCH1DataRate,           // R_SCH1 data rate
        iprmR_SCH1Encoding,           // R_SCH1 encoding

        iprmNW_MSControl,             // MS Orig. SO Negotiation
        iprmSO3Mode,                  // OS3 Mode
        iprmSO32_33Option,            // OS32/33 Option
        iprmASSIGN_MODE,              // Assign Mode
        iprmBYPASS_ALERT_ANSWER,      // BYPASS_ALERT_ANSWER
        iprmLayer2AddressType,        // Layer 2 Address Type
        iprmESN,                      // ESN
        iprmIMSIType,                 // IMSI Type
        iprmIMSI_MCC,                 // IMSI (MCC part)
        iprmIMSI_MNC,                 // IMSI (MNC part)
        iprmIMSI_MSIN,                // IMSI (MSIN part)
        iprmDormantState,             // Dormant State
        iprmDormantTimer,             // Dormant Timer

        BSS_iPwrClass,                //Bluetooth Power Class
        BSS_iAvePwrStart,             //Bluetooth
        BSS_iAvePwrStop,              //Bluetooth

        //HSPA for MT8820C WCDMA
        iprmHsupaERGCHPattern,         // E-AGCH pattern
        iprmHsupaDPCCHPwrOffset,       // E-DPCCH power offset
        iprmHsupaSubtest5Ver,          // Subtest 5 version

        iPwrSplitterMode,

        iprmTrafficChannelPayload,     //MT8820C EVDO Traffic Channel Payload
        iprmARQMode,                   //MT8820C EVDO ARQ MODE
        iprmRRIGain,                   //MT8820C EVDO RRI GAIN 0
        iprmDataChannelTransmissionMode,    //MT8820C EVDO Data Channel Transmission Mode
        iprmDataChannelPacketSize,    //MT8820C EVDO Data Channel PacketSize
        iprmT2PTransition,            //MT8820C EVDO T2P Transition
        iprmTerminationTarget,        //MT8820C EVDO Termination Target
        iprmRRIGainPost,              //MT8820C EVDO RRI Post GAIN 0
        iprmRRIGain1,                 //MT8820C EVDO RRI GAIN 1
        iprmRRIGain2,                 //MT8820C EVDO RRI GAIN 2
        iprmRRIGain3,                 //MT8820C EVDO RRI GAIN 3
        iprmRRIGainPost1,             //MT8820C EVDO RRI Post GAIN 1
        iprmRRIGainPost2,             //MT8820C EVDO RRI Post GAIN 2

        iprmCalculateRippleAttributes,   // Ripple based vector pattern attributes
        iprmCalculateRipplePattern,
        iprmAutoCalculateRippleAttributes,
        iprmAutoCalculateRipplePattern,
        iprmCalculatePolarizationPurity,
        iprmRipple2,
        iprmRipple3,
        iprmCalculateNF2FFConversion,    // Near to far-field conversion

        BSS_iWCDMA_XMITSIB5bis,

        iprmLTE_TxAntenna_Num,     //No of TX Antennas

        iprmLTE_CDRX_STATe,        //Connected DRX Connected DRX On/Off
        iprmLTE_CDRX_LDCYcle,      //Connected DRX longDRX-Cycle
        iprmLTE_CDRX_LDCStart,     //Connected DRX longDRX-CycleStartOffset
        iprmLTE_CDRX_ONDuration,   //Connected DRX onDurationTimer
        iprmLTE_CDRX_INACtivity,   //Connected DRX drx-InactivityTime
        iprmLTE_CDRX_SDCYcle_STATe,   //Connected DRX Short DRX Cycle On/Off
        iprmLTE_CDRX_SDCYcle_Value,   //Connected DRX ShortDRX-Cycle
        iprmLTE_CDRX_SDCYcle_TIMer,   //Connected DRX drxShortCycleTimer

        iprmLTE_MIMO_CTMIndex,     //Codeword 2 MCS Index
        iprmLTE_MIMO_CTIMcs,       //l_MCS(Codeword 2)
        iprmLTE_MIMO_NUMLayerMODE,       //Rank Selection
        iprmLTE_MIMO_CODEBookMODE,       //Precoder Selection

        i2090_TriggerToggleOnInit,       //trigger toggle on 2090 ini to fix race condition

        iprmUPDConnPort,                 //The port for UPD connection
        iprmEquipConnType,               //Equipment Connection Type

        iChannelModelType,               //MIMO or Constant Tap
        iChanEmulStepTime,

        iOutSignalStatus9,
        iOutSignalStatus10,
        iOutSignalStatus11,
        iOutSignalStatus12,
        iOutSignalStatus13,
        iOutSignalStatus14,
        iOutSignalStatus15,
        iOutSignalStatus16,
        iInpSignalStatus9,
        iInpSignalStatus10,
        iInpSignalStatus11,
        iInpSignalStatus12,
        iInpSignalStatus13,
        iInpSignalStatus14,
        iInpSignalStatus15,
        iInpSignalStatus16,

        iprmComAntennaPatternTestPlanName,     // Name of the test plan (multi-Antenna Pattern Test)
        iprmComAntennaPatternTestPlanVersion,  // Version of the test plan (multi-Antenna Pattern Test)
        iprmAntennaPatternTestResultOuput,     // multi-Antenna Pattern Test Results Output
        BSS_iPDTCH_PRLBurst5,
        BSS_iPDTCH_PRLBurst6,
        iSupportTSlot5n6,
        BSS_iSensitivityRSSOptimization,       //Use RSSI value to do the sensitivity measurement optimization
        iNumberOfUnits,       // number of EMCEnter units
        iprmOutputCorFileCount,

        iprmCMW500_RXConverter,     // CMW500 RX Converter
        iprmCMW500_TXConverter,     // CMW500 TX Converter

        iprmAllowHandoverFromPreConn, // Allow handover from previous connection
        iprmHandoverBandChange,       // The mechanism to be used for inter-band handover
        iprmHandoverBandChangeTime,   // The settling time to be used for inter-band handover
        iprmHandoverFreqChange,       // The mechanism to be used for inter-freq handover
        iprmHandoverFreqChangeTime,   // The settling time to be used for inter-freq handover

        iBSS_EnableSecAddress,
        iBSS_GSM_400_SecAddress,
        iBSS_GSM_850_SecAddress,
        iBSS_GSM_900_SecAddress,
        iBSS_GSM_1800_SecAddress,
        iBSS_GSM_1900_SecAddress,

        iEnable_Audio_EncoderDecoder,
        iBSS_VoiceActDetectAlg,
        iBSS_VoiceActDetectAlgOpt,
        iBSS_WCDMA_ARMSource,

        iBSS_WCDMA_SecAddress,
        iBSS_CDMA_450_SecAddress,
        iBSS_CDMA_800_SecAddress,
        iBSS_CDMA_1900_SecAddress,
        iBSS_CDMA_2200_SecAddress,

        iBSS_RMCDataRate,
        iBSS_SRBDataRate,

        iprmCMW500_MeasureStatisticCounts,
        iprmCMW500_MeasureSlotOffset,
        iprmCMW500_MeasureNoOfSlot,
        iprmCMW500_CSMeasureSlot,
        iprmCMW500_PSGSMDataSource,
        iprmCMW500_PSSlotOffset,
        iprmCMW500_CSCallerID,
        iprmCMW500_TCHAssignment,
        iprmCMW500_BSAGblksres,
        iprmCMW500_BSPamfrms,
        iprmCMW500_PDPContextActivation,
        iprmCMW500_T3312,

        iprmCMW500_TBFLevel,
        iprmCMW500_ULCodingScheme,

        iprmCMW500_ULGammaSlot0,
        iprmCMW500_ULGammaSlot1,
        iprmCMW500_ULGammaSlot2,
        iprmCMW500_ULGammaSlot3,
        iprmCMW500_ULGammaSlot4,
        iprmCMW500_ULGammaSlot5,
        iprmCMW500_ULGammaSlot6,
        iprmCMW500_ULGammaSlot7,

        iAgilent_AI_Ver2_2_DLL,

        iprmECCPatternMode,

        iprmCMW500_AMRNBFR_DL,
        iprmCMW500_AMRNBFR_UL,
        iprmCMW500_AMRNBFR_CodecMode4,
        iprmCMW500_AMRNBFR_CodecMode3,
        iprmCMW500_AMRNBFR_CodecMode2,
        iprmCMW500_AMRNBFR_CodecMode1,

        iprmCMW500_AMRNBHR_DL,
        iprmCMW500_AMRNBHR_UL,
        iprmCMW500_AMRNBHR_CodecMode4,
        iprmCMW500_AMRNBHR_CodecMode3,
        iprmCMW500_AMRNBHR_CodecMode2,
        iprmCMW500_AMRNBHR_CodecMode1,

        iprmCMW500_AMRWBFR_DL,
        iprmCMW500_AMRWBFR_UL,
        iprmCMW500_AMRWBFR_CodecMode3,
        iprmCMW500_AMRWBFR_CodecMode2,
        iprmCMW500_AMRWBFR_CodecMode1,

        iprmTwoAntennaOption,   // Two Antenna Method options
        iprmRefAntennaNumber,    // Two Antenna Method reference antenna number

        iprmTDLTE_ULDLConfig,    // TD-LTE UL DL Configuration
        iprmTDLTE_SpecialFrame,  // TD-LTE Special Frame Configuration

        iprmLTE_TDD_UDTTI_DL_NumRB_0,         //User Defined TTI Based Downlink Number Resource Blocks, TTI 0
        iprmLTE_TDD_UDTTI_DL_NumRB_5,         //User Defined TTI Based Downlink Number Resource Blocks, TTI 5
        iprmLTE_TDD_UDTTI_DL_NumRB_S,         //User Defined TTI Based Downlink Number Resource Blocks, Special subframe
        iprmLTE_TDD_UDTTI_DL_NumRB_Left,      //User Defined TTI Based Downlink Number Resource Blocks, All left

        iprmLTE_TDD_UDTTI_DL2_NumRB_0,        //User Defined TTI Based Downlink2 Number Resource Blocks, TTI 0
        iprmLTE_TDD_UDTTI_DL2_NumRB_5,        //User Defined TTI Based Downlink2 Number Resource Blocks, TTI 5
        iprmLTE_TDD_UDTTI_DL2_NumRB_S,        //User Defined TTI Based Downlink2 Number Resource Blocks, Special subframe
        iprmLTE_TDD_UDTTI_DL2_NumRB_Left,     //User Defined TTI Based Downlink2 Number Resource Blocks, All left

        iprmLTE_TDD_UDTTI_UL_NumRB_A,         //User Defined TTI Based Uplink Number Resource Blocks, TTI All

        iprmLTE_TDD_UDTTI_DL_StartRB_0,       //User Defined TTI Based Downlink Start Resource Block, TTI 0
        iprmLTE_TDD_UDTTI_DL_StartRB_5,       //User Defined TTI Based Downlink Start Resource Block, TTI 5
        iprmLTE_TDD_UDTTI_DL_StartRB_S,       //User Defined TTI Based Downlink Start Resource Block, Special subframe
        iprmLTE_TDD_UDTTI_DL_StartRB_Left,    //User Defined TTI Based Downlink Start Resource Block, All left

        iprmLTE_TDD_UDTTI_DL2_StartRB_0,       //User Defined TTI Based Downlink2 Start Resource Block, TTI 0
        iprmLTE_TDD_UDTTI_DL2_StartRB_5,       //User Defined TTI Based Downlink2 Start Resource Block, TTI 5
        iprmLTE_TDD_UDTTI_DL2_StartRB_S,       //User Defined TTI Based Downlink2 Start Resource Block, Special subframe
        iprmLTE_TDD_UDTTI_DL2_StartRB_Left,    //User Defined TTI Based Downlink2 Start Resource Block, All left

        iprmLTE_TDD_UDTTI_UL_StartRB_A,         //User Defined TTI Based Uplink Start Resource Block, TTI All

        iprmLTE_TDD_UDTTI_DL_TBSI_0,       //User Defined TTI Based Downlink Transport Blk Size Index, TTI 0
        iprmLTE_TDD_UDTTI_DL_TBSI_5,       //User Defined TTI Based Downlink Transport Blk Size Index, TTI 5
        iprmLTE_TDD_UDTTI_DL_TBSI_S,       //User Defined TTI Based Downlink Transport Blk Size Index, Special subframe
        iprmLTE_TDD_UDTTI_DL_TBSI_Left,    //User Defined TTI Based Downlink Transport Blk Size Index, All left

        iprmLTE_TDD_UDTTI_DL2_TBSI_0,       //User Defined TTI Based Downlink2 Transport Blk Size Index, TTI 0
        iprmLTE_TDD_UDTTI_DL2_TBSI_5,       //User Defined TTI Based Downlink2 Transport Blk Size Index, TTI 5
        iprmLTE_TDD_UDTTI_DL2_TBSI_S,       //User Defined TTI Based Downlink2 Transport Blk Size Index, Special subframe
        iprmLTE_TDD_UDTTI_DL2_TBSI_Left,    //User Defined TTI Based Downlink2 Transport Blk Size Index, All left

        iprmLTE_TDD_UDTTI_UL_TBSI_A,      //User Defined TTI Based Uplink Transport Blk Size Index, TTI All

        iprmAMS8900CalCheck1,               // Special purpose post processing features
        iprmAMS8900CalCheck2,
        iprmAMS8900CalCheck3,
        iprmReverbPatternCrossCorrelation,
        iprmECC_Dummy0,                    // Extra placeholders for ECC parms
        iprmECC_Dummy1,
        iprmECC_Dummy2,

        iprmLTE_MIX_Level,
        iprmLTE_T3412_Timer,
        iprmLTE_Network_RANDValue,

        iprmFieldMapCalculateTheory, // For MIMO site validation field mapping calculation
        iprmFieldMapCalculateRelativePercent, // For MIMO site validation field mapping calculation
        iprmFieldMapNormalizationOption, // For MIMO site validation field mapping calculation
        iprmFieldMapExtra1,  // For MIMO site validation field mapping calculation

        iprmSNRFixed_NoiseOrSignal,  //For AWGN tests
        iprmTPvPwrTestMode,          //TP@Pwr or TP@SNR (so far)

        iInpSignalStatus17,
        iInpSignalStatus18,
        iInpSignalStatus19,
        iInpSignalStatus20,
        iInpSignalStatus21,
        iInpSignalStatus22,
        iInpSignalStatus23,
        iInpSignalStatus24,
        iInpSignalStatus25,
        iInpSignalStatus26,
        iInpSignalStatus27,
        iInpSignalStatus28,
        iInpSignalStatus29,
        iInpSignalStatus30,
        iInpSignalStatus31,
        iInpSignalStatus32,
        iOutSignalStatus17,
        iOutSignalStatus18,
        iOutSignalStatus19,
        iOutSignalStatus20,
        iOutSignalStatus21,
        iOutSignalStatus22,
        iOutSignalStatus23,
        iOutSignalStatus24,
        iOutSignalStatus25,
        iOutSignalStatus26,
        iOutSignalStatus27,
        iOutSignalStatus28,
        iOutSignalStatus29,
        iOutSignalStatus30,
        iOutSignalStatus31,
        iOutSignalStatus32,

        iprmLTE_Modulation_DL,     // LTE Modulation DL
        iprmLTE_Modulation_UL,     // LTE Modulation UL
        iprmLTE_NAS_IntegrityAlg,  // LTE NAS Integrity Algorithm
        iprmLTE_NAS_CipherAlg,     // LTE NAS Ciphering Algorithm
        iprmLTE_TBS_UL,            // LTE Transport Block Size UL
        iprmLTE_TBS_DL,            // LTE Transport Block Size DL
        iprmAGPS_ResponseTime,       // Network Response Time
        iprmAGPS_SUPLInitMethod,     // Initial trigger type of SUPL session
        iprmAGPS_SUPLSecureType,     // Secure type of SUPL Session
        iprmAGPS_LBSProtocol,        // LBS positioning protocol
        iprmAGPS_TLSVERHMACHash,     // TLS_VERHMACHash for SUPL session
        iprmAGPS_EnableAssistSpeed, // Reduce accuracy of coarse time assistance
        iprmAGPS_SETIPAddressType,   // LTE SET IP address type
        iprmAGPS_SLPIPAddressType,   // LTE SLP IP address type
        iprmAGPS_TlsVersion,
        iprmAGPS_TlsCipherSuite,
        iprmAGPS_MedianOrAvg,        //for GSM/WCDMA CTIA v3.0 vs v3.2

        iprmLTE_LevelOptBeforeHO,    //Level Optimization before Handover
        iprmLTE_PDNType,             //PDN type
        iprmRobustConnMode,          //Robust Connection Mode
        iprmTDD_ACKNACKFeedBackMode, //TDD ACK/NACK Feedback Mode
        iprmCQIReportingInterval,    //CQI Reporting Interval
        iprmRLCModeForDTCH,          //RLC Mode for DTCH
        iprmIPV4_ClientAddress2,     //IPV4 Client Address 2

        iprmIPV6_Address0_Sub1,      //IPV6 Client Address 0
        iprmIPV6_Address0_Sub2,
        iprmIPV6_Address0_Sub3,
        iprmIPV6_Address0_Sub4,
        iprmIPV6_Address0_Sub5,
        iprmIPV6_Address0_Sub6,
        iprmIPV6_Address0_Sub7,
        iprmIPV6_Address0_Sub8,

        iprmIPV6_Address1_Sub1,      //IPV6 Client Address 1
        iprmIPV6_Address1_Sub2,
        iprmIPV6_Address1_Sub3,
        iprmIPV6_Address1_Sub4,
        iprmIPV6_Address1_Sub5,
        iprmIPV6_Address1_Sub6,
        iprmIPV6_Address1_Sub7,
        iprmIPV6_Address1_Sub8,

        iprmIPV6_Address2_Sub1,      //IPV6 Client Address 2
        iprmIPV6_Address2_Sub2,
        iprmIPV6_Address2_Sub3,
        iprmIPV6_Address2_Sub4,
        iprmIPV6_Address2_Sub5,
        iprmIPV6_Address2_Sub6,
        iprmIPV6_Address2_Sub7,
        iprmIPV6_Address2_Sub8,

        iprmRMCTargetState,
        iprmRMCLoopBackActivation,
        iprmRMCPreRegistration,

        iprmULRBStartLow,
        iprmULRBStartMed,
        iprmULRBStartHi,

        iprmSNRNoiseMode,
        iprmResBlockDir, //0 = uplink, 1 = downlink

        iprmBackupLTE_RMC_DL_NumRB,            //RMC Downlink Number Resource Blocks
        iprmBackupLTE_RMC_UL_NumRB,            //RMC Uplink Number Resource Blocks

        iprmIC_UseFS_TIS_Data,
        iprmCE_Sum_Inputs,

        iprmWIFIScenario,                      //WIFI Scenario
        iprmMACTXTriggerSlope,                 //MAC TX Trigger Slope
        iprmMACTXTriggerPulseLength,           //MAC TX Trigger Pulse Length
        iprmMACRXTriggerSlope,                 //MAC RX Trigger Slope
        iprmMACRXTriggerPulseLength,           //MAC RX Trigger Pulse Length
        iprmCountryCodeFirstChannel,           //Country Code First Channel
        iprmCountryCodeNumOfChannel,           //Country Code Number of Channels
        iprmCountryCodeMaxTXPower,             //Country Code Max Tx Power
        iprmPERAckType,                        //PER ACK TYPE
        iprmPERDataPattern,                    //PER Data Pattern
        iprmPERNumOfPacket,                    //PER Number of Packet
        iprmPERDataInterval,                   //PER Data Interval
        iprmPERPayloadSize,                    //PER Payload Size
        iprmPERLimit,                          //PER Limit
        i2090Speed1Val,
        i2090Speed2Val,
        i2090Speed3Val,
        i2090Speed4Val,
        i2090Speed5Val,
        i2090Speed6Val,
        i2090Speed7Val,
        i2090Speed8Val,
        i2090VSOverrideLow,
        i2090VSOverrideHigh,
        iNMeasurements,                //Number of Measurements (reverb tests)
        iPositioner2Ratio,             //Ratio of positiner1 to positioner2 for speed, etc.
        iPositioner3Ratio,             //Ratio of positiner1 to positioner3 for speed, etc.
        iMismatchSelection,             //Select antanna mismatch index (for reverb chamber)
        iprmLTE_PDN1_IPAddrType,       // PDN 1 IP Address Type
        iprmLTE_PDN2_IPAddrType,       // PDN 2 IP Address Type
        iNumberOfEISPoints,             //Number of EIS points fore reverb fast TIS
        iNumberOfRSSvsPWR,              //Number of RSS "linearization" curves for reverb fast TIS
        iNTurns1,                       //Number of allowed turns on positioner
        iNTurns2,
        iNTurns3,
        iNTurns4,
        iNTurns5,

        iVectorFinalDataFormat,

        iTriggerPorts,                // Trigger A, or Trigger B
        iTriggerPort_Direction,       // Trigger Direction
        iTriggerPort_Source,          // Trigger Source
        iTriggerPort_Slope,           // Trigger Slope

        iPCMeasChannel,               // PC Meas Channel
        iTAvg_tw,                     // T Avg t/w
        iBEPPeriod,                   // BEP Period
        iReverbProbingSamples,        // Reverb Probing Samples
        iReverbAvgProbingNumber,      // Reverb Average Probing Number

        //EMCenter
        iprmEMCenterUnitNumber,       // EMCenter Unit Number
        iprmEMCenterSlotNumber,       // EMCenter Slot Number
        iprmEMCenterDeviceNumber,     // EMCenter Device Number

        iprmLinkCEInputs,

        iprmAGPS_Sens_TBS_DL,          // DL TBS for AGPS Sensitivity test
        iprmAGPS_Sens_TBS_UL,          // UL TBS for AGPS Sensitivity test

        iprmRSS_ZigbeeTriggers,
        iprmTRP_ZigbeeToneOrStream,    // Mode Tone = 0, Stream = 1
        iprmTRP_ZigbeeToneOrStreamMS,  // length of zigbee tone or stream data where 0 = infinity

        iprm_RSSMultiEISCnt,           //number of extra EIS measurements to apply to EIS pattern
        iprm_RSSMultiEISOpt,           //correction page option to not apply multiple EIS offsets
        iNSA_LeftWallFileIdx,          //Left wall absorber (0,1,2,3,4,5,6�0 means perfect reflector).
        iNSA_RightWallFileIdx,         // Right wall absorber
        iNSA_FrontWallFileIdx,         // Front wall absorber
        iNSA_BackWallFileIdx,          // Back wall absorber
        iNSA_FloorFileIdx,             // Floor absorber
        iNSA_CeilingFileIdx,           // Ceiling absorber
        iPos_ContRotationOpt,          // Allows for CR vs NCR support in positioners in config
        iNSA_MaxReflections,           // Multi-path Limit
        iNSA_NModelSteps,           //�� Number of test points over antenna height range
        iUseMinFramesTillThreshhold,   // Use minimum frames in TP vs Pwr test until threshhold is reached
        iUseIteratorCounter,
        iAllowCE_IO_All_Ports,

        iprmUPDUseSeverListener,
        iprmUPDListenerPort,

        iprmUseSACCHRxQLevel,
        BSS_iInquiryDuration,

        iprmReverbCalculateCalAverage,
        iprmReverbUseExternalMismatch,

        iSwapFreqIteratorPos,
        iprmLinkCEOutputs,
        BSS_iBeaconIntervalAlternate,   // Wi-Fi beacon interval in ms, implemented for sensitivity search

        iCEInputPortCount,
        iCEOutputPortCount,

        BSS_iTDSC_PowerTargetForce,     // 4400 UE power control
        BSS_iTDSC_RMC_ULCode,
        iCMW500_WLAN_CSD_TX1,
        iCMW500_WLAN_CSD_TX2,
        iprmCMW500_TXConverter2,
        iCEMapAngularInputPorts,
        iCMW500MeasurementTriggerSource,
        iCMW500MeasurementTriggerSlope,
        iCMW500MeasurementTriggerTimeout,
        //  Someone's forgetting the iprmXxxx naming convention again
        iprmClusterPASShape,              // storage for channel model PAS selection
        iprmChannelEmulatorFilterShape,   // shape of bandwidth filter for simulated CE
        iprmChannelModelParm1,            // a couple of dummies for expansion
        iprmChannelModelParm2,            // (except these will be forgotten and never used like all the other "expansion" parameters)
        iVR5_RLCM,                        // radio link compensation mode for VR5, no "iprm" because parameter is targeted to VR5 only
        iPositionerStepCount1,             // how many steps to take from 0 to 3360
        iPositionerStepCount2,             // how many steps to take from 0 to 3360
        iPreferTestFrequency,           //  Add all new parameters iprmXxxx naming convention
        iCTONEnabled_1,                 //  Add all new parameters iprmXxxx naming convention
        iCTONEnabled_2,                 //  Add all new parameters iprmXxxx naming convention
        iCTONEnabled_3,                 //  Add all new parameters iprmXxxx naming convention
        iCTONEnabled_4,                 //  Add all new parameters iprmXxxx naming convention
        iCTONEnabled_5,                //  Add all new parameters iprmXxxx naming convention
        iCTONEnabled_6,                 //  Add all new parameters iprmXxxx naming convention
        iCTONEnabled_7,                 //  Add all new parameters iprmXxxx naming convention
        iCTONEnabled_8,                 //  Add all new parameters iprmXxxx naming convention
        iCE_BS_InputPhaseCal,           //  Add all new parameters iprmXxxx naming convention
        iprmPhaseIterator,
        iprmPhasePortNum,
        iprmReverbIndependSamples,
        //  Add all new parameters iprmXxxx naming convention
        iRFValSNR_Test,                 //  Add all new parameters iprmXxxx naming convention
        iRFValSNR_Signal,               //  Add all new parameters iprmXxxx naming convention
        iRFValSNR_SignalAndNoise,       //  Add all new parameters iprmXxxx naming convention
        iRFValSNR_Noise,                //  Add all new parameters iprmXxxx naming convention

        iprmBackUpOnThreshold,     // avoid backing up when passing the fine resolution threshold
        iprmUseICF_Filter,
        BSS_iHSPA_HARQRedundancy,       //  H-ARQ Redundancy Versions
        BSS_iHSPA_ETFCI_MSET_OnOFf,      // Minimum Set E-TFCI
        BSS_iHSPA_ISGV,                  // Initial Serving Grant Value

        // E-AGCH
        BSS_iHSPA_EAGCH_AGIndexLev01,    // AG OnOff
        BSS_iHSPA_EAGCH_AGIndexOnOff01,  // AG Index
        BSS_iHSPA_EAGCH_AGScopeOnOff01,  // AG Scope
        BSS_iHSPA_EAGCH_IDTypeOnOff01,   // ID Type
        BSS_iHSPA_EAGCH_AGIndexLev02,
        BSS_iHSPA_EAGCH_AGIndexOnOff02,
        BSS_iHSPA_EAGCH_AGScopeOnOff02,
        BSS_iHSPA_EAGCH_IDTypeOnOff02,
        BSS_iHSPA_EAGCH_AGIndexLev03,
        BSS_iHSPA_EAGCH_AGIndexOnOff03,
        BSS_iHSPA_EAGCH_AGScopeOnOff03,
        BSS_iHSPA_EAGCH_IDTypeOnOff03,
        BSS_iHSPA_EAGCH_AGIndexLev04,
        BSS_iHSPA_EAGCH_AGIndexOnOff04,
        BSS_iHSPA_EAGCH_AGScopeOnOff04,
        BSS_iHSPA_EAGCH_IDTypeOnOff04,
        BSS_iHSPA_EAGCH_AGIndexLev05,
        BSS_iHSPA_EAGCH_AGIndexOnOff05,
        BSS_iHSPA_EAGCH_AGScopeOnOff05,
        BSS_iHSPA_EAGCH_IDTypeOnOff05,
        BSS_iHSPA_EAGCH_AGIndexLev06,
        BSS_iHSPA_EAGCH_AGIndexOnOff06,
        BSS_iHSPA_EAGCH_AGScopeOnOff06,
        BSS_iHSPA_EAGCH_IDTypeOnOff06,
        BSS_iHSPA_EAGCH_AGIndexLev07,
        BSS_iHSPA_EAGCH_AGIndexOnOff07,
        BSS_iHSPA_EAGCH_AGScopeOnOff07,
        BSS_iHSPA_EAGCH_IDTypeOnOff07,
        BSS_iHSPA_EAGCH_AGIndexLev08,
        BSS_iHSPA_EAGCH_AGIndexOnOff08,
        BSS_iHSPA_EAGCH_AGScopeOnOff08,
        BSS_iHSPA_EAGCH_IDTypeOnOff08,

        BSS_iHSPA_EAGCH_1STUEID,   // E-AGCH Primary UE-ID
        BSS_iHSPA_EAGCH_2NDUEID,   // E-AGCH Secondary UE-ID
        BSS_iHSPA_EAGCH_UNSCHDLTTI,   // Unscheduled TTI

        BSS_iHSPA_PH_EAGCHOnOff,   // Physical Channels E-AGCH OnOff
        BSS_iHSPA_PH_EAGCH,   // Physical Channels E-AGCH
        BSS_iHSPA_PH_EHICHOnOff,   // Physical Channels E-HICH OnOff
        BSS_iHSPA_PH_EHICH,   // Physical Channels E-HICH
        BSS_iHSPA_PH_ERGCHOnOff,   // Physical Channels E-RGCH OnOff
        BSS_iHSPA_PH_ERGCH,   // Physical Channels E-RGCH

        iBSS_HSPA_EHICH_FFWDOnOff,  // Fill-Up Frame With Dummies
        iBSS_HSPA_EHICH_HARQ_FBMode, // HARQ Feedback Mode
        iBSS_HSPA_EHICH_RGMode,      // Relative Grant Mode

        iprmSupportedRateUserDefined, //Packet Generator Data Control for CMW500 WLAN
        iprmSupportedRate_DSSS_1,
        iprmSupportedRate_DSSS_2,
        iprmSupportedRate_CCK_55,
        iprmSupportedRate_CCK_11,
        iprmSupportedRate_BPSK_6,
        iprmSupportedRate_BPSK_9,
        iprmSupportedRate_QPSK_12,
        iprmSupportedRate_QPSK_18,
        iprmSupportedRate_16_QAM_24,
        iprmSupportedRate_16_QAM_36,
        iprmSupportedRate_64_QAM_48,
        iprmSupportedRate_64_QAM_54,
        iprmSupportedRate_MCS_0,
        iprmSupportedRate_MCS_1,
        iprmSupportedRate_MCS_2,
        iprmSupportedRate_MCS_3,
        iprmSupportedRate_MCS_4,
        iprmSupportedRate_MCS_5,
        iprmSupportedRate_MCS_6,
        iprmSupportedRate_MCS_7,
        iprmSupportedRate_MCS_8,
        iprmSupportedRate_MCS_9,
        iprmSupportedRate_MCS_10,
        iprmSupportedRate_MCS_11,
        iprmSupportedRate_MCS_12,
        iprmSupportedRate_MCS_13,
        iprmSupportedRate_MCS_14,
        iprmSupportedRate_MCS_15,

        iprmDataFrameRateUserDefined,
        iprmDataFrameRate,
        iprmManagementFrameRateUserDefined,
        iprmManagementFrameRate,

        iprmDesenseTurnOffInterferenceSignal,   //Desense Test Turning off the signal
        iprmPingSimpleSetting,

        iBSS_HSPA_EHICH_HARQ_FBSig, // HARQ Feedback Mode
        iBSS_HSPA_EHICH_RGSig,      // Relative Grant Mode
        iBSS_HSPA_AGPattern_Rep,
        iBSS_HSPA_ERGCH_Length,
        iBSS_HSPA_AGPattern_Len,
        iBSS_HSPA_ISGV_Type,                  // Initial Serving Grant Value
        iBSS_HSPA_ISGV_OnOff,                  // Initial Serving Grant Value
        iBSS_HSPA_Modulation,
        iBSS_HSPA_EAGCH_TblIdx,
        iTPT_SensitivitySearch,
        iTPT_InterpolateToTarget,

        BSS_iHSPA_Proceedure,
        BSS_iHSPA_Direction,
        BSS_iHSPA_Data,
        BSS_iHSPA_Channels,

        iprmReverb_Rayleigh,    //For Reverb Rayleigh Validation


        iGPIBBoard2,           //For Carrier Aggregation
        iGPIBBoard3,
        iGPIBBoard4,
        iGPIBBoard5,
        iGPIBBoard6,

        iGPIBAddress3,
        iGPIBAddress4,
        iGPIBAddress5,
        iGPIBAddress6,

        iprmLTE_Basetion_CA_Mode,
        iprmLTE_Basetion_CA_SCC_Number,
        iprmLTE_Basetion_CA_SensMeasMode,

        iLTEChannelBandwidth_PCC,
        BSS_iDTCRFChannel_PCC,
        iprmLTE_RMC_UL_NumRB_PCC,
        iprmLTE_UDCH_UL_StartRB_PCC,
        iprmLTE_UL_MCS_Index_PCC,


        iprmLTE_CA_Activation_SCC1,
        BSS_iOptionSelect_SCC1,
        iLTEChannelBandwidth_SCC1,
        BSS_iDTCRFChannel_SCC1,
        iprmLTE_RMC_DL_NumRB_SCC1,
        iprmLTE_UDCH_DL_StartRB_SCC1,
        iprmLTE_DL_MCS_Index_0_SCC1,
        iprmLTE_DL_MCS_Index_5_SCC1,
        iprmLTE_DL_MCS_Index_1469_SCC1,
        iprmLTE_TDD_UDTTI_DL_TBSI_Left_SCC1,
        iprmLTE_CFI_SCC1,
        iprmLTE_SCell_Cycle_SCC1,

        iprmLTE_CA_Activation_SCC2,
        BSS_iOptionSelect_SCC2,
        iLTEChannelBandwidth_SCC2,
        BSS_iDTCRFChannel_SCC2,
        iprmLTE_RMC_DL_NumRB_SCC2,
        iprmLTE_UDCH_DL_StartRB_SCC2,
        iprmLTE_DL_MCS_Index_0_SCC2,
        iprmLTE_DL_MCS_Index_5_SCC2,
        iprmLTE_DL_MCS_Index_1469_SCC2,
        iprmLTE_TDD_UDTTI_DL_TBSI_Left_SCC2,
        iprmLTE_CFI_SCC2,
        iprmLTE_SCell_Cycle_SCC2,

        BSS_iRFOutputPort_SCC1,
        iprmLTE_ExternalLoss_SCC1,
        iprmLTE_P2_ExternalLoss_SCC1,
        iprmLTE_RMC_UL_NumRB_SCC1,
        iprmLTE_UDCH_UL_StartRB_SCC1,
        iprmLTE_UL_MCS_Index_SCC1,


        BSS_iRFOutputPort_SCC2,
        iprmLTE_ExternalLoss_SCC2,
        iprmLTE_P2_ExternalLoss_SCC2,
        iprmLTE_RMC_UL_NumRB_SCC2,
        iprmLTE_UDCH_UL_StartRB_SCC2,
        iprmLTE_UL_MCS_Index_SCC2,

        iprmMT8820C_RefFreq,
        iprmMT8820C_RefFreq2,
        iprmMT8820C_RefFreq3,
        iprmMT8820C_RefFreq4,
        iprmMT8820C_RefFreq5,
        iprmMT8820C_RefFreq6,
        iMinimumPolling,
        iprmMT8820C_SCC_DCI_1A_Len,
        iprmOCNG_Idle,
        iprmOCNG_Connected,
        iCEInput_MeasureNetPathloss,
        iCEInput_NetPathlossRefPort,

        //  Add all new parameters iprmXxxx naming convention
        //  Add all new parameters iprmXxxx naming convention
        //  Add all new parameters iprmXxxx naming convention

        // For MS2830A Demodulator
        iprmDeModulator_SlotLength,
        iprmDeModulator_MeasureInterval,
        iprmDeModulator_SyncWordSearch,
        iprmDeModulator_BurstSearch,
        iprmDeModulator_Enable2ndWord,
        iprmDeModulator_SearchSlot1,
        iprmDeModulator_SyncWordLen1,
        iprmDeModulator_SyncWordOffset1,
        iprmDeModulator_SearchSlot2,
        iprmDeModulator_SyncWordLen2,
        iprmDeModulator_SyncWordOffset2,
        iprmDeModulator_SpanUp,
        iprmDeModulator_MeasureFilter1,
        iprmDeModulator_MeasureFilter2,
        iprmDeModulator_RefFilter1,
        iprmDeModulator_RefFilter2,
        iprmDeModulator_ModulationFrameFormat, // 0:Frame Formatted, 1:Non-Formated
        BSS_iPhysicalCellID,
        iprmSecurityOption01,
        iprmSecurityOption02,
        iprmSecurityOption03,
        iprmSecurityOption04,
        iprmSecurityOption05,
        iprmSecurityOption06,
        iprmSecurityOption07,
        iprmSecurityOption08,
        iprmSecurityOption09,
        iprmSecurityOption10,
        iSampleCount2,
        //LTE RRC State Transition
        iprmRRCStateTrans,
        iprmLTE_TransmissionMode,
        iprmLTE_Use64QAM_UL,
        iprmLTE_DLAntConfig,

        //Reverb Processing Tool
        iprmReverbProcessingUseFreqWindow,
        iprmReverbProcessingGenUncertainty,
        iprmReverbProcessingGenAnisotropyInfo,
        iprmLTE_PRACHHighSpeedFlag,
        iprmLTE_PDSCH_PA,
        iprmLTE_PSS_PA,
        iprmLTE_SSS_PA,
        iprmLTE_OtherChan_PA,
        iprmLTE_PDSCH_PB,
        iprmLTE_OtherChan_PB,
        iprmLTE_PMaxEnable,
        iprmLTE_PMax,
        iprmLTE_SpecEmmision,
        iprmLTE_AccumEnabled,
        iprmLTE_DCIMsgType,
        iprmLTE_PwrAdjAccum,
        iprmLTE_PwrAdjDCI,
        iprmLTE_PwrAdjAbs,
        iprmLTE_PUSCHState,
        iprmLTE_DCIFormat,
        iprmCE_MinPortPowerEnabled,
        iprmReverbChiSquareDoF,
        iprmEMQuestBSAutoInputLevel,
        iprmEMQuestBSAutoInputMode,
        iprmOptSkipICD,
        iprmRSS_LinSteppingOptions,
        // Parameters for TD-SCDMA (Data)
        BSS_iDLCLPowerCtrl,
        BSS_iDPCHRecordCount,
        BSS_iQltyDTCHState,
        BSS_iPrevisionControl,
        BSS_iTDSCDMA_HSDPA_RMC,
        iTDSCDMA_RBT_RMCPDUSize,
        iHSPA_PSD_MidambleMod,
        iHSPA_PSD_PDSCHOVSF,
        iHSPA_PSD_PDSCHTmSlots,
        iHSPA_PSD_TmSlotStart,
        iHSPA_PSD_PDSCHCode,
        iHSPA_PSD_DLDPCHTmSlot,
        iprmDirection1,    // Positioner starting direction
        iprmDirection2,
        iprmDirection3,
        iprmDirection4,
        iprmScanReverse1,  // Reverse the scan direction
        iprmScanReverse2,
        iprmScanReverse3,
        iprmScanReverse4,
        // HSUPA
        iHSUPA_RBT_EDCH_RETRAMISNTMR, //E-DCH Retransmission Timer
        iHSUPA_PSD_CHConfig, //PS Data Channel Configuration
        iHSUPA_PSD_PUCHOVSF, //PS Data E-PUCH OVSF
        iHSUPA_PSD_PDSCHOVSF, //PS Data HS PDSCH OVSF (HSUPA)
        iHSUPA_PSD_PDSCHCode, //PS Data HS-PDSCH Channel Code (HSUPA)
        iprm_IteratorSwap,

        //CMW500 Carrier Aggregation
        iprmReverbAlternativePowerStepping,
        iprmCopyPCC_CMW_SCC1,
        iprmCopyPCC_CMW_SCC2,
        iprmLTE_Basetion_CA_Mode_CMW_SCC1,
        iprmLTE_Basetion_CA_Mode_CMW_SCC2,
        BSS_iOptionSelect_CMW_SCC1,
        BSS_iOptionSelect_CMW_SCC2,
        BSS_iDTCRFChannel_CMW_SCC1,
        BSS_iDTCRFChannel_CMW_SCC2,
        iBandWidth_CMW_SCC1,
        iBandWidth_CMW_SCC2,
        BSS_iCellID_CMW_SCC1,
        BSS_iCellID_CMW_SCC2,
        iprmLTE_UETermConnType_CMW_SCC1,
        iprmLTE_UETermConnType_CMW_SCC2,
        BSS_iRFInputPort_CMW_SCC1,
        BSS_iRFInputPort_CMW_SCC2,
        BSS_iRFOutputPort_CMW_SCC1,
        BSS_iRFOutputPort_CMW_SCC2,
        iprmLTE_RFOutputPort2_CMW_SCC1,
        iprmLTE_RFOutputPort2_CMW_SCC2,
        iprmLTE_RMC_DL_NumRB_CMW_SCC1,
        iprmLTE_RMC_DL_NumRB_CMW_SCC2,
        iprmLTE_RMC_DL_RBPos_CMW_SCC1,
        iprmLTE_RMC_DL_RBPos_CMW_SCC2,
        iprmLTE_UDCH_DL_NumRB_CMW_SCC1,
        iprmLTE_UDCH_DL_NumRB_CMW_SCC2,
        iprmLTE_UDCH_DL_StartRB_CMW_SCC1,
        iprmLTE_UDCH_DL_StartRB_CMW_SCC2,
        iprmLTE_UDCH_DL_TrnBlkSzIdx_CMW_SCC1,
        iprmLTE_UDCH_DL_TrnBlkSzIdx_CMW_SCC2,
        iprmLTE_RMC_DL2_NumRB_CMW_SCC1,
        iprmLTE_RMC_DL2_NumRB_CMW_SCC2,
        iprmLTE_RMC_DL2_RBPos_CMW_SCC1,
        iprmLTE_RMC_DL2_RBPos_CMW_SCC2,
        iprmLTE_UDCH_DL2_NumRB_CMW_SCC1,
        iprmLTE_UDCH_DL2_NumRB_CMW_SCC2,
        iprmLTE_UDCH_DL2_StartRB_CMW_SCC1,
        iprmLTE_UDCH_DL2_StartRB_CMW_SCC2,
        iprmLTE_UDCH_DL2_TrnBlkSzIdx_CMW_SCC1,
        iprmLTE_UDCH_DL2_TrnBlkSzIdx_CMW_SCC2,
        iprmLTE_UDTTI_DL2_NumRB_0_CMW_SCC1,
        iprmLTE_UDTTI_DL2_NumRB_0_CMW_SCC2,
        iprmLTE_UDTTI_DL2_NumRB_5_CMW_SCC1,
        iprmLTE_UDTTI_DL2_NumRB_5_CMW_SCC2,
        iprmLTE_UDTTI_DL2_NumRB_1469_CMW_SCC1,
        iprmLTE_UDTTI_DL2_NumRB_1469_CMW_SCC2,
        iprmLTE_UDTTI_DL2_StartRB_0_CMW_SCC1,
        iprmLTE_UDTTI_DL2_StartRB_0_CMW_SCC2,
        iprmLTE_UDTTI_DL2_StartRB_5_CMW_SCC1,
        iprmLTE_UDTTI_DL2_StartRB_5_CMW_SCC2,
        iprmLTE_UDTTI_DL2_StartRB_1469_CMW_SCC1,
        iprmLTE_UDTTI_DL2_StartRB_1469_CMW_SCC2,
        iprmLTE_UDTTI_DL2_TBSI_0_CMW_SCC1,
        iprmLTE_UDTTI_DL2_TBSI_0_CMW_SCC2,
        iprmLTE_UDTTI_DL2_TBSI_5_CMW_SCC1,
        iprmLTE_UDTTI_DL2_TBSI_5_CMW_SCC2,
        iprmLTE_UDTTI_DL2_TBSI_1469_CMW_SCC1,
        iprmLTE_UDTTI_DL2_TBSI_1469_CMW_SCC2,
        iprmLTE_UDTTI_DL_NumRB_0_CMW_SCC1,
        iprmLTE_UDTTI_DL_NumRB_0_CMW_SCC2,
        iprmLTE_UDTTI_DL_NumRB_5_CMW_SCC1,
        iprmLTE_UDTTI_DL_NumRB_5_CMW_SCC2,
        iprmLTE_UDTTI_DL_NumRB_1469_CMW_SCC1,
        iprmLTE_UDTTI_DL_NumRB_1469_CMW_SCC2,
        iprmLTE_UDTTI_DL_StartRB_0_CMW_SCC1,
        iprmLTE_UDTTI_DL_StartRB_0_CMW_SCC2,
        iprmLTE_UDTTI_DL_StartRB_5_CMW_SCC1,
        iprmLTE_UDTTI_DL_StartRB_5_CMW_SCC2,
        iprmLTE_UDTTI_DL_StartRB_1469_CMW_SCC1,
        iprmLTE_UDTTI_DL_StartRB_1469_CMW_SCC2,
        iprmLTE_UDTTI_DL_TBSI_0_CMW_SCC1,
        iprmLTE_UDTTI_DL_TBSI_0_CMW_SCC2,
        iprmLTE_UDTTI_DL_TBSI_5_CMW_SCC1,
        iprmLTE_UDTTI_DL_TBSI_5_CMW_SCC2,
        iprmLTE_UDTTI_DL_TBSI_1469_CMW_SCC1,
        iprmLTE_UDTTI_DL_TBSI_1469_CMW_SCC2,
        iprmLTE_PRACH_CfgIndex_CMW_SCC1,
        iprmLTE_PRACH_CfgIndex_CMW_SCC2,
        iprmLTE_TransmissionScheme_CMW_SCC1,
        iprmLTE_TransmissionScheme_CMW_SCC2,
        iprmLTE_PDSCH_OffsetPA_CMW_SCC1,
        iprmLTE_PDSCH_OffsetPA_CMW_SCC2,
        iprmLTE_PDSCH_RatioIdxPB_CMW_SCC1,
        iprmLTE_PDSCH_RatioIdxPB_CMW_SCC2,
        iprmLTE_StaticChModel_h11phi_CMW_SCC1,
        iprmLTE_StaticChModel_h11phi_CMW_SCC2,
        iprmLTE_StaticChModel_h12phi_CMW_SCC1,
        iprmLTE_StaticChModel_h12phi_CMW_SCC2,
        iprmLTE_StaticChModel_h21phi_CMW_SCC1,
        iprmLTE_StaticChModel_h21phi_CMW_SCC2,
        iprmLTE_StaticChModel_h22phi_CMW_SCC1,
        iprmLTE_StaticChModel_h22phi_CMW_SCC2,
        iprmLTE_TDD_UDTTI_DL_NumRB_0_CMW_SCC1,
        iprmLTE_TDD_UDTTI_DL_NumRB_0_CMW_SCC2,
        iprmLTE_TDD_UDTTI_DL_StartRB_0_CMW_SCC1,
        iprmLTE_TDD_UDTTI_DL_StartRB_0_CMW_SCC2,
        iprmLTE_TDD_UDTTI_DL_TBSI_0_CMW_SCC1,
        iprmLTE_TDD_UDTTI_DL_TBSI_0_CMW_SCC2,
        iprmLTE_TDD_UDTTI_DL_NumRB_5_CMW_SCC1,
        iprmLTE_TDD_UDTTI_DL_NumRB_5_CMW_SCC2,
        iprmLTE_TDD_UDTTI_DL_StartRB_5_CMW_SCC1,
        iprmLTE_TDD_UDTTI_DL_StartRB_5_CMW_SCC2,
        iprmLTE_TDD_UDTTI_DL_TBSI_5_CMW_SCC1,
        iprmLTE_TDD_UDTTI_DL_TBSI_5_CMW_SCC2,
        iprmLTE_TDD_UDTTI_DL_NumRB_S_CMW_SCC1,
        iprmLTE_TDD_UDTTI_DL_NumRB_S_CMW_SCC2,
        iprmLTE_TDD_UDTTI_DL_StartRB_S_CMW_SCC1,
        iprmLTE_TDD_UDTTI_DL_StartRB_S_CMW_SCC2,
        iprmLTE_TDD_UDTTI_DL_TBSI_S_CMW_SCC1,
        iprmLTE_TDD_UDTTI_DL_TBSI_S_CMW_SCC2,
        iprmLTE_TDD_UDTTI_DL_NumRB_Left_CMW_SCC1,
        iprmLTE_TDD_UDTTI_DL_NumRB_Left_CMW_SCC2,
        iprmLTE_TDD_UDTTI_DL_StartRB_Left_CMW_SCC1,
        iprmLTE_TDD_UDTTI_DL_StartRB_Left_CMW_SCC2,
        iprmLTE_TDD_UDTTI_DL_TBSI_Left_CMW_SCC1,
        iprmLTE_TDD_UDTTI_DL_TBSI_Left_CMW_SCC2,
        iprmLTE_TDD_UDTTI_DL2_NumRB_0_CMW_SCC1,
        iprmLTE_TDD_UDTTI_DL2_NumRB_0_CMW_SCC2,
        iprmLTE_TDD_UDTTI_DL2_StartRB_0_CMW_SCC1,
        iprmLTE_TDD_UDTTI_DL2_StartRB_0_CMW_SCC2,
        iprmLTE_TDD_UDTTI_DL2_TBSI_0_CMW_SCC1,
        iprmLTE_TDD_UDTTI_DL2_TBSI_0_CMW_SCC2,
        iprmLTE_TDD_UDTTI_DL2_NumRB_5_CMW_SCC1,
        iprmLTE_TDD_UDTTI_DL2_NumRB_5_CMW_SCC2,
        iprmLTE_TDD_UDTTI_DL2_StartRB_5_CMW_SCC1,
        iprmLTE_TDD_UDTTI_DL2_StartRB_5_CMW_SCC2,
        iprmLTE_TDD_UDTTI_DL2_TBSI_5_CMW_SCC1,
        iprmLTE_TDD_UDTTI_DL2_TBSI_5_CMW_SCC2,
        iprmLTE_TDD_UDTTI_DL2_NumRB_S_CMW_SCC1,
        iprmLTE_TDD_UDTTI_DL2_NumRB_S_CMW_SCC2,
        iprmLTE_TDD_UDTTI_DL2_StartRB_S_CMW_SCC1,
        iprmLTE_TDD_UDTTI_DL2_StartRB_S_CMW_SCC2,
        iprmLTE_TDD_UDTTI_DL2_TBSI_S_CMW_SCC1,
        iprmLTE_TDD_UDTTI_DL2_TBSI_S_CMW_SCC2,
        iprmLTE_TDD_UDTTI_DL2_NumRB_Left_CMW_SCC1,
        iprmLTE_TDD_UDTTI_DL2_NumRB_Left_CMW_SCC2,
        iprmLTE_TDD_UDTTI_DL2_StartRB_Left_CMW_SCC1,
        iprmLTE_TDD_UDTTI_DL2_StartRB_Left_CMW_SCC2,
        iprmLTE_TDD_UDTTI_DL2_TBSI_Left_CMW_SCC1,
        iprmLTE_TDD_UDTTI_DL2_TBSI_Left_CMW_SCC2,
        iprmAGPSLocationPlane,            //AGPS Control or User Plane
        iprmBackupLTE_RMC_DL_NumRB_CMW_SCC1,
        iprmBackupLTE_RMC_DL_NumRB_CMW_SCC2,
        iprmCA_Basestation_Status_SCC,
        iSpecialMicrosoftSplitRingProcessingOn,
        iprmMeasureOnSameLevelForWholeReverbSequene,
        iSigGen_AWF_State,
        iSigGen_AWF_SLEN,
        iSigGen_AWF_TriggerMode,
        iprmReverbCalRefAntennaPort,
        iprmReverbCalMethod,
        iSigGen_AWF_TriggerSignalUnit,
        iprmEquipSelection,
        iprmTPValOpt_ContinuousH,
        iprmTPValOpt_ContinuousV,
        iprmMeasureStartDelay,
        iprmMeasureDuration,
        iprmSensitivityCurveFromKnee,
        iprmGNSSOption,
        iprmULTestPort,
        iprmDLTestPort,

        iprmCMW500_TXConverter_SCC1,     // CMW500 TX Converter
        iprmCMW500_TXConverter_SCC1_2,   // CMW500 TX Converter
        iprmCMW500_TXConverter_SCC2,     // CMW500 TX Converter
        iprmCMW500_TXConverter_SCC2_2,   // CMW500 TX Converter
        iprmCMW500_Automatic_Converter,  // CMW500 TX Converter automatica setting
        iprmCMW500_RXConverter_SCC1,     // CMW500 RX Converter
        iprmCMW500_RXConverter_SCC2,     // CMW500 RX Converter

        iprmTestSA_MultiThroughputAxis,
        iprmCAMultiThroughputEnable,
        BSS_iAdvancedAutoEstablish,
        BSS_iAdvAutoLastPoint,
        BSS_iAdvAutoSkip,
        BSS_iAdvAutoUserPos,
        BSS_iAutoLastPtThreshold,
        BSS_iAutoSkipThreshold,
        BSS_iAutoUserPosThreshold,
        BSS_iDefaultFloorLevFlag,
        iRSS_EIS_Compensation,
        iRSS_BestFitOption,
        BSS_iAdvToggleSig,
        BSS_iToggleSigThreshold,
        iprmLTE_FrameType_SCC1,
        iprmLTE_FrameType_SCC2,
        iprmLTE_TXXOutputPort_SCC1,
        iprmLTE_TXXOutputPort_SCC2,
        iprm_OptCorOptMedianPower,
        iprm_OptAvgInverseVoltage,
        iprmSimulatedReverbRandomSeed, // random number seed for repeated reverb model behaviors
        iprmSimulatedReverbDataOutputMode, // list of possible output combinations...
        iprmSimulatedParameter1,     // extra parameter or two for use in simulated field generator
        iprmSimulatedParameter2,     // extra parameter or two for use in simulated field generator
        iprmLTE_SIB8Enabled,
        iprmLTE_SIB16Enabled,
        iprmAGNSSSatellitePowers,
        iNeedToClose,               //For new goniometer (new pattern, iterator based, measurement)
        iprmCheckGainStability,     // parameters for compression test
        iprmAutoCalibrateCables,
        iprmForceAutoCalibration,
        iprmAGNSSSingleStep,
        iprmAGNSSPatternOpt,
        iprmAGNSSLinCurveOpt,
        iprmReberbStirringCyclesMinNum,
        iprmBoundsContained,                    //For new pattern measurement coordination transformations
        iprmTP_AvgPwr,               //post-processing
        iprmTP_AvgDb,                   //post-processing
        iprmTP_InvAvgPwr,
        iprmTP_CalcAvgTP,
        iprmAGNSSEIS1Opt,
        iprmAGNSSEIS2Opt,
        iprmAGNSSICD1Opt,
        iprmAGNSSICD2Opt,
        iprmAGNSSSingleStepOpt,
        iprm_CombineTPvsPwrOptions,
        iprm_TruncateThruputToTarget,
        iprmTriggerPorts_2nd,
        iprmTriggerPort_Direction_2nd,
        iprmTriggerPort_Source_2nd,
        iprmTriggerPort_Slope_2nd,
        iprmAGPS_TLSCertificate,
        iprm_UseOffsetForEPRE,
        iprm_CA_TurnOff2ndRFAfterConnLost,
        iprmLTE_VoLTE911,
        iprmCE_CalcRealtimeAIP,
        iprm_OverrideSNRStart,
        iprm_BT_DirtyTX,
        iprm_MBT_Axis,
        iprm_iMeasurementType,
        iprmSigGen_GNSS_State,
        iprmSigGen_GNSS_Scenario,
        iprmMultiCMW,
        iprmMultiCMW_SCC1,
        iprmMultiCMW_SCC2,
        iprmMultiCMW_SCC3,
        iprmMultiCMW_SCC4,

        iprm_RAWX2_DB_Insert, // Enables inserting data via the EMQuest Executive
        iprmWLAN_AdjustIntialPower,
        iprmGNSSStartFixModePattern,
        iprmGNSSStartFixModeSensitivity,

        iprmInpSignalStatus33,
        iprmInpSignalStatus34,
        iprmInpSignalStatus35,
        iprmInpSignalStatus36,
        iprmOutSignalStatus33,
        iprmOutSignalStatus34,
        iprmOutSignalStatus35,
        iprmOutSignalStatus36,
        iprm_PacketCount,
        iprm_BaseStationPort,
        iprm_AnalyzerPort,
        iprm_DataRate,
        iprmGNSSNumSatellites,
        iprmInitPowerControlOption,
        iprmInitPowerSearchStep,
        iprmInitPowerSearchArea,
        iprmApplicationManagerSelection,
        iprmTxAmp_N_CE_Noise,
        iprmTXAmp_Noise,
        iprmRxInstr_Noise,
        iprmRandomTriggerOpt,
        iprmRandomTriggerMod,

        iprmEPSNetowrk,
        iprmIMSVoiceOverIP,
        iprmIPVersion,
        iprmIMSAuthentication,
        iprmIMSKeyGenAlg,
        iprmIMSIPSec,
        iprmIMSIPSecIntegrityAlg,
        iprmIMSIPSecEncryptAlg,
        iprmIMSSignalType,
        iprmIMSDedicatedBearer,
        iprmIMSAudioCodec,
        iprmIMS_AMR_Alignment_Mode,
        iprmIMSAudioCodecRate0,
        iprmIMSAudioCodecRate1,
        iprmIMSAudioCodecRate2,
        iprmIMSAudioCodecRate3,
        iprmIMSAudioCodecRate4,
        iprmIMSAudioCodecRate5,
        iprmIMSAudioCodecRate6,
        iprmIMSAudioCodecRate7,
        iprmIMSAudioCodecRate8,
        iprmIMS_EVS_ULDLSync,
        iprmIMS_EVS_Bandwidth,
        iprmIMS_EVS_BitRate1,
        iprmIMS_EVS_BitRate2,
        iprmIMS_EVS_StartMode,
        iprmReverbTIS_Correction,
        iprmReverbUtilitySISO_MIMO,
        iprmReverbUtilityProximity_Correlation,
        iprmReverbUtilityT_Cal,
        iprmOptDisableExercise,
        iprmOptDisableAncillaryGUI,

        iprmLTE_RFOutputPort2_3,
        iprmCMW500_TXConverter2_3,
        iprmLTE_UseExtAttenOut1_3,
        iprmLTE_RFOutputPort2_4,
        iprmCMW500_TXConverter2_4,
        iprmLTE_UseExtAttenOut1_4,
        iprmLTE_UseDLStream1SettingsUDTTI_3,
        iprmLTE_UseDLStream1SettingsUDTTI_4,
        iprmLTE_TDD_UseDLStream1SettingsUDTTI_3,
        iprmLTE_TDD_UseDLStream1SettingsUDTTI_4,
        iprmLTE_TM_DCI_Combination,
        iprmLTE_TM_DCI_Combination_SCC1,
        iprmLTE_TM_DCI_Combination_SCC2,
        iprmLTE_PowerControlDCI_SCC1,
        iprmLTE_PowerControlDCI_SCC2,
        iprmLTE_Antenna_Config_SCC1,
        iprmLTE_Antenna_Config_SCC2,
        iprmLTE_PMI,
        iprmLTE_PMI_SCC1,
        iprmLTE_PMI_SCC2,
        iprmRFPowValUseTriggerOffset,
        iprmRFPowValTriggerCounts,
        iprmNewSensAlog,
        iprmPowerCycleTime,
        iprmTDLTE_ULDLConfig_SCC1,    // TD-LTE UL DL Configuration
        iprmTDLTE_SpecialFrame_SCC1,  // TD-LTE Special Frame Configuration
        iprmTDLTE_ULDLConfig_SCC2,    // TD-LTE UL DL Configuration
        iprmTDLTE_SpecialFrame_SCC2,  // TD-LTE Special Frame Configuration
        iprmPPDUFormat_n,
        iprmPPDUType_n,
        iprmMCSIdx_n,
        iprmGuardInt_n,
        iprmPPDUType_ac,
        iprmMCSIdx_ac,
        iprmGuardInt_ac,
        iprmOpDataRate,
        iprmAutoAssignIP,
        iprmTriggerSrc,
        iprmPacketDataRate_b,
        iprmPacketDataRate_g,
        iprmShowDiagnosticData,
        iprmDontVerifyConnection,
        iprmGNSS_WaitForFix,
        iprmSMS_CallDroppingEnabled,
        iprmUserDefinedManagementFrameFormat,
        iprmUserDefinedDataFrameFormat,
        iprmUserDefinedDataChanBW,
        iprmUserDefinedDataGuardInterval,
        iprmUserDefinedPER_FrameFormat,
        iprmUserDefinedPER_ChanBW,
        iprmUserDefinedPER_GuardInterval,
        iprmEnableDTXCheck,
        iprmSigGenSweepPoint,
        iprmSigGenSweepPointDwellTime,
        iprmSigGenPointTriggerMode,
        iprmSigGenTriggerInPolarity,
        iprmSigGenTriggerOutPolarity,
        iprmDiagnosticLoggingLevel,
        iprmRFSourceMultiFactor,
        iprmExtMixerHarmonicMixingNumber,
        iprmSigGenReceiverSweepNumOfPoints,
        iprmEnableCQIReporting,
        iprmCSIReportMode,
        iprmEnablePMI_RI_Reporting,
        iprmCQI_PMI_ConfigIndex_FDD,
        iprmCQI_PMI_ConfigIndex_TDD,
        iprmCQI_SetScheduledCQIManually,
        iprmCQI_FollowWB_RB_Number,
        iprmCQI_FollowWB_StartRB,
        iprmCQI_FollowWB_MCS_Table,
        iprmCQI_FollowWB_Modulation,
        iprmCQI_FollowWB_TBS_Index,
        iprm_AttributeStatistics,
        iprmCoherenceBandwithBWSelfDefinedCenter,
        iprmAttenuatorType1,
        iprmAttenuatorType2,
        iprmAttenuatorType3,
        iprmAttenuatorType4,
        iprmAttenuatorType5,
        iprmAttenuatorType6,
        iprmAttenuatorType7,
        iprmAttenuatorType8,
        iprmAttenuatorType9,
        iprmAttenuatorType10,
        iprmAttenuatorType11,
        iprmAttenuatorType12,
        iprmAttenuatorType13,
        iprmAttenuatorType14,
        iprmAttenuatorType15,
        iprmAttenuatorType16,
        iprmReverbAFS_MeasurementOption,
        iprmLTE_P3_ExternalLoss,
        iprmLTE_P4_ExternalLoss,
        iprmLTE_DL_256QAM,

        BSS_iRFOutputPort_SCC3,
        iprmLTE_ExternalLoss_SCC3,
        iprmLTE_P2_ExternalLoss_SCC3,
        iprmLTE_FrameType_SCC3,
        iprmLTE_CA_Activation_SCC3,
        BSS_iOptionSelect_SCC3,
        iLTEChannelBandwidth_SCC3,
        BSS_iDTCRFChannel_SCC3,
        iprmLTE_RMC_DL_NumRB_SCC3,
        iprmLTE_UDCH_DL_StartRB_SCC3,
        iprmLTE_DL_MCS_Index_0_SCC3,
        iprmLTE_DL_MCS_Index_5_SCC3,
        iprmLTE_DL_MCS_Index_1469_SCC3,
        iprmLTE_TDD_UDTTI_DL_TBSI_Left_SCC3,
        iprmLTE_CFI_SCC3,
        iprmLTE_SCell_Cycle_SCC3,
        iprmLTE_RMC_UL_NumRB_SCC3,
        iprmLTE_UDCH_UL_StartRB_SCC3,
        iprmLTE_UL_MCS_Index_SCC3,
        iprmBackupLTE_RMC_DL_NumRB_CMW_SCC3,
        iprmLTE_TXXOutputPort_SCC3,
        iprmLTE_PDSCH_OffsetPA_SCC1,    //Get ready for MIMO CA
        iprmLTE_PDSCH_OffsetPA_SCC2,
        iprmLTE_PDSCH_OffsetPA_SCC3,
        iprmLTE_PDSCH_RatioIdxPB_SCC1,
        iprmLTE_PDSCH_RatioIdxPB_SCC2,
        iprmLTE_PDSCH_RatioIdxPB_SCC3,
        iprmLTE_LAA_SCC1,
        iprmLTE_LAA_SCC2,
        iprmLTE_LAA_SCC3,
        iprmAmplifierUnitNumber,
        iprmAmplifierPortNumber,
        iprmAttenuatorUnitNumber,
        iprmAttenuatorPortNumber,
        iprmEmulatorPortNumber,
        iprmLTE_CatZeroALlowed,
        iprmLTE_PowerSavingModingallowed,
        iprmCAT_M1_UL_NBIndex,
        iprmCAT_M1_UL_NBStartRB,
        iprmCAT_M1_DL_NBIndex,
        iprmCAT_M1_DL_NBStartRB,
        iprmLAA_Mode_SCC1,
        iprmPartialSubFrameMCS_Index_SCC1,
        iprmLAA_Mode_SCC2,
        iprmPartialSubFrameMCS_Index_SCC2,
        iprmLAA_Mode_SCC3,
        iprmPartialSubFrameMCS_Index_SCC3,
        iprmLAA_Mode_SCC4,
        iprmPartialSubFrameMCS_Index_SCC4,

        iprmLTE_MIMO_ChannelModel_Selection,
        iprmLTE_MIMO_Layers_Number,
        iprmLTE_StaticChModel_h13phi,
        iprmLTE_StaticChModel_h14phi,
        iprmLTE_StaticChModel_h23phi,
        iprmLTE_StaticChModel_h24phi,
        iprmLTE_StaticChModel_h31phi,
        iprmLTE_StaticChModel_h32phi,
        iprmLTE_StaticChModel_h33phi,
        iprmLTE_StaticChModel_h34phi,
        iprmLTE_StaticChModel_h41phi,
        iprmLTE_StaticChModel_h42phi,
        iprmLTE_StaticChModel_h43phi,
        iprmLTE_StaticChModel_h44phi,
        iprmDisablePowerControl,
        iprmAttenuationStep,
        iprmLTE_UDCH_DL_NumRB_eMTC,
        iprmLTE_UDCH_DL_NB_Index_eMTC,
        iprmLTE_UDCH_DL_NB_StartRB_eMTC,
        iprmLTE_UDCH_DL_StartRB_eMTC,
        iprmLTE_UDCH_DL_TrnBlkSzIdx_eMTC,
        iprmLTE_UDCH_UL_NumRB_eMTC,
        iprmLTE_UDCH_UL_NB_Index_eMTC,
        iprmLTE_UDCH_UL_NB_StartRB_eMTC,
        iprmLTE_UDCH_UL_StartRB_eMTC,
        iprmLTE_UDCH_UL_TrnBlkSzIdx_eMTC,
        iprmLTE_eDRX_Enabled_eMTC,
        iprmLTE_eDRX_PagingTimeWindow_eMTC,
        iprmLTE_eDRX_CycleLength_eMTC,
        iprmLTE_UL_FrequencyHopping_eMTC,
        iprmLTE_DL_FrequencyHopping_eMTC,
        iprmLTE_CE_Mode_eMTC,
        iprmCE_SystemBandwidth,
        iprmCE_UseUnitCountForGain,

        iprmLTE_LAA_BurstType_SCC1,
        iprmLTE_LAA_LengthOfBurst_SCC1,
        iprmLTE_LAA_Periodicity_SCC1,
        iprmLTE_LAA_StartingPosOfFirstBurst_SCC1,
        iprmLTE_LAA_OccupiedOFDMInLastBurst_SCC1,
        iprmLTE_LAA_ModulationInitialSF_SCC1,
        iprmLTE_LAA_TBSIndexInitialSF_SCC1,
        iprmLTE_LAA_ModulationEndingSF_SCC1,
        iprmLTE_LAA_TBSIndexEndingSF_SCC1,
        iprmLTE_LAA_BurstType_SCC2,
        iprmLTE_LAA_LengthOfBurst_SCC2,
        iprmLTE_LAA_Periodicity_SCC2,
        iprmLTE_LAA_StartingPosOfFirstBurst_SCC2,
        iprmLTE_LAA_OccupiedOFDMInLastBurst_SCC2,
        iprmLTE_LAA_ModulationInitialSF_SCC2,
        iprmLTE_LAA_TBSIndexInitialSF_SCC2,
        iprmLTE_LAA_ModulationEndingSF_SCC2,
        iprmLTE_LAA_TBSIndexEndingSF_SCC2,

        iprmCMW500_TXConverter_SCC3,
        iprmCMW500_TXConverter_SCC3_2,
        iprmTDLTE_ULDLConfig_SCC3,
        iprmTDLTE_SpecialFrame_SCC3,
        //LAA
        iprmLTE_LAA_BurstType_SCC3,
        iprmLTE_LAA_LengthOfBurst_SCC3,
        iprmLTE_LAA_Periodicity_SCC3,
        iprmLTE_LAA_StartingPosOfFirstBurst_SCC3,
        iprmLTE_LAA_OccupiedOFDMInLastBurst_SCC3,
        iprmLTE_LAA_ModulationInitialSF_SCC3,
        iprmLTE_LAA_TBSIndexInitialSF_SCC3,
        iprmLTE_LAA_ModulationEndingSF_SCC3,
        iprmLTE_LAA_TBSIndexEndingSF_SCC3,

        iprmCopyPCC_CMW_SCC3,
        iprmLTE_Basetion_CA_Mode_CMW_SCC3,
        BSS_iOptionSelect_CMW_SCC3,
        BSS_iDTCRFChannel_CMW_SCC3,
        iBandWidth_CMW_SCC3,
        BSS_iCellID_CMW_SCC3,
        iprmLTE_UETermConnType_CMW_SCC3,
        BSS_iRFInputPort_CMW_SCC3,
        BSS_iRFOutputPort_CMW_SCC3,
        iprmLTE_RFOutputPort2_CMW_SCC3,
        iprmLTE_RMC_DL_NumRB_CMW_SCC3,
        iprmLTE_RMC_DL_RBPos_CMW_SCC3,
        iprmLTE_UDCH_DL_NumRB_CMW_SCC3,
        iprmLTE_UDCH_DL_StartRB_CMW_SCC3,
        iprmLTE_UDCH_DL_TrnBlkSzIdx_CMW_SCC3,
        iprmLTE_RMC_DL2_NumRB_CMW_SCC3,
        iprmLTE_RMC_DL2_RBPos_CMW_SCC3,
        iprmLTE_UDCH_DL2_NumRB_CMW_SCC3,
        iprmLTE_UDCH_DL2_StartRB_CMW_SCC3,
        iprmLTE_UDCH_DL2_TrnBlkSzIdx_CMW_SCC3,
        iprmLTE_UDTTI_DL2_NumRB_0_CMW_SCC3,
        iprmLTE_UDTTI_DL2_NumRB_5_CMW_SCC3,
        iprmLTE_UDTTI_DL2_NumRB_1469_CMW_SCC3,
        iprmLTE_UDTTI_DL2_StartRB_0_CMW_SCC3,
        iprmLTE_UDTTI_DL2_StartRB_5_CMW_SCC3,
        iprmLTE_UDTTI_DL2_StartRB_1469_CMW_SCC3,
        iprmLTE_UDTTI_DL2_TBSI_0_CMW_SCC3,
        iprmLTE_UDTTI_DL2_TBSI_5_CMW_SCC3,
        iprmLTE_UDTTI_DL2_TBSI_1469_CMW_SCC3,
        iprmLTE_UDTTI_DL_NumRB_0_CMW_SCC3,
        iprmLTE_UDTTI_DL_NumRB_5_CMW_SCC3,
        iprmLTE_UDTTI_DL_NumRB_1469_CMW_SCC3,
        iprmLTE_UDTTI_DL_StartRB_0_CMW_SCC3,
        iprmLTE_UDTTI_DL_StartRB_5_CMW_SCC3,
        iprmLTE_UDTTI_DL_StartRB_1469_CMW_SCC3,
        iprmLTE_UDTTI_DL_TBSI_0_CMW_SCC3,
        iprmLTE_UDTTI_DL_TBSI_5_CMW_SCC3,
        iprmLTE_UDTTI_DL_TBSI_1469_CMW_SCC3,
        iprmLTE_PRACH_CfgIndex_CMW_SCC3,
        iprmLTE_TransmissionScheme_CMW_SCC3,
        iprmLTE_PDSCH_OffsetPA_CMW_SCC3,
        iprmLTE_PDSCH_RatioIdxPB_CMW_SCC3,
        iprmLTE_StaticChModel_h11phi_CMW_SCC3,
        iprmLTE_StaticChModel_h12phi_CMW_SCC3,
        iprmLTE_StaticChModel_h21phi_CMW_SCC3,
        iprmLTE_StaticChModel_h22phi_CMW_SCC3,
        iprmLTE_TDD_UDTTI_DL_NumRB_0_CMW_SCC3,
        iprmLTE_TDD_UDTTI_DL_StartRB_0_CMW_SCC3,
        iprmLTE_TDD_UDTTI_DL_TBSI_0_CMW_SCC3,
        iprmLTE_TDD_UDTTI_DL_NumRB_5_CMW_SCC3,
        iprmLTE_TDD_UDTTI_DL_StartRB_5_CMW_SCC3,
        iprmLTE_TDD_UDTTI_DL_TBSI_5_CMW_SCC3,
        iprmLTE_TDD_UDTTI_DL_NumRB_S_CMW_SCC3,
        iprmLTE_TDD_UDTTI_DL_StartRB_S_CMW_SCC3,
        iprmLTE_TDD_UDTTI_DL_TBSI_S_CMW_SCC3,
        iprmLTE_TDD_UDTTI_DL_NumRB_Left_CMW_SCC3,
        iprmLTE_TDD_UDTTI_DL_StartRB_Left_CMW_SCC3,
        iprmLTE_TDD_UDTTI_DL_TBSI_Left_CMW_SCC3,
        iprmLTE_TDD_UDTTI_DL2_NumRB_0_CMW_SCC3,
        iprmLTE_TDD_UDTTI_DL2_StartRB_0_CMW_SCC3,
        iprmLTE_TDD_UDTTI_DL2_TBSI_0_CMW_SCC3,
        iprmLTE_TDD_UDTTI_DL2_NumRB_5_CMW_SCC3,
        iprmLTE_TDD_UDTTI_DL2_StartRB_5_CMW_SCC3,
        iprmLTE_TDD_UDTTI_DL2_TBSI_5_CMW_SCC3,
        iprmLTE_TDD_UDTTI_DL2_NumRB_S_CMW_SCC3,
        iprmLTE_TDD_UDTTI_DL2_StartRB_S_CMW_SCC3,
        iprmLTE_TDD_UDTTI_DL2_TBSI_S_CMW_SCC3,
        iprmLTE_TDD_UDTTI_DL2_NumRB_Left_CMW_SCC3,
        iprmLTE_TDD_UDTTI_DL2_StartRB_Left_CMW_SCC3,
        iprmLTE_TDD_UDTTI_DL2_TBSI_Left_CMW_SCC3,
        iprmLTE_Antenna_Config_SCC3,
        iprmLTE_PowerControlDCI_SCC3,
        iprmLTE_PMI_SCC3,
        iprmSI_NB_R13,
        iprmCA_SyncRewind,
        iprmCA_MeasureMode,

        iprmNB_IOT_OperationMode,
        iprmNB_IOT_CoexitingBandwidth,
        iprmNB_IOT_FreqIndex_UL,
        iprmNB_IOT_FreqIndex_DL,
        iprmNB_IOT_NPUSCH_Format,
        iprmNB_IOT_NPRACH_Format,
        iprmNB_IOT_PatternSet,
        iprmNB_IOT_UL_SubCarrier_Spacing,
        iprmNB_IOT_UL_SubCarrier_Number,
        iprmNB_IOT_UL_SubCarrier_Start,
        iprmNB_IOT_UL_ResourceUnits_Number,
        iprmNB_IOT_NCellID,
        iprmNB_IOT_P0_UE_NPUSCH,
        iprmNB_IOT_NRS_Power,

        iprmNB_IOT_T3412_Unit,
        iprmNB_IOT_T3412_Value,
        iprmNB_IOT_T3324_Unit,
        iprmNB_IOT_T3324_Value,
        iprmNB_IOT_T3412EXT_Unit,
        iprmNB_IOT_T3412EXT_Value,
        iprmNB_IOT_EXT_DRX_Value,
        iprmNB_IOT_EXT_DRX_PagingTimeWindow,
        iprmRMCFrequencyOffsetByBaseStationSign,
        iprmThreadedEquipmentInit,
        iprmWLAN_TXSet,
        iprmWLAN_RXSet,
        iprmCE_as_SCC_Interface,
        iprmNB_IOT_EARFCN_Offset_UL,   // For NBIoT guard-band settings
        iprmNB_IOT_EARFCN_Offset_DL,   // For NBIoT guard-band settings
        iprmNB_IOT_DL_ResourceUnits_Number,   // For NBIoT DL Resource Assignment

        iprmNB_IOT_DLFrequencyOffset,
        iprmNB_IOT_ULFrequencyOffset,
        iprmNB_IOT_LTEControlRegionSize,
        iprmNB_IOT_In_BandPCI,
        iprmNB_IOT_In_BandCarrierPos,
        iprmNB_IOT_Guard_BandCarrierPos,
        iprmNB_IOT_PreambleFormat,
        iprmNB_IOT_SyncZone,
        iprmNB_IOT_SyncOffset,
        iprmNB_IOT_TestModeIPVersion,
        iprmNB_IOT_DataAppIPVersion,
        iprmNB_IOT_C_IoTOptimization,
        iprmNB_IOT_ErrorRatioCal,
        iprmP_CSCF_Address_Response,
        iprmWLAN_NP20_Index,

        iprmBeamformingXCount,
        iprmBeamformingYCount,
        iprmBeamformingZCount,
        iprmBeamformingDummy1,
        iprmBeamformingDummy2,
        iprmBeamformingDummy3,

        iprm5G_SetupSelection,
        iprm5G_ScenarioSelection,
        iprm5G_LTE_CarrierAssignment,
        iprm5G_LTE_CellSelection,
        iprm5G_LTE_BSEModeSelection,

        // 5G NR Hybrid Mode
        iprm_UXM_LTE_NR_HYBRID_MODE,

        // For 5G Band, extra info similiar to BSS_iOptionSelect, since they coexist with LTE bands
        BSS_iOptionSelect_NR_CELL1,
        BSS_iOptionSelect_NR_CELL2,
        BSS_iOptionSelect_NR_CELL3,
        BSS_iOptionSelect_NR_CELL4,

        iprmNR_FrameType_CELL1,
        iprmNR_FrameType_CELL2,
        iprmNR_FrameType_CELL3,
        iprmNR_FrameType_CELL4,

        iprmNR_iDTCRFChannel_CELL1,
        iprmNR_iDTCRFChannel_CELL2,
        iprmNR_iDTCRFChannel_CELL3,
        iprmNR_iDTCRFChannel_CELL4,

        iprm5G_NR_Cell1,
        iprm5G_NR_Cell2,
        iprm5G_NR_Cell3,
        iprm5G_NR_Cell4,

        iprm_NR_FrequencyRange_CELL1,
        iprm_NR_FrequencyRange_CELL2,
        iprm_NR_FrequencyRange_CELL3,
        iprm_NR_FrequencyRange_CELL4,

        iBandWidth_NR_CELL1,
        iBandWidth_NR_CELL2,
        iBandWidth_NR_CELL3,
        iBandWidth_NR_CELL4,

        iprm_NR_SubCarrier_Spacing_C1,
        iprm_NR_SubCarrier_Spacing_C2,
        iprm_NR_SubCarrier_Spacing_C3,
        iprm_NR_SubCarrier_Spacing_C4,

        iprm_NR_DL_PhyAttenPorts_CELL1,
        iprm_NR_DL_PhyAttenPorts_CELL2,
        iprm_NR_DL_PhyAttenPorts_CELL3,
        iprm_NR_DL_PhyAttenPorts_CELL4,

        iprm_NR_UL_PhyAttenPorts_CELL1,
        iprm_NR_UL_PhyAttenPorts_CELL2,
        iprm_NR_UL_PhyAttenPorts_CELL3,
        iprm_NR_UL_PhyAttenPorts_CELL4,
        //
        //  PLEASE add all new parameters above this line using the iprmXxxx naming convention
        //
        // NR SSB
        iprmNR_SSB_SubcarrierSpacing,
        iprmNR_SSB_Periodicity,
        iprmNR_SSB_Raster,
        iprmNR_SSB_Kssb,
        iprmNR_SSB_MIB_UserFixedData_OnOff,
        iprmNR_SSB_MIB_UserFixedData,
        iprmNR_SSB_MIB_SubCarrierSpacing,
        iprmNR_SSB_MIB_SubCarrierOffset,
        iprmNR_SSB_MIB_DMSTypeAPos,
        iprmNR_SSB_MIB_PDCCHS1B1,
        iprmNR_SSB_CellBarred_OnOff,
        iprmNR_SSB_IntraFreqResel_OnOff,

        iprmNR_CRNTI_CELL1,
        iprmNR_CRNTI_CELL2,
        iprmNR_CRNTI_CELL3,
        iprmNR_CRNTI_CELL4,

        iprmNR_iCellID_CELL1,
        iprmNR_iCellID_CELL2,
        iprmNR_iCellID_CELL3,
        iprmNR_iCellID_CELL4,

        iprmRANOperation,
        iprmNumDLSCCs,
        iprmNumULSCCs,

        iprmTDD_Config_Common_Periodicity,
        iprmTDD_Config_Common_DL_Duration,
        iprmTDD_Config_Common_UL_Duration,
        iprmTDD_Config_Dedicated,

        iprmOffsetToCarrier,
        iprmULRMC_Waveform,
        iprmDL_PointA_Channel,
        iprmRFConverter_RF_Switch,
        iprmRFConverter_SG_SA_Mode,

        iprmSS_Burst_Periodicity,
        iprmSS_Block_Mapping_Pattern,
        iprmSS_Block_Transmission_Type,
        iprmSS_Block_Num,
        iprmSS_K_SSB,
        iprmPDCCH_Symbol_CORESET,
        iprmPDSCH_DMRS_duration,
        iprmPDSCH_DL_DMRS_typeA_pos,
        iprmPDSCH_DL_DMRS_starting_pos,
        iprmPDSCH_DMRS_starting_pos,
        iprmPDSCH_DL_DMRS_Config_Type,
        iprmPUSCH_Mapping_Type,
        iprmPUSCH_Start_Symbol,
        iprmPUSCH_Symbol_Length,
        iprmPUSCH_DMRS_duration,
        iprmPUSCH_Antenna_DCI,
        iprmPUSCH_Antenna_port,
        iprmPUSCH_UL_DMRS_typeA_pos,
        iprmPUSCH_UL_DMRS_add_pos,
        iprmPUSCH_DMRS_starting_pos,
        iprmPUSCH_UL_DMRS_Config_Type,
        iprmPUSCH_UL_DMRS_Scrambling_ID,
        iprmPUSCH_N_ID_nSCID,
        iprmPUSCH_Group_Hopping,
        iprmPUSCH_Sequence_Hopping,
        iprmPUSCH_UL_PTRS,
        iprmPUSCH_K_PTRS,
        iprmPUSCH_L_PTRS,
        iprmPUSCH_PTRS_groups,
        iprmPUSCH_PTRS_samples_per_group,

        iprmMeasurementPort,
        iprmMeasurementSlot,
        iprmMeasurementLongSpanSearch,
        iprmMeasurementPhaseTracking,
        iprmMeasurementTriggerSource,
        iprmMeasurementOTACal,
        iprmMeasurementFast,

        iprmSpectrumMonitor_Freq_Span,
        iprmSpectrumMonitor_RBW,
        iprmSpectrumMonitor_Dectect_Mode,
        iprmSpectrumMonitor_Trigger_Souce,
        iprmSpectrumMonitor_Trigger_Timeout,
        iprmSpectrumMonitor_Trigger_PowerMeasurementBandwith,
        iprmSpectrumMonitor_Trigger_PowerMeasurementAverageCount,


        iprmRFRoutingMode,
        iprmRFTestSlot,

        iprmSlot1TestInterface,
        iprmSlot1_RFRounting_TRx1,
        iprmSlot1_RFRounting_TRx2,

        iprmSlot2TestInterface,
        iprmSlot2_RFRounting_TRx1,
        iprmSlot2_RFRounting_TRx2,

        iprmSlot1_ExternalLoss,
        iprmSlot2_ExternalLoss,

        iprmOTA_Calibration_Switch,

        iprmNR_SSB_ARFCN,

        iprmNR_Scheduling_TDDPattern_Enable,
        iprmNR_Scheduling_TDDPattern_SubCarSpac,
        iprmNR_Scheduling_TDDPattern_DLSlots,
        iprmNR_Scheduling_TDDPattern_DLSymbols,
        iprmNR_Scheduling_TDDPattern_TransPeriod,
        iprmNR_Scheduling_TDDPattern_ULSlots,
        iprmNR_Scheduling_TDDPattern_ULSymbols,

        iprmNR_Scheduling_Misc_Mode,
        iprmNR_Scheduling_Misc_IMCS,
        iprmNR_Scheduling_Misc_DCIAggLevl,
        iprmNR_Scheduling_Misc_RBAlloc_Start,
        iprmNR_Scheduling_Misc_RBAlloc_Count,
        iprmNR_Scheduling_Misc_Symbol_Start,
        iprmNR_Scheduling_Misc_Symbol_LEN,
        iprmGNSS_ScenarioResetTime,
        iprm_UseLegacyDriver,
        iprmNR_PhaseCompensation,
        iprmNR_MeasurementTargetSwitch,
        iprmNR_MeasurementULSubframe,
        iprmNR_MeasurementULSlot,
        iprmNR_MeasurementMode,
        iprmNR_MeasurementMetric,
        iprmNR_MeasurementMethod,
        iprmNR_tp_p2BPSK,
        iprmNR_OffsetToCarrier,
        iprmNR_SymbolOfCORESET,
        iprmNR_TxConfig,
        iprmNR_PUCCHFormat0_StartRB,
        iprmNR_PUCCHFormat0_StartSymbol,
        iprmNR_PUCCHFormat0_SymbolLen,
        iprmNR_PUCCHFormat2_StartRB,
        iprmNR_PUCCHFormat2_RBNumber,
        iprmNR_PUCCHFormat2_StartSymbol,
        iprmNR_PUCCHFormat2_SymbolLen,
        iprmNR_PUCCHGroupHopping,
        iprmNR_AdditionalSpecEmissionOnOFF,
        iprmNR_AdditionalSpecEmission,
        iprmNR_PrePhaseCorrection,
        iprmNR_UBFMode,
        iprmGNSSStartFixModeLin,
        iprmGNSS_WaitForFixLin,
        iprmHalfDuplex_eMTC_RMC,
        iprmSFPattern_eMTC_RMC,
        iprmIgnoreIncorrectness_eMTC_RMC,
        iprmLTE_UDCH_DL_NumRB_eMTC_RMC,
        iprmLTE_UDCH_UL_NumRB_eMTC_RMC,
        iprmLTE_RMC_DL_RBPos_eMTC_RMC,
        iprmLTE_RMC_UL_RBPos_eMTC_RMC,
        iprmLTE_UDCH_DL_NB_Index_eMTC_RMC,
        iprmLTE_UDCH_UL_NB_Index_eMTC_RMC,
        iprmLTE_UDCH_DL_Mod_eMTC_RMC,
        iprmLTE_UDCH_UL_Mod_eMTC_RMC,
        iprmSlot1_RFConverter_RFSwitch_TRx1,
        iprmSlot1_RFConverter_SGSAMode_TRx1,
        iprmSlot1_RFConverter_RFSwitch_TRx2,
        iprmSlot1_RFConverter_SGSAMode_TRx2,
        iprmSlot2_RFConverter_RFSwitch_TRx1,
        iprmSlot2_RFConverter_SGSAMode_TRx1,
        iprmSlot2_RFConverter_RFSwitch_TRx2,
        iprmSlot2_RFConverter_SGSAMode_TRx2,
        iprmNR_TRxPort,
        iprmNR_UL_Antenna_Config,
        iprmNR_PreambleFormat,
        iprmNR_RANAC,
        iprmNR_BeamLockStatus,
        iprmLabelOutputAsCircularPolarization,
        iprmNRScalingFactor,
        iprmTputSetWindowsParameters,
        iprmTputAttachUE,
        iprmTputStartTransfer,
        iprmTputSamplingTime,
        iprmTputTraceAttach,
        iprmTputTraceTransfer,
        iprmNRFrequencyOffsetSign,
        iprmNR_Scheduling_Type,
        iprmNR_SS_Block_SCS,
        iprmPDSCH_Start_Symbol,
        iprmPDSCH_Symbol_Length,
        iprmPDSCH_HARQ_ACK_CodeBook,
        iprmPDSCH_nrofHARQ_Processes,
        iprmPUCCH_K1_ListSize,
        iprmNR_SRS,
        iprmNR_SymbolClockErrorCorrection,
        iprmNR_ThroughputSampleUnit,
        iprmNR_DL_DCI_Scheduling,
        iprmNR_DL_DCI_K1_Index,
        iprmNR_DL_DCI_K1,
        iprmNR_UL_DCI_Scheduling,
        iprmNR_UL_DCI_Allocation_Index,
        iprmNR_UL_DCI_K2,
        iprmNR_SISO_FR2_TXRX_SEPARATION,
        iprmNR_CommonGuard_Period,
        iprmNR_PUSCH_Allocation_Size,
        iprmNR_SRS_ResourceType,
        iprmNR_SRS_Periodicity,
        iprmNR_SRS_Offset,
        iprmNR_SRS_Start_Symbol,
        iprmNR_SRS_Symbol_Length,
        iprmNR_t310,
        iprmNR_n310,
        iprmNR_n311,
        iprmNR_TestEnv,

        // UCSD Array Control Parameters
        iprmArray_ElementXStart,
        iprmArray_ElementXStop,
        iprmArray_ElementXStep,
        iprmArray_ElementYStart,
        iprmArray_ElementYStop,
        iprmArray_ElementYStep,
        iprmArray_TXrxMode,
        iprmArray_RXAttenuator,
        iprmArray_IterateAzimuth,
        iprmArray_IterateElevation,
        iprmArray_IterateTXVGA,
        iprmArray_IterateRXVGA,
        iprmArray_IterateTXPA,
        iprmArray_IterateRXLNA,
        iprmArray_IterateElements,
        iprmArray_IteratePhase,
        iprmICP_FrequencyCorrection,
        iprmDL_BWP_LOBW,
        iprmSS_PBCH_BLOCKPower,
        iprmVrb_Prb_Mapping,
        iprmOffsettoPointA,
        iprmTD_KaiserBeta,

        // UXM 5G Power Control Mode
        iprmNR_PUSCH_DTC_PCL,   // PUSCH Power Control Mode
        iprmNR_PUCCH_DTC_PCL,   // PUCCH Power Control Mode
        iprmNR_NOM_PUSCH_Enabled,
        iprmNR_NOM_PUSCH,
        iprmNR_PXTPZUE_PUSCh_Enabled,
        iprmNR_PXTPZUE_PUSCh,
        iprmNR_PMaxEnable,
        iprmNR_PMax,
        iprmPUSCH_DMRS_MappintTypeA_Enabled,
        iprmNR_PMaxEUTRA_Enabled,
        iprmNR_PMaxEUTRA,
        iprmNR5G_SA_REG_PIGGyback,
        iprmPHY_PUSCH_CBSUBset,
        iprmPDSCH_DMRS_MappintTypeA_Enabled,
        iprmPDCCH_AggreCandidates_One,
        iprmPDCCH_AggreCandidates_Two,
        iprmPDCCH_AggreCandidates_Four,
        iprmPDCCH_AggreCandidates_Eight,

        iprmFR2_BeamPeakPolarization,
        iprmFR2_BeamLockTime,
        iprmFR2_CDFNumberOfBins,

        iprmPDCCH_StartingRBOfCORESET,
        iprmPDCCH_CCE_Index_AllocType,
        iprmNR_DCI_UL_Format,
        iprmNR_DCI_DL_Format,
        iprmNR_SigParm_NormPUCCH,
        iprmNR_SigParm_NormPUSCH,
        iprmNR_SigParm_UE_PUCCH,
        iprmNR_SigParm_UE_PUSCH,

        iprmCalculateLogMagTaperRipple,
        iprmCalculateLinearPhaseTaperRipple,
        iprmPerformBandCalSign,

        iprmFR2_DUT_AlignmentOption,
        iprmFR2_DUT_RepositionOption,
        iprmFR2_BP_AlignmentOption,
        iprmFR2_BP_RepositionOption,

        iprmBaseStationCipheringMethod,
        iprmPDSCH_PRB_BundleSize,
        iprmPRACHSubcarrierSpacing,

        iprmSearchSpaceAggreLev1,
        iprmSearchSpaceAggreLev2,
        iprmSearchSpaceAggreLev4,
        iprmSearchSpaceAggreLev8,
        iprmSearchSpaceAggreLev16,

        iprmPDCCH_AggreCandidates_Sixteen,

        iprmNR_UXM5G_Dummy0, // reserved
        iprmNR_UXM5G_Dummy1, // reserved
        iprmNR_UXM5G_Dummy2, // reserved
        iprmNR_UXM5G_Dummy3, // reserved
        iprmNR_UXM5G_Dummy4, // reserved
        iprmNR_UXM5G_Dummy5, // reserved
        iprmNR_UXM5G_Dummy6, // reserved
        iprmNR_UXM5G_Dummy7, // reserved
        iprmNR_UXM5G_Dummy8, // reserved
        iprmNR_UXM5G_Dummy9, // reserved

        iprmWLAN_VHT_Rates_Config,
        iprmWLAN_TrafficIdentifier,
        iprmWLAN_Dummy0,
        iprmWLAN_Dummy1,
        iprmWLAN_Dummy2,
        iprmWLAN_Dummy3,
        iprmWLAN_Dummy4,
        iprmWLAN_Dummy5,
        iprmWLAN_Dummy6,
        iprmWLAN_Dummy7,
        iprmWLAN_Dummy8,
        iprmWLAN_Dummy9,
        iprmFR2_TestType,   //specifies the type of measurement
        iprmApplyNormalization,

        iprmTD_FloatingGate, // Make the gate relative to the peak
        iprmTD_FloatingWindow, // Make the window relative to the peak
        iprmTD_CalculatePDPMetrics,  // flag that the PDP metrics need to be extracted from time domain
        iprmTD_SmoothingMode,       // average or peak across window (and maybe off)
        iprmTD_ShowIntermediateData,   // Give multiple graphs in a response test (and possibly elsewhere)
        iprmTD_Option5,
        iprmTD_Option6,

        iprmTriggeredModeAcquisition,  // Moving this from dummy in TChanEmulValidation
        iprmAlgorithmNF2FF,   // Select NF2FF algorithm (was _iDummy3)

        // signal analysis flags
        iprmSigAnEnableFFT,       // Enable FFT for time IQ data
        iprmSigAnFFTSize,         // Number of points in the FFT
        iprmSigAnRunningWindow,   // Overlap or don't overlap window
        iprmSigAnUseRMSFilter,    // Apply an RMS filter             // Note, these parameters are moved from TD_Option2/3
        iprmSigAnRMSFilterPoints, // Specify the number of points

        iprm_Dummy0,             // For future use
        iprm_Dummy1,             // For future use
        iprm_Dummy2,             // For future use

        iprmGNSS_NumMeasurePattern,    // Number of measurements to average during Pattern
        iprmGNSS_NumMeasureLin,        // Number of measurements to average during Linearization
        iprmGNSS_CheckCNoDeviation,    // Check Allowable C/No deviation
        iprmGNSS_CheckAvgCNoDeviation, // Check Allowable Average C/No deviation

        iprmNRQ6DriverOption,
        iprmNRQ6TimeSlots,
        iprmNRQ6GateNumber,
        iprmNRQ6ContAvSmoothModSig,
        iprmNRQ6ContAvUseDutyCycle,
        iprmNRQ6ContAvUseAutoRange,
        iprmNRXIsPresent,
        iprmNRQ6_Reserved2,
        iprmNRQ6_Reserved3,
        iprmNRQ6_Reserved4,

        iprmBeamCount,

        iprmLTE_DLAntConfig_SCC1,   //UXM5G LTE CA
        iprmLTE_DLAntConfig_SCC2,
        iprmLTE_DLAntConfig_SCC3,
        iprmInputLevelSetMode_SCC1,
        iprmInputLevelSetMode_SCC2,
        iprmInputLevelSetMode_SCC3,
        iprmEnableCQIReporting_SCC1,
        iprmEnableCQIReporting_SCC2,
        iprmEnableCQIReporting_SCC3,
        iprm5G_LTE_CellSelection_SCC1,
        iprm5G_LTE_CellSelection_SCC2,
        iprm5G_LTE_CellSelection_SCC3,
        iprm5G_LTE_BSEModeSelection_SCC1,
        iprm5G_LTE_BSEModeSelection_SCC2,
        iprm5G_LTE_BSEModeSelection_SCC3,
        iBandWidth_SCC1,
        iBandWidth_SCC2,
        iBandWidth_SCC3,
        iprmLTE_CyclicPrefix_SCC1,
        iprmLTE_CyclicPrefix_SCC2,
        iprmLTE_CyclicPrefix_SCC3,
        iprmLTE_TransmissionMode_SCC1,
        iprmLTE_TransmissionMode_SCC2,
        iprmLTE_TransmissionMode_SCC3,
        BSS_iPrachCodeword_SCC1,
        BSS_iPrachCodeword_SCC2,
        BSS_iPrachCodeword_SCC3,
        iprmLTE_DL_256QAM_SCC1,
        iprmLTE_DL_256QAM_SCC2,
        iprmLTE_DL_256QAM_SCC3,

        iprmCalculatePhaseVariation,
        iprmAUTOrientation,

        iprmRealtimeCorOpt,
        iprmCorrectPhaseVariation,

        iprmNR_UL_SchedulingMode,
        iprmNR_UL_TransmissonMode,
        iprmNR_UL_MCSTable,
        iprmNR_UL_MCSIndex,
        iprmNR_UL_NumRB,
        iprmNR_UL_StartRB,
        iprmNR_DL_SchedulingMode,
        iprmNR_DL_TransmissonMode,
        iprmNR_DL_MCSTable,
        iprmNR_DL_MCSIndex,
        iprmNR_DL_NumRB,
        iprmNR_DL_StartRB,
        iprmNR_UL_Split_Threshold,
        iprmNR_DL_Split_Ratio,
        iprmPPDUFormat_ax,
        iprmPPDUType_ax,
        iprmMCSIdx_ax,
        iprmGuardInt_ax,
        iprmCodingType_ax,
        iprmBSS_AX_PrimaryChannel,
        iprmMeasurementGridType,
        iprmCDGrid_PointsToMeasure,
        iprmCDGrid_MeasurePath,
        iprmRSE_GetRMSTrace,
        iprmRSE_MaxPeakCount,

        //ADDED NR CA related items

        iprmNR_Basetion_CA_Mode,
        iprmNR_Basetion_CA_SCC_Number,
        iprmNR_Basetion_CA_SensMeasMode,
        iprmNR_Basetion_CA_CC_Setting_Mode,
        iprmNR_Basetion_CA_CC_Setting_Mode_Phsical_Channel,

        //Would add Slot3 and Slot4 in the future.
        iprmNR_SLOT_NR_SCC1,
        iprmNR_SLOT_NR_SCC2,
        iprmNR_SLOT_NR_SCC3,
        iprmNR_TRX_NR_SCC1,
        iprmNR_TRX_NR_SCC2,
        iprmNR_TRX_NR_SCC3,

        iprmNR_CA_Basestation_Status_NR_SCC,

        //For now, we just support the most important things I believe, and add more things if needed.
        iprmLTE_FrameType_NR_SCC1,
        iprmLTE_FrameType_NR_SCC2,
        iprmLTE_FrameType_NR_SCC3,
        iprm_NR_SubCarrier_Spacing_C1_IND_ONLY_SCC1,
        iprm_NR_SubCarrier_Spacing_C1_IND_ONLY_SCC2,
        iprm_NR_SubCarrier_Spacing_C1_IND_ONLY_SCC3,
        //iLTEChannelBandwidth_SCC1,
        //iLTEChannelBandwidth_SCC2,
        //iLTEChannelBandwidth_SCC3,
        iprmNR_iCellID_CELL1_SCC1,
        iprmNR_iCellID_CELL1_SCC2,
        iprmNR_iCellID_CELL1_SCC3,
        iprmNR_Scell_Activation_SCC1,
        iprmNR_Scell_Activation_SCC2,
        iprmNR_Scell_Activation_SCC3,
        iprmNR_PhaseCompensation_IND_ONLY_SCC1,
        iprmNR_PhaseCompensation_IND_ONLY_SCC2,
        iprmNR_PhaseCompensation_IND_ONLY_SCC3,
        iprmTDD_Config_Common_Periodicity_IND_ONLY_SCC1,
        iprmTDD_Config_Common_Periodicity_IND_ONLY_SCC2,
        iprmTDD_Config_Common_Periodicity_IND_ONLY_SCC3,
        iprmTDD_Config_Common_DL_Duration_IND_ONLY_SCC1,
        iprmTDD_Config_Common_DL_Duration_IND_ONLY_SCC2,
        iprmTDD_Config_Common_DL_Duration_IND_ONLY_SCC3,
        iprmTDD_Config_Common_UL_Duration_IND_ONLY_SCC1,
        iprmTDD_Config_Common_UL_Duration_IND_ONLY_SCC2,
        iprmTDD_Config_Common_UL_Duration_IND_ONLY_SCC3,
        iprmNR_Scheduling_TDDPattern_DLSymbols_IND_ONLY_SCC1,
        iprmNR_Scheduling_TDDPattern_DLSymbols_IND_ONLY_SCC2,
        iprmNR_Scheduling_TDDPattern_DLSymbols_IND_ONLY_SCC3,
        iprmNR_Scheduling_TDDPattern_ULSymbols_IND_ONLY_SCC1,
        iprmNR_Scheduling_TDDPattern_ULSymbols_IND_ONLY_SCC2,
        iprmNR_Scheduling_TDDPattern_ULSymbols_IND_ONLY_SCC3,
        iprmNR_Scheduling_Type_SCC1,
        iprmNR_Scheduling_Type_SCC2,
        iprmNR_Scheduling_Type_SCC3,

        //iprmLTE_RMC_DL_NumRB_SCC1,
        //iprmLTE_RMC_DL_NumRB_SCC2,
        //iprmLTE_RMC_DL_NumRB_SCC3,
        //iprmLTE_UDCH_DL_StartRB_SCC1,
        //iprmLTE_UDCH_DL_StartRB_SCC2,
        //iprmLTE_UDCH_DL_StartRB_SCC3,
        //iprmLTE_DL_256QAM_SCC1,
        //iprmLTE_DL_256QAM_SCC2,
        //iprmLTE_DL_256QAM_SCC3,
        //iprmLTE_DL_MCS_Index_1469_SCC1,
        //iprmLTE_DL_MCS_Index_1469_SCC2,
        //iprmLTE_DL_MCS_Index_1469_SCC3,
        //BSS_iOptionSelect_SCC1,
        //BSS_iOptionSelect_SCC2,
        //BSS_iOptionSelect_SCC3,
        iprmDL_PointA_Channel_SCC1,
        iprmDL_PointA_Channel_SCC2,
        iprmDL_PointA_Channel_SCC3,
        iprmNB_IOT_EARFCN_Offset_UL_SCC1,
        iprmNB_IOT_EARFCN_Offset_UL_SCC2,
        iprmNB_IOT_EARFCN_Offset_UL_SCC3,
        iprmNR_iDTCRFChannel_CELL1_SCC1,
        iprmNR_iDTCRFChannel_CELL1_SCC2,
        iprmNR_iDTCRFChannel_CELL1_SCC3,
        iprmNR_OffsetToCarrier_SCC1,
        iprmNR_OffsetToCarrier_SCC2,
        iprmNR_OffsetToCarrier_SCC3,

        //Physical Channel
        iprmSS_Burst_Periodicity_IND_ONLY_SCC1,
        iprmSS_Burst_Periodicity_IND_ONLY_SCC2,
        iprmSS_Burst_Periodicity_IND_ONLY_SCC3,
        iprmNR_SSB_SubcarrierSpacing_IND_ONLY_SCC1,
        iprmNR_SSB_SubcarrierSpacing_IND_ONLY_SCC2,
        iprmNR_SSB_SubcarrierSpacing_IND_ONLY_SCC3,
        iprmSS_Block_Mapping_Pattern_IND_ONLY_SCC1,
        iprmSS_Block_Mapping_Pattern_IND_ONLY_SCC2,
        iprmSS_Block_Mapping_Pattern_IND_ONLY_SCC3,
        iprmSS_Block_Transmission_Type_IND_ONLY_SCC1,
        iprmSS_Block_Transmission_Type_IND_ONLY_SCC2,
        iprmSS_Block_Transmission_Type_IND_ONLY_SCC3,
        iprmSS_Block_Num_IND_ONLY_SCC1,
        iprmSS_Block_Num_IND_ONLY_SCC2,
        iprmSS_Block_Num_IND_ONLY_SCC3,
        iprmSS_K_SSB_SCC1,
        iprmSS_K_SSB_SCC2,
        iprmSS_K_SSB_SCC3,
        iprmPDCCH_Symbol_CORESET_IND_ONLY_SCC1,
        iprmPDCCH_Symbol_CORESET_IND_ONLY_SCC2,
        iprmPDCCH_Symbol_CORESET_IND_ONLY_SCC3,
        iprmCQI_FollowWB_RB_Number_IND_ONLY_SCC1,
        iprmCQI_FollowWB_RB_Number_IND_ONLY_SCC2,
        iprmCQI_FollowWB_RB_Number_IND_ONLY_SCC3,
        iprmPDCCH_StartingRBOfCORESET_IND_ONLY_SCC1,
        iprmPDCCH_StartingRBOfCORESET_IND_ONLY_SCC2,
        iprmPDCCH_StartingRBOfCORESET_IND_ONLY_SCC3,
        iprmSearchSpaceAggreLev1_IND_ONLY_SCC1,
        iprmSearchSpaceAggreLev1_IND_ONLY_SCC2,
        iprmSearchSpaceAggreLev1_IND_ONLY_SCC3,
        iprmSearchSpaceAggreLev2_IND_ONLY_SCC1,
        iprmSearchSpaceAggreLev2_IND_ONLY_SCC2,
        iprmSearchSpaceAggreLev2_IND_ONLY_SCC3,
        iprmSearchSpaceAggreLev4_IND_ONLY_SCC1,
        iprmSearchSpaceAggreLev4_IND_ONLY_SCC2,
        iprmSearchSpaceAggreLev4_IND_ONLY_SCC3,
        iprmSearchSpaceAggreLev8_IND_ONLY_SCC1,
        iprmSearchSpaceAggreLev8_IND_ONLY_SCC2,
        iprmSearchSpaceAggreLev8_IND_ONLY_SCC3,
        iprmSearchSpaceAggreLev16_IND_ONLY_SCC1,
        iprmSearchSpaceAggreLev16_IND_ONLY_SCC2,
        iprmSearchSpaceAggreLev16_IND_ONLY_SCC3,
        iprmPDCCH_CCE_Index_AllocType_IND_ONLY_SCC1,
        iprmPDCCH_CCE_Index_AllocType_IND_ONLY_SCC2,
        iprmPDCCH_CCE_Index_AllocType_IND_ONLY_SCC3,
        iprmNR_SymbolOfCORESET_IND_ONLY_SCC1,
        iprmNR_SymbolOfCORESET_IND_ONLY_SCC2,
        iprmNR_SymbolOfCORESET_IND_ONLY_SCC3,
        iprmLTE_RARespWindowSize_IND_ONLY_SCC1,
        iprmLTE_RARespWindowSize_IND_ONLY_SCC2,
        iprmLTE_RARespWindowSize_IND_ONLY_SCC3,
        iprmPDSCH_DMRS_duration_IND_ONLY_SCC1,
        iprmPDSCH_DMRS_duration_IND_ONLY_SCC2,
        iprmPDSCH_DMRS_duration_IND_ONLY_SCC3,
        iprmPDSCH_DL_DMRS_typeA_pos_IND_ONLY_SCC1,
        iprmPDSCH_DL_DMRS_typeA_pos_IND_ONLY_SCC2,
        iprmPDSCH_DL_DMRS_typeA_pos_IND_ONLY_SCC3,
        iprmPDSCH_PRB_BundleSize_IND_ONLY_SCC1,
        iprmPDSCH_PRB_BundleSize_IND_ONLY_SCC2,
        iprmPDSCH_PRB_BundleSize_IND_ONLY_SCC3,
        iprmPDSCH_DL_DMRS_starting_pos_IND_ONLY_SCC1,
        iprmPDSCH_DL_DMRS_starting_pos_IND_ONLY_SCC2,
        iprmPDSCH_DL_DMRS_starting_pos_IND_ONLY_SCC3,
        iprmPDSCH_DL_DMRS_Config_Type_IND_ONLY_SCC1,
        iprmPDSCH_DL_DMRS_Config_Type_IND_ONLY_SCC2,
        iprmPDSCH_DL_DMRS_Config_Type_IND_ONLY_SCC3,
        iprmPDSCH_Start_Symbol_IND_ONLY_SCC1,
        iprmPDSCH_Start_Symbol_IND_ONLY_SCC2,
        iprmPDSCH_Start_Symbol_IND_ONLY_SCC3,
        iprmPDSCH_Symbol_Length_IND_ONLY_SCC1,
        iprmPDSCH_Symbol_Length_IND_ONLY_SCC2,
        iprmPDSCH_Symbol_Length_IND_ONLY_SCC3,
        iprmPDSCH_HARQ_ACK_CodeBook_IND_ONLY_SCC1,
        iprmPDSCH_HARQ_ACK_CodeBook_IND_ONLY_SCC2,
        iprmPDSCH_HARQ_ACK_CodeBook_IND_ONLY_SCC3,
        iprmPDSCH_nrofHARQ_Processes_IND_ONLY_SCC1,
        iprmPDSCH_nrofHARQ_Processes_IND_ONLY_SCC2,
        iprmPDSCH_nrofHARQ_Processes_IND_ONLY_SCC3,
        iprmOCNG_Idle_IND_ONLY_SCC1,
        iprmOCNG_Idle_IND_ONLY_SCC2,
        iprmOCNG_Idle_IND_ONLY_SCC3,
        //ENDED NR CA related items
        iprmRSE_RMSTraceOption,
        iprmSubCarrierSpacingInTesting,
        iprm_BSS_Enable6EBands,
        iprmFR2_RX_MeasureType,
        iprmFR2_PolarizationOption,

        iprmBackupLTE_RMC_DL_NumRB_CMW_SCC4,
        BSS_iRFOutputPort_SCC4,
        iprmLTE_ExternalLoss_SCC4,
        iprmLTE_P2_ExternalLoss_SCC4,
        iprmLTE_FrameType_SCC4,
        iprmLTE_CA_Activation_SCC4,
        BSS_iOptionSelect_SCC4,
        iLTEChannelBandwidth_SCC4,
        BSS_iDTCRFChannel_SCC4,
        iprmLTE_RMC_DL_NumRB_SCC4,
        iprmLTE_UDCH_DL_StartRB_SCC4,
        iprmLTE_DL_MCS_Index_0_SCC4,
        iprmLTE_DL_MCS_Index_5_SCC4,
        iprmLTE_DL_MCS_Index_1469_SCC4,
        iprmLTE_TDD_UDTTI_DL_TBSI_Left_SCC4,
        iprmLTE_CFI_SCC4,
        //iprmLAA_Mode_SCC4,
        //iprmPartialSubFrameMCS_Index_SCC4,
        iprmLTE_SCell_Cycle_SCC4,
        iprmLTE_RMC_UL_NumRB_SCC4,
        iprmLTE_UDCH_UL_StartRB_SCC4,
        iprmLTE_UL_MCS_Index_SCC4,
        iprmLTE_PDSCH_OffsetPA_SCC4,
        iprmLTE_PDSCH_RatioIdxPB_SCC4,
        iprmLTE_TXXOutputPort_SCC4,
        iprmNormalizationMethod,

        // For Asymmetric Channel Bandwith
        iBandWidth_NR_UL_CELL1,
        iBandWidth_NR_UL_CELL2,
        iBandWidth_NR_UL_CELL3,
        iBandWidth_NR_UL_CELL4,
        iprmNR_AsymmetricChannelBW,

        iprmTDD_Config_Common_PatternConfig,
        iprmTDD_Config_Common_Periodicity_PAT12,
        iprmTDD_Config_Common_DL_Duration_PAT2,
        iprmTDD_Config_Common_UL_Duration_PAT2,
        iprmNR_Scheduling_TDDPattern_DLSymbols_PAT2,
        iprmNR_Scheduling_TDDPattern_ULSymbols_PAT2,
        iprmNR_FreqBandListFilterFlag,
        iprmLTE_FreqBandListFilterFlag,
        iprmNotActivateNR_InNSA,
        iprmEnablePowerClass1_5,

        iprmNR_Basetion_CA_Mode_Uplink,
        iprmNR_Basetion_CA_SensMeasMode_Uplink,
        iprmNR_AsymmetricChannelBW_SCC1,
        iprmNR_AsymmetricChannelBW_SCC2,
        iprmNR_AsymmetricChannelBW_SCC3,
        iBandWidth_NR_UL_CELL1_SCC1,
        iBandWidth_NR_UL_CELL1_SCC2,
        iBandWidth_NR_UL_CELL1_SCC3,
        iHSPA_PSD_CQI_Level_SCC1,
        iHSPA_PSD_CQI_Level_SCC2,
        iHSPA_PSD_CQI_Level_SCC3,
        iprmULRMC_Waveform_SCC1,
        iprmULRMC_Waveform_SCC2,
        iprmULRMC_Waveform_SCC3,
        iprmLTE_UL_AggregationLevel_SCC1,
        iprmLTE_UL_AggregationLevel_SCC2,
        iprmLTE_UL_AggregationLevel_SCC3,
        iprmLTE_Use64QAM_UL_SCC1,
        iprmLTE_Use64QAM_UL_SCC2,
        iprmLTE_Use64QAM_UL_SCC3,
        iprmNR_tp_p2BPSK_SCC1,
        iprmNR_tp_p2BPSK_SCC2,
        iprmNR_tp_p2BPSK_SCC3,
        BSS_iDCCH_MAC_SCC1,
        BSS_iDCCH_MAC_SCC2,
        BSS_iDCCH_MAC_SCC3,
        iprmNR_TxConfig_SCC1,
        iprmNR_TxConfig_SCC2,
        iprmNR_TxConfig_SCC3,
        iprmPUSCH_Mapping_Type_SCC1,
        iprmPUSCH_Mapping_Type_SCC2,
        iprmPUSCH_Mapping_Type_SCC3,
        iprmPUSCH_Start_Symbol_SCC1,
        iprmPUSCH_Start_Symbol_SCC2,
        iprmPUSCH_Start_Symbol_SCC3,
        iprmPUSCH_Symbol_Length_SCC1,
        iprmPUSCH_Symbol_Length_SCC2,
        iprmPUSCH_Symbol_Length_SCC3,
        iprmPUSCH_DMRS_duration_SCC1,
        iprmPUSCH_DMRS_duration_SCC2,
        iprmPUSCH_DMRS_duration_SCC3,
        iprmPUSCH_Antenna_DCI_SCC1,
        iprmPUSCH_Antenna_DCI_SCC2,
        iprmPUSCH_Antenna_DCI_SCC3,
        iprmPUSCH_UL_DMRS_typeA_pos_SCC1,
        iprmPUSCH_UL_DMRS_typeA_pos_SCC2,
        iprmPUSCH_UL_DMRS_typeA_pos_SCC3,
        iprmPUSCH_UL_DMRS_add_pos_SCC1,
        iprmPUSCH_UL_DMRS_add_pos_SCC2,
        iprmPUSCH_UL_DMRS_add_pos_SCC3,
        iprmPUSCH_UL_DMRS_Config_Type_SCC1,
        iprmPUSCH_UL_DMRS_Config_Type_SCC2,
        iprmPUSCH_UL_DMRS_Config_Type_SCC3,
        iprmPUSCH_UL_DMRS_Scrambling_ID_SCC1,
        iprmPUSCH_UL_DMRS_Scrambling_ID_SCC2,
        iprmPUSCH_UL_DMRS_Scrambling_ID_SCC3,
        iprmPUSCH_N_ID_nSCID_SCC1,
        iprmPUSCH_N_ID_nSCID_SCC2,
        iprmPUSCH_N_ID_nSCID_SCC3,
        iprmPUSCH_Group_Hopping_SCC1,
        iprmPUSCH_Group_Hopping_SCC2,
        iprmPUSCH_Group_Hopping_SCC3,
        iprmPUSCH_Sequence_Hopping_SCC1,
        iprmPUSCH_Sequence_Hopping_SCC2,
        iprmPUSCH_Sequence_Hopping_SCC3,
        iprmPUSCH_UL_PTRS_SCC1,
        iprmPUSCH_UL_PTRS_SCC2,
        iprmPUSCH_UL_PTRS_SCC3,
        iprmPUSCH_K_PTRS_SCC1,
        iprmPUSCH_K_PTRS_SCC2,
        iprmPUSCH_K_PTRS_SCC3,
        iprmPUSCH_L_PTRS_SCC1,
        iprmPUSCH_L_PTRS_SCC2,
        iprmPUSCH_L_PTRS_SCC3,
        iprmPUSCH_PTRS_groups_SCC1,
        iprmPUSCH_PTRS_groups_SCC2,
        iprmPUSCH_PTRS_groups_SCC3,
        iprmPUSCH_PTRS_samples_per_group_SCC1,
        iprmPUSCH_PTRS_samples_per_group_SCC2,
        iprmPUSCH_PTRS_samples_per_group_SCC3,
        BSS_iPCL_SCC1,
        BSS_iPCL_SCC2,
        BSS_iPCL_SCC3,
        BSS_iMaxPCL_SCC1,
        BSS_iMaxPCL_SCC2,
        BSS_iMaxPCL_SCC3,
        iprmLTE_NOM_PUSCH_SCC1,
        iprmLTE_NOM_PUSCH_SCC2,
        iprmLTE_NOM_PUSCH_SCC3,
        iprmNR_AdditionalSpecEmissionOnOFF_SCC1,
        iprmNR_AdditionalSpecEmissionOnOFF_SCC2,
        iprmNR_AdditionalSpecEmissionOnOFF_SCC3,
        iprmNR_AdditionalSpecEmission_SCC1,
        iprmNR_AdditionalSpecEmission_SCC2,
        iprmNR_AdditionalSpecEmission_SCC3,
        iprmSS_PBCH_BLOCKPower_SCC1,
        iprmSS_PBCH_BLOCKPower_SCC2,
        iprmSS_PBCH_BLOCKPower_SCC3,

        iprmSlot1_RFRounting_TRx3,
        iprmSlot1_RFRounting_TRx4,
        iprmSlot2_RFRounting_TRx3,
        iprmSlot2_RFRounting_TRx4,
        iprmMT800A_033,
        iprmDivideFFByKR,            // Near to far-field conversion
        iprmStartAtClosestLimit,
        iprmWaitForPosReset,
        iprmNF2FFStepSizeMode,

        iprmPostProcessingSelection,   // New option to allow optional post processing selections in a test...

        // FARO scanner parameters
        iprmFARO_TargetType,
        iprmFARO_DistanceMode,
        iprmFARO_SightMode,
        iprmFARO1,
        iprmFARO2,
        iprmFARO3,

        // comment these out as used, don't delete!
        _iDummy0,            // placeholder--  comment/delete as we add
        _iDummy1,            // placeholder--  comment/delete as we add
        _iDummy2,            // placeholder--  comment/delete as we add
        _iDummy3,            // placeholder--  comment/delete as we add
        _iDummy4,            // placeholder--  comment/delete as we add
        _iDummy5,            // placeholder--  comment/delete as we add
        _iDummy6,            // placeholder--  comment/delete as we add
        _iDummy7,            // placeholder--  comment/delete as we add
        _iDummy8,            // placeholder--  comment/delete as we add
        _iDummy9,            // placeholder--  comment/delete as we add

        //INTEGER SECTION END
        //Append double types to the end of this section
        //DOUBLE SECTION START
        dStartFreqMHz,
        dStopFreqMHz,
        dSmoothAper,
        dGateSpanNS,
        dGateCenterNS,
        dCalibPowerdBm,
        dMeasurePowerdBm,
        dStepSize,  // changed from dTowerStepSize to better represent current use...
        dFineStep,
        dFineStepSize,
        dUpperLimit,
        dLowerLimit,
        dTransmitHeight,
        dSeparationDistance,
        dStepSize2, // changed from dTurntableStep to better represent current use
        dOrthoStep,
        dReceiveDiameter,
        dTransmitDiameter,
        dKFactor,
        dTemperature,
        dHumidity,
        dUpperLimit2, // changed from dUpperLimitTT to better represent use
        dLowerLimit2, // changed from dLowerLimitTT to better represent use
        dStabilityPauseSecs,
        dStabilityTolerance,
        dOutputPowerdBm,
        dCorConstant,
        dCenterFreqMHz,
        dSpanFreqMHz,
        dAntPortInpPwr,
        dTriggerLevelDB,
        dSweepTime,
        dCorConstantH,
        dCorConstantV,
        dTestDuration,
        dOutputReferenceLevel,
        BSS_dRAL_RFMaxLevel,
        BSS_dDCCHRFLevel,
        BSS_dDTCRFLevel,
        BSS_dOCRFLevel,
        BSS_dOutput1Attenuation,
        BSS_dOutput2Attenuation,
        BSS_dOutput3Attenuation,
        BSS_dOutputAttenuation,
        BSS_dInput1Attenuation,
        BSS_dInput2Attenuation,
        BSS_dInput4Attenuation,
        BSS_dInputAttenuation,
        dFreqOffsetMHz,
        dPositionerSkew,     // skew offset for continuous motion positioner movement
        dFilteredPulseWidth,
        dPositionerOffset,
        BSS_dUnusedRFLevel,  // relative level of unused GSM timeslots.
        BSS_dUsedRFLevel,  // dDTCRFLevel for used GSM timeslots.
        BSS_dGSMCCHRFLevel,// same as DCCHRFLevel, but GSM has slightly different command
        BSS_dDefaultMIN, // this could be a 34 bit integer, so store it as a double
        BSS_dAFAL_AFMaxLevel, // AF Analyzer max level
        BSS_dACCRFLevel,      // AMPS control channel RF level
        BSS_dCDMAPower,       // CDMA Power level
        BSS_dTrafficLevel,    // CDMA relative power level for traffic channel
        BSS_dPagingLevel,     // CDMA relative power level for paging
        BSS_dSyncLevel,       // CDMA relative power level for synchronization
        BSS_dPilotLevel,      // CDMA relative power level for pilot channel
        BSS_dOCNSLevel,       // CDMA relative power level for OCNS
        dTargetPosition,
        dPrecalSource1Power,
        dPrecalSource2Power,
        dPostcalSource1Power,
        dPostcalSource2Power,
        dFreqRangeDomainCent,
        dFreqRangeDomainSpan,
        BSS_dSensitivityThreshold,   // Sensitivity threshold (% BER/FER)
        BSS_dConfidenceLevel,        // Sensitivity BER/FER confidence level (%)
        BSS_dMaxSenseStep,           // Maximum attenuation/power level step
        BSS_dMinSenseStep,           // Minimum attenuation/power level step
        dPwrMeterRange,
        dSweepTimeoutPeriod,
        dAttenuationMin,
        dAttenuationStep,
        dAttenuationFineStep,
        dAttenuationMax,
        dThroughputLimitMbps,
        dThroughputVariationTolerance,
        dThroughputTimeToleranceFromMean,
        dCalibPowerdBm2,
        dMeasurePowerdBm2,
        BSS_dInitialSignalLevel,      // Initial signal level for sensitivity test.
        BSS_dSensitivityThreshold2,   // Sensitivity threshold (% BER/FER)
        BSS_dSensitivityThreshold3,   // Sensitivity threshold (% BER/FER)
        BSS_dSensitivityThreshold4,   // Sensitivity threshold (% BER/FER)
        BSS_dAGCHoldOffTime,          // AGC Holdoff time for BER measurements (GSM)
        BSS_dSyncHoldOffTime,         // Sync Holdoff time for BER measurements (GSM)
        BSS_dConfidenceMinTime,       // minimum test time for GSM BER.
        dPositionerTolerance1,
        dPositionerTolerance2,
        dPositionerAccuracyReq1,
        dPositionerAccuracyReq2,
        dGateSidelobeSuppress,
        BSS_dCDMA2k_CLDetect,          // CDMA2k Call Loss Detect
        BSS_dPCBitStepSize,            // CDMA2k Power Control Bit Step Size
        BSS_dFineSenseStep,           // Middle attenuation/power level step used once sense level is found
        dUpperHardLimit,
        dLowerHardLimit,
        dExpectedMaxSpeed,
        dOverSpeedTolerance,
        dUnderSpeedTolerance,
        dEncoderCalTarget,
        dEncoderCalRange,
        dEncoderCalTolerance,
        dTurntableDiameter,
        dFwdRevSpeedTolerance,
        dIgnoreStepsBelow,
        dExpectedMinSpeed,
        dMinSpdOverSpeedTolerance,
        dMinSpdUnderSpeedTolerance,
        dMinSpdFwdRevSpeedTolerance,
        dMinSpdTestSpan,
        dMaxSpdTestSpan,
        dRevMotionGlitchTolerance,
        dSigGenPowerdBm,
        dSigGenFreqMHz,
        dFilteredCeilingLevel,
        BSS_dAutoConnectRetryTime,     // retry time in seconds...
        dPolarizationSpeedMin,
        dPolarizationSpeedMax,
        dCorConstLogMag,
        dCorConstPhase,
        dChannelBandwidth,
        dFromFormattedBW,   //this is going to be from the analyzer baseframes and changes 30 MHZ for example into 30000000
        dModulationEnvelope,
        dFilterFlatnessTolerance,
        BSS_dBLER_Threshold,
        dMotorbaseLimitHysteresis,
        BSS_dMaxUEUplinkPwr,             // WCDMA Max. Allowed UE Power
        BSS_dTargetUEUplinkPwr,          // WCDMA Uplink Target Power
        BSS_dUplinkInterference,         // WCDMA Uplink Interference Level
        BSS_dPreambleConstant,           // WCDMA Initial Preamble Constant Value
        BSS_dReportedPCPICHPwr,          // WCDMA Reported P-CPICH Power
        BSS_dDPCCHPwrOffset,             // WCDMA DPCCH Power Offset
        BSS_dWCDMA_SSCH,                 // WCDMA Secondary Synchronization Channel (S-SCH) Level
        BSS_dWCDMA_PCCPCH,               // WCDMA Primary Common Control Physical Channel (P-CCPCH) Level
        BSS_dWCDMA_SCCPCH,               // WCDMA Secondary Common Control Physical Channel (S-CCPCH) Level
        BSS_dWCDMA_AICH,                 // WCDMA Acquisition Indicator Channel (AICH) Level
        BSS_dWCDMA_DPDCH,                // WCDMA Dedicated Physical Data Channel (DPDCH) Level
        BSS_dWCDMA_DPxCH_Offset,         // WCDMA DPCCH/DPDCH Power Offset
        BSS_dTCH_PwrRedLev1,         // TCH Power Red Level 1
        BSS_dTCH_PwrRedLev2,         // TCH Power Red Level 2
        BSS_dPDTCH_P0,               // PDTCH Power Reduction Reference
        BSS_dPDTCH_PRL1,            // PDTCH Power Reduction Level 1
        BSS_dPDTCH_PRL2,            // PDTCH Power Reduction Level 2
        BSS_dMSTXLevBurst1,              // PDTCH TX Level Burst 1
        BSS_dMSTXLevBurst2,              // PDTCH TX Level Burst 2
        BSS_dMSTXLevBurst3,              // PDTCH TX Level Burst 3
        BSS_dMSTXLevBurst4,              // PDTCH TX Level Burst 4
        BSS_dRecPowBurst1,            // Receiver Manual Power Burst 1
        BSS_dRecPowBurst2,            // Receiver Manual Power Burst 2
        BSS_dRecPowBurst3,            // Receiver Manual Power Burst 3
        BSS_dRecPowBurst4,            // Receiver Manual Power Burst 4
        dICPFlatnessPercentSpan,   // percent of span used for integrated channel power flatness spec (could be used elsewhere?)
        dFilteredFloorLevel,       // Used in place of trigger level for minimum valid level...
        dTriggerOffset,            // trigger offset for spectrum analyzers
        dTimedTestDuration,        // specified duration for a time based response test
        dTimedTestTimeStep,        // specified time step for a time based response test
        BSS_dAWGNPower,        // CDMA AWGN (additive white gaussian noise) power
        BSS_dMaxEIRP,           // CDMA Paging Max EIRP
        BSS_dFSCH,           // CDMA2000 Code Channel F-SCH Level
        BSS_dAmps_IntFMDev,
        BSS_dAmps_IntFMFreq,
        BSS_dGSM_P0_Offset,        // Offset between BCCH and TCH
        BSS_dWCDMA_OCNSLevel,
        BSS_dCDMA2k_SCHZero,
        BSS_dCDMA2k_QPCH,
        dTRPStepSize,        // for combined TRP/TIS tests
        dTISStepSize,        // for combined TRP/TIS tests
        BSS_dOccupiedBW,     // Occupied bandwidth in percent (power meas)
        BSS_dPwrDistPcnt,    // Power Distribution in percent (power meas)
        dTRPOuterStepSize,   // for combined TRP/TIS DA tests.
        dTISOuterStepSize,   // for combined TRP/TIS DA tests.
        BSS_dCPICHLev,          //CPICH Level
        BSS_dPCCPCHLev,         //P-CCPCH/SCH Level
        BSS_dSCCPCHLev,         //S-CCPCH Level
        BSS_dPICHLev,           //PICH Level
        BSS_dAICHLev,           //AICH Level
        BSS_dDPCHLev,           //DPCH Level
        BSS_dConCPICH,          //Connected CPICH Level
        BSS_dConPCCPCH,         //Connected P-CCPCH/SCH Level
        BSS_dConSecCCPCH,       //Connected S-CCPCH Level
        BSS_dConPICH,           //Connected PICH Level
        BSS_dConDPCH,           //Connected DPCH Level
        BSS_dHsdpaCPICH,        //Connected HSDPA CPICH Level
        BSS_dHsdpaPCCPCH,       //Connected HSDPA C-CCPCH/SCH Level
        BSS_dHsdpaSecCCPCH,     //Connected HSDPA S-CCPCH Level
        BSS_dHsdpaPICH,         //Connected HSDPA PICH Level
        BSS_dHsdpaAICH,         //Connected HSDPA DPCH Level
        BSS_dHsdpaSumActive,    //Sum of active connected HS-PDSCH Levels
        BSS_dHsdpaSCCH1,        //Connected HS-SCCH 1 Level
        BSS_dHsdpaSCCH2,        //Connected HS-SCCH 2 Level
        BSS_dHsdpaSCCH3,        //Connected HS-SCCH 3 Level
        BSS_dHsdpaSCCH4,        //Connected HS-SCCH 4 Level
        BSS_dMinSensTestTime,
        dFilterSmoothingFactor, //percentage filter smoothing factor
        BSS_dMeasFreq,          //EVDO - Meas Frequency
        BSS_dOffNom,            //EVDO - Nominal Pwr
        BSS_dOff9k6,            //EVDO - Data Offset 9k6
        BSS_dOff19k2,           //EVDO - Data Offset 19k2
        BSS_dOff38k4,           //EVDO - Data Offset 38k4
        BSS_dOff76k8,           //EVDO - Data Offset 76k8
        BSS_dOff153k6,          //EVDO - Data Offset 153k6
        BSS_dACKGain,           //EVDO - ACK Chan Gain
        BSS_dDRCGain,           //EVDO - DRC Chan Gain
        BSS_dAPARPwrStep,       //EVDO - Power Step
        dPacketDataRate,        //Data rate for transmitted packets
        dPacketInterval_ms,           //Interval between data packets in milliseconds
        dStartPower,            //for quantity vs power curve
        dStopPower,             //for quantity vs power curve
        dPowerStep,             //for quantity vs power curve
        dMaxPER,
        dFromFormattedVidBW,    //Video BW version of dFromFormattedBW - for changing string "30 MHz" to double 30000000.0
        TD_dStartTime,          // Start of time domain transform
        TD_dEndTime,             // End of time domain transform
        TD_dGateStartTime,      // Start of time domain gate
        TD_dGateEndTime,        // End of time domain gate
        TD_dVelocityFactor,     // velocity factor for distance display
        dMinAttainablePER,
        BSS_dRevStepSize,
        dRotationRoll,         //rotation around the x-axis
        dRotationPhi,          //rotation in phi angle (about z-axis)
        dRotationTheta,        //rotation in theta angle (about y-axis)
        dDeviceOpt01,           //generic double parameter
        dDeviceOpt02,           //generic double parameter
        dDeviceOpt03,           //generic double parameter
        dDeviceOpt04,           //generic double parameter
        dDeviceOpt05,           //generic double parameter
        dDeviceOpt06,           //generic double parameter
        dDeviceOpt07,           //generic double parameter
        dDeviceOpt08,           //generic double parameter
        dDeviceOpt09,           //generic double parameter
        dDeviceOpt10,           //generic double parameter
        dStartGain,           //for Range Extender Cal
        dStopGain,           //for Range Extender Cal
        dGainStep,           //for Range Extender Cal
        dStage2Pwr,           //for Range Extender Cal
        dStage3Pwr,           //for Range Extender Cal
        dStage2Gain,           //for Range Extender Cal
        dStage3Gain,           //for Range Extender Cal
                               // E6651 General
        BSS_dFrequency,
        BSS_dAmplitude,
        BSS_dInPowerOffset,
        BSS_dOutPowerOffset,
        BSS_dFreqOffset,
        // E6651 SPECTRUM MODE
        BSS_dSPOBW,
        // E6651 BS EMULATOR MODE
        BSS_dSamplingFrequency,
        BSS_dBSRNGRSP_TimeOffset,
        // Positioner Trigger Options
        POS_dPreTriggerDelay,      //Pre-Trigger Delay in ms w/resolution of .01 ms
        POS_dTriggerPulseLength,   //Trigger Pulse Length in ms w/resolution of .01 ms
        POS_dPostTriggerDelay,     //Post-Trigger Delay in ms w/resolution of .01 ms
        dStage2Atten,              //Attenuation for stage two of a measurement series
        dStage3Atten,              //Attenuation for stage three of a measurement series
        dFilterBandStart,
        dFilterBandEnd,

        BSS_dTemp0,           // Placeholder for E6651 values
        BSS_dTemp1,           // Placeholder for E6651 values
        BSS_dTemp2,           // Placeholder for E6651 values
        BSS_dTemp3,           // Placeholder for E6651 values
        BSS_dTemp4,           // Placeholder for E6651 values
        BSS_dTemp5,           // Placeholder for E6651 values
        BSS_dTemp6,           // Placeholder for E6651 values
        BSS_dTemp7,           // Placeholder for E6651 values
        BSS_dTemp8,           // Placeholder for E6651 values
        BSS_dTemp9,           // Placeholder for E6651 values
        BSS_dTDSCDMA0,         //placeholder for SP6116 TDSCDMA analyzer
        BSS_dTDSCDMA1,         //placeholder for SP6116 TDSCDMA analyzer
        BSS_dTDSCDMA2,         //placeholder for SP6116 TDSCDMA analyzer
        BSS_dTDSCDMA3,         //placeholder for SP6116 TDSCDMA analyzer
        BSS_dTDSCDMA4,         //placeholder for SP6116 TDSCDMA analyzer
        BSS_dTDSCDMA5,         //placeholder for SP6116 TDSCDMA analyzer
        BSS_dTDSCDMA6,         //placeholder for SP6116 TDSCDMA analyzer
        BSS_dTDSCDMA7,         //placeholder for SP6116 TDSCDMA analyzer
        BSS_dTDSCDMA8,         //placeholder for SP6116 TDSCDMA analyzer
        BSS_dTDSCDMA9,         //placeholder for SP6116 TDSCDMA analyzer
        BSS_dTDSCDMA10,         //placeholder for SP6116 TDSCDMA analyzer
        BSS_dTDSCDMA11,         //placeholder for SP6116 TDSCDMA analyzer
        BSS_dTDSCDMA12,         //placeholder for SP6116 TDSCDMA analyzer
        BSS_dTDSCDMA13,         //placeholder for SP6116 TDSCDMA analyzer
        BSS_dTDSCDMA14,         //placeholder for SP6116 TDSCDMA analyzer
        BSS_dTDSCDMA15,         //placeholder for SP6116 TDSCDMA analyzer
        dStabilityWindow,
        dPrimaryAngle,        //For labeling position of single cuts
        REM_dFilterWindowMhz,  //filter window for REM corrections
        TD_dXScaleFactor,      // Vector test time domain X scale velocity factor for distance
        TD_dXScaleSeparation,  // Vector test time domain separation distance for point-to-point mode
        TD_dXScaleAngle,       // Vector test time domain angle that points towards fixed antenna point
        TD_dCorrectValuesAbove, // Vector test time domain - Prevent correcting values above specified noise floor
        TD_dNoisePeriod,        // Vector test time domain - Value used when averaging noise
        dAGPSFineStepLimit,     // for GPS curve, when to stop using Fine Step and start using Min Step
        dAGPSPathLoss,          // path loss for GPS at 1572.42 MHz goes on equip page temporarily
        dAGPSLatReference,      // latitude reference point for AGPS
        dAGPSLongReference,     // longitude reference point for AGPS
        dICFrequency1,          // intermediate channel freq
        dICFrequency2,          // intermediate channel freq
        dICFrequency3,          // intermediate channel freq
        dICThetaPos1,           // intermediate channel theta position
        dICThetaPos2,           // intermediate channel theta position
        dICThetaPos3,           // intermediate channel theta position
        dICPhiPos1,             // intermediate channel phi position
        dICPhiPos2,             // intermediate channel phi position
        dICPhiPos3,             // intermediate channel phi position
        dICSenseRef1,           // intermediate channel sensitivity reference
        dICSenseRef2,           // intermediate channel sensitivity reference
        dICSenseRef3,           // intermediate channel sensitivity reference
        dICEIS1,                // intermediate channel sensitivity EIS
        dICEIS2,                // intermediate channel sensitivity EIS
        dICEIS3,                // intermediate channel sensitivity EIS
        dICTolerance1,          // intermediate channel tolerance for pass/fail results
        dICTolerance2,          // intermediate channel tolerance for pass/fail results
        dICTolerance3,          // intermediate channel tolerance for pass/fail results
        dPolarSlipLimit,        // max that position can slip during polarization
        dRSS_Position1,         // RSS Curve Position
        dRSS_Position2,         // RSS Curve Position
        dRSS_InitialPower,      // RSS Initial Power for curve
        dRSS_FinestepLimit,     // RSS Fine step limit for curve
        dRSS_Stepsize,          // RSS Step size for curve
        dRSS_Finestep,          // RSS Fine Step size for curve
        dRSS_PatternPower,      // RSS Pattern power level
        dRSS_TargetPower,       // RSS target power during linearization
        dAlternateCorFreqMhz,   // Alternative correction frequency to use instead of trace frequency
        dTriggerHoldoff,
        dDurationReference,     // reference level for calculation of pulse duration
        dGateOffset1,           // gate start time 1
        dGateLength1,           // gate length     1
        dGateOffset2,           // gate start time 2
        dGateLength2,           // gate length     2
        dGateOffset3,           // gate start time 3
        dGateLength3,           // gate length     3
        dGateOffset4,           // gate start time 4
        dGateLength4,           // gate length     4
        dSweepOffset,           //offset for sweep time start
        dMaxTraceLevel,         //max level for trace display (video max?)
        dTransitionReferenceLow,    //N1912 meas configutation
        dTransitionReferenceHigh,   //N1912 meas configutation
        dPositionerConfigOffset,    //"permanent" offset to positioner location
        dICDDatum,                  //Holds ICD results for transferring to post-processing
        dSimulatedRangeLength,  // simulated range length for vector analyzer
        dSimulatedSourcePower,  // simulated source power for vector analyzer
        dSimulatedPathLoss,     // additional path loss in simulated VNA scenario
        dSimulatedNoiseFloor,   // target noise floor for simulated signals
        dSimulatedRSSUpperLimit,  // target upper cutoff (lower limit will be noise floor) for RSS/SNR/CNR numbers
        dSimulatedRSSGranularity, // simulated RSS step size
        dSimulatedRSSParameter2,  // additional dummy parameters for various RSS based simulation--rename as needed
        dSimulatedRSSParameter3,  // additional dummy parameters for various RSS based simulation--rename as needed
        dRSS_NoiseFloorDelta,     //delta factor for determining when noise floor is hit in RSS search
        dRSS_MinPowerRange,       //minimum range of power for RSS I curve before warning is issued
        BSS_dULPadPwrCtlLevel,    //Power Control Level for UL Padding test (TRP)
        dSimulatedChannelOffset,  // offset between channels for polarization variation simulation
        dSimulatedFieldVolumeXMin, // Simulated field volume dimensions
        dSimulatedFieldVolumeXMax, // Simulated field volume dimensions
        dSimulatedFieldVolumeXStep, // Simulated field volume dimensions
        dSimulatedFieldVolumeYMin, // Simulated field volume dimensions
        dSimulatedFieldVolumeYMax, // Simulated field volume dimensions
        dSimulatedFieldVolumeYStep, // Simulated field volume dimensions
        dSimulatedFieldVolumeZMin, // Simulated field volume dimensions
        dSimulatedFieldVolumeZMax, // Simulated field volume dimensions
        dSimulatedFieldVolumeZStep, // Simulated field volume dimensions
        dSimulatedFieldVolumePhase, // Simulated field volume animation phase step
        dSimulatedFieldVolumeSource1X, // Source locations for reflections
        dSimulatedFieldVolumeSource1Y, // Source locations for reflections
        dSimulatedFieldVolumeSource1Z, // Source locations for reflections
        dSimulatedFieldVolumeSource2X, // Source locations for reflections
        dSimulatedFieldVolumeSource2Y, // Source locations for reflections
        dSimulatedFieldVolumeSource2Z, // Source locations for reflections
        dSimulatedCircularArrayRadius, // Simulated circular environment simulator array radius
        dSimulatedCircularArrayAngularOffset, // Angular offset of first sensor from zero (X axis)
        dSimulatedFieldVolumeDummy1, // Extras
        dSimulatedFieldVolumeDummy2, // Extras
        dSimulatedFieldVolumeDummy3, // Extras
        dSrcPwrAtBoresite1,
        dSrcPwrAtBoresite2,
        dSrcPwrAtBoresite3,
        dUseBestOrientationLimit,
        dTriggerDelay,
        dGateDelaySec,
        dGateDurationSec,
        dGateHoldoffSec,
        dAveInpAmp1,
        dAveInpAmp2,
        dAveInpAmp3,
        dAveInpAmp4,
        dAveInpAmp5,
        dAveInpAmp6,
        dAveInpAmp7,
        dAveInpAmp8,
        dReferenceOutputGain,
        dOutCorrectionAngle1,
        dOutCorrectionAngle2,
        dOutCorrectionAngle3,
        dOutCorrectionAngle4,
        dOutCorrectionAngle5,
        dOutCorrectionAngle6,
        dOutCorrectionAngle7,
        dAveOutGainOffset1,
        dAveOutGainOffset2,
        dAveOutGainOffset3,
        dAveOutGainOffset4,
        dAveOutGainOffset5,
        dAveOutGainOffset6,
        dAveOutGainOffset7,
        dAveOutGainOffset8,
        dInpCrestFactor,
        dMobileSpeedkph,
        dRefAveInputLevel,
        dTotalGain,
        dOutCorrectionAngle8,
        dNRPTimeSlotWidth,            //
        dNRPTimeSlotNumber,           //
        dNRPTimeGateTime,             //
        dNRPIntegrationTime,          //
        dNRPExcludeTimeStart,         //
        dNRPExcludeTimeEnd,           //
        dNRPDutyCycle,                //
        dNRPBurstDropoutTolerance,    //
        dNRPTimeGateOffset,           //
        dNRPReserved0,                 //
        dNRPReserved1,                 //
        dNRPReserved2,                 //
        dNRPReserved3,                 //
        dNRPReserved4,                 //
        dSourceCalPower,
        dChanEmulBandwidth,
        dEmulatorCenterFreq,
        dEmulatorLinkCableLength,
        dTDSCDMA_PrachPower,       //Desired PRACH Rx Power
        dTDSCDMA_TMSIVal,          //TMSI Value (huge - had to turn into a double)
        dSetInitialGain,
        dEmulatorStartingGain,
        dEmulatorEndingGain,
        dEmulatorGainStep,
        dReferencePhase,
        dPhaseOffset1,
        dPhaseOffset2,
        dPhaseOffset3,
        dPhaseOffset4,
        dPhaseOffset5,
        dPhaseOffset6,
        dPhaseOffset7,
        dPhaseOffset8,
        dMediaFLO_SampleClock,//MediaFLO Waveform Sample Clock Rate
        dInputCalSourcePwrLevel,
        dRSE_ExclusionZoneCenterMHz,
        dRSE_ExclusionZoneBandMHz,
        dChariotTestTime,
        dSafeNAPowerLevel,
        dNRPContAvAperture,
        dNRPContAvSampleRate,
        dNRPContAvDutyCycle,
        dAgpsDeltaT,
        dErrorRateTarget,
        dThroughputTargetKBPS,
        dGainMeasStart,
        dGainMeasStep,
        dGainMeasLimit,
        TD_dZeroOffset,        // Location of zero on time domain data
        TD_dprmBoresightThetaAngle,
        dprmTD_SmoothingWindowPercentage, // use this instead of point count...
        dThetaPosUpperLimit,
        dThetaPosLowerLimit,
        dThetaPosStep,
        dPhiPosUpperLimit,
        dPhiPosLowerLimit,
        dPhiPosStep,
        // Starting new naming convention from here on.  TDataAwareTypes (parameters)
        // are now labeled as <type>prmParameterName, e.g. dprmPhiPosStep
        // Carrying existing prefixes BSS_, TD_, etc. forward along with this is
        // acceptable, e.g. TD_dprmZeroOffset
        dprmFilterSegmentBuffer,    // Percentage of space to reserve at each filter segment to address timing flexibility...
        dprmMaximumCompressionTarget,
        dDisNLStoHOMELS,            // The distance between -LS and Home sensor (For ASDxx oriental motor Linear slide)
        dDisHOMELStoPLS,            // The distance between Home sensor and +LS (For ASDxx oriental motor Linear slide)
        dAsdSlideZeroOffset,        // The offset between original 0 (Home sensor) and user defined 0 (For ASDxx Linear slide)
        dAsdSlideSpeedOne,          // The speed one definition (For ASDxx Linear slide)
        dAsdSlideSpeedTwo,          // The speed two definition (For ASDxx Linear slide)
        dAsdSlideSpeedThree,        // The speed three definition (For ASDxx Linear slide)
        dAsdSlideSpeedFour,         // The speed four definition (For ASDxx Linear slide)
        dAsdSlideSpeedFive,         // The speed five definition (For ASDxx Linear slide)
        dAsdSlideSpeedSix,          // The speed six definition (For ASDxx Linear slide)
        dAsdSlideSpeedSeven,        // The speed seven definition (For ASDxx Linear slide)
        dAsdSlideSpeedEight,        // The speed eight definition (For ASDxx Linear slide)
                                    //Agilent 8960 HSPA+
                                    //---------------------
        dHSPA_EAGChanLevel,           //call:connected:eagchannel
        dHSPA_HSSCCH2_HSPALev,        //call:connected:hsscchannel2:hspa
        dHSPA_HSDPSCH_Level,          //call:connected:hspdschannel:hspa
        dHSPA_CPICHLev,               //call:conn:cpic:lev:hspa
        dHSPA_CCPCH_SecLev,           //call:conn:ccpc:sec:lev:hspa
        dHSPA_CCPCH_PrimLev,          //call:conn:ccpc:prim:lev:hspa
        dHSPA_PICH_Level,             //call:conn:pich:lev:hspa
        dHSPA_DPCH_Level,             //call:conn:dpch:lev:hspa
        dHSPA_HSSC1_Level,            //call:conn:hssc1:lev:hspa
        dHSPA_HSSC2_Level,            //call:conn:hssc2:lev:hspa
        dHSPA_HSSC3_Level,            //call:conn:hssc3:lev:hspa
        dHSPA_HSSC4_Level,            //call:conn:hssc4:lev:hspa
        dHSPA_HSPD_Level,             //call:conn:hspd:lev:hspa
        dHSPA_ERGC_Level,             //call:conn:ergc:lev:hspa
        dCEConnectPwr,
        //LTE (CMW 500)
        dprmLTE_PSS_Offset,           //PSS Power Offset
        dprmLTE_SSS_Offset,           //SSS Power Offset
        dprmLTE_PBCH_Offset,          //PBCH Power Offset
        dprmLTE_PCFICH_Offset,        //PCFICH Power Offset
        dprmLTE_PHICH_Offset,         //PHICH Power Offset
        dprmLTE_PDCCH_Offset,         //PDCCH Power Offset
                                      //LTE (Anritsu 8820C)
        dprmLTE_Input_Level,          //Input level
        dprmLTE_Main_UL,              //Main UL Loss
        dprmLTE_Main_DL,              //Main DL Loss

        dGoniometerRange,
        dSensorSpacing,

        //LTE (Anritsu MT8820C) - Part II
        dprmLTE_Aux_Loss,             //AUX Loss
        dprmLTE_P2_Main_UL,           //Phone-2 Main UL Loss
        dprmLTE_P2_Main1_DL,          //Phone-2 Main1 DL Loss
        dprmLTE_P2_Aux_Loss,          //Phone-2 AUX Loss

        dAsdDisNLStoHOMELS,           //ASD Motor Distance between NEG LS to Home LS
        dAsdDisHOMELStoPLS,           //ASD Motor Distance between POS LS to Home LS
        dAsdLowerLimit,               //ASD Motor lower limit
        dAsdUpperLimit,               //ASD Motor upper limit

        //LTE (CMW 500)
        dprmLTE_StaticChModel_h11abs, //Static Channel Model h11abs
        dprmLTE_StaticChModel_h21abs, //Static Channel Model h21abs

        //Goniometer/Ring settings
        dGoniometerMin,               //Minimum goniometer value (degrees)
        dGoniometerMax,               //Maximum goniometer value (degrees)
        dRingStartAngle,              //Most negative sensor position on theta ring
        dRingSpacingAngle,            //Spacing in degrees between sensors on the ring

        //Asd Moto Driver settings
        dAsdDefSpeed,                 //Default Speed
        dAsdMinSpeed,                 //Min Speed
        dAsdMaxSpeed,                 //Max Speed

        dprmLTE_ClosedLoopTgtPwr,     //LTE Closed Loop Target Power
        dprmLTE_ExpNomPwr,            //RF Power Uplink Expected Nominal Power
        dprmLTE_UserMargin,           //RF Power Uplink User Margin
        dCrossPolarizationRatio,      //For Antenna Correlation
        dprmThetaTheta0,              //For Antenna Correlation
        dprmThetaSigma,               //For Antenna Correlation
        dprmPhiTheta0,                //For Antenna Correlation
        dprmPhiSigma,                 //For Antenna Correlation

        dprmCMU_GPSInitialPower,      //CMU200 A-GPS Initial Power
        dprmCMU_GPSMax2DPosErr,       //CMU200 A-GPS Max 2D Pos. Error

        dICDFreqDatum,                  //ICD Frequency

        //Placeholders for future MT8820C settings
        dprmMT8820Cdummy1,
        dprmMT8820Cdummy2,
        dprmMT8820Cdummy3,
        dprmMT8820Cdummy4,
        dprmMT8820Cdummy5,
        dprmMT8820Cdummy6,
        dprmMT8820Cdummy7,
        dprmMT8820Cdummy8,
        dprmMT8820Cdummy9,
        dprmMT8820Cdummy10,
        dprmMT8820Cdummy11,
        dprmMT8820Cdummy12,
        dprmMT8820Cdummy13,
        dprmMT8820Cdummy14,
        dprmMT8820Cdummy15,

        dprmHsupaEHICHPower,
        dprmDwPCHPower,

        //HSPA CMU
        dBSS_HSPA_PLPL, //"HSUPA Puncturing Limit PLnon-max"
        dBSS_HSPA_QQUALMIN, //"Cell Reselection Information Qqualmin "
        dBSS_HSPA_QRXLEVMIN, //"Cell Reselection Information Qrxlevmin"
        dBSS_HSUPA_ERGH_LEV, //" E-RGCH/E-HICH "
        dBSS_HSUPA_EAGCH_LEV,  // " E-AGCH "
        dBSS_HSPD_LEV,         //HSPD Level

        //MT8820C GSM
        dprmBSSPowerControlLevel,   // MS Power COntrol Level
        dprmBSSPowerControlLevel1,  // MS Power Control Level Slot 1
        dprmBSSPowerControlLevel2,  // MS Power Control Level Slot 2
        dprmBSSPowerControlLevel3,  // MS Power Control Level Slot 3
        dprmBSSPowerControlLevel4,  // MS Power Control Level Slot 4
        dprmBSSPowerControlLevel5,  // MS Power Control Level Slot 5
        BSS_dSensitivityThreshold5, // Sensitivity Threshold
        dprmBSSDLSlotLevel0,        // Output Level Slot 0
        dprmBSSDLSlotLevel1,        // Output Level Slot 1
        dprmBSSDLSlotLevel2,        // Output Level Slot 2
        dprmBSSDLSlotLevel3,        // Output Level Slot 3
        dprmBSSDLSlotLevel4,        // Output Level Slot 4
        dprmBSSDLSlotLevel5,        // Output Level Slot 5
        dprmBSSDLSlotLevel6,        // Output Level Slot 6
        dprmBSSDLSlotLevel7,        // Output Level Slot 7

        dprmCallDropTimeOut,        //MT8820C Call drop timeout
        dprmInputLevelUpperLimit,   //MT8820C CDMA input level Upper Limit
        dprmF_FCHLevel,             //MT8820C CDMA F-FCH Level
        dprmF_SCH1Level,            //MT8820C CDMA F-SCH Level

        BSS_dPollPeriod,            //Bluetooth
        BSS_dInquiryDuration,       //Bluetooth

        dprmInput_LevelConn,  //MT8820C EVDO Input Level Connection
        dprmDSCGain,          //MT8820C EVDO DSC Gain
        dprmTxT2P,            //MT8820C EVDO TxT2P
        dprmTxT2P_Post,       //MT8820C EVDO TxT2P PostTransition

        dprmLTE_SNR_RF1,       //Signal to Noise Ratio (RF1)
        dprmLTE_SNR_RF2,       //Signal to Noise Ratio (RF2)

        dprmQZRadius,          // QZ/DUT radius
        dprmNF2FFParm1,        // Dummy for NF2FF if needed
        dprmNF2FFParm2,        // Dummy for NF2FF if needed

        dprmMotionDirStepSize,

        dChannelModelRefPwr,

        dAveInpAmp9,
        dAveInpAmp10,
        dAveInpAmp11,
        dAveInpAmp12,
        dAveInpAmp13,
        dAveInpAmp14,
        dAveInpAmp15,
        dAveInpAmp16,
        dAveOutGainOffset9,
        dAveOutGainOffset10,
        dAveOutGainOffset11,
        dAveOutGainOffset12,
        dAveOutGainOffset13,
        dAveOutGainOffset14,
        dAveOutGainOffset15,
        dAveOutGainOffset16,
        dPhaseOffset9,
        dPhaseOffset10,
        dPhaseOffset11,
        dPhaseOffset12,
        dPhaseOffset13,
        dPhaseOffset14,
        dPhaseOffset15,
        dPhaseOffset16,
        dLowerLimit3,
        dUpperLimit3,
        dStepSize3,
        BSS_dMSTXLevBurst5,
        BSS_dMSTXLevBurst6,
        dBSS_RTVInpV,
        dBSS_RTVOutV,

        dprmCMW500_DLCSSlotLevelOffset,

        dprmCMW500_DLOffsetSlot0,
        dprmCMW500_DLOffsetSlot1,
        dprmCMW500_DLOffsetSlot2,
        dprmCMW500_DLOffsetSlot3,
        dprmCMW500_DLOffsetSlot4,
        dprmCMW500_DLOffsetSlot5,
        dprmCMW500_DLOffsetSlot6,
        dprmCMW500_DLOffsetSlot7,

        dprmECCPatternStepSize,
        dprmBSSUEReportInterval,

        dprmECC_SphericalThetaTilt,  // Spherical pattern origin (DUT tilt)
        dprmECC_SphericalPhiTilt,    // Spherical pattern origin (DUT tilt)
        dprmECC_Dummy0,                // More ECC parm placeholders
        dprmECC_Dummy1,
        dprmECC_Dummy2,

        dprmLTE_PUCCH_ClosedLoop_TargetPower,
        dCableCalValue, //PTW70 DRE

        dprmFieldMapCenterOffsetRadius, // For MIMO site validation field mapping calculation
        dprmFieldMapCenterOffsetAngle,  // For MIMO site validation field mapping calculation
        dprmFieldMapRingRadius,         // For MIMO site validation field mapping calculation
        dprmFieldMapExtra1,  // For MIMO site validation field mapping calculation
        dprmFieldMapExtra2,  // For MIMO site validation field mapping calculation

        dprmAWGN,            //Additive White Guassian Noise setting for SNR tests
        dprmSNRStart,
        dprmSNREnd,

        dAveInpAmp17,
        dAveInpAmp18,
        dAveInpAmp19,
        dAveInpAmp20,
        dAveInpAmp21,
        dAveInpAmp22,
        dAveInpAmp23,
        dAveInpAmp24,
        dAveInpAmp25,
        dAveInpAmp26,
        dAveInpAmp27,
        dAveInpAmp28,
        dAveInpAmp29,
        dAveInpAmp30,
        dAveInpAmp31,
        dAveInpAmp32,
        dAveOutGainOffset17,
        dAveOutGainOffset18,
        dAveOutGainOffset19,
        dAveOutGainOffset20,
        dAveOutGainOffset21,
        dAveOutGainOffset22,
        dAveOutGainOffset23,
        dAveOutGainOffset24,
        dAveOutGainOffset25,
        dAveOutGainOffset26,
        dAveOutGainOffset27,
        dAveOutGainOffset28,
        dAveOutGainOffset29,
        dAveOutGainOffset30,
        dAveOutGainOffset31,
        dAveOutGainOffset32,
        dPhaseOffset17,
        dPhaseOffset18,
        dPhaseOffset19,
        dPhaseOffset20,
        dPhaseOffset21,
        dPhaseOffset22,
        dPhaseOffset23,
        dPhaseOffset24,
        dPhaseOffset25,
        dPhaseOffset26,
        dPhaseOffset27,
        dPhaseOffset28,
        dPhaseOffset29,
        dPhaseOffset30,
        dPhaseOffset31,
        dPhaseOffset32,

        dprmSatelliteMinPwr, // minimum Satellite power for AGPS sensitivity

        dprmIC_TIS_LimLo,
        dprmIC_TIS_LimMed,
        dprmIC_TIS_LimHi,
        dprmIC_TIS_FS_Lo,
        dprmIC_TIS_FS_Med,
        dprmIC_TIS_FS_Hi,
        dprmIC_ErrorRateLim,
        dprmMACTXTriggerPulseValue,   //MAC TX Trigger Pulse Value
        dprmMACRXTriggerPulseValue,   //MAC RX Trigger Pulse Value
        dprmConfig_DegPerSec_Max,
        dprmConfig_DegPerSec_Min,
        dVSPosContinuousScanSpeed,
        dVSPosSteppedSpeed,
        dVSPosReturnSpeed,

        dSpeedRatio1,               //Reverb Chamber Positioner Speed Ratio
        dSpeedRatio2,               //Reverb Chamber Positioner Speed Ratio
        dSpeedRatio3,               //Reverb Chamber Positioner Speed Ratio
        dSpeedRatio4,               //Reverb Chamber Positioner Speed Ratio
        dSpeedRatio5,               //Reverb Chamber Positioner Speed Ratio
        dWindowHalfWidth,

        dINPhaseOffset01,
        dINPhaseOffset02,
        dINPhaseOffset03,
        dINPhaseOffset04,
        dINPhaseOffset05,
        dINPhaseOffset06,
        dINPhaseOffset07,
        dINPhaseOffset08,
        dINPhaseOffset09,
        dINPhaseOffset10,
        dINPhaseOffset11,
        dINPhaseOffset12,
        dINPhaseOffset13,
        dINPhaseOffset14,
        dINPhaseOffset15,
        dINPhaseOffset16,
        dINPhaseOffset17,
        dINPhaseOffset18,
        dINPhaseOffset19,
        dINPhaseOffset20,
        dINPhaseOffset21,
        dINPhaseOffset22,
        dINPhaseOffset23,
        dINPhaseOffset24,
        dINPhaseOffset25,
        dINPhaseOffset26,
        dINPhaseOffset27,
        dINPhaseOffset28,
        dINPhaseOffset29,
        dINPhaseOffset30,
        dINPhaseOffset31,
        dINPhaseOffset32,

        dReverbProbingStepSize,      //Reverb Probing Step Size
        dReverbFrameLength,          //Reverb Frame Length
        dReverbProbingErrorRate,     //Reverb Probing Target Error Rate
        dReverbRewind,               //Reverb Probing Rewind
        dThroughputMinStepSize,      //Reverb Probing Min Step Size
        dReverbMinRewind,            //Reverb Probing Min Rewind
        dGainMinMeasStart,           //Gain Power for Min Step Size Start
        dprmMinSNRStart,               //SNR for Min Step Size Start

        dRBWFilterCorrection,        // Integrated Channel Power filter correction -- Could be a global correction for SA readings, but...
        dReverbDegreePerPoint,       // Degree Per Poing informaion for Reverberation Chamber
        dNSA_Width,         //���� Width of chamber (ft or m)
        dNSA_Length,            //��� Length (ft or m)
        dNSA_Height,            //� Height (ft or m)
        dNSA_SrcDistanceLeftWall,           //� Source coordinate: distance from left wall (ft or m)
        dNSA_AUTDistanceLeftWall,           //)�� Antenna coordinate: distance from left wall (ft or m)
        dNSA_SrcDistanceFrontWall,          //�� Source coordinate: distance from front wall (ft or m)
        dNSA_AUTDistanceSrc,            //�� Antenna coordinate: distance from source (3, 5, or 10m)
        dNSA_QZDiameter,            //� Quiet Zone Diameter (m)
        dNSA_AUTHeight_Start,           //� Range (start-stop) for antenna height above floor (m)
        dNSA_AUTHeight_Stop,            //�� Range (start-stop) for antenna height above floor (m)
        dPrm_TPFineStepLimit,
        dNSA_SrcHeight,         //� Source height above floor
        dNSA_MaxRayLength,      //�� Maximum ray trace path length (ft or m)
        dPrm_ErrorFineStepLimit,
        dGainFineStep,
        dPrm_MinFrameTPLimit,
        dPrm_AWGN_BandWidth,
        dPrm_DUT_RecBandWidth,
        dprmFPACHLevel,

        dprmReverbCalAverageBandwith,
        dNSA_AUTXPosition_Start,            //� Range (start-stop) for antenna distance (m)
        dNSA_AUTXPosition_Stop,         //� Range (start-stop) for antenna distance (m)

        dInput_ReferencePhase,

        dCMW500_TX2_TX1_PowerRatio,

        dCMW500MeasurementTriggerThreshold,
        dprmClusterASD,               // Angular spread of cluser AOD
        dprmClusterASA,               // Angular spread of cluser AOA
        dprmModelMobileSpeed,         // Mobile speed in model (could potentially pull from CE driver?)
        dprmMobileDirectionOfTravel,  // DOT form mobile in model
        dprmModelXPR,                 // XPR setting for model
        dprmChannelEmulatorBandwidth, // bandwidth of CE filter
        dprmChannelModelParm1,            // a couple of dummies for expansion
        dprmChannelModelParm2,
        dprmMaxTPLimit,
        dprmPhaseStep,
        dprmPhaseTarget,
        dprmReverbTestTime,
        dPositionerCfgMin,           // Positioner Configuration Limit/Hardware Limit
        dPositionerCfgMax,           // Positioner Configuration Limit/Hardware Limit
        dPositionerCfgStep,          // Positioner Configuration Limit/Hardware Limit
        dICF_FilterSpan,
        dICF_ChannelBW,
        dICF_NoiseBW,
        dICF_RWBCorrection,
        dICF_NotchWindowOffset,
        dICF_NotchSpan,
        dBSS_HSPA_HBDCONDITION,
        //HSPA
        BSS_dHSPA_PH_ERGCH,   // Physical Channels E-RGCH
        BSS_dHSPA_PH_EHICH,   // Physical Channels E-HICH

        dprmLTE_Input_Level_SCC1,     //For MT8820C CA
        BSS_dCDMAPower_SCC1,
        BSS_dAWGNPower_SCC1,
        dprmLTE_Main_UL_SCC1,
        dprmLTE_Main_DL_SCC1,
        dprmLTE_Aux_Loss_SCC1,
        dprmLTE_P2_Main_UL_SCC1,
        dprmLTE_P2_Main1_DL_SCC1,
        dprmLTE_P2_Aux_Loss_SCC1,


        dprmLTE_Input_Level_SCC2,
        BSS_dCDMAPower_SCC2,
        BSS_dAWGNPower_SCC2,
        dprmLTE_Main_UL_SCC2,
        dprmLTE_Main_DL_SCC2,
        dprmLTE_Aux_Loss_SCC2,
        dprmLTE_P2_Main_UL_SCC2,
        dprmLTE_P2_Main1_DL_SCC2,
        dprmLTE_P2_Aux_Loss_SCC2,

        // For MS2830A Demodulator
        dDeModulator_SymbolRate,
        dDeModulator_RollOff1,
        dDeModulator_RollOff2,
        dTimedTestDuration2,

        //LTE RRC State Transition
        dprmRRCInactivityTimer,

        //LTE RRC State Transition
        dprmReverbProcessingCenterFreq,
        dprmReverbProcessingFreqWindowSize,
        dprmCE_ClipPortPowerValue,
        dprmEMQuestBSInputLevelMargin,

        //Paramters for TD-SCDMA
        BSS_dMaxDPCHLevel,
        BSS_dMinDPCHLevel,
        BSS_dPCCPCHTxPower,
        BSS_dQltyDTCH,

        //CMW500 Carrier Aggregation
        BSS_dCDMAPower_CMW_SCC1,
        BSS_dCDMAPower_CMW_SCC2,
        BSS_dInput1Attenuation_CMW_SCC1,
        BSS_dInput1Attenuation_CMW_SCC2,
        BSS_dOutput1Attenuation_CMW_SCC1,
        BSS_dOutput1Attenuation_CMW_SCC2,
        BSS_dOutput2Attenuation_CMW_SCC1,
        BSS_dOutput2Attenuation_CMW_SCC2,
        dprmLTE_PSS_Offset_CMW_SCC1,
        dprmLTE_PSS_Offset_CMW_SCC2,
        dprmLTE_SSS_Offset_CMW_SCC1,
        dprmLTE_SSS_Offset_CMW_SCC2,
        dprmLTE_PBCH_Offset_CMW_SCC1,
        dprmLTE_PBCH_Offset_CMW_SCC2,
        dprmLTE_PCFICH_Offset_CMW_SCC1,
        dprmLTE_PCFICH_Offset_CMW_SCC2,
        dprmLTE_PHICH_Offset_CMW_SCC1,
        dprmLTE_PHICH_Offset_CMW_SCC2,
        dprmLTE_PDCCH_Offset_CMW_SCC1,
        dprmLTE_PDCCH_Offset_CMW_SCC2,
        BSS_dAWGNPower_CMW_SCC1,
        BSS_dAWGNPower_CMW_SCC2,
        dprmLTE_StaticChModel_h11abs_CMW_SCC1,
        dprmLTE_StaticChModel_h11abs_CMW_SCC2,
        dprmLTE_StaticChModel_h21abs_CMW_SCC1,
        dprmLTE_StaticChModel_h21abs_CMW_SCC2,
        dChannelBandwidth_DL_CMW_SCC1,
        dChannelBandwidth_DL_CMW_SCC2,
        dGainMaxStep,
        dprmCoherenceBandwithThreshold,
        dDefaultFloorLevel,
        dUserAccessPosition,
        dRSS_EIS_Compensation,
        dprmLTE_AuxX_Loss_SCC1,
        dprmLTE_P2_AuxX_Loss_SCC1,
        dprmLTE_AuxX_Loss_SCC2,
        dprmLTE_P2_AuxX_Loss_SCC2,
        xyarm_X_Origin,
        xyarm_Y_Origin,
        xyarm_XY_Maximum,
        xyarm_RotateMin,
        xyarm_RotateMax,
        xyarm_RotateOffset,
        xyarm_Radius,
        dprmGainStabilityWindow,
        dprmOCNG_LAMBDA,
        dprmOCNG_LAMBDA_SCC1,
        dprmOCNG_LAMBDA_SCC2,
        dprmOCNG_LAMBDA_SCC3,
        dprmAGNSSEISOffset,
        dprmDielectricMaterialConstant,
        dprm_SS1,
        dprm_SS2,
        dprm_SS3,
        dprm_SS4,
        dprm_SS5,
        dprm_SS6,
        dprm_SS7,
        dprm_SS8,
        dprm_RPM1,
        dprm_RPM2,
        dprm_RPM3,
        dprm_RPM4,
        dprm_RPM5,
        dprm_RPM6,
        dprm_RPM7,
        dprm_RPM8,
        dprm_MBT_AccuracyTarget,
        dprm_WLAN_Adjustable_Power1,
        dprm_WLAN_Adjustable_Power2,
        dprmAveInpAmp33,
        dprmAveInpAmp34,
        dprmAveInpAmp35,
        dprmAveInpAmp36,
        dprmAveOutGainOffset33,
        dprmAveOutGainOffset34,
        dprmAveOutGainOffset35,
        dprmAveOutGainOffset36,
        dprmPhaseOffset33,
        dprmPhaseOffset34,
        dprmPhaseOffset35,
        dprmPhaseOffset36,
        dprmINPhaseOffset33,
        dprmINPhaseOffset34,
        dprmINPhaseOffset35,
        dprmINPhaseOffset36,
        dprm_ReferenceLevel,
        dprmSIRExtrapoPnts,
        dprmReverbUtility_Kp,

        dprmOutput2Attenuation_3,
        dprmOutput2Attenuation_4,
        dprmRFPowValTriggerOffset,
        dprmAnalyzerSweepTime,//read back from equipment in tests
        dprmMaxPortPowerLimit,
        dprmGNSS_ResponseTime,
        dprmIF_Frequency,
        dprmCoherenceBandwithCenterFreq,
        dprmCoherenceBandwithBW,
        dprmAttenuation1,
        dprmAttenuation2,
        dprmAttenuation3,
        dprmAttenuation4,
        dprmAttenuation5,
        dprmAttenuation6,
        dprmAttenuation7,
        dprmAttenuation8,
        dprmAttenuation9,
        dprmAttenuation10,
        dprmAttenuation11,
        dprmAttenuation12,
        dprmAttenuation13,
        dprmAttenuation14,
        dprmAttenuation15,
        dprmAttenuation16,
        dprmAFSMeaurementPowerLevel,
        dprmLTE_P3_Main_UL,
        dprmLTE_P3_Main1_DL,
        dprmLTE_P3_Aux_Loss,
        dprmLTE_P4_Main_UL,
        dprmLTE_P4_Main1_DL,
        dprmLTE_P4_Aux_Loss,

        dChannelBandwidth_DL_CMW_SCC3,
        dprmLTE_Input_Level_SCC3,
        BSS_dCDMAPower_SCC3,
        BSS_dAWGNPower_SCC3,
        dprmLTE_Main_UL_SCC3,
        dprmLTE_Main_DL_SCC3,
        dprmLTE_Aux_Loss_SCC3,
        dprmLTE_P2_Main_UL_SCC3,
        dprmLTE_P2_Main1_DL_SCC3,
        dprmLTE_P2_Aux_Loss_SCC3,
        dprmLTE_AuxX_Loss_SCC3,
        dprmLTE_P2_AuxX_Loss_SCC3,
        dprmLTEChannelBandwidth_DL_CMW_SCC3,
        dprmLTE_PSS_Offset_SCC1,
        dprmLTE_SSS_Offset_SCC1,
        dprmLTE_PBCH_Offset_SCC1,
        dprmLTE_PCFICH_Offset_SCC1,
        dprmLTE_PHICH_Offset_SCC1,
        dprmLTE_PDCCH_Offset_SCC1,
        dprmLTE_PSS_Offset_SCC2,
        dprmLTE_SSS_Offset_SCC2,
        dprmLTE_PBCH_Offset_SCC2,
        dprmLTE_PCFICH_Offset_SCC2,
        dprmLTE_PHICH_Offset_SCC2,
        dprmLTE_PDCCH_Offset_SCC2,
        dprmLTE_PSS_Offset_SCC3,
        dprmLTE_SSS_Offset_SCC3,
        dprmLTE_PBCH_Offset_SCC3,
        dprmLTE_PCFICH_Offset_SCC3,
        dprmLTE_PHICH_Offset_SCC3,
        dprmLTE_PDCCH_Offset_SCC3,
        dprmFilterPulseWindow,
        dprmLTE_StaticChModel_h31abs,
        dprmLTE_StaticChModel_h41abs,
        dprmLTE_StaticChModel_h12abs,
        dprmLTE_StaticChModel_h22abs,
        dprmLTE_StaticChModel_h32abs,
        dprmLTE_StaticChModel_h42abs,
        dprmLTE_StaticChModel_h13abs,
        dprmLTE_StaticChModel_h23abs,
        dprmLTE_StaticChModel_h33abs,
        dprmLTE_StaticChModel_h43abs,
        dprmLTE_StaticChModel_h14abs,
        dprmLTE_StaticChModel_h24abs,
        dprmLTE_StaticChModel_h34abs,
        dprmLTE_StaticChModel_h44abs,
        dprmLTE_DTXThreshold_Probing,
        dprmLTE_DTXThreshold_Sens_Throughput,

        BSS_dCDMAPower_CMW_SCC3,
        BSS_dInput1Attenuation_CMW_SCC3,
        BSS_dOutput1Attenuation_CMW_SCC3,
        BSS_dOutput2Attenuation_CMW_SCC3,
        dprmLTE_PSS_Offset_CMW_SCC3,
        dprmLTE_SSS_Offset_CMW_SCC3,
        dprmLTE_PBCH_Offset_CMW_SCC3,
        dprmLTE_PCFICH_Offset_CMW_SCC3,
        dprmLTE_PHICH_Offset_CMW_SCC3,
        dprmLTE_PDCCH_Offset_CMW_SCC3,
        BSS_dAWGNPower_CMW_SCC3,
        dprmLTE_StaticChModel_h11abs_CMW_SCC3,
        dprmLTE_StaticChModel_h21abs_CMW_SCC3,
        dprmRMCFrequencyOffset_DL,
        dprmRMCFrequencyOffset_UL,
        dprmBeamformingDummy1,
        dprmBeamformingDummy2,
        dprmBeamformingDummy3,
        dprmNB_IOT_DL_Freq,
        dprmNB_IOT_DL_NB_IOT_LTE_Offset,

        dprm_TargetPwrRef_NR_C1, // Reference Power
        dprm_TargetPwrRef_NR_C2,
        dprm_TargetPwrRef_NR_C3,
        dprm_TargetPwrRef_NR_C4,

        dprm_ExpectedULPwr_CELL1,
        dprm_ExpectedULPwr_CELL2,
        dprm_ExpectedULPwr_CELL3,
        dprm_ExpectedULPwr_CELL4,

        // NR SSB
        dprmNR_SSB_PSSPowerLvl,
        dprmNR_SSB_SSSPowerLvl,
        dprmNR_SSB_Frequecy,
        dprmNR_SSB_PBCH_PowerLvl,
        dprmNR_SSB_PBCH_DMRSPowerLvl,

        dprmSlot1_TRX1_MainUL,
        dprmSlot1_TRX1_MainDL,
        dprmSlot1_TRX1_AUX,
        dprmSlot1_TRX2_MainUL,
        dprmSlot1_TRX2_MainDL,
        dprmSlot1_TRX2_AUX,
        dprmSlot1_TRX1_Converter1_UL,
        dprmSlot1_TRX1_Converter1_DL,
        dprmSlot1_TRX1_Converter2_DL,
        dprmSlot1_TRX1_Converter2_UL,

        dprmSlot2_TRX1_MainUL,
        dprmSlot2_TRX1_MainDL,
        dprmSlot2_TRX1_AUX,
        dprmSlot2_TRX2_MainUL,
        dprmSlot2_TRX2_MainDL,
        dprmSlot2_TRX2_AUX,
        dprmSlot2_TRX1_Converter1_UL,
        dprmSlot2_TRX1_Converter1_DL,
        dprmSlot2_TRX1_Converter2_UL,
        dprmSlot2_TRX1_Converter2_DL,

        dprmMeasurementTriggerLevel,
        dprmSpectrumMonitor_Trigger_Level,
        dprmSpectrumMonitor_Trigger_Delay,

        dprmSlot1_TRX2_Converter1_UL,
        dprmSlot1_TRX2_Converter1_DL,
        dprmSlot1_TRX2_Converter2_DL,
        dprmSlot1_TRX2_Converter2_UL,

        dprmSlot2_TRX2_Converter1_UL,
        dprmSlot2_TRX2_Converter1_DL,
        dprmSlot2_TRX2_Converter2_UL,
        dprmSlot2_TRX2_Converter2_DL,
        dprmGNSS_ResponseTimeLin,
        dprmSeparationDistance_2,
        dprmSeparationDistance_3,
        dprmAntennaRadius_1,
        dprmAntennaRadius_2,
        dprmAntennaRadius_3,
        dprmNRBandwidthPerRB,
        dprmNRFreqOffsetWithStart0DL,
        dprmNRFreqOffsetWithStart0UL,

        // UCSD Array Control Parameters
        dprmArray_ElevationStart,
        dprmArray_ElevationStop,
        dprmArray_ElevationStep,
        dprmArray_AzimuthStart,
        dprmArray_AzimuthStop,
        dprmArray_AzimuthStep,
        dprmArray_TXPAGainStart,
        dprmArray_TXPAGainStop,
        dprmArray_TXPAGainStep,
        dprmArray_TXVGAGainStart,
        dprmArray_TXVGAGainStop,
        dprmArray_TXVGAGainStep,
        dprmArray_RXVGAGainStart,
        dprmArray_RXVGAGainStop,
        dprmArray_RXVGAGainStep,
        dprmArray_RXLNAGainStart,
        dprmArray_RXLNAGainStop,
        dprmArray_RXLNAGainStep,
        dprmArray_PhaseStart,
        dprmArray_PhaseStop,
        dprmArray_PhaseStep,
        dprmArray_Frequency,
        dprmFR2_BeamPeakPrimaryAngle,
        dprmFR2_BeamPeakSecondaryAngle,
        dprmFR2_BeamPeakRepositionAngle1,
        dprmFR2_BeamPeakRepositionAngle2,
        dprmAGNSS_L1L5PowerOffset,
        dprmAGNSS_L1L5PowerOffset2,
        dprmGNSS_CNoDeviation,    // Allowable C/No deviation
        dprmGNSS_AvgCNoDeviation, // Allowable Average C/No deviation
        /*
        dprmArray_Start,
        dprmArray_Stop,
        dprmArray_Step,
        */

        dprmNRQ6TimeSlotWidth,
        dprmNRQ6TimeSlotNumber,
        dprmNRQ6TimeGateTime,
        dprmNRQ6IntegrationTime,
        dprmNRQ6ExcludeTimeStart,
        dprmNRQ6ExcludeTimeEnd,
        dprmNRQ6DutyCycle,
        dprmNRQ6BurstDropoutTolerance,
        dprmNRQ6TimeGateOffset,
        dprmNRQ6ContAvAperture,
        dprmNRQ6ContAvSampleRate,
        dprmNRQ6ContAvDutyCycle,
        dprmNRQ6Reserved0,
        dprmNRQ6Reserved1,
        dprmNRQ6Reserved2,
        dprmNRQ6Reserved3,
        dprmNRQ6Reserved4,

        dprmDesignTiltAngle,

        dprmRealtimeCorTarget,
        dprmFR2_QZRadius,
        dprmFR2_QZXtilt,
        dprmFR2_QZYtilt,
        dprmRealtimeCorMaxPwr,

        dprmUoHNF2FFScale,
        dprmUoHNF2FFOffset,

        dprmNRBandwidthPerRB_NR_SCC1,
        dprmNRBandwidthPerRB_NR_SCC2,
        dprmNRBandwidthPerRB_NR_SCC3,
        dprmNRFreqOffsetWithStart0DL_NR_SCC1,
        dprmNRFreqOffsetWithStart0DL_NR_SCC2,
        dprmNRFreqOffsetWithStart0DL_NR_SCC3,
        dprmChannelBandwidthInTesting,
        dprmBaseStationPwrLvlInTesting,

        dprmRMSTraceSpan,

        dprmLTEChannelBandwidth_DL_CMW_SCC4,
        dprmLTE_Input_Level_SCC4,
        BSS_dCDMAPower_SCC4,
        BSS_dAWGNPower_SCC4,
        dprmLTE_Main_UL_SCC4,
        dprmLTE_Main_DL_SCC4,
        dprmLTE_Aux_Loss_SCC4,
        dprmLTE_P2_Main_UL_SCC4,
        dprmLTE_P2_Main1_DL_SCC4,
        dprmLTE_P2_Aux_Loss_SCC4,
        dprmLTE_AuxX_Loss_SCC4,
        dprmLTE_P2_AuxX_Loss_SCC4,
        dprmLTE_PSS_Offset_SCC4,
        dprmLTE_SSS_Offset_SCC4,
        dprmLTE_PBCH_Offset_SCC4,
        dprmLTE_PCFICH_Offset_SCC4,
        dprmLTE_PHICH_Offset_SCC4,
        dprmLTE_PDCCH_Offset_SCC4,
        dprmOCNG_LAMBDA_SCC4,

        dprmPostProcessingDuration,
        dprmNRBandwidthPerRB_NR_SCC1_Uplink,
        dprmNRFreqOffsetWithStart0DL_NR_SCC1_Uplink,
        dprmNRBandwidthPerRB_NR_SCC2_Uplink,
        dprmNRFreqOffsetWithStart0DL_NR_SCC2_Uplink,
        dprmNRBandwidthPerRB_NR_SCC3_Uplink,
        dprmNRFreqOffsetWithStart0DL_NR_SCC3_Uplink,
        dprmNRFreqOffsetWithStart0UL_SCC1,
        dprmNRFreqOffsetWithStart0UL_SCC2,
        dprmNRFreqOffsetWithStart0UL_SCC3,

        dprmSlot1_TRX3_MainUL,
        dprmSlot1_TRX3_MainDL,
        dprmSlot1_TRX3_AUX,
        dprmSlot1_TRX4_MainUL,
        dprmSlot1_TRX4_MainDL,
        dprmSlot1_TRX4_AUX,
        dprmSlot2_TRX3_MainUL,
        dprmSlot2_TRX3_MainDL,
        dprmSlot2_TRX3_AUX,
        dprmSlot2_TRX4_MainUL,
        dprmSlot2_TRX4_MainDL,
        dprmSlot2_TRX4_AUX,

        dprmUoHNF2FFThetaStep,
        dprmUoHNF2FFPhiStep,

        dprmFARO_TargetDiameter,
        dprmFARO_TargetOffset,
        dprmFARO1,
        dprmFARO2,
        dprmFARO3,

        dprm_TDNormPDPTimeOffset,


        //
        //  PLEASE add all new parameters above this line using the dprmXxxx naming convention
        //


        // comment these out as used, don't delete!
        _dDummy0,            // placeholder--  comment/delete as we add
        _dDummy1,            // placeholder--  comment/delete as we add
        _dDummy2,            // placeholder--  comment/delete as we add
        _dDummy3,            // placeholder--  comment/delete as we add
        _dDummy4,            // placeholder--  comment/delete as we add
        _dDummy5,            // placeholder--  comment/delete as we add
        _dDummy6,            // placeholder--  comment/delete as we add
        _dDummy7,            // placeholder--  comment/delete as we add
        _dDummy8,            // placeholder--  comment/delete as we add
        _dDummy9,            // placeholder--  comment/delete as we add
                             //DOUBLE SECTION END

        //Append bool types to the end of this section
        //(append windows BOOL type to int)
        //BOOLEAN SECTION START
        bAverageOn,
        bSmoothingOn,
        bUseGate,
        bSteptower,
        bFineStep,
        bRangePause,
        bFreqPause,
        bLowerAfterPt,
        bUseTower,
        bTwoAntenna,
        bGenDualAF,
        bUseDualAF,
        bMultiDataset,
        bEdMax,
        bUseNSA,
        bFreqDoubler,
        bUseOpenConnector,
        bPort1Male,
        bPort2Male,
        bTimeDomain,
        bAutoBW,
        bThreeAntenna,
        bAllowMultiRanges,
        bDualChannel,// indicates dual channel (two port) measurement desired
        bStabTolerance,
        bAllowStepMode,
        bRelative_Absolute, // Make relative (true) or absolute (false) measurements
        bAutoSweep,
        bAutoAttenuation,
        bUseNewCmds,         // flag for 85XX spectrum analyzers to use old/new cmd set
        BSS_bSS_SUFF_ON,                 // CMU 200 Base Station Simulator ids
        BSS_bRSS_AC_MIN_ON,
        BSS_bSOC_ON,
        BSS_bMCC_ON,
        BSS_bUseMSDefaults,
        BSS_bUseBSDefaults,
        BSS_bUseNetworkDefaults,
        BSS_bGetMobileSerialNumber,
        BSS_bGetMobileCapability,
        BSS_bRegistrationOnPowerUp,
        BSS_bRegistrationOnPowerDown,
        BSS_bRegistrationOnNewSystem,
        BSS_bRegistrationOnDeregistration,
        BSS_bRegistrationTimeout,
        bVideoAutoBW,
        bInvertFinalData,      // flag to optionally invert pattern data for TIS test
        bTxRxFlag,          // TX/RX flag for R&S inport utility
        bUseNotifyDefaults, // use notification configuration defaults
        bSMTPAlert,      // Email Notification
        bEmailAttach,      // Attach datafile to Email
        bPlayWave,      // Play wave file on measurement completion
        bWaveContinouse,   // Play above wave file in continouse loop
        bSinglePtPoles,   // fill secondary axes when primary = 0,180,360 and pri = elevation
        bEMailWarnings,      // Email Notification of warning dialogs
        bUseYWidthPrecision,
        bOptimizeClosePattern,
        bExtrapolatePoles,
        bUseActualPosReading,
        bUseDetector,
        BSS_bSignallingMode,     // Used for Qualcomm MediaFLO
        bDualTrigger,
        bReverseSinglePtPole,
        bSkipAncillaryState,
        bOverrideLimits,
        BSS_bDTX_ON,              // GSM Discontinuous Transmission mode
        BSS_bTestSetRLTimeout_ON, // allows turning off test set radiolink Timeout
        BSS_bMTCTimeout_ON,       // allows turning off MTC Timeout
        BSS_bRegistrationHome,    // Registration for home mobiles
        BSS_bRegistrationRoam,    // Registration for roaming mobiles
        BSS_bReadControlFiller,   // Read Control Filler Message
        bDeviceOpt1,
        bDeviceOpt2,
        bDeviceOpt3,
        bDeviceOpt4,
        bDeviceOpt5,
        bDeviceOpt6,
        bDeviceOpt7,
        bDeviceOpt8,
        bDeviceOpt9,
        bDeviceOpt10,
        BSS_bReleaseOnEnd,         // Release mobile at end of test
        bUseFreqRangeDomain,
        bExportDirectivity,
        bExportEfficiency,
        bExportGain,
        bExportMaxRipple,
        bExportRippleStdDev,
        bExportUncertainty,
        bExportRaw,
        bExportCorrectionType,
        bExportFileView,
        bExportFileOverwrite,
        bExportCut1,
        bExportCut2,
        bExportCut3,
        bExportCutsCombine,
        BSS_bAutoEstablish,         // Auto-dials phone without dialog (primarily CDMA)
        bStoreAxis,
        bUseElectronicCalModule,
        bToggleSwitchAtEachFreq,
        BSS_bCDMA2k_CLDetect_ON,          // CDMA2k Call Loss Detect enable
        BSS_bUseWildcard,                 // Use IMSI wildcard
        BSS_bAuthentication,              // Use Authentication
        bUseWirelessFreqTool,
        bEncoderCalTest,                  // motorbase sub-test types
        bMotionDirTest,
        bHardLimitTest,
        bMaxSpeedTest,
        bBurnInTest,
        bClearOvershootCompensation,
        bAbortRemainingTests,
        bViewRawData,
        bMinSpeedTest,                    // motorbase test
        bMotorbaseCal,                    // flags that this is a motorbase, not a finished device
        bReverseOutputShaft,          // flags that the output shaft goes CCW for the UP/CW direction
        bExportVSWR,
        BSS_bUseSoftAutoRange,      // use software auto range on CMU driver
        bMotionDirPostTest,
        bHardLimitPostTest,
        bEncoderCalPostTest,
        bMaxSpeedPostTest,
        bMinSpeedPostTest,
        bPolarizationTest,
        bPolarizationPostTest,
        BSS_bReCloseLoop,
        bSequentialPolTest,
        bHandControllerTest,
        bHandControllerPostTest,
        bRemoveFreqArrayOnSinglePt,
        bExportPassFail,
        BSS_bPauseForUserSettings,   // flag that we want to pause to allow the user to set some stuff up..
        BSS_bUplinkCRCEnable,         // WCDMA Uplink CRC Enable
        BSS_bWCDMA_DPDCH,             // WCDMA Dedicated Physical Data Channel (DPDCH) On/Off
        BSS_bUseRegChanAtReConnect,   // CMU go to registration channel before re-connecting, then back to currentchannel
        bUseFloorLevelForPulseDetect,  // Overrides default pulse behavior to search for pulse start/end using floor level instead of trigger level
        bUseMaxMarkerForDefault,    // Allows control of default behavior for pulsed measurements
        BSS_bCallLimiteMode,
        BSS_bAWGNState,             // CDMA AWGN State
        BSS_bLinkBCCH_TCCH,         // flag to link BCCH and TCCH for power settings
        BSS_bOCNSEnable,
        BSS_bProbeUsingBER,
        BSS_bDPCHState,         //DPCH State
        BSS_bConSecCCPCHState,  //S-CCPCH State
        BSS_bHsdpaSecCCPCHState,//S-CCPCH State
        BSS_bHsdpaSCCH2State,   //HS-SCCH 2 State
        BSS_bHsdpaSCCH3State,   //HS-SCCH 3 State
        BSS_bHsdpaSCCH4State,   //HS-SCCH 4 State
        bPromptUser,            // Prompt user for action
        BSS_bHsdpaSCCH1State,   //HS-SCCH 1 State
        b802_11_WEP,            // encryption on or off
        TD_bEnableTDTransform,   // enable time domain transform in vector post processing
        TD_bEnableTDGate,       // enable time domain gating in vector post processing
        TD_bBothFreqAndTime,    // display both frequency and time domain info
        TD_bUseDistance,        // display TD data as distance data
        TD_bReflectedDistance,  // divide distance by two (may do automatically)
        TD_bAutoTimeScale,      // automatically determine the time scale based on freq.
        bHasCorrections,       // for Range Extander, calibration file is present for use
        bUsingUserTXCal,       // for Range Extander, user had calibrated TX path through box
        bAmplifyRXPath,       // for Range Extander, switch amplification into the RX (return) path
        bSegmentedSweep,     //flag for segmented sweeps on NA's
        bThetaWeightedPhi,   //phi = sin(theta)
        bTXBypass,           //TX bypass path for DRE
        bWhitening,           //Data whitening, on/off, for Bluetooth
        bSwitchThenSweep,       // controls switch/sweep order for switch hybrids.
        bWatchPolarSlip,        // flag that we should watch for position slip during polarizations
        bExportCSV,           //Export data to csv format
        bStepDetection,       //Turn on and off step detection mode
        bVideoAverageOn,       //Turn on and off video averaging
        bSwapPolarizationChannels,
        bSimulateFieldVolume,
        bMirrorOnThetaAxis,     //Flip polarity of phi antenna about theta axis
        bMirrorOnPhiAxis,       //Flip polarity of theta antenna about phi axis

        bNRPTraceRealtime,
        bNRPZeroAtStart,
        bNRPUseDutyCycleCorrection,
        bNRPTriggerAuto,
        bNRPUseSmoothing,
        bNRPUseAveragePower,
        bNRPDisplayOFFDuringTest,
        bNRPGateUseFence,
        bNRPReserved1,
        bNRPReserved2,

        bChanEmulatorIterateThroughPorts,
        bChanEmulatorMeasureFrequency,
        bChanEmulatorMeasureSteps,
        bChanEmulatorUsePositioner1,
        bChanEmulatorUsePositioner2,
        bChanEmulatorMapOutputPorts,
        bChanEmulatorIterateGain,

        bCompleteSecondaryAxisVsFreq, //Measure secondary axis as a function of frequency
                                      // Starting new naming convention from here on.  TDataAwareTypes (parameters)
                                      // are now labeled as <type>prmParameterName, e.g. dprmPhiPosStep
                                      // Carrying existing prefixes BSS_, TD_, etc. forward along with this is
                                      // acceptable, e.g. TD_dprmZeroOffset

        //LTE (CMW 500)
        bprmLTE_NAS_Security,      //use NAS Security
        bprmLTE_AS_Security,       //use AS Security
        bprmLTE_Milenage,          //use Milenage algorithm
        bprmLTE_OCNG,              //enable OFDMA Channel Noise Generator
        bprmLTE_Testmode,          //enable Testmode message
        bprmLTE_DL_Padding,        //activate Downlink Padding

        bprmUseConstantLinearPositioner, // for CE validation.  Option to use radius dependent angle steps (constant linear steps)

        //LTE (CMW 500)
        bprmLTE_UseDLStream1SettingsRMC,   //Use DL Stream 1 settings for MIMO DL Stream 2 RMC
        bprmLTE_UseDLStream1SettingsUDCH,   //Use DL Stream 1 settings for MIMO DL Stream 2 UDCH
        bprmLTE_StaticChModelEnbl,  //Static Channel Model Enable
        bStepUntilCallDrop,
        bprmLTE_UEMsrRptEnbl,      //LTE UE Measurement Report Enable
        bprmLTE_UseAttachedForConnected,
        bprmLTE_UseDLStream1SettingsUDTTI,  //Use DL Stream 1 settings for DL Stream 2 UDTTI
        bprmLTE_PRACH_NoRespPreambles,      //PRACH No Response to Preambles
        bprmLTE_SoundingRS,        //Sounding RS (SRS)
        bprmLTE_UseExtAttenOut1,   //Use Output 1 External Attenuation for Output 2

        //Placeholders for future MT8820C settings
        bprmMT8820Cdummy1,
        bprmMT8820Cdummy2,
        bprmMT8820Cdummy3,
        bprmMT8820Cdummy4,
        bprmMT8820Cdummy5,
        bprmMT8820Cdummy6,
        bprmMT8820Cdummy7,
        bprmMT8820Cdummy8,
        bprmMT8820Cdummy9,
        bprmMT8820Cdummy10,
        bprmMT8820Cdummy11,
        bprmMT8820Cdummy12,
        bprmMT8820Cdummy13,
        bprmMT8820Cdummy14,
        bprmMT8820Cdummy15,

        //UE Blind Log Related.
        bprmUEBlindLogEnabled,
        //HSPA
        bBSS_HSPD_LEV_STATE,         //HSPD Level
        bBSS_AG_SCOPE,          //"HSUPA E-AGCH AG Pattern AG Scope"

        // MT8820C GSM
        bprmBSSOutLvlContinuous,   // Output Level Continuous
        bprmBSSVariableSlotDLLvl,  // Variable Slot Output Level
        bprmBSSRandomUSF,          // Random USF
        bprmBSSIncRedundancy,      // Inncremental Redundancy
        bprmBSSVariableSlotPCL,    // Variable Slot PCL

        //LTE (CMW 500, firmware 2.1.20)
        bprmLTE_KeepRRC_Connection,   //Keep RRC Connection

        bFrequencyHopping,            //Bluetooth toggle frequency hopping
        BluetoothUseEDR,              //Bluetooth Use Enhanced Data Rate

        bprmCMW500_LoopReclose,
        bprmCMW500_RepeatedFACCH,
        bprmCMW500_RepeatedSACCH,

        bprmCMW500_ULUsedSlot0,
        bprmCMW500_ULUsedSlot1,
        bprmCMW500_ULUsedSlot2,
        bprmCMW500_ULUsedSlot3,
        bprmCMW500_ULUsedSlot4,
        bprmCMW500_ULUsedSlot5,
        bprmCMW500_ULUsedSlot6,
        bprmCMW500_ULUsedSlot7,

        bprmCMW500_DLUsedSlot0,
        bprmCMW500_DLUsedSlot1,
        bprmCMW500_DLUsedSlot2,
        bprmCMW500_DLUsedSlot3,
        bprmCMW500_DLUsedSlot4,
        bprmCMW500_DLUsedSlot5,
        bprmCMW500_DLUsedSlot6,
        bprmCMW500_DLUsedSlot7,

        bprmCMW500_DLOffsetSlot0,
        bprmCMW500_DLOffsetSlot1,
        bprmCMW500_DLOffsetSlot2,
        bprmCMW500_DLOffsetSlot3,
        bprmCMW500_DLOffsetSlot4,
        bprmCMW500_DLOffsetSlot5,
        bprmCMW500_DLOffsetSlot6,
        bprmCMW500_DLOffsetSlot7,

        bprmCMW500_UseCSPCLForAllSlots,
        bprmCMW500_NoDLOffsetForAllSlots,

        bprmCMW500_AMRNBFR_CodecMode4,
        bprmCMW500_AMRNBFR_CodecMode3,
        bprmCMW500_AMRNBFR_CodecMode2,
        bprmCMW500_AMRNBFR_CodecMode1,

        bprmCMW500_AMRNBHR_CodecMode4,
        bprmCMW500_AMRNBHR_CodecMode3,
        bprmCMW500_AMRNBHR_CodecMode2,
        bprmCMW500_AMRNBHR_CodecMode1,

        bprmCMW500_AMRWBFR_CodecMode3,
        bprmCMW500_AMRWBFR_CodecMode2,
        bprmCMW500_AMRWBFR_CodecMode1,

        bprmLTE_TDD_UseDLStream1SettingsUDTTI,  //Use DL Stream 1 settings for DL Stream 2 UDTTI

        bprmLTE_UECategoryReported,
        bprmLTE_T3412Enabled,
        bUseCableCal, //PTW70 DRE

        bprmCountryCodeEnabled,                //Country Code Enabled
        bprmIQSWAPTx,                          //IQ SWAP TX
        bprmIQSWAPRx,                          //IQ SWAP RX
        bprmPacketGeneratorState,              //Packet Generator State
        bprmLTE_PDN1Enabled,                  // PDN 1 Enabled
        bprmLTE_PDN2Enabled,                  // PDN 2 Enabled
        bprmReverbEnableSmartMeas,            // Enable the Smart Measurement
        bprmVariableStepSize,                 // Enable the variable step size
        bReverb_CalculatePDP,                 //  Add all new parameters above this line using the bprmXxxx naming convention
        bReverb_CalculateG,                   //  Add all new parameters above this line using the bprmXxxx naming convention
        bHomeSensorTestPre,                  //  Add all new parameters above this line using the bprmXxxx naming convention
        bHomeSensorTestPost,                  //  Add all new parameters above this line using the bprmXxxx naming convention
        bChanEmulatorMapInputPorts,           //  Add all new parameters above this line using the bprmXxxx naming convention
        bChanEmulatorIterateInputPorts,        //  Add all new parameters above this line using the bprmXxxx naming convention
        bTurnOffBaseStation,                     //  Add all new parameters above this line using the bprmXxxx naming convention
        bExportTRPGain,                      //Sleeve Dipole Exports      //  Add all new parameters above this line using the bprmXxxx naming convention

        bprmMapInputPortAngleData,            // Allows remapping output data X axis in CE validation test
        bprmMapOutputPortAngleData,
        bExportSystemRangeLoss,                      //Sleeve Dipole Exports      //  Add all new parameters above this line using the bprmXxxx naming convention

        BSS_bAWGNState_SCC1,                 //For MT8820C CA
        BSS_bAWGNState_SCC2,

        //CMW500 Carrier Aggregation
        bprmLTE_StaticChModelEnbl_CMW_SCC1,
        bprmLTE_StaticChModelEnbl_CMW_SCC2,
        BSS_bAWGNState_CMW_SCC1,
        BSS_bAWGNState_CMW_SCC2,
        bprmLTE_OCNG_CMW_SCC1,
        bprmLTE_OCNG_CMW_SCC2,
        bprmLTE_UseExtAttenOut1_CMW_SCC1,
        bprmLTE_UseExtAttenOut1_CMW_SCC2,
        bprmLTE_UseDLStream1SettingsRMC_CMW_SCC1,
        bprmLTE_UseDLStream1SettingsRMC_CMW_SCC2,
        bprmLTE_UseDLStream1SettingsUDCH_CMW_SCC1,
        bprmLTE_UseDLStream1SettingsUDCH_CMW_SCC2,
        bprmLTE_UseDLStream1SettingsUDTTI_CMW_SCC1,
        bprmLTE_UseDLStream1SettingsUDTTI_CMW_SCC2,
        bprmLTE_TDD_UseDLStream1SettingsUDTTI_CMW_SCC1,
        bprmLTE_TDD_UseDLStream1SettingsUDTTI_CMW_SCC2,

        bprm_MBT_SoftlimitTest_1,//pre-burnin
        bprm_MBT_SoftlimitTest_2,//post-burn in
        bprm_MBT_Tracking_1,
        bprm_MBT_Tracking_2,
        bprm_MBT_SystemTemp_1,
        bprm_MBT_SystemTemp_2,
        bprm_MBT_TriggerTest_1,
        bprm_MBT_TriggerTest_2,
        bprm_MBT_AccuracyTest_1,
        bprm_MBT_AccuracyTest_2,
        bprm_bInitialized,
        bprm_MBT_ParameterTest,
        BSS_bAWGNState_SCC3,        //For SCC-3, added to keep up with the same convention.

        bprmLTE_StaticChModelEnbl_CMW_SCC3,  //Still to have to add it to keep the logic unchanged.
        BSS_bAWGNState_CMW_SCC3,
        bprmLTE_OCNG_CMW_SCC3,
        bprmLTE_UseExtAttenOut1_CMW_SCC3,
        bprmLTE_UseDLStream1SettingsRMC_CMW_SCC3,
        bprmLTE_UseDLStream1SettingsUDCH_CMW_SCC3,
        bprmLTE_UseDLStream1SettingsUDTTI_CMW_SCC3,
        bprmLTE_TDD_UseDLStream1SettingsUDTTI_CMW_SCC3,

        bprmNRQ6TraceRealtime,
        bprmNRQ6ZeroAtStart,
        bprmNRQ6UseDutyCycleCorrection,
        bprmNRQ6TriggerAuto,
        bprmNRQ6UseSmoothing,
        bprmNRQ6UseAveragePower,
        bprmNRQ6DisplayOFFDuringTest,
        bprmNRQ6GateUseFence,
        bprmNRQ6Reserved1,
        bprmNRQ6Reserved2,

        BSS_bAWGNState_SCC4,
        bEdMax_SCC1,
        bEdMax_SCC2,
        bEdMax_SCC3,


        //DON'T ADD ANY MORE BOOL TYPES - USE INTEGERS INSTEAD
        //Seems like nobody frickin' listens so screw it



        //
        //  PLEASE add all new parameters above this line using the bprmXxxx naming convention
        //

        // comment these out as used, don't delete!
        _bDummy0,            // placeholder--  comment/delete as we add
        _bDummy1,            // placeholder--  comment/delete as we add
        _bDummy2,            // placeholder--  comment/delete as we add
        _bDummy3,            // placeholder--  comment/delete as we add
        _bDummy4,            // placeholder--  comment/delete as we add
        _bDummy5,            // placeholder--  comment/delete as we add
        _bDummy6,            // placeholder--  comment/delete as we add
        _bDummy7,            // placeholder--  comment/delete as we add
        _bDummy8,            // placeholder--  comment/delete as we add
        _bDummy9,            // placeholder--  comment/delete as we add
                             //BOOLEAN SECTION END
                             //TPARAMETER SECTION START
        tpParamArray,
        tpEquipment,
        tpSettings,
        tpUberEquipList,
        tpChanEmulInput,
        tpChanEmulOutput,
        // Starting new naming convention from here on.  TDataAwareTypes (parameters)
        // are now labeled as <type>prmParameterName, e.g. dprmPhiPosStep
        // Carrying existing prefixes BSS_, TD_, etc. forward along with this is
        // acceptable, e.g. TD_dprmZeroOffset






        //
        //  PLEASE add all new parameters above this line using the tpprmXxxx naming convention
        //






        // comment these out as used, don't delete!
        _tpDummy0,            // placeholder--  comment/delete as we add
        _tpDummy1,            // placeholder--  comment/delete as we add
        _tpDummy2,            // placeholder--  comment/delete as we add
        _tpDummy3,            // placeholder--  comment/delete as we add
        _tpDummy4,            // placeholder--  comment/delete as we add
        _tpDummy5,            // placeholder--  comment/delete as we add
        _tpDummy6,            // placeholder--  comment/delete as we add
        _tpDummy7,            // placeholder--  comment/delete as we add
        _tpDummy8,            // placeholder--  comment/delete as we add
        _tpDummy9,            // placeholder--  comment/delete as we add
                              //TPARAMETER SECTION END
                              //VECTOR ARRAY TPARAMETER SECTION START
        paEquipmentList,
        paRanges,
        paEquipment,
        paNodes,
        paHybridArray,        // TParameter array for hybrid driver
        paConfigArray,        // Array to hold different equiment configurations (accessed by popup menu on equipment form)
        paAncillaryEquipStates,
        paHandoverBands,     // handover sub-parameters
        paChanEmulatorArray,
        paMultiSwitchEquipment,
        paMultiSwitchAncillary,
        paF32Array,
        // Starting new naming convention from here on.  TDataAwareTypes (parameters)
        // are now labeled as <type>prmParameterName, e.g. dprmPhiPosStep
        // Carrying existing prefixes BSS_, TD_, etc. forward along with this is
        // acceptable, e.g. TD_dprmZeroOffset

        paprmAmplifiers,     // Amplifiers Info
        paprmAttenuators,    // Attenuators Info
        paprmPCUPortMap,     // Power Control Unit, Port Map
        paMultiVertexArray,
        paprmMeasurePoints, //  Sets of points to measure

        //
        //  PLEASE add all new parameters above this line using the paprmXxxx naming convention
        //




        // comment these out as used, don't delete!
        _paDummy0,            // placeholder--  comment/delete as we add
        _paDummy1,            // placeholder--  comment/delete as we add
        _paDummy2,            // placeholder--  comment/delete as we add
        _paDummy3,            // placeholder--  comment/delete as we add
        _paDummy4,            // placeholder--  comment/delete as we add
        _paDummy5,            // placeholder--  comment/delete as we add
        _paDummy6,            // placeholder--  comment/delete as we add
        _paDummy7,            // placeholder--  comment/delete as we add
        _paDummy8,            // placeholder--  comment/delete as we add
        _paDummy9,            // placeholder--  comment/delete as we add
                              //VECTOR ARRAY TPARAMETER SECTION START
                              //XYZArray ARRAY TYPE SECTION START
        xyzFrequencyList,
        xyzOutputPts,
        xyzTestAnalyzerPts,
        xyzFreqArrayList,
        xyzThroughputList,
        xyzChannelID_Deprecated,
        xyzSegmentedPts,       //XYZ Array for segmented sweeps
        xyzSimulatedArray,     // array parameters for simulated array in test VNA
        xyzSimulatedPathLoss,  // frequency dependent path loss option for test VNA
        xyzSimulatedTimeDomain,// time domain shape for test VNA
        xyzLimitLine,          // used to present an XY limit line
        xyzBandwidths,         // x=resolution BW, y=video BW
        xyzAngularPortMap,
        xyzIteratorStatus,     // Array used to store the iterator status (Iterator index and direction)
        xyzULinkDLinkMap,
        xyzSR5500AnalogGains,
        xyzprmFieldMapAngleList,
        xyzprmResBlockOffsets,
        xyzChanEmulPortSettings,
        xyzAngularInputPortMap,
        // Starting new naming convention from here on.  TDataAwareTypes (parameters)
        // are now labeled as <type>prmParameterName, e.g. dprmPhiPosStep
        // Carrying existing prefixes BSS_, TD_, etc. forward along with this is
        // acceptable, e.g. TD_dprmZeroOffset

        xyzprmChannelModelTaps,   // Array for specifying a channel model for some reference calculations.
        xyzCA_FrequencyList,
        xyz_Bestfit_StdDev,
        xyz_Positioner_SpeedTable,
        xyzprmSimulatedReverbAbsorber,// Absorber location table for spherical simulation
        xyzExpectedValues,
        xyzprmTPCorMetrics,
        xyzSignalTemplate,
        xyzCA_MeasurementOpts, //Using for PCC/SCCx measurement options because number of SCCs can grow
        xyz_ZigbeeChannelPowers,
        xyzprmAmplifierLimits,
        xyzprm_CA_Metrics,
        xyzprmBeamformingSignals,
        xyzprmBeamformingInterferers,
        xyzprmBeamformingDummy,
        // xyzChannel is no longer sufficient to describe the info. of Frequency List with
        // the adding of 5G NR bands
        // since the Band of each item is only represented within 7bits (less than 128)
        xyzChannelID_Extended,
        xyz_NR_UXM_FrameMap,
        xyz_NR_UXM_SlotMap,
        xyz_NR_UXM_SlotConfig,
        xyz_RXTX_ChannelPairing,
        xyzAngularOffsetPortMap,
        xyzRMSMeasureTarget,

        //
        //  PLEASE add all new parameters above this line using the xyzprmXxxx naming convention
        //
        // comment these out as used, don't delete!
        _xyzDummy0,            // placeholder--  comment/delete as we add
        _xyzDummy1,            // placeholder--  comment/delete as we add
        _xyzDummy2,            // placeholder--  comment/delete as we add
        _xyzDummy3,            // placeholder--  comment/delete as we add
        _xyzDummy4,            // placeholder--  comment/delete as we add
        _xyzDummy5,            // placeholder--  comment/delete as we add
        _xyzDummy6,            // placeholder--  comment/delete as we add
        _xyzDummy7,            // placeholder--  comment/delete as we add
        _xyzDummy8,            // placeholder--  comment/delete as we add
        _xyzDummy9,             // placeholder--  comment/delete as we add
        _xyzDummy10,             // placeholder--  comment/delete as we add
                                 //XYZArray ARRAY TYPE SECTION END
                                 //VOID POINTER ARRAY SECTION START - for various struct types
        vpaGeneric,
        vpaGraphSettings,
        vpaParmTreeSettings,
        vpaTableSettings,
        vpaExerciseDlgPos,
        vpa2090Parameters,
        vpaOutputFormat,
        vpaMotorbaseConfigs,
        vpaRequiredControl,
        vpa2090Parameters2,
        vpaCS_Downlink,   //multislot circuit-switched BS
        vpaCS_Uplink,       //multislot circuit-switched Mobile
        vpaPD_Downlink,     //multislot Packet data BS
        vpaPD_Uplink,       //multislot Packet data Mobile
        vpaMBVParameter,   //motorbase V parameter
        vpaExportList,      //patterncal exports
        vpa8960HOList,
        vpaUserDefinedParmBlock,  // for user defined equipment API
        vpaExportTypes,
        vpaBoresiteData,
        vpsChanEmulOffsets,
        vpaSFScheduling,
        vpaSFScheduling_SCC1,
        vpaSFScheduling_SCC2,
        vpaSFScheduling_SCC3,

        // Starting new naming convention from here on.  TDataAwareTypes (parameters)
        // are now labeled as <type>prmParameterName, e.g. dprmPhiPosStep
        // Carrying existing prefixes BSS_, TD_, etc. forward along with this is
        // acceptable, e.g. TD_dprmZeroOffset

        //
        //  PLEASE add all new parameters above this line using the vpaprmXxxx naming convention
        //




        // comment these out as used, don't delete!
        _vpaDummy0,
        _vpaDummy1,
        //VOID POINTER SECTION END
        zzLastParameter
    };

    public enum TDataAwareTypeRanges
    {
        DATR_NegativeUndefinedType,
        DATR_Nothing,
        DATR_String,
        DATR_Integer,
        DATR_Double,
        DATR_Boolean,
        DATR_Parameter,
        DATR_ParameterArray,
        DATR_XYZArray,
        DATR_VoidPointer,
        DATR_PositiveUndefinedType,
    };
}