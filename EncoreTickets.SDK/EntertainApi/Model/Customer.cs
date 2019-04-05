﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace EncoreTickets.SDK.EntertainApi.Model
{
    public class Customer
    {
        public string title { get; set; }

        public string firstName { get; set; }

        public string surname { get; set; }

        public string address1 { get; set; }

        public string address2 { get; set; }

        public string city { get; set; }

        public string county { get; set; }

        public string postcode { get; set; }

        public string country { get; set; }

        public string phoneNo { get; set; }

        public string email { get; set; }

        public string confirmEmail { get; set; }

        public string optMail { get; set; }
        public bool subscribe { get; set; }
        public string ticketDispatch { get; set; }
        public bool termsAndConditions { get; set; }

        public IEnumerable<string> Titles
        {
            get
            {
                return new List<string> { "Mr", "Mrs", "Ms", "Miss" };            
            }
        }

        /*public string FormattedCustomerAddress
        {
            get
            {
                var stringBuilder = new StringBuilder();

                if (!string.IsNullOrEmpty(Address1)) stringBuilder.Append(Address1 + "<br />");

                if (!string.IsNullOrEmpty(Address2)) stringBuilder.Append(Address2 + "<br />");

                if (!string.IsNullOrEmpty(City)) stringBuilder.Append(City + "<br />");

                if (!string.IsNullOrEmpty(County)) stringBuilder.Append(County + "<br />");

                if (!string.IsNullOrEmpty(Postcode)) stringBuilder.Append(Postcode + "<br />");

                if (!string.IsNullOrEmpty(Country)) stringBuilder.Append(Country);

                return stringBuilder.ToString();
            }
        }
        */

        public Dictionary<string,string> Countries
        {
            get
            {
                return new Dictionary<string, string>
                {
                    { "AL|ALB|Albania", "Albania" },
                    { "DZ|DZA|Algeria", "Algeria" },
                    { "AS|ASM|American Samoa", "American Samoa" },
                    { "AD|AND|Andorra", "Andorra" },
                    { "AO|AGO|Angola", "Angola" },
                    { "AI|AIA|Anguilla", "Anguilla" },
                    { "AQ|ATA|Antarctica", "Antarctica" },
                    { "AG|ATG|Antigua and Barbuda", "Antigua and Barbuda" },
                    { "ARG|ARG|Argentina", "Argentina" },
                    { "AM|ARM|Armenia", "Armenia" },
                    { "AW|ABW|Aruba", "Aruba" },
                    { "AU|AUS|Australia", "Australia" },
                    { "A|AUT|Austria", "Austria" },
                    { "AZ|AZE|Azerbaijan", "Azerbaijan" },
                    { "BS|BHS|Bahamas", "Bahamas" },
                    { "BH|BHR|Bahrain", "Bahrain" },
                    { "BD|BGD|Bangladesh", "Bangladesh" },
                    { "BB|BRB|Barbados", "Barbados" },
                    { "BY|BLR|Belarus", "Belarus" },
                    { "B|BEL|Belgium", "Belgium" },
                    { "BZ|BLZ|Belize", "Belize" },
                    { "BJ|BEN|Benin", "Benin" },
                    { "BM|BMU|Bermuda", "Bermuda" },
                    { "BT|BTN|Bhutan", "Bhutan" },
                    { "BO|BOL|Bolivia", "Bolivia" },
                    { "BA|BIH|Bosnia and Herzegovina", "Bosnia and Herzegovina" },
                    { "BW|BWA|Botswana", "Botswana" },
                    { "BV|BVT|Bouvet Island", "Bouvet Island" },
                    { "BRA|BRA|Brazil", "Brazil" },
                    { "IO|IOT|British Indian Ocean Territory", "British Indian Ocean Territory" },
                    { "BN|BRN|Brunei", "Brunei" },
                    { "BG|BGR|Bulgaria", "Bulgaria" },
                    { "BF|BFA|Burkina Faso", "Burkina Faso" },
                    { "BI|BDI|Burundi", "Burundi" },
                    { "KH|KHM|Cambodia", "Cambodia" },
                    { "CM|CMR|Cameroon", "Cameroon" },
                    { "CDN|CAN|Canada", "Canada" },
                    { "CV|CPV|Cape Verde", "Cape Verde" },
                    { "KY|CYM|Cayman Islands", "Cayman Islands" },
                    { "CF|CAF|Central African Republic", "Central African Republic" },
                    { "TD|TCD|Chad", "Chad" },
                    { "CL|CHL|Chile", "Chile" },
                    { "CN|CHN|China", "China" },
                    { "CX|CXR|Christmas Island", "Christmas Island" },
                    { "CC|CCK|Cocos (Keeling) Islands", "Cocos (Keeling) Islands" },
                    { "CO|COL|Colombia", "Colombia" },
                    { "KM|COM|Comoros", "Comoros" },
                    { "CG|COG|Congo", "Congo" },
                    { "CK|COK|Cook Islands", "Cook Islands" },
                    { "CR|CRI|Costa Rica", "Costa Rica" },
                    { "HR|HRV|Croatia", "Croatia" },
                    { "CU|CUB|Cuba", "Cuba" },
                    { "CY|CYP|Cyprus", "Cyprus" },
                    { "CZ|CZE|Czech Republic", "Czech Republic" },
                    { "DK|DNK|Denmark", "Denmark" },
                    { "DJI|Djibouti", "Djibouti" },
                    { "DM|DMA|Dominica", "Dominica" },
                    { "DO|DOM|Dominican Republic", "Dominican Republic" },
                    { "TP|TMP|East Timor", "East Timor" },
                    { "EC|ECU|Ecuador", "Ecuador" },
                    { "EG|EGY|Egypt", "Egypt" },
                    { "SV|SLV|El Salvador", "El Salvador" },
                    { "GQ|GNQ|Equatorial Guinea", "Equatorial Guinea" },
                    { "ER|ERI|Eritrea", "Eritrea" },
                    { "EE|EST|Estonia", "Estonia" },
                    { "ET|ETH|Ethiopia", "Ethiopia" },
                    { "FK|FLK|Falkland Islands", "Falkland Islands" },
                    { "FO|FRO|Faroe Islands", "Faroe Islands" },
                    { "FJ|FJI|Fiji", "Fiji" },
                    { "FIN|FIN|Finland", "Finland" },
                    { "F|FRA|France", "France" },
                    { "GF|GUF|French Guiana", "French Guiana" },
                    { "PF|PYF|French Polynesia", "French Polynesia" },
                    { "GA|GAB|Gabon", "Gabon" },
                    { "GM|GMB|Gambia", "Gambia" },
                    { "GE|GEO|Georgia", "Georgia" },
                    { "D|DEU|Germany", "Germany" },
                    { "GH|GHA|Ghana", "Ghana" },
                    { "GI|GIB|Gibraltar", "Gibraltar" },
                    { "GR|GRC|Greece", "Greece" },
                    { "GL|GRL|Greenland", "Greenland" },
                    { "GD|GRD|Grenada", "Grenada" },
                    { "GP|GLP|Guadeloupe", "Guadeloupe" },
                    { "GU|GUM|Guam", "Guam" },
                    { "GT|GTM|Guatemala", "Guatemala" },
                    { "GN|GIN|Guinea", "Guinea" },
                    { "GW|GNB|Guinea-Bissau", "Guinea-Bissau" },
                    { "GY|GUY|Guyana", "Guyana" },
                    { "HT|HTI|Haiti", "Haiti" },
                    { "HM|HMD|Heard and McDonald Islands", "Heard and McDonald Islands" },
                    { "HN|HND|Honduras", "Honduras" },
                    { "HK|HKG|Hong Kong", "Hong Kong" },
                    { "HU|HUN|Hungary", "Hungary" },
                    { "IS|ISL|Iceland", "Iceland" },
                    { "IN|IND|India", "India" },
                    { "ID|IDN|Indonesia", "Indonesia" },
                    { "IR|IRN|Iran", "Iran" },
                    { "IQ|IRQ|Iraq", "Iraq" },
                    { "IE|IRL|Ireland", "Ireland" },
                    { "ISL|ISR|Israel", "Israel" },
                    { "I|ITA|Italy", "Italy" },
                    { "JM|JAM|Jamaica", "Jamaica" },
                    { "J|JPN|Japan", "Japan" },
                    { "JO|JOR|Jordan", "Jordan" },
                    { "KZ|KAZ|Kazakhstan", "Kazakhstan" },
                    { "KE|KEN|Kenya", "Kenya" },
                    { "KI|KIR|Kiribati", "Kiribati" },
                    { "KP|PRK|Korea (North)", "Korea (North)" },
                    { "KR|KOR|Korea (South)", "Korea (South)" },
                    { "KW|KWT|Kuwait", "Kuwait" },
                    { "KG|KGZ|Kyrgyzstan", "Kyrgyzstan" },
                    { "LA|LAO|Laos", "Laos" },
                    { "LV|LVA|Latvia", "Latvia" },
                    { "LB|LBN|Lebanon", "Lebanon" },
                    { "LS|LSO|Lesotho", "Lesotho" },
                    { "LR|LBR|Liberia", "Liberia" },
                    { "LY|LBY|Libya", "Libya" },
                    { "LI|LIE|Liechtenstein", "Liechtenstein" },
                    { "LT|LTU|Lithuania", "Lithuania" },
                    { "LU|LUX|Luxembourg", "Luxembourg" },
                    { "MO|MAC|Macau", "Macau" },
                    { "MK|MKD|Macedonia", "Macedonia" },
                    { "MG|MGD|Madagascar", "Madagascar" },
                    { "MW|MWI|Malawi", "Malawi" },
                    { "MY|MYS|Malaysia", "Malaysia" },
                    { "MV|MDV|Maldives", "Maldives" },
                    { "ML|MLI|Mali", "Mali" },
                    { "MTA|MLT|Malta", "Malta" },
                    { "MH|MHL|Marshall Islands", "Marshall Islands" },
                    { "MQ|MTQ|Martinique", "Martinique" },
                    { "MR|MRT|Mauritania", "Mauritania" },
                    { "MU|MUS|Mauritius", "Mauritius" },
                    { "YT|MYT|Mayotte", "Mayotte" },
                    { "MEX|MEX|Mexico", "Mexico" },
                    { "FM|FSM|Micronesia", "Micronesia" },
                    { "MD|MDA|Moldova", "Moldova" },
                    { "MC|MCO|Monaco", "Monaco" },
                    { "MN|MNG|Mongolia", "Mongolia" },
                    { "MS|MSR|Montserrat", "Montserrat" },
                    { "MA|MAR|Morocco", "Morocco" },
                    { "MZ|MOZ|Mozambique", "Mozambique" },
                    { "MM|MMR|Myanmar", "Myanmar" },
                    { "NA|NAM|Namibia", "Namibia" },
                    { "NR|NRU|Nauru", "Nauru" },
                    { "NP|NPL|Nepal", "Nepal" },
                    { "NL|NLD|Netherlands", "Netherlands" },
                    { "AN|ANT|Netherlands Antilles", "Netherlands Antilles" },
                    { "NC|NCL|New Caledonia", "New Caledonia" },
                    { "NZ|NZL|New Zealand", "New Zealand" },
                    { "NI|NIC|Nicaragua", "Nicaragua" },
                    { "NE|NER|Niger", "Niger" },
                    { "NG|NGA|Nigeria", "Nigeria" },
                    { "NU|NIU|Niue", "Niue" },
                    { "NF|NFK|Norfolk Island", "Norfolk Island" },
                    { "MP|MNP|Northern Mariana Islands", "Northern Mariana Islands" },
                    { "N|NOR|Norway", "Norway" },
                    { "OM|OMN|Oman", "Oman" },
                    { "PK|PAK|Pakistan", "Pakistan" },
                    { "PW|PLW|Palau", "Palau" },
                    { "PA|PAN|Panama", "Panama" },
                    { "PG|PNG|Papua New Guinea", "Papua New Guinea" },
                    { "PY|PRY|Paraguay", "Paraguay" },
                    { "PE|PER|Peru", "Peru" },
                    { "PH|PHL|Philippines", "Philippines" },
                    { "PN|PCN|Pitcairn", "Pitcairn" },
                    { "PL|POL|Poland", "Poland" },
                    { "PT|PRT|Portugal", "Portugal" },
                    { "PR|PRI|Puerto Rico", "Puerto Rico" },
                    { "QA|QAT|Qatar", "Qatar" },
                    { "RE|REU|Reunion", "Reunion" },
                    { "RO|ROU|Romania", "Romania" },
                    { "RU|RUS|Russian Federation", "Russian Federation" },
                    { "RW|RWA|Rwanda", "Rwanda" },
                    { "GS|SGS|S. Georgia and S. Sandwich Isls.", "S. Georgia and S. Sandwich Isls." },
                    { "KN|KNA|Saint Kitts and Nevis", "Saint Kitts and Nevis" },
                    { "LC|LCA|Saint Lucia", "Saint Lucia" },
                    { "VC|VCT|Saint Vincent and the Grenadines", "Saint Vincent and the Grenadines" },
                    { "WS|WSM|Samoa", "Samoa" },
                    { "SM|SMR|San Marino", "San Marino" },
                    { "ST|STP|Sao Tome and Principe", "Sao Tome and Principe" },
                    { "SA|SAU|Saudi Arabia", "Saudi Arabia" },
                    { "SN|SEN|Senegal", "Senegal" },
                    { "SC|SYC|Seychelles", "Seychelles" },
                    { "SL|SLE|Sierra Leone", "Sierra Leone" },
                    { "SG|SGP|Singapore", "Singapore" },
                    { "SK|SVK|Slovak Republic", "Slovak Republic" },
                    { "SI|SVN|Slovenia", "Slovenia" },
                    { "SB|SLB|Solomon Islands", "Solomon Islands" },
                    { "SO|SOM|Somalia", "Somalia" },
                    { "RSA|ZAF|South Africa", "South Africa" },
                    { "E|ESP|Spain", "Spain" },
                    { "LK|LKA|Sri Lanka", "Sri Lanka" },
                    { "SH|SHN|St. Helena", "St. Helena" },
                    { "PM|SPM|St. Pierre and Miquelon", "St. Pierre and Miquelon" },
                    { "SD|SDN|Sudan", "Sudan" },
                    { "SR|SUR|Suriname", "Suriname" },
                    { "SZ|SWZ|Swaziland", "Swaziland" },
                    { "S|SWE|Sweden", "Sweden" },
                    { "CH|CHE|Switzerland", "Switzerland" },
                    { "SY|SYR|Syria", "Syria" },
                    { "TW|TWN|Taiwan", "Taiwan" },
                    { "TJ|TJK|Tajikistan", "Tajikistan" },
                    { "TZ|TZA|Tanzania", "Tanzania" },
                    { "TH|THA|Thailand", "Thailand" },
                    { "TG|TGO|Togo", "Togo" },
                    { "TK|TKL|Tokelau", "Tokelau" },
                    { "TO|TON|Tonga", "Tonga" },
                    { "TT|TTO|Trinidad and Tobago", "Trinidad and Tobago" },
                    { "TN|TUN|Tunisia", "Tunisia" },
                    { "TR|TUR|Turkey", "Turkey" },
                    { "TM|TKM|Turkmenistan", "Turkmenistan" },
                    { "TC|TCA|Turks and Caicos Islands", "Turks and Caicos Islands" },
                    { "TV|TUV|Tuvalu", "Tuvalu" },
                    { "UG|UGA|Uganda", "Uganda" },
                    { "UA|UKR|Ukraine", "Ukraine" },
                    { "AE|ARE|United Arab Emirates", "United Arab Emirates" },
                    { "UK|GBR|United Kingdom", "United Kingdom" },
                    { "USA|USA|United States", "United States" },
                    { "UY|URY|Uruguay", "Uruguay" },
                    { "UM|UMI|US Minor Outlying Islands", "US Minor Outlying Islands" },
                    { "UZ|UZB|Uzbekistan", "Uzbekistan" },
                    { "VU|VUT|Vanuatu", "Vanuatu" },
                    { "VA|VAT|Vatican City", "Vatican City" },
                    { "VE|VEN|Venezuela", "Venezuela" },
                    { "VN|VNM|Viet Nam", "Viet Nam" },
                    { "VG|VGB|British Virgin Islands", "British Virgin Islands" },
                    { "VI|VIR|US Virgin Islands", "US Virgin Islands" },
                    { "WF|WLF|Wallis and Futuna Islands", "Wallis and Futuna Islands" },
                    { "EH|ESH|Western Sahara", "Western Sahara" },
                    { "YE|YEM|Yemen", "Yemen" },
                    { "YU|YUG|Yugoslavia", "Yugoslavia" },
                    { "ZR|ZAR|Zaire", "Zaire" },
                    { "ZM|ZMB|Zambia", "Zambia" },
                    { "ZW|ZWE|Zimbabwe", "Zimbabwe" },
                };
            }
        }

        public Customer()
        {
            country = "UK|GBR|United Kingdom";
            optMail = "C";
            subscribe = true;
        }
    }
}