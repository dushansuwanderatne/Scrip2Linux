Feature: EN_E_PostcodeEnquiry
	Ensure EN_E_PostcodeEnquiry functionality covered

@winformsTest
@EnquiryTest
@NAB_AUTO
@EN_E_PostcodeEnquiry
@18459
Scenario Outline: Test Case 18459: 01_Code Enquiries -DLAS
	# Enquiry System -Action PCE
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to Holder Enquiry System
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | PCE   |
			| Locate Argument |       |
		And I enter Postcode Enquiry System details as "<Country>" "<DisplayOption>" "<StartLocation>" "<State>"
	#Then In ENSPCE10 I should see Postcode Enquiry system details Part1 as "<Country1>" "<Town1>" "<Town2>" "<Town3>" "<Town4>" "<Town5>" "<Town6>" "<Town7>" "<State1>" "<State2>" "<State3>" "<State4>" "<State5>" "<State6>" "<State7>" "<Postcode1>" "<Postcode2>" "<Postcode3>" "<Postcode4>"
	#	And ENSPCE10 I should see Postcode Enquiry system details Part2 as "<Postcode5>" "<Postcode6>" "<Postcode7>" "<Presort1>" "<Presort2>" "<Presort3>" "<Presort4>" "<Presort5>" "<Presort6>" "<Presort7>" "<BarcodePresort1>" "<BarcodePresort2>" "<BarcodePresort3>" "<BarcodePresort4>" "<BarcodePresort5>" "<BarcodePresort6>" "<BarcodePresort7>"
	Then ENSPCE10 I should see Town details as "<Country1>" "<Town1>" "<Town2>" "<Town3>" "<Town4>" "<Town5>" "<Town6>" "<Town7>" "<Town8>" "<Town9>" "<Town10>" "<Town11>" "<Town12>" "<Town13>" "<Town14>" "<Town15>" "<Town16>"
		And ENSPCE10 I should see State details as "<State1>" "<State2>" "<State3>" "<State4>" "<State5>" "<State6>" "<State7>" "<State8>" "<State9>" "<State10>" "<State11>" "<State12>" "<State13>" "<State14>" "<State15>" "<State16>"
		And ENSPCE10 I should see Postcode details as "<Postcode1>" "<Postcode2>" "<Postcode3>" "<Postcode4>" "<Postcode5>" "<Postcode6>" "<Postcode7>" "<Postcode8>" "<Postcode9>" "<Postcode10>" "<Postcode11>" "<Postcode12>" "<Postcode13>" "<Postcode14>" "<Postcode15>" "<Postcode16>" 
		And ENSPCE10 I should see Presort details as "<Presort1>" "<Presort2>" "<Presort3>" "<Presort4>" "<Presort5>" "<Presort6>" "<Presort7>" "<Presort8>" "<Presort9>" "<Presort10>" "<Presort11>" "<Presort12>" "<Presort13>" "<Presort14>" "<Presort15>" "<Presort16>"
		And ENSPCE10 I should see BarcodePresort details as "<BarcodePresort1>" "<BarcodePresort2>" "<BarcodePresort3>" "<BarcodePresort4>" "<BarcodePresort5>" "<BarcodePresort6>" "<BarcodePresort7>" "<BarcodePresort8>" "<BarcodePresort9>" "<BarcodePresort10>" "<BarcodePresort11>" "<BarcodePresort12>" "<BarcodePresort13>" "<BarcodePresort14>" "<BarcodePresort15>" "<BarcodePresort16>"

Examples: 
		| Test  | Country | DisplayOption | StartLocation | State | Town1         | Town2         | Town3           | Town4             | Town5           | Town6           | Town7            | Town8 | State1 | State2 | State3 | State4 | State5 | State6 | State7 | State8 | Postcode1 | Postcode2 | Postcode3 | Postcode4 | Postcode5 | Postcode6 | Postcode7 | Postcode8 | Presort1 | Presort2 | Presort3 | Presort4 | Presort5 | Presort6 | Presort7 | Presort8 | BarcodePresort1 | BarcodePresort2 | BarcodePresort3 | BarcodePresort4 | BarcodePresort5 | BarcodePresort6 | BarcodePresort7 | BarcodePresort8 | Country1    | Town9 | Town10 | Town11 | Town12 | Town13 | Town14 | Town15 | Town16 | State9 | State10 | State11 | State12 | State13 | State14 | State15 | State16 | Postcode9 | Postcode10 | Postcode11 | Postcode12 | Postcode13 | Postcode14 | Postcode15 | Postcode16 | Presort9 | Presort10 | Presort11 | Presort12 | Presort13 | Presort14 | Presort15 | Presort16 | BarcodePresort9 | BarcodePresort10 | BarcodePresort11 | BarcodePresort12 | BarcodePresort13 | BarcodePresort14 | BarcodePresort15 | BarcodePresort16 |
		| Test1 | A       | DLAS          | BLAIR         |       | BLAIR ATHOL   | BLAIR ATHOL   | BLAIRGOWRIE     | BLAIRMORE         | BLAIRMOUNT      |                 |                  |       | NSW    | SA     | VIC    | QLD    | NSW    |        |        |        | 2560      | 5084      | 3942      | 4625      | 2559      |           |           |           | 205      | 520      | 316      | 440      | 205      |          |          |          | 014             | 046             | 032             | 002             | 014             |                 |                 |                 | Australia   |       |        |        |        |        |        |        |        |        |         |         |         |         |         |         |         |           |            |            |            |            |            |            |            |          |           |           |           |           |           |           |           |                 |                  |                  |                  |                  |                  |                  |                  |
		| Test2 | A       | DLAS          | HAWTHORN      |       | HAWTHORN      | HAWTHORN      | HAWTHORN EAST   | HAWTHORN NORTH    | HAWTHORN WEST   | HAWTHORNDENE    | HAWTHORNE        |       | SA     | VIC    | VIC    | VIC    | VIC    | SA     | QLD    |        | 5062      | 3122      | 3123      | 3122      | 3122      | 5051      | 4171      |           | 520      | 315      | 315      | 315      | 315      | 520      | 430      |          | 047             | 030             | 030             | 030             | 030             | 047             | 035             |                 | Australia   |       |        |        |        |        |        |        |        |        |         |         |         |         |         |         |         |           |            |            |            |            |            |            |            |          |           |           |           |           |           |           |           |                 |                  |                  |                  |                  |                  |                  |                  |
		| Test3 | A       | DLAS          | VICTORIA      | WA    | VICTORIA PARK | VICTORIA PARK | VICTORIA ROCK   |                   |                 |                 |                  |       | WA     | WA     | WA     |        |        |        |        |        | 6100      | 6979      | 6429      |           |           |           |           |           | 630      | 630      | 670      |          |          |          |          |          | 052             | 052             | 049             |                 |                 |                 |                 |                 | Australia   |       |        |        |        |        |        |        |        |        |         |         |         |         |         |         |         |           |            |            |            |            |            |            |            |          |           |           |           |           |           |           |           |                 |                  |                  |                  |                  |                  |                  |                  |
		| Test4 | A       | DLAS          | CHURCHILL     | QLD   | CHURCHILL     |               |                 |                   |                 |                 |                  |       | QLD    |        |        |        |        |        |        |        | 4305      |           |           |           |           |           |           |           | 420      |          |          |          |          |          |          |          | 040             |                 |                 |                 |                 |                 |                 |                 | Australia   |       |        |        |        |        |        |        |        |        |         |         |         |         |         |         |         |           |            |            |            |            |            |            |            |          |           |           |           |           |           |           |           |                 |                  |                  |                  |                  |                  |                  |                  |
		| Test5 | N       | DLAS          | WELLINGTON    |       | WELLINGTON    | WELLINGTON    | WELLINGTON EAST | WELLINGTON FOREST | WELLINGTON MILL | WELLINGTON PARK | WELLINGTON POINT |       | NSW    | SA     | SA     | WA     | WA     | TAS    | QLD    |        | 2820      | 5259      | 5259      | 6236      | 6236      | 7054      | 4160      |           |          |          |          |          |          |          |          |          |                 |                 |                 |                 |                 |                 |                 |                 | New Zealand |       |        |        |        |        |        |        |        |        |         |         |         |         |         |         |         |           |            |            |            |            |            |            |            |          |           |           |           |           |           |           |           |                 |                  |                  |                  |                  |                  |                  |                  |

@winformsTest
@EnquiryTest
@NAB_AUTO
@EN_E_PostcodeEnquiry
@18462
Scenario Outline: Test Case 18462: 02_Post Code Enquiries -DLPC/DLPS/DLBP
	# Enquiry System -Action PCE
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to Holder Enquiry System
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | PCE   |
			| Locate Argument |       |
		And I enter Postcode Enquiry System details as "<Country>" "<DisplayOption>" "<StartLocation>" "<State>"
	Then ENSPCE10 I should see Town details as "<Country1>" "<Town1>" "<Town2>" "<Town3>" "<Town4>" "<Town5>" "<Town6>" "<Town7>" "<Town8>" "<Town9>" "<Town10>" "<Town11>" "<Town12>" "<Town13>" "<Town14>" "<Town15>" "<Town16>"
		And ENSPCE10 I should see State details as "<State1>" "<State2>" "<State3>" "<State4>" "<State5>" "<State6>" "<State7>" "<State8>" "<State9>" "<State10>" "<State11>" "<State12>" "<State13>" "<State14>" "<State15>" "<State16>"
		And ENSPCE10 I should see Postcode details as "<Postcode1>" "<Postcode2>" "<Postcode3>" "<Postcode4>" "<Postcode5>" "<Postcode6>" "<Postcode7>" "<Postcode8>" "<Postcode9>" "<Postcode10>" "<Postcode11>" "<Postcode12>" "<Postcode13>" "<Postcode14>" "<Postcode15>" "<Postcode16>" 
		And ENSPCE10 I should see Presort details as "<Presort1>" "<Presort2>" "<Presort3>" "<Presort4>" "<Presort5>" "<Presort6>" "<Presort7>" "<Presort8>" "<Presort9>" "<Presort10>" "<Presort11>" "<Presort12>" "<Presort13>" "<Presort14>" "<Presort15>" "<Presort16>"
		And ENSPCE10 I should see BarcodePresort details as "<BarcodePresort1>" "<BarcodePresort2>" "<BarcodePresort3>" "<BarcodePresort4>" "<BarcodePresort5>" "<BarcodePresort6>" "<BarcodePresort7>" "<BarcodePresort8>" "<BarcodePresort9>" "<BarcodePresort10>" "<BarcodePresort11>" "<BarcodePresort12>" "<BarcodePresort13>" "<BarcodePresort14>" "<BarcodePresort15>" "<BarcodePresort16>"

Examples: 
		| Test  | Country | DisplayOption | StartLocation | State | Town1                | Town2            | Town3            | Town4           | Town5                 | Town6           | Town7          | Town8        | State1 | State2 | State3 | State4 | State5 | State6 | State7 | State8 | Postcode1 | Postcode2 | Postcode3 | Postcode4 | Postcode5 | Postcode6 | Postcode7 | Postcode8 | Presort1 | Presort2 | Presort3 | Presort4 | Presort5 | Presort6 | Presort7 | Presort8 | BarcodePresort1 | BarcodePresort2 | BarcodePresort3 | BarcodePresort4 | BarcodePresort5 | BarcodePresort6 | BarcodePresort7 | BarcodePresort8 | Country1    | Town9           | Town10           | Town11        | Town12              | Town13            | Town14               | Town15             | Town16    | State9 | State10 | State11 | State12 | State13 | State14 | State15 | State16 | Postcode9 | Postcode10 | Postcode11 | Postcode12 | Postcode13 | Postcode14 | Postcode15 | Postcode16 | Presort9 | Presort10 | Presort11 | Presort12 | Presort13 | Presort14 | Presort15 | Presort16 | BarcodePresort9 | BarcodePresort10 | BarcodePresort11 | BarcodePresort12 | BarcodePresort13 | BarcodePresort14 | BarcodePresort15 | BarcodePresort16 |
		| Test1 | A       | DLPC          | 5000          |       | ADELAIDE             | ADELAIDE BC      | CITY WEST CAMPUS | HALIFAX STREET  | HUTT STREET           | RUNDLE MALL     | STATION ARCADE | STURT STREET | SA     | SA     | SA     | SA     | SA     | SA     | SA     | SA     | 5000      | 5000      | 5000      | 5000      | 5000      | 5000      | 5000      | 5000      | 524      | 524      | 524      | 524      | 524      | 524      | 524      | 524      | 045             | 045             | 045             | 045             | 045             | 045             | 045             | 045             | Australia   |                 |                  |               |                     |                   |                      |                    |           |        |         |         |         |         |         |         |         |           |            |            |            |            |            |            |            |          |           |           |           |           |           |           |           |                 |                  |                  |                  |                  |                  |                  |                  |
		| Test2 | A       | DLPC          | 3122          |       | AUBURN SOUTH         | GLENFERRIE SOUTH | HAWTHORN         | HAWTHORN NORTH  | HAWTHORN WEST         |                 |                |              | VIC    | VIC    | VIC    | VIC    | VIC    |        |        |        | 3122      | 3122      | 3122      | 3122      | 3122      |           |           |           | 315      | 315      | 315      | 315      | 315      |          |          |          | 030             | 030             | 030             | 030             | 030             |                 |                 |                 | Australia   |                 |                  |               |                     |                   |                      |                    |           |        |         |         |         |         |         |         |         |           |            |            |            |            |            |            |            |          |           |           |           |           |           |           |           |                 |                  |                  |                  |                  |                  |                  |                  |
		| Test3 | A       | DLPS          | 628           |       | CITY DELIVERY CENTRE | PERTH            | PERTH GPO        | PERTH           | HIGHGATE              | NORTHBRIDGE     | EAST PERTH     | KINGS PARK   | WA     | WA     | WA     | WA     | WA     | WA     | WA     | WA     | 6000      | 6000      | 6000      | 6001      | 6003      | 6003      | 6004      | 6005      | 628      | 628      | 628      | 628      | 628      | 628      | 628      | 628      | 049             | 049             | 049             | 049             | 049             | 049             | 049             | 049             | Australia   | WEST PERTH      | PERTH            | PERTH         | PERTH               | PERTH             | PERTH ST GEORGES TCE | PERTH              | PERTH     | WA     | WA      | WA      | WA      | WA      | WA      | WA      | WA      | 6005      | 6800       | 6809       | 6827       | 6830       | 6831       | 6837       | 6838       | 628      | 628       | 628       | 628       | 628       | 628       | 628       | 628       | 049             | 049              | 049              | 049              | 049              | 049              | 049              | 049              |
		| Test4 | A       | DLBP          | 047           |       | CLARENCE GARDENS     | EDWARDSTOWN      | MELROSE PARK     | MELROSE PARK DC | COLONEL LIGHT GARDENS | CUMBERLAND PARK | DAW PARK       | PANORAMA     | SA     | SA     | SA     | SA     | SA     | SA     | SA     | SA     | 5039      | 5039      | 5039      | 5039      | 5041      | 5041      | 5041      | 5041      | 520      | 520      | 520      | 520      | 520      | 520      | 520      | 520      | 047             | 047             | 047             | 047             | 047             | 047             | 047             | 047             | Australia   | WESTBOURNE PARK | BEDFORD PARK     | CLOVELLY PARK | FLINDERS UNIVERSITY | PASADENA          | ST MARYS             | TONSLEY			|BELLEVUE HEIGHTS | SA     | SA      | SA      | SA      | SA      | SA      | SA      | SA      | 5041      | 5042       | 5042       | 5042       | 5042       | 5042       | 5042       | 5050       | 520      | 520       | 520       | 520       | 520       | 520       | 520       | 520       | 047             | 047              | 047              | 047              | 047              | 047              | 047              | 047              |
		| Test5 | N       | DLPC          | 7054          |       | BARRETTA             | CONINGHAM        | ELECTRONA        | FERN TREE       | HOWDEN                | LESLIE VALE     | LOWER SNUG     | MARGATE      | TAS    | TAS    | TAS    | TAS    | TAS    | TAS    | TAS    | TAS    | 7054      | 7054      | 7054      | 7054      | 7054      | 7054      | 7054      | 7054      |          |          |          |          |          |          |          |          |                 |                 |                 |                 |                 |                 |                 |                 | New Zealand | NEIKA           | RIDGEWAY         | SNUG          | TINDERBOX           | WELLINGTON PARK   |                      |                    |           | TAS    | TAS     | TAS     | TAS     | TAS     |         |         |         | 7054      | 7054       | 7054       | 7054       | 7054       |            |            |            |          |           |           |           |           |           |           |           |                 |                  |                  |                  |                  |                  |                  |                  |

@winformsTest
@EnquiryTest
@NAB_AUTO
@EN_E_PostcodeEnquiry
@18465
Scenario Outline: Test Case 18465: 03_Post Code Enquiries Error Messages for country-ENSPCE06
	# Enquiry System -Action PCE
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to Holder Enquiry System
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | PCE   |
			| Locate Argument |       |
		And In ENSPCE06 I enter country code as "<Country>"
	Then I should see the below ErrorMessage "<ErrorMessage>"

Examples: 
		| Test  | Country | ErrorMessage                          |
		| Test1 | I       | Please enter either: <space>, A, N, U |
		| Test2 |         | Invalid Country Selected              |

@winformsTest
@EnquiryTest
@NAB_AUTO
@EN_E_PostcodeEnquiry
@18465
Scenario Outline: Test Case 18465: 03_Post Code Enquiries Error Messages for country -ENSPCE01
	# Enquiry System -Action PCE
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to Holder Enquiry System
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | PCE   |
			| Locate Argument |       |
		And In ENSPCE01 I enter Display Option as "<Country>" "<DisplayOption>"
	Then I should see the below ErrorMessage "<ErrorMessage>"

Examples: 
		| Test  | Country | DisplayOption | ErrorMessage                                     |
		| Test1 | A       | ABCD          | Your response of "ABCD" is not on the menu.      |
		| Test2 | A       |               | Your response of "<nothing>" is not on the menu. | 

@winformsTest
@EnquiryTest
@NAB_AUTO
@EN_E_PostcodeEnquiry
@18467
Scenario Outline: Test Case 18467: 04_Post Code Enquiries Error Messages for Display options
	# Enquiry System -Action PCE
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to Holder Enquiry System
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | PCE   |
			| Locate Argument |       |
		And I Search Postcode Enquiry System details as "<Country>" "<DisplayOption>" "<StartLocation>" "<State>"
	Then I should see the below ErrorMessage "<ErrorMessage>"

	Examples: 
		| Test  | Country | DisplayOption | StartLocation | State | ErrorMessage                           |
		| Test1 | A       | DLAS          | INDIA         |       | No Match On Location/State Found       |
		| Test2 | A       | DLPC          | ABCD          |       | No Match On Postcode Found             |
		| Test3 | A       | DLPC          | 1234          |       | No Match On Postcode Found             |
		| Test4 | A       | DLPC          |               |       | No Match On Postcode Found             |
		| Test5 | A       | DLPS          | 1234          |       | No Match On Presort Code Found         |
		| Test6 | A       | DLBP          | 999           |       | No Match On Barcode Presort Code Found |
