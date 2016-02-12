﻿/************************************************************************
 * 
 * The MIT License (MIT)
 * 
 * Copyright (c) 2025 - Christian Falch
 * 
 * Permission is hereby granted, free of charge, to any person obtaining 
 * a copy of this software and associated documentation files (the 
 * "Software"), to deal in the Software without restriction, including 
 * without limitation the rights to use, copy, modify, merge, publish, 
 * distribute, sublicense, and/or sell copies of the Software, and to 
 * permit persons to whom the Software is furnished to do so, subject 
 * to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be 
 * included in all copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, 
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF 
 * MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. 
 * IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY 
 * CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, 
 * TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE 
 * SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
 * 
 ************************************************************************/

using System;
using Xamarin.Forms;

namespace NControl.Controls
{
	/// <summary>
	/// Font awesome label.
	/// </summary>
	public class FontAwesomeLabel: Label
	{
		/// <summary>
		/// The name of the font awesome.
		/// </summary>
		public const string FontAwesomeName = "FontAwesome";

		/// <summary>
		/// Initializes a new instance of the <see cref="NControl.Controls.FontAwesomeLabel"/> class.
		/// </summary>
		public FontAwesomeLabel()
		{
			FontFamily = FontAwesomeName;
			FontSize = 18;
            HorizontalTextAlignment = TextAlignment.Center;
            VerticalTextAlignment = TextAlignment.Center;
		}

		#region Icon Constants

		public static string FAGlass = "\uf000";
		public static string FAMusic = "\uf001";
		public static string FASearch = "\uf002";
		public static string FAEnvelopeO = "\uf003";
		public static string FAHeart = "\uf004";
		public static string FAStar = "\uf005";
		public static string FAStarO = "\uf006";
		public static string FAUser = "\uf007";
		public static string FAFilm = "\uf008";
		public static string FAThLarge = "\uf009";
		public static string FATh = "\uf00a";
		public static string FAThList = "\uf00b";
		public static string FACheck = "\uf00c";
		public static string FATimes = "\uf00d";
		public static string FASearchPlus = "\uf00e";
		public static string FASearchMinus = "\uf010";
		public static string FAPowerOff = "\uf011";
		public static string FASignal = "\uf012";
		public static string FACog = "\uf013";
		public static string FATrashO = "\uf014";
		public static string FAHome = "\uf015";
		public static string FAFileO = "\uf016";
		public static string FAClockO = "\uf017";
		public static string FARoad = "\uf018";
		public static string FADownload = "\uf019";
		public static string FAArrowCircleODown = "\uf01a";
		public static string FAArrowCircleOUp = "\uf01b";
		public static string FAInbox = "\uf01c";
		public static string FAPlayCircleO = "\uf01d";
		public static string FARepeat = "\uf01e";
		public static string FARefresh = "\uf021";
		public static string FAListAlt = "\uf022";
		public static string FALock = "\uf023";
		public static string FAFlag = "\uf024";
		public static string FAHeadphones = "\uf025";
		public static string FAVolumeOff = "\uf026";
		public static string FAVolumeDown = "\uf027";
		public static string FAVolumeUp = "\uf028";
		public static string FAQrcode = "\uf029";
		public static string FABarcode = "\uf02a";
		public static string FATag = "\uf02b";
		public static string FATags = "\uf02c";
		public static string FABook = "\uf02d";
		public static string FABookmark = "\uf02e";
		public static string FAPrint = "\uf02f";
		public static string FACamera = "\uf030";
		public static string FAFont = "\uf031";
		public static string FABold = "\uf032";
		public static string FAItalic = "\uf033";
		public static string FATextHeight = "\uf034";
		public static string FATextWidth = "\uf035";
		public static string FAAlignLeft = "\uf036";
		public static string FAAlignCenter = "\uf037";
		public static string FAAlignRight = "\uf038";
		public static string FAAlignJustify = "\uf039";
		public static string FAList = "\uf03a";
		public static string FAOutdent = "\uf03b";
		public static string FAIndent = "\uf03c";
		public static string FAVideoCamera = "\uf03d";
		public static string FAPictureO = "\uf03e";
		public static string FAPencil = "\uf040";
		public static string FAMapMarker = "\uf041";
		public static string FAAdjust = "\uf042";
		public static string FATint = "\uf043";
		public static string FAPencilSquareO = "\uf044";
		public static string FAShareSquareO = "\uf045";
		public static string FACheckSquareO = "\uf046";
		public static string FAArrows = "\uf047";
		public static string FAStepBackward = "\uf048";
		public static string FAFastBackward = "\uf049";
		public static string FABackward = "\uf04a";
		public static string FAPlay = "\uf04b";
		public static string FAPause = "\uf04c";
		public static string FAStop = "\uf04d";
		public static string FAForward = "\uf04e";
		public static string FAFastForward = "\uf050";
		public static string FAStepForward = "\uf051";
		public static string FAEject = "\uf052";
		public static string FAChevronLeft = "\uf053";
		public static string FAChevronRight = "\uf054";
		public static string FAPlusCircle = "\uf055";
		public static string FAMinusCircle = "\uf056";
		public static string FATimesCircle = "\uf057";
		public static string FACheckCircle = "\uf058";
		public static string FAQuestionCircle = "\uf059";
		public static string FAInfoCircle = "\uf05a";
		public static string FACrosshairs = "\uf05b";
		public static string FATimesCircleO = "\uf05c";
		public static string FACheckCircleO = "\uf05d";
		public static string FABan = "\uf05e";
		public static string FAArrowLeft = "\uf060";
		public static string FAArrowRight = "\uf061";
		public static string FAArrowUp = "\uf062";
		public static string FAArrowDown = "\uf063";
		public static string FAShare = "\uf064";
		public static string FAExpand = "\uf065";
		public static string FACompress = "\uf066";
		public static string FAPlus = "\uf067";
		public static string FAMinus = "\uf068";
		public static string FAAsterisk = "\uf069";
		public static string FAExclamationCircle = "\uf06a";
		public static string FAGift = "\uf06b";
		public static string FALeaf = "\uf06c";
		public static string FAFire = "\uf06d";
		public static string FAEye = "\uf06e";
		public static string FAEyeSlash = "\uf070";
		public static string FAExclamationTriangle = "\uf071";
		public static string FAPlane = "\uf072";
		public static string FACalendar = "\uf073";
		public static string FARandom = "\uf074";
		public static string FAComment = "\uf075";
		public static string FAMagnet = "\uf076";
		public static string FAChevronUp = "\uf077";
		public static string FAChevronDown = "\uf078";
		public static string FARetweet = "\uf079";
		public static string FAShoppingCart = "\uf07a";
		public static string FAFolder = "\uf07b";
		public static string FAFolderOpen = "\uf07c";
		public static string FAArrowsV = "\uf07d";
		public static string FAArrowsH = "\uf07e";
		public static string FABarChartO = "\uf080";
		public static string FATwitterSquare = "\uf081";
		public static string FAFacebookSquare = "\uf082";
		public static string FACameraRetro = "\uf083";
		public static string FAKey = "\uf084";
		public static string FACogs = "\uf085";
		public static string FAComments = "\uf086";
		public static string FAThumbsOUp = "\uf087";
		public static string FAThumbsODown = "\uf088";
		public static string FAStarHalf = "\uf089";
		public static string FAHeartO = "\uf08a";
		public static string FASignOut = "\uf08b";
		public static string FALinkedinSquare = "\uf08c";
		public static string FAThumbTack = "\uf08d";
		public static string FAExternalLink = "\uf08e";
		public static string FASignIn = "\uf090";
		public static string FATrophy = "\uf091";
		public static string FAGithubSquare = "\uf092";
		public static string FAUpload = "\uf093";
		public static string FALemonO = "\uf094";
		public static string FAPhone = "\uf095";
		public static string FASquareO = "\uf096";
		public static string FABookmarkO = "\uf097";
		public static string FAPhoneSquare = "\uf098";
		public static string FATwitter = "\uf099";
		public static string FAFacebook = "\uf09a";
		public static string FAGithub = "\uf09b";
		public static string FAUnlock = "\uf09c";
		public static string FACreditCard = "\uf09d";
		public static string FARss = "\uf09e";
		public static string FAHddO = "\uf0a0";
		public static string FABullhorn = "\uf0a1";
		public static string FABell = "\uf0f3";
		public static string FACertificate = "\uf0a3";
		public static string FAHandORight = "\uf0a4";
		public static string FAHandOLeft = "\uf0a5";
		public static string FAHandOUp = "\uf0a6";
		public static string FAHandODown = "\uf0a7";
		public static string FAArrowCircleLeft = "\uf0a8";
		public static string FAArrowCircleRight = "\uf0a9";
		public static string FAArrowCircleUp = "\uf0aa";
		public static string FAArrowCircleDown = "\uf0ab";
		public static string FAGlobe = "\uf0ac";
		public static string FAWrench = "\uf0ad";
		public static string FATasks = "\uf0ae";
		public static string FAFilter = "\uf0b0";
		public static string FABriefcase = "\uf0b1";
		public static string FAArrowsAlt = "\uf0b2";
		public static string FAUsers = "\uf0c0";
		public static string FALink = "\uf0c1";
		public static string FACloud = "\uf0c2";
		public static string FAFlask = "\uf0c3";
		public static string FAScissors = "\uf0c4";
		public static string FAFilesO = "\uf0c5";
		public static string FAPaperclip = "\uf0c6";
		public static string FAFloppyO = "\uf0c7";
		public static string FASquare = "\uf0c8";
		public static string FABars = "\uf0c9";
		public static string FAListUl = "\uf0ca";
		public static string FAListOl = "\uf0cb";
		public static string FAStrikethrough = "\uf0cc";
		public static string FAUnderline = "\uf0cd";
		public static string FATable = "\uf0ce";
		public static string FAMagic = "\uf0d0";
		public static string FATruck = "\uf0d1";
		public static string FAPinterest = "\uf0d2";
		public static string FAPinterestSquare = "\uf0d3";
		public static string FAGooglePlusSquare = "\uf0d4";
		public static string FAGooglePlus = "\uf0d5";
		public static string FAMoney = "\uf0d6";
		public static string FACaretDown = "\uf0d7";
		public static string FACaretUp = "\uf0d8";
		public static string FACaretLeft = "\uf0d9";
		public static string FACaretRight = "\uf0da";
		public static string FAColumns = "\uf0db";
		public static string FASort = "\uf0dc";
		public static string FASortAsc = "\uf0dd";
		public static string FASortDesc = "\uf0de";
		public static string FAEnvelope = "\uf0e0";
		public static string FALinkedin = "\uf0e1";
		public static string FAUndo = "\uf0e2";
		public static string FAGavel = "\uf0e3";
		public static string FATachometer = "\uf0e4";
		public static string FACommentO = "\uf0e5";
		public static string FACommentsO = "\uf0e6";
		public static string FABolt = "\uf0e7";
		public static string FASitemap = "\uf0e8";
		public static string FAUmbrella = "\uf0e9";
		public static string FAClipboard = "\uf0ea";
		public static string FALightbulbO = "\uf0eb";
		public static string FAExchange = "\uf0ec";
		public static string FACloudDownload = "\uf0ed";
		public static string FACloudUpload = "\uf0ee";
		public static string FAUserMd = "\uf0f0";
		public static string FAStethoscope = "\uf0f1";
		public static string FASuitcase = "\uf0f2";
		public static string FABellO = "\uf0a2";
		public static string FACoffee = "\uf0f4";
		public static string FACutlery = "\uf0f5";
		public static string FAFileTextO = "\uf0f6";
		public static string FABuildingO = "\uf0f7";
		public static string FAHospitalO = "\uf0f8";
		public static string FAAmbulance = "\uf0f9";
		public static string FAMedkit = "\uf0fa";
		public static string FAFighterJet = "\uf0fb";
		public static string FABeer = "\uf0fc";
		public static string FAHSquare = "\uf0fd";
		public static string FAPlusSquare = "\uf0fe";
		public static string FAAngleDoubleLeft = "\uf100";
		public static string FAAngleDoubleRight = "\uf101";
		public static string FAAngleDoubleUp = "\uf102";
		public static string FAAngleDoubleDown = "\uf103";
		public static string FAAngleLeft = "\uf104";
		public static string FAAngleRight = "\uf105";
		public static string FAAngleUp = "\uf106";
		public static string FAAngleDown = "\uf107";
		public static string FADesktop = "\uf108";
		public static string FALaptop = "\uf109";
		public static string FATablet = "\uf10a";
		public static string FAMobile = "\uf10b";
		public static string FACircleO = "\uf10c";
		public static string FAQuoteLeft = "\uf10d";
		public static string FAQuoteRight = "\uf10e";
		public static string FASpinner = "\uf110";
		public static string FACircle = "\uf111";
		public static string FAReply = "\uf112";
		public static string FAGithubAlt = "\uf113";
		public static string FAFolderO = "\uf114";
		public static string FAFolderOpenO = "\uf115";
		public static string FASmileO = "\uf118";
		public static string FAFrownO = "\uf119";
		public static string FAMehO = "\uf11a";
		public static string FAGamepad = "\uf11b";
		public static string FAKeyboardO = "\uf11c";
		public static string FAFlagO = "\uf11d";
		public static string FAFlagCheckered = "\uf11e";
		public static string FATerminal = "\uf120";
		public static string FACode = "\uf121";
		public static string FAReplyAll = "\uf122";
		public static string FAMailReplyAll = "\uf122";
		public static string FAStarHalfO = "\uf123";
		public static string FALocationArrow = "\uf124";
		public static string FACrop = "\uf125";
		public static string FACodeFork = "\uf126";
		public static string FAChainBroken = "\uf127";
		public static string FAQuestion = "\uf128";
		public static string FAInfo = "\uf129";
		public static string FAExclamation = "\uf12a";
		public static string FASuperscript = "\uf12b";
		public static string FASubscript = "\uf12c";
		public static string FAEraser = "\uf12d";
		public static string FAPuzzlePiece = "\uf12e";
		public static string FAMicrophone = "\uf130";
		public static string FAMicrophoneSlash = "\uf131";
		public static string FAShield = "\uf132";
		public static string FACalendarO = "\uf133";
		public static string FAFireExtinguisher = "\uf134";
		public static string FARocket = "\uf135";
		public static string FAMaxcdn = "\uf136";
		public static string FAChevronCircleLeft = "\uf137";
		public static string FAChevronCircleRight = "\uf138";
		public static string FAChevronCircleUp = "\uf139";
		public static string FAChevronCircleDown = "\uf13a";
		public static string FAHtml5 = "\uf13b";
		public static string FACss3 = "\uf13c";
		public static string FAAnchor = "\uf13d";
		public static string FAUnlockAlt = "\uf13e";
		public static string FABullseye = "\uf140";
		public static string FAEllipsisH = "\uf141";
		public static string FAEllipsisV = "\uf142";
		public static string FARssSquare = "\uf143";
		public static string FAPlayCircle = "\uf144";
		public static string FATicket = "\uf145";
		public static string FAMinusSquare = "\uf146";
		public static string FAMinusSquareO = "\uf147";
		public static string FALevelUp = "\uf148";
		public static string FALevelDown = "\uf149";
		public static string FACheckSquare = "\uf14a";
		public static string FAPencilSquare = "\uf14b";
		public static string FAExternalLinkSquare = "\uf14c";
		public static string FAShareSquare = "\uf14d";
		public static string FACompass = "\uf14e";
		public static string FACaretSquareODown = "\uf150";
		public static string FACaretSquareOUp = "\uf151";
		public static string FACaretSquareORight = "\uf152";
		public static string FAEur = "\uf153";
		public static string FAGbp = "\uf154";
		public static string FAUsd = "\uf155";
		public static string FAInr = "\uf156";
		public static string FAJpy = "\uf157";
		public static string FARub = "\uf158";
		public static string FAKrw = "\uf159";
		public static string FABtc = "\uf15a";
		public static string FAFile = "\uf15b";
		public static string FAFileText = "\uf15c";
		public static string FASortAlphaAsc = "\uf15d";
		public static string FASortAlphaDesc = "\uf15e";
		public static string FASortAmountAsc = "\uf160";
		public static string FASortAmountDesc = "\uf161";
		public static string FASortNumericAsc = "\uf162";
		public static string FASortNumericDesc = "\uf163";
		public static string FAThumbsUp = "\uf164";
		public static string FAThumbsDown = "\uf165";
		public static string FAYoutubeSquare = "\uf166";
		public static string FAYoutube = "\uf167";
		public static string FAXing = "\uf168";
		public static string FAXingSquare = "\uf169";
		public static string FAYoutubePlay = "\uf16a";
		public static string FADropbox = "\uf16b";
		public static string FAStackOverflow = "\uf16c";
		public static string FAInstagram = "\uf16d";
		public static string FAFlickr = "\uf16e";
		public static string FAAdn = "\uf170";
		public static string FABitbucket = "\uf171";
		public static string FABitbucketSquare = "\uf172";
		public static string FATumblr = "\uf173";
		public static string FATumblrSquare = "\uf174";
		public static string FALongArrowDown = "\uf175";
		public static string FALongArrowUp = "\uf176";
		public static string FALongArrowLeft = "\uf177";
		public static string FALongArrowRight = "\uf178";
		public static string FAApple = "\uf179";
		public static string FAWindows = "\uf17a";
		public static string FAAndroid = "\uf17b";
		public static string FALinux = "\uf17c";
		public static string FADribbble = "\uf17d";
		public static string FASkype = "\uf17e";
		public static string FAFoursquare = "\uf180";
		public static string FATrello = "\uf181";
		public static string FAFemale = "\uf182";
		public static string FAMale = "\uf183";
		public static string FAGittip = "\uf184";
		public static string FASunO = "\uf185";
		public static string FAMoonO = "\uf186";
		public static string FAArchive = "\uf187";
		public static string FABug = "\uf188";
		public static string FAVk = "\uf189";
		public static string FAWeibo = "\uf18a";
		public static string FARenren = "\uf18b";
		public static string FAPagelines = "\uf18c";
		public static string FAStackExchange = "\uf18d";
		public static string FAArrowCircleORight = "\uf18e";
		public static string FAArrowCircleOLeft = "\uf190";
		public static string FACaretSquareOLeft = "\uf191";
		public static string FADotCircleO = "\uf192";
		public static string FAWheelchair = "\uf193";
		public static string FAVimeoSquare = "\uf194";
		public static string FATry = "\uf195";
		public static string FAPlusSquareO = "\uf196"; 

		public static string FACar = "\uf1b9";

		#endregion

	}
}

