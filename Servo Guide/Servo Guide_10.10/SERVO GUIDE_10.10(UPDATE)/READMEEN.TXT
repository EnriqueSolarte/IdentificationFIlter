
                           READMEEN.TXT File
                     README file for SERVO GUIDE
        Copyright(C), FANUC CORPORATION, 2001-2015. All Rights Reserved.

This document provides the information about "SERVO GUIDE".
Please read this document before using the SOFTWARE.

------------------------------------------------------------------------------

[1] Introduction

[2] Outline
  2.1  About SERVO GUIDE
  2.2  The version of applicable software
  2.3  Operation environment

[3] Installation
  3.1  Install SERVO GUIDE
  3.2  Install FFG Calculation tool

[4] Uninstallation

[5] Activation
  5.1 Starting the SERVO GUIDE from the Windows [Programs] menu
  5.2 Starting of the help for SERVO GUIDE

[6] History

+-------------------------------------------------------------------------------+
|* Windows is the trademark of Microsoft Corporation.                           |
|* Other companies, products described in this document are the (registered)    |
|  trademarks of each companies.                                                |
+-------------------------------------------------------------------------------+


==============================================================================
[1] Introduction
==============================================================================

    This manual describes about "SERVO GUIDE".

    As for the detailed explanation, refer to online help after installation
    of SERVO GUIDE.

 Notes

  (1) All rights regarding "SERVO GUIDE", including the copyright shall
      belong to FANUC LTD.

  (2) No one can use or copy any part or whole of the software or document of
      "SERVO GUIDE" without a prior agreement.

==============================================================================
[2] Outline
==============================================================================

2.1  About SERVO GUIDE

    SERVO GUIDE is a Servo Tuning TooL. Main functions are shown below.

      1) Parameter Window
         Support Servo Parameter Handling on the tuning
      2) Graph Window
         Data Measurement and various analysis
      3) Program Window
         Support making Test Program for the tuning
      4) Tuning Navigator
         Support tuning by automatic tuning functions

2.2  Operation environment
        
     To use this software, the requirements indicated in the table below must
     be satisfied.

     +-------------------+---------------------------------------------------+
     | CNC               | Series 30i, 31i, 32i, 35i-MODEL B         (Note 1)|
     |                   | Series 30i, 31i, 32i-MODEL A                      |
     |                   | Series 16i, 18i, 21i, 20i-MODEL B                 |
     |                   | Series 18i-LNB                                    |
     |                   | Series 0i-MODEL F                                 |
     |                   | Series 0i-MODEL D, 0i-Mate-MODEL D                |
     |                   | Series 0i-MODEL C, 0i-Mate-MODEL C                |
     |                   | Series 0i-MODEL B, 0i-Mate-MODEL B                |
     |                   | Power Motion i-MODEL A                            |
     |                   | Power Mate i-MODEL D, Power Mate i-MODEL H        |
     |                   | Digital Servo Adapter-MODEL B (DSA-B)             |
     |                   | Pulse input type DSA (Digital Servo Adapter)      |
     +-------------------+---------------------------------------------------+
     | Computer          | IBM PC/AT COMPATIBLE                              |
     |                   |  Ethernet connection : Ethernet port required     |
     |                   |  HSSB connection : FANUC HSSB board required      |
     |                   |  Panel i is also applicable via HSSB              |
     +-------------------+---------------------------------------------------+
     | OS                | Microsoft Windows 2000/XP/Vista/7/8 (32bit)       |
     |                   | Microsoft Windows 7/8 (64bit)             (Note 2)|
     +-------------------+---------------------------------------------------+
     | CPU               | Windows 8          : Pentium III 1GHz or better   |
     |                   | Windows 7          : Pentium III 1GHz or better   |
     |                   | Windows Vista      : Pentium III 1GHz or better   |
     |                   | Windows XP         : Pentium III 500MHz or better |
     |                   | Windows 2000       : Pentium 200MHz or better     |
     +-------------------+---------------------------------------------------+
     | Memory            | Windows 8          : 1GByte or more (1GByte)      |
     |                   | Windows 7          : 512MBytes or more (1GByte)   |
     |                   | Windows Vista      : 512MBytes or more (1GByte)   |
     |                   | Windows XP         : 256MBytes or more (512MByte) |
     |                   | Windows 2000       : 128MBytes or more (256MByte) |
     +-------------------+---------------------------------------------------+
     | Pointing device   | Something pointing device necessary (Mouse etc.)  |
     +-------------------+---------------------------------------------------+
     | Hard disk         | 100Mbytes or more free space              (Note 3)|
     |                   | 200Mbytes on Installing                           |
     +-------------------+---------------------------------------------------+
     | Graphic adapter   | SVGA or higher (XGA or higher recommended)(Note 4)|
     +-------------------+---------------------------------------------------+
     | Printer           | The printers added by the printers settings on    |
     |                   | Windows.                                          |
     +-------------------+---------------------------------------------------+

Ethernet connection only
     +-------------------+---------------------------------------------------+
     | LAN card for CNC  | FANUC specification (A02B-0281-K710)      (Note 5)|
     +-------------------+---------------------------------------------------+

Using of 3-D View Function (Option A08B-9010-J904)
     +-------------------+---------------------------------------------------+
     | Graphic adapter   | XGA(1024x768) or higher (required)                |
     |                   | OpenGL support with sufficient performance        |
     +-------------------+---------------------------------------------------+
     | USB port          | For connecting the hardware key                   |
     +-------------------+---------------------------------------------------+


     (Note 1) Series and editions of applicable system software
              [System]
                Series 30i/31i/32i/35i-B all
                Series 30i-A      G001/23 or later, G011/23 or later, G021/23 or later
                                  G00A/01 or later, G01A/01 or later, G02A/01 or later
                                  G002/01 or later, G012/01 or later, G022/01 or later
                                  G003/01 or later, G013/01 or later, G023/01 or later
                                  G00C/01 or later, G01C/01 or later, G02C/01 or later
                                  G004/01 or later, G014/01 or later, G024/01 or later
                Series 31i-A      G101/01 or later, G111/01 or later
                                  G103/01 or later, G113/01 or later
                                  G104/01 or later, G114/01 or later
                Series 31i-A5     G121/01 or later, G131/01 or later
                                  G123/01 or later, G133/01 or later
                                  G12C/01 or later, G13C/01 or later
                                  G124/01 or later, G134/01 or later
                Series 32i-A      G201/01 or later
                                  G203/01 or later
                                  G204/01 or later
                Series 16i-MB     B0H1/05 or later, B0HA/01 or later, B0HK/01 or later
                                  B0K1/01 or later, B0N1/01 or later
                Series 16i-TB     B1H1/06 or later, B1HA/01 or later, B1HK/01 or later
                                  B1K1/01 or later, B1N1/01 or later
                Series 18i-MB     BDH1/05 or later, BDHA/01 or later, BDHK/01 or later
                                  BDK1/01 or later, BDN1/01 or later
                Series 18i-MB5    BDH5/01 or later, BDHE/01 or later
                                  BDK5/01 or later, BDN5/01 or later
                Series 18i-TB     BEH1/06 or later, BEHA/01 or later, BEHK/01 or later
                                  BEK1/01 or later, BEN1/01 or later
                Series 18i-LNB    BDG3/12 or later (BDG3/15 or later is required for 2PATH system)
                Series 21i-MB     DDH1/05 or later, DDHA/01 or later, DDHK/01 or later
                                  DDK1/01 or later
                Series 21i-TB     DEH1/06 or later, DEHA/01 or later, DEHK/01 or later
                                  DEK1/01 or later
                Series 20i-FB     D0H1/01 or later
                Series 20i-TB     D1H1/01 or later
                Series 0i-MF      D4G1/02 or later
                Series 0i-TF      D6G1/02 or later
                Series 0i-MD      D4F1/01 or later
                Series 0i-TD      D6F1/01 or later
                Series 0i Mate-MD D5F1/01 or later
                Series 0i Mate-TD D7F1/01 or later
                Series 0i-MC      D4B1/01 or later, D4C1/01 or later
                Series 0i-TC      D6B1/01 or later, D6C1/01 or later
                Series 0i-TTC     D6D1/01 or later
                Series 0i Mate-MC D511/01 or later, D521/01 or later 
                Series 0i Mate-TC D711/01 or later, D721/05 or later 
                Series 0i-PC      D811/01 or later
                Series 0i-MB      D4A1/01 or later
                Series 0i-TB      D6A1/01 or later
                Series 0i Mate-MB D501/01 or later
                Series 0i Mate-TB D701/01 or later
                Series 0i-PB      D801/01 or later
                Power Motion i-A  88H0/01 or later
                Power Mate i-D    88E0/18 or later, 88E1/01 or later, 88E3/01 or later
                Power Mate i-H    88F2/01 or later, 88F3/01 or later
                Digital Servo Adapter-MODEL B [A03B-0827-B822]
                                  881S/01 or later, 881R/01 or later, 881T/01 or later
                Pulse input type DSA (Digital Servo Adapter) [A03B-0818-B121]
                                  881H/05 or later
              [Ethernet/OPEN CNC]
                Series 30i, 31i, 32i-A
                 656E/06 or later & 656F/07 or later
                Series 30i, 31i, 32i-A (for 15" color LCD)
                 Control software 1 for 15" color LCD
                   A02B-0207-J595#60VB 1.3 or later (1.7 or later is required for Edition 4.00)
                                       1.7 or later (I/O Link beta i is supported.)
                   A02B-0207-J903#60VF 01 or later
                Series 30i, 31i, 32i-A (Personal computer function with WindowsCE)
                 WindowsCE.NET customize OS 
                   A02B-0207-J594 1.2 or later
                 WindowsCE.NET FOCAS2/HSSB library
                   A02B-0207-J808 1.2 or later (1.5 or later is required for Edition 4.00)
                                  1.7 or later (I/O Link beta i is supported.)
                   A02B-0207-J875 1.0 or later
                 WindowsCE.NET standard application & library
                   A02B-0207-J809 1.2 or later
                Series 16i,18i,21i
                 656A/03 or later (except 656A/07)
                 656A/13 or later (I/O Link beta i is supported.)
                 656A/14 or later (FANUC Remote Option System is supported.)
                Series 0i-D
                 658E/01 or later & 658F/01 or later
                Series 0i-C,20i-B
                 656V/01 or later
                 656V/07 or later (FANUC Remote Option System is supported.)
                Series 0i-B
                 656A/05 or later (except 656A/07)
                Power Mate i-D, i-H
                 6567/01 or later
                 6567/17 or later (I/O Link beta i is supported.)
                Pulse input type DSA (Digital Servo Adapter)
                 6567/19 or later
              [Servo]
                Series 30i,31i,32i,35i-B,Power Motion i-A
                                   90G0/06 or later, 90J0/01 or later, 90K0/01 or later
                Series 30i,31i,32i-A
                                   90D0/03 or later, 90E0/03 or later
                Series 16i,18i,21i-B
                                   90B0/06 or later (90B0/20 or later is needed for using Tuning Navigator.),
                                   90B6/01 or later, 90B1/01 or later
                Series 21i,0i-B    9096/01 or later (9096 does not support Tuning Navigator.)
                Series 0i-B        90B0/06 or later (90B0/20 or later is needed for using Tuning Navigator.),
                                   90B6/01 or later
                Series 0i-C,20i-B  90B5/01 or later
                Series 0i-D        90C5/01 or later, 90E5/01 or later
                                   90C8/01 or later, 90E8/01 or later
                Series 0i-F        90M0/02 or later, 90M8/02 or later
              [Spindle]
                Series 30i,31i,32i,35i-B (for alpha i-B series SP)    9DA0/01 or later
                Series 30i,31i,32i-A  (for alpha i/beta i series SPM) 9D70/02 or later, 9D80/01 or later, 9D90/01 or later
                Series 16i,18i,21i,0i (for alpha i/beta i series SPM) 9D50/02 or later
                Series 16i,18i,21i    (for alpha series SPM)          9D20/11 or later
              [I/O Link beta i]
                I/O Link beta i control software 88A6/03 or later
                Power Mate CNC manager (J674)
                Series 16i,18i,21i, PowerMate i-D, i-H:
                 Power Mate CNC manager function (for beta i) 8A01/03 or later

              You may be able to use SERVO GUIDE with any other softwares.
              But we assure the correct working with alpha i/beta i series
              in above combination. 

              Parameter Window and Program Window of SERVO GUIDE don't support
              multi-path control systems so far.

     (Note 2) Windows 95/98/Me/NT4.0 are NOT supported.
     (Note 3) In addition, the space for storing mesuring data is required.
     (Note 4) Although SVGA also operates, when two or more windows are opened 
              simultaneously, it becomes hard to see by window overlap.
     (Note 5) When using 16i,18i,21i Personal computer function with WindowsCE, 
              LAN card can't be used for connecting PC and CNC to use "SERVO GUIDE".
              Then LAN card is not necessary, and use embedded ethernet port behind CNC.
              But LAN card can be used for 30i,31i,32i Personal computer function with 
              WindowsCE on the other hand.

     (Note 6) Some part of SERVO GUIDE function requires the following system softwares.
       1) I/O Link beta i
              [System]
                Series 30i,31i,32i,35i-B all
                Series 30i-A      G002/23 or later, G012/23 or later, G022/23 or later
                                  G003/06 or later, G013/06 or later, G023/06 or later
                                  G00C/06 or later, G01C/06 or later, G02C/06 or later
                                  G004/01 or later, G014/01 or later, G024/01 or later
                Series 31i-A      G101/23 or later, G111/23 or later
                                  G103/06 or later, G113/06 or later
                                  G104/01 or later, G114/01 or later
                Series 31i-A5     G121/23 or later, G131/23 or later
                                  G123/06 or later, G133/06 or later
                                  G12C/06 or later, G13C/06 or later
                                  G124/01 or later, G134/01 or later
                Series 32i-A      G201/23 or later
                                  G203/06 or later
                                  G204/01 or later
                Series 16i-MB     B0HA/24 or later, B0HK/01 or later
                                  B0K1/01 or later, B0N1/01 or later
                Series 16i-TB     B1HK/06 or later
                                  B1K1/01 or later, B1N1/01 or later
                Series 18i-MB     BDHA/24 or later, BDHK/01 or later
                                  BDK1/01 or later, BDN1/01 or later
                Series 18i-MB5    BDHE/14 or later
                                  BDK5/01 or later, BDN5/01 or later
                Series 18i-TB     BEHK/06 or later
                                  BEK1/01 or later, BEN1/01 or later
                Series 21i-MB     DDHA/24 or later, DDHK/01 or later
                                  DDK1/01 or later
                Series 21i-TB     DEHK/06 or later
                                  DEK1/01 or later
                Series 0i-MF      D4G1/02 or later
                Series 0i-TF      D6G1/02 or later
                Series 0i-MD      D4F1/01 or later
                Series 0i-TD      D6F1/01 or later
                Series 0i Mate-MD D5F1/01 or later
                Series 0i Mate-TD D7F1/01 or later
                Power Motion i-A  88H0/01 or later
                Power Mate i-D    88E3/01 or later
                Power Mate i-H    88F3/01 or later
              [Ethernet/OPEN CNC]
                Series 30i, 31i, 32i-A
                 656E/06 or later & 656F/07 or later
                Series 30i, 31i, 32i-A (for 15" color LCD)
                 Control software 1 for 15" color LCD
                   A02B-0207-J595#60VB 1.7 or later
                   A02B-0207-J903#60VF 01 or later
                Series 30i, 31i, 32i-A (Personal computer function with WindowsCE)
                 WindowsCE.NET FOCAS2/HSSB library
                   A02B-0207-J808 1.7 or later
                   A02B-0207-J875 1.2 or later
                Series 16i,18i,21i
                 656A/13 or later
                Series 0i-D
                 658E/01 or later & 658F/01 or later
                Power Mate i-D, i-H
                 6567/17 or later
              [I/O Link beta i]
                I/O Link beta i control software 88A6/03 or later
                Power Mate CNC manager (J674)
                Series 16i,18i,21i, PowerMate i-D, i-H:
                 Power Mate CNC manager function (for beta i) 8A01/03 or later

       2) CNC parameters and CNC ID information from "FANUC Remote Option System" CNC
              [System]
                Series 30i,31i,32i,35i-B all
                Series 30i-A      G003/06 or later, G013/06 or later, G023/06 or later
                                  G00C/06 or later, G01C/06 or later, G02C/06 or later
                                  G004/01 or later, G014/01 or later, G024/01 or later
                Series 31i-A      G103/06 or later, G113/06 or later
                                  G104/01 or later, G114/01 or later
                Series 31i-A5     G123/06 or later, G133/06 or later
                                  G12C/06 or later, G13C/06 or later
                                  G124/01 or later, G134/01 or later
                Series 32i-A      G203/06 or later
                                  G204/01 or later
                Series 16i-MB     B0K1/04 or later, B0N1/01 or later
                Series 16i-TB     B1K1/04 or later, B1N1/01 or later
                Series 18i-MB     BDK1/04 or later, BDN1/01 or later
                Series 18i-MB5    BDK5/04 or later, BDN5/01 or later
                Series 18i-TB     BEK1/04 or later, BEN1/01 or later
                Series 21i-MB     DDK1/04 or later
                Series 21i-TB     DEK1/04 or later
                Series 0i-MF      D4G1/02 or later
                Series 0i-TF      D6G1/02 or later
                Series 0i-MD      D4F1/01 or later
                Series 0i-TD      D6F1/01 or later
                Series 0i Mate-MD D5F1/01 or later
                Series 0i Mate-TD D7F1/01 or later
                Series 0i-MC      D4C1/05 or later
                Series 0i-TC      D6C1/05 or later
                Series 0i-TTC     D6D1/01 or later
                Series 0i Mate-MC D521/05 or later
                Series 0i Mate-TC D721/05 or later
                Power Motion i-A  88H0/01 or later
              [Ethernet/OPEN CNC]
                Series 30i, 31i, 32i-A
                 656E/06 or later & 656F/07 or later
                Series 30i, 31i, 32i-A (for 15" color LCD)
                 Control software 1 for 15" color LCD
                   A02B-0207-J595#60VB 1.7 or later
                   A02B-0207-J903#60VF 01 or later
                Series 30i, 31i, 32i-A (Personal computer function with WindowsCE)
                 WindowsCE.NET FOCAS2/HSSB library
                   A02B-0207-J808 1.7 or later
                   A02B-0207-J875 1.2 or later
                Series 16i,18i,21i
                 656A/14 or later
                Series 0i-D
                 658E/01 or later & 658F/01 or later
                Series 0i-C
                 656V/07 or later
                 656A/05 or later (except 656A/07)

       3) Tuning Navigator (Gain tuning, Filter tuning)
              [Servo]
                Series 30i,31i,32i,35i-B,Power Motion i-A
                 90G0/06 or later, 90J0/01 or later, 90K0/01 or later
                Series 30i,31i,32i-A
                 90D0/03 or later, 90E0/03 or later
                Series 16i,18i,21i,0i-B
                 90B0/20 or later
                 90B6/01 or later, 90B1/01 or later
                Series 0i-C,20i-B
                 90B5/01 or later, 90B8/01 or later
                Series 0i-D
                 90C5/01 or later, 90E5/01 or later
                 90C8/01 or later, 90E8/01 or later
                Series 0i-F
                 90M0/02 or later, 90M8/02 or later

       4) Tuning Navigator (Automatic Backlash Acceleration)
              [System]
                Series 30i,31i,32i,35i-B all
                Series 30i-A      G002/12 or later, G012/12 or later, G022/12 or later
                                  G003/01 or later, G013/01 or later, G023/01 or later
                                  G00C/01 or later, G01C/01 or later, G02C/01 or later
                                  G004/01 or later, G014/01 or later, G024/01 or later
                Series 31i-A      G101/12 or later, G111/12 or later
                                  G103/01 or later, G113/01 or later
                                  G104/01 or later, G114/01 or later
                Series 31i-A5     G121/12 or later, G131/12 or later
                                  G123/01 or later, G133/01 or later
                                  G12C/01 or later, G13C/01 or later
                                  G124/01 or later, G134/01 or later
                Series 32i-A      G201/12 or later
                                  G203/01 or later
                                  G204/01 or later
                Series 0i-D       all
                Power Motion i-A  88H0/01 or later
              [Servo]
                Series 30i,31i,32i,35i-B,Power Motion i-A
                 90G0/06 or later, 90J0/01 or later, 90K0/01 or later
                Series 30i,31i,32i-A
                 90D0/12 or later, 90E0/12 or later
                 90D0/15 or later, 90E0/15 or later (tandem axes tuning)
                 90D0/16 or later, 90E0/16 or later (acceleration shape improvement)
                Series 0i-D
                 90C5/01 or later, 90E5/01 or later
                 90C8/01 or later, 90E8/01 or later
                Series 0i-F
                 90M0/02 or later, 90M8/02 or later

       5) Spindle Tuning (Aceeleration performance, Orientation)
              [Spindle]
                alpha i spindle   9D50/23 or later(alpha i SP, FS16i, Induction)
                                  9D53/12 or later(alpha i SP, FS16i, Synchronous)
                                  9D70/12 or later(alpha i SP, FS30i)
                                  9D80/08 or later(Level-up alpha i SP)

       6) PMC signal acquisition function
              [System]
                Series 30i-B      G301/07 or later, G311/07 or later, G321/07 or later, G331/07 or later
                Series 31i-B5     G421/07 or later, G431/07 or later
                Series 31i-B      G401/07 or later, G411/07 or later
                Series 32i-B      G501/07 or later, G511/07 or later
                Series 35i-B      G601/01 or later, G611/01 or later
                Series 30i-A      G002/38 or later, G012/38 or later, G022/38 or later
                                  G003/21 or later, G013/21 or later, G023/21 or later
                                  G00C/21 or later, G01C/21 or later, G02C/21 or later
                                  G004/01 or later, G014/01 or later, G024/01 or later
                Series 31i-A      G101/38 or later, G111/38 or later
                                  G103/21 or later, G113/21 or later
                                  G104/01 or later, G114/01 or later
                Series 31i-A5     G121/38 or later, G131/38 or later
                                  G123/21 or later, G133/21 or later
                                  G12C/21 or later, G13C/21 or later
                                  G124/01 or later, G134/01 or later
                Series 32i-A      G201/38 or later
                                  G203/21 or later
                                  G204/01 or later
                Series 16i-MB     B0HK/06 or later, B0K1/10 or later, B0N1/01 or later
                Series 16i-TB     B1HK/15 or later, B1K1/10 or later, B1N1/01 or later
                Series 18i-MB     BDHK/06 or later, BDK1/10 or later, BDN1/01 or later
                Series 18i-MB5    BDHE/21 or later, BDK5/10 or later, BDN5/01 or later
                Series 18i-TB     BEHK/15 or later, BEK1/10 or later, BEN1/01 or later
                Series 21i-MB     DDHK/06 or later, DDK1/10 or later
                Series 21i-TB     DDHK/15 or later, DEK1/10 or later
                Series 0i-MF      D4G1/02 or later
                Series 0i-TF      D6G1/02 or later
                Series 0i-MD      D4F1/02 or later
                Series 0i-TD      D6F1/02 or later
                Series 0i Mate-MD D5F1/02 or later
                Series 0i Mate-TD D7F1/02 or later
                Power Motion i-A  88H0/01 or later
              [Ethernet/OPEN CNC]
                Series 30i, 31i, 32i-A
                 656E/06 or later & 656F/07 or later
                Series 30i, 31i, 32i-A (for 15" color LCD)
                 Control software 1 for 15" color LCD
                   A02B-0207-J595#60VB 2.0 or later
                   A02B-0207-J903#60VF 03 or later
                Series 30i, 31i, 32i-A (Personal computer function with WindowsCE)
                 WindowsCE.NET FOCAS2/HSSB library
                   A02B-0207-J808 1.9 or later
                   A02B-0207-J875 1.4 or later
                Series 16i,18i,21i-B
                 656A/15 or later
                Series 0i-D
                 658E/01 or later & 658F/01 or later

       7) Spindle Tuning (Frequency response, Tuning Navigator (Filter tuning))
              [Spindle]
                alpha i spindle   9D50/24 or later(alpha i SP, FS16i, Induction)
                                  9D53/13 or later(alpha i SP, FS16i, Synchronous)
                                  9D70/13 or later(alpha i SP, FS30i)
                                  9D80/09 or later(Level-up alpha i SP)

       8) Tuning Navigator (Interactive Force Compensation Gain Tuning)
              [System]
                Series 30i,31i,32i,35i-B all
                Series 30i-A      G002/23 or later, G012/23 or later, G022/23 or later
                                  G003/06 or later, G013/06 or later, G023/06 or later
                                  G00C/06 or later, G01C/06 or later, G02C/06 or later
                                  G004/01 or later, G014/01 or later, G024/01 or later
                Series 31i-A      G101/23 or later, G111/23 or later
                                  G103/06 or later, G113/06 or later
                                  G104/01 or later, G114/01 or later
                Series 31i-A5     G121/23 or later, G131/23 or later
                                  G123/06 or later, G133/06 or later
                                  G12C/06 or later, G13C/06 or later
                                  G124/01 or later, G134/01 or later
                Series 32i-A      G201/23 or later
                                  G203/06 or later
                                  G204/01 or later
                Power Motion i-A  88H0/01 or later
              [Servo]
                Series 30i,31i,32i,35i-B,Power Motion i-A
                 90G0/06 or later, 90J0/01 or later, 90K0/01 or later
                Series 30i,31i,32i-A
                 90D0/16 or later, 90E0/16 or later

       9) CNC information acquisition function
              [System]
                Series 30i-B      G301/59 or later, G311/59 or later, G321/59 or later, G331/59 or later
                Series 31i-B5     G421/59 or later, G431/59 or later
                Series 31i-B      G401/59 or later, G411/59 or later
                Series 32i-B      G501/59 or later, G511/59 or later
                Series 35i-B      G601/?? or later, G611/?? or later (edition unfixed)
                Series 31i-B(Transfer Line Function) G441/07 or later
                Series 32i-B(Transfer Line Function) G541/07 or later
                Series 35i-B(Transfer Line Function) G641/07 or later
                Series 0i-MF      D4G1/02 or later
                Series 0i-TF      D6G1/02 or later
                Series 0i-MD      D4F1/39 or later, D4F2/08 or later
                Series 0i-TD      D6F1/39 or later, D6F2/08 or later
                Series 0i Mate-MD D5F1/39 or later, D5F3/09 or later
                Series 0i Mate-TD D7F1/39 or later, D7F3/09 or later
              [Ethernet/OPEN CNC]
                Series 30i/31i/32i/35i-B (for 10" color LCD B/C, 15" color LCD)
                 Graphic function software (60VP)             A02B-0207-J884#60VP
                 Graphic function software (60VS)             A02B-0207-J884#60VS
                Series 30i/31i/32i/35i-B (Personal computer function with WindowsCE)
                 Windows Embedded CE FOCAS2/HSSB library      A02B-0207-J887
                Series 30i/31i/32i/35i-B (Fast Ethernet connection)
                 Fast Ethernet software                       A02B-0323-J561#658K

      10) Extension of PMC signal acquisition function (Byte, Word)
              [System]
                Series 30i-B      G301/62 or later (plan), G311/62 or later (plan), G321/62 or later (plan), G331/62 or later (plan)
                Series 31i-B5     G421/62 or later (plan), G431/62 or later (plan)
                Series 31i-B      G401/62 or later (plan), G411/62 or later (plan)
                Series 32i-B      G501/62 or later (plan), G511/62 or later (plan)
                Series 0i-MF      D4G1/02 or later
                Series 0i-TF      D6G1/02 or later
              [Ethernet/OPEN CNC]
                Series 30i/31i/32i-B (for 10" color LCD B/C, 15" color LCD)
                 Graphic function software (60VP)             A02B-0207-J884#60VP/13 or later (plan)
                 Graphic function software (60VS)             A02B-0207-J884#60VS/03 or later (plan)
                Series 30i/31i/32i-B (Personal computer function with WindowsCE)
                 Windows Embedded CE FOCAS2/HSSB library      A02B-0207-J887 2.7 or later (plan)
                Series 30i/31i/32i-B (Fast Ethernet connection)
                 Fast Ethernet software                       A02B-0323-J561#658K/15 or later (plan)


==============================================================================
[3] Installation
==============================================================================

3.1 Installation of SERVO GUIDE main part
   (1) SERVO GUIDE installation disk is inserted in CD drive.
   (2) Open the folder of CD drive from a [my computer], and double-click
       "Setup.exe".
   (3) Please operate it according to directions of an installer.
       * Re-starting may be needed.

   Note)If you execute "Setup.exe" at the PC in which older version is installed,
        the uninstallation will be executed at first. After that please execute
        "Setup.exe" again to install newer version.

3.2 Installation of FFG calculation software
      As auxiliary software of SERVO GUIDE, it is machine composition, scale information, 
     etc. to FFG. The software which calculates a setup of a grade is prepared.
     In order to cooperate with SERVO GUIDE and to use this software, it needs to install
     in the following procedure.
   (1) Insert SERVO GUIDE installation disk in CD drive.
   (2) Please open the folder of CD drive from a [my computer], and double-click 
       "FFG\ENG\Setup.exe"
   (3) Please operate it according to directions of an installer.
   
     When this software is made to cooperate from SERVO GUIDE, 
     It can perform by following operations in parameter window,
        [Servo axis setting group] 
           -> [a feedback setting tab] 
             -> [a setting support button]

     (This software can be used to independently of SERVO GUIDE.)  

==============================================================================
[4] Uninstallation
==============================================================================
[Operation]
   (1) Click a [start] button.
   (2) Execute "Cleaner" from [FANUC SERVO GUIDE] group on start-menu.
   (3) From start-menu, choose [control panel].
   (4) Choose "FANUC SERVO GUIDE" from [add or delete of application]
       Please push a [add or delete] button.
       * FFG calculation software is also uninstallable by the same method.


==============================================================================
[5] Activation
==============================================================================

5.1 Starting the SERVO GUIDE from the Windows [Programs] menu

    [Operation]
	(1) Click the [Start] button.
	(2) Click the [Programs] menu of the [Start] menu.
	(3) Click the [FANUC SERVO GUIDE] folder of the [Programs] menu.
	(4) Click the "SERVO GUIDE" of the [FANUC SERVO GUIDE] folder.
	    Activate the SERVO GUIDE and run.

5.2  Starting of the help for SERVO GUIDE
     If SERVO GUIDE is started, the launcher bar called "Main Bar" will rise.
     Please carry out a right click on this bar, and choose [a help] from 
     a context menu.

==========================================================================
[6] History
==========================================================================

2014/01/09	Edition 10.10
- Support Digital Servo Adapter-MODEL B (DSA-B)
  + GraphWindow and ParameterWindow are supported.
  + ProgramWindow and TuningNavigator are NOT supported.
- Correction of ParameterWindow
  In case of Series 0i-F, parameter screen for unexpected disturbance detection 
  function and spindle orientation function is not displayed correctly.
  This problem has been corrected. (This problem occurs at Ver10.10 only)
- Addition of new kind of test programs in the ProgramWindow
  (Diamond program, Diamond with 1/4 Arc)

2014/09/30	Edition 10.00
- Support Series 0i-MODEL F
- Extension of PMC signal acquisition function
  (PMC byte signal or word signal can be measured.)

2014/07/31	Edition 9.40
- Serial number is introduced.
- Site license package (J930) is added.
- Update package (J919) is added.
- Improvement of GraphWindow
 + Waveform searching function is added and cursor function is modified.
 + CNC information acquisition function is added.
 + Tuning assist screen of rigid tapping acc./dec. is added.
- Improvement of ParameterWindow
 + FSSB high-speed rigid tapping
 + Optimum acceleration/deceleration for rigid tapping
- Tuning Navigator: Frequency response measurement (high precision mode) is supported.

2014/02/26	Edition 9.30
- Multiple license packages (J910,J920) are added.

2014/01/07	Edition 9.20
- Frequency response measurement (high precision mode) is supported.
  To use this function, the servo software that supports this function is required.
- Addition of measuring datas
  (Common power supply:14 data such as PSENGY)

2013/09/02	Edition 9.10
- Improvement of ParameterWindow
 + SERVO HRV+ Control
 + SmartBacklashCompensation
- Improvement of GraphWindow
 + Parameter calculation support function for SmartBacklashCompensation is added.
- Addition of measuring datas
  (Servo:SMTBKL, SMTTRQ, SCREWL, DTRQAL)
- Support Windows 8 (32bit/64bit)

2013/04/12	Edition 9.00
- Addition of Parameter automatic saving function
  and add FileViewer (FileViewer.exe) and Parameter Comparison Tool (PrmCompTool.exe)
- 3-D View Function: 3-D reference path display function is added.
- Tuning Navigator: Spindle velocity gain tuning (for Cs axis) function is added.
- Addition of measuring datas
  (Servo:POSFN,POS3DN, Spindle:CSPOSN,POS3DN,MTPOS, Common power supply:PSPOW)

2012/06/15	Edition 8.40
- In case of using Spindle Tuning Function in the GraphWindow,
  spindle axis except N-th axis in N path can not be selected (N=1-4).
  This problem had been amended. (This problem occurs at Edition 8.30 only)

2012/05/31	Edition 8.30
- Improvement of smoothness compensation for synchronous built-in servo motors 
  (Parameter support for 4.5 times/pole-pairs compensation)
- Addition of measuring data for spindle (SPCMD2)
- Improvement of Parameter Window (Spindle synchronous control parameter No.4550-4559).
- Support power source data acquisition at 30i-B series PS
- Add power source data monitoring software "PS Monitor".

2012/03/09	Edition 8.20
- Support of window-collapse of display setting panel for overlay view or 3-D View
- Addition of new operations (Tangent acceleration/jerk, synthetic acceleration/jerk)
- Correction of package file saving for OverlayView Function
- Correction of display content in ParameterWindow (Auto-setting of optimum orientation)

2012/01/31	Edition 8.10
- Addition of overlay view function
  (not supported on 3-D View Function)
- Improvement of 3-D View Function
  + 5-axis coordinate setting : Automatic setting is supported.
  + 5-axis coordinate setting : 5-axis machine parameter setting screen is added.
  + 5-axis coordinate conversion : Imaginary rotary axis is supported.
  + 5-axis coordinate conversion : Angular axis controlled machine is supported.
  + New operations are added. (Curvature, normal acceleration, normal jerk) 
  + Length measurement mode is added.
  + 3-D View screen layout switching is supported.
- Tuning Navigator: Improvement of Automatic Backlash Acceleration function 
 + Override parameter check screen is added.
- Support 31i/32i/35i-B Transfer Line Function
- Addition of measuring datas (SV:TQMAX,TQMIN,SP:TCMD2)

2011/07/31	Edition 8.00
- Support Power Motion i-MODEL A
- Expansion of the maximum channel number of spindle axis to 4ch. (30i-B Series CNC)
- Addition of tolerance setting of reference data for circular interpolation in ProgramWindow.
- Support Windows 7 (64bit)

2011/01/24	Edition 7.30
- Support Series 30i/31i/32i/35i-MODEL B
- Tool tip hints in ParameterWindow have been revised, and for each parameter 
  to be tuned, typical setting value and range of modification are displayed 
  as a guideline.
- Graph Window: Fix the TangentN operation problem (7.20 only)

2010/11/17	Edition 7.20
- Improvement of 3-D View Function
  + Display color setting function depending on reference data. (color-coded display) 
  + New operations are added. (About path error, rotating radius of 5-axis machining) 
  + Addtional functions for ease of operation. 
    + Panel for display setting (3-D graph) 
    + Rotating operation around axis based on screen (3-D graph) 
    + Centering function (3-D graph) 
    + Automatic scaling with time axis fixed. (2-D graph) 
- Acc./dec. parameters concerning tool center point control are added to the ParameterWindow. 
- Add measuring datas for spindle (IRMS,IPEAK,CSPOS2)
- At the 2-D graph in the GraphWindow, the operation that specifies the tool center point 
  data (TCP:X,Y,Z) is used and saved to the display settings, an application error occurs 
  when opening a new window. It has been amended.

2010/07/13	Edition 7.10
- Frequency response measurement of position loop is supported.
  To use this function, the servo software that supports this function is required.
- In 3-D circle path error display of 3-D View Function, the following problems
  had been amended.
 + When the normal vector of the plane including the reference circle has the
   negative value in the X or Y component, the path error of 3-D circle had
   displayed incorrectly. It has been amended.
 + In case of using the time-range for display, the start data number had been
   ineffective and the waveform was always displayed from the beginning of data.
   It has been amended.

2010/03/31	Edition 7.00
- 3-D View Function (option)
- Support of Windows 7 (32bit) - 64bit version is NOT supported.
- Windows 98/Me/NT4.0 were no longer supported.

2009/11/18	Edition 6.50
- In case of 0i-D, waveform of spindle axis or path-2 servo axes can't be 
  measured in the GraphWindow. This problem has been corrected.
  (This problem occurs at Edition 6.40 only)
  The above problem affects the TuningNavigator.

2009/10/16	Edition 6.40
- Graph Window: Improvement of smoothness compensation calculation
- Graph Window: Addition of Automatic saving function
- Graph Window: Addition of Automatic repeat measurement function

2009/06/12	Edition 6.30
- Tuning Navigator: Modification of tuning program for backlash acceleration of rotary axis.
 + A workpiece coordinate system setting G code (G92/G50) was not used in tuning program.
 + Tuning program is generated with incremental command for the axis which accepts
   the incremental command.
 + Tuning program is generated with absolute command for the axis which doesn't accept
   the incremental command (ex. A, B axis on G code system A in the lathe system)

2009/03/30	Edition 6.20
- Tuning Navigator: Addition of gain tuning of Interactive Force Compensation function
- Tuning Navigator: Addition of tuning of unexpected disturbance detection function
- Tuning Navigator: Improvement of Automatic Backlash Acceleration function (Rotary axis supported)
- Parameter Window: Update of servo parameter screens
  + Filter function
   + Resonance elimination filter L 
   + Adaptive resonance elimination filter
  + Shape error suppression function
   + Interactive force compensation function (IFC function)
  + Stop function
   + Lifting function against gravity at emergency stop
   + Quick stop function for separate serial detector alarms
  + Unexpected disturbance torque detection function
   + Dynamic friction compensation in the stop state and compensation limit
   + Unexpected disturbance torque detection switching function depending on acceleration
  + Axis setting
   + Acceleration sensor setting

2008/09/10	Edition 6.10
- Synchronous spindle motor screen is added to the ParameterWindow.

2008/05/28	Edition 6.00
- Support Series 0i-MODEL D
- Improvement of Spindle Tuning function
  + Frequency response measurement
  + Tuning Navigator (Automatic tuning for HRV filter)
- Improvement of Tuning Navigator for Automatic Backlash Acceleration function

2008/01/30	Edition 5.00a
- Improvement of Tuning Navigator for Automatic Backlash Acceleration function

2007/09/28	Edition 5.00
- Spindle Tuning function is added.
  + Aceeleration performance
  + Orientation
- Optimum orientation screen is added to the ParameterWindow.
- PMC signal acquisition function is added.
  To use the function, CNC software should be renewed.
  But we've not prepared the official version yet and we can offer only the
  preliminary version so far. 
  If you try to use it, please consult FANUC individually.

2007/05/30	Edition 4.20
- Supporting Pulse input type DSA (Digital Servo Adapter)
  + ParameterWindow and GraphWindow are supported.
    (But trigger can not be used on GraphWindow.)
  + ProgramWindow and TuningNavigator are NOT supported.
- Supporting Windows Vista

2007/04/11	Edition 4.11
- After cancelling a measurement of frequency response in the Tuning Navigator,
  an application error occurs. It has been amended. (Edition 4.10 only)

2007/02/26	Edition 4.10
- Graph Window: Addition of Cursor function, Area expanding function
- Graph Window: Extension of the maximum channel number of data acquisition
- Tuning Navigator: Supporting tuning for synchronous axes or tandem axes 
                    in Automatic Backlash Acceleration function.
- Parameter Window: Supporting parameter file of CNC using "FANUC Remote Option System".
- Program Window: Program generation considering diameter axis programming.

2006/08/10	Edition 4.00
- Automatic Backlash Acceleration function was added in Tuning Navigotor.

2006/03/08	Edition 3.21a
- Feature restriction mechanism is added.

2006/02/20	Edition 3.21
- Improvement of Tuning Navigotor for tuning time constant for rapid traverse.
  + Support the case using "Linear acc./dec. before interpolation for rapid traverse" 
    under the condition of "Always AI contour control effectve" in FS30i series. 
  + Execute over travel check at making test program.
  + Change not to select the axis which use "Optimum torque acc./dec. function".
    (Such axis is out of support in Tuning Navigotor) 
- Replace some bad figure of Tuning Navigator in help file.

2005/12/08	Edition 3.20
- Addition of tuning for time constant of rapid traverse in Tuning Navigator
- Newly supporting to get data of I/O link beta i in Graph Window
  So far today, only Power Mate i-H supports getting data of I/O link beta i.
  To use the function, following all software should be renewed. CNC software, Ethernet software, 
  Power Mate CNC manager software(PMM) and I/O link beta i software.
  But we've not prepared the official version yet and we can offer only the preliminary version so far. 
  If you try to use it, please consult FANUC individually.
- Supporting tuning for synchronous axes or tandem axes in Tuning Navigator
- Addition of tuning for smoothness compensation for synchronous built-in servo motors

- FFG calculation software is updated.
  + I/O Link beta
  + synchronous built-in servo motor
  + Separate rotary encoder RCNxxx(Heidenhain), MPscale(Mitsubishi Heavy Industry),
    alpha iCZ sensor(FANUC)
  + Linear Motor Position Detection Circuit H, C
  + Some overflow correction

2005/09/01	Edition 3.11f
- Support waveform measurement for I/O Link beta i
  ParameterWindow, ProgramWindow and TuningNavigator are NOT available.
  Applicable CNC software series and version are following.
   [System]
    Power Mate i-H 88F3/Z2
   [Ethernet/OPEN CNC]
    Power Mate i-D, i-H 6567/P1
   [I/O Link beta i]
    PowerMate CNC manager(PMM)       8A01/B1
    I/O Link beta i control software 88A6/B8

2005/08/05	Edition 3.11e
- Support parameter calculation of smoothness compensation for synchronous built-in servo motors

2005/07/29	Edition 3.11d
- Support the frequency response measurement by the simultaneous oscillation setting
  at multi-path system. (Graph Window)
- Correct displaying real number parameters under the first decimal place. (Parameter Window)

2005/06/30	Edition 3.11c
- Revise the calculation algorithm of smooth compensation for linear motors (Graph Window)

2005/03/11	Edition 3.11
- Program Window newly supports Series 18i-LNB
- Tuning Navigator newly supports Series 18i-LNB
- Parameter controls disapper from the parameter page by axis selection
  of different path in ParameterWindow. It has been amended.
- Waveform data which is saved at X-Y mode or CIRCLE mode is not displayed
  at reading from the file. It has been amended. (Graph Window)

2004/12/29	Edition 3.10
- Chinese versions (Simplified, Traditional) are released.
- Language switching is available.
- Spindle parameter screens are added.
 + Orientation group is added.
 + Spindle syncronization control group is added.
 + HRV filter screen is added.
- Servo parameter screens are changed.
 + AMR setting screen is separated from feedback setting screen.
 + Directional setting of 2-stage backlash acceleration is supported.
 + 2-stage backlash acceleration type2 is supported.

2004/09/15	Edition 3.01
Correct the following items which had changed at edition 3.00.
- Spindle axis can not be selected at Parameter Window for 16i series CNC. It has been amended.
- Previous setting restoration in the frequency response measurement at Graph Window is added,
  but "other" setting value is not restored and cleared to zero. It has been amended.
- Spindle data "SFLG1" was not displayed at GraphWindow. The data has been added.

2004/07/30	Edition 3.00
- Support Series 30i, 31i, 32i-MODEL A
 + Axis name expansion
 + Multi-path axis configration
 + Program file name / folder management
 + Real number parameters
- Support Series 0i-MODEL C
- Support inch-output machine (Parameter Window)
- Support multi-path parameter handling (Parameter Window)
- Support multi-path program handling (Program Window)
 # Loader control path is not included to multi-path because
 # loader control path has no room for supporting FOCAS1.
- Correct multi-path measurement of Frequency Response. (Graph Window)
- Correct multi-path measurement of Tuning Navigator. (Tuning Navigator)
- Add some measuring datas of servo/spindle (Graph Window)
- Add file association to graph data file (*.gdt) (Graph Window)
- Default file name is brought up at saving graph data (Graph Window)
- Apply sizing steps of graph (Graph Window)
- Add a brief indication of graph size (Graph Window)
- Revise the calculation algorithm of smooth compensation for linear motors (Graph Window)

2002/10/25	Edition 2.00a
- Correction of the wrong access of parameters in the High speed High precision tuning wizard.
  (Tuning Navigator)
- PS000 alarm (POWER MUST BE OFF) was not detected via HSSB connection. It has been amended.
  (Parameter Window)
- The parameter bit of "Always current loop 1/2PI control" in the Current Gain page was used as
  by the reverse-meaning. It has been amended. (Parameter Window)
- In WindowsXP, the ActiveX components for the Parameter Window are not installed. It has been amended.

2002/09/11	Edition 2.00
- Add Tuning Navigator (Automatic tuning for Gain and Filter. Support tuning for High speed High precision functions.)
- Support Series 0i-MODEL B
- Add the dialog for the calculation of Smooth compensation for linear motors (Graph Window)
- Availability of save data of frequency response in Bode diagram screen (Graph Window)
- Add short-cut for change to Bode diagram (Ctrl+M) (Graph Window)
- Availability of the measurement of frequency response even when synchronous axes.(Graph Window)
- Add HRV filter setting screen (Parameter Window)
- Add Jerk control setting screen (Parameter Window)
- Change option setting screen by adding of Jerk control (Parameter Window)
- Change handling of PWE(When PWE is 1 originally, SERVO GUIDE doesn't change it.) 
- Correction of Feed-forward setting screen for HPCC.
- Support second acceleration switching by derection in 2-stage backlash acc. function. (Parameter Window)
- Add Peak-Valley indication in Circle mode.(Graph Window)
- Revise the algorithm in Contour mode.(Graph Window)


2001/12/18	Edition 1.20 (Application name is changed to "SERVO GUIDE")
- HSSB connection is available.
- The angular axis coordinate conversion function has been supported.
- Position loop gain is not changed when measuring the frequency response. It has been amended.
- The parameters of 'linear motor smoothness compensation (reverse direction)' have been supported.
- Resource leaks at GraphWindow are corrected.
- The program path of circular interpolation in the ProgramWindow can not been created when G code system A for Turning CNC is selected. It has been amended.

2001/07/27	Edition 1.10
		English version release.

2001/03/21	Edition 1.00
		English version is not included.

- First Version is released.

							- End of document -
