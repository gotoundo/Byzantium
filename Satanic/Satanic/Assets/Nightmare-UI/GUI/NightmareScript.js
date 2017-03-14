#pragma strict
import System.Collections.Generic;

// This script will only work with the Nightmare skin
var NightmareSkin : GUISkin;
var Image1 : Texture2D;

// Some info about our loading animation
var LoadingAnimation1 : Texture2D;
private var LoadingAnimation1TileX : int = 23; 			// Here you can place the number of columns of your sheet. 
private var LoadingAnimation1TileY : int = 1; 			// Here you can place the number of rows of your sheet. 
private var LoadingAnimation1FPS : float = 30.0;		// Frames per second
private var LoadingAnimation1Start : boolean = true;	// Start/Stop the loading animation
private var LA1PUT : float = 0.100; 					// Percentage update interval

// Windows
private var Windows : NMWindowInfo[] = new NMWindowInfo[4];

// The first window info
Windows[0].rect = Rect(0, 0, 463, 697);
Windows[0].Alpha = 0.0;
Windows[0].UIAlpha = 0.0;
Windows[0].Show = true;
Windows[0].TimeToWait = 0.0;
Windows[0].Speed = 2.0;

// The second window info
Windows[1].rect = Rect(463, 28, 463, 697);
Windows[1].Alpha = 0.0;
Windows[1].UIAlpha = 0.0;
Windows[1].Show = true;
Windows[1].TimeToWait = 0.0;
Windows[1].Speed = 2.0;

// The third window info
Windows[2].rect = Rect(926, 0, 463, 697);
Windows[2].Alpha = 0.0;
Windows[2].UIAlpha = 0.0;
Windows[2].Show = true;
Windows[2].TimeToWait = 0.0;
Windows[2].Speed = 2.0;

// The login window
Windows[3].rect = Rect(1389, 28, 385, 447);
Windows[3].Alpha = 0.0;
Windows[3].UIAlpha = 0.0;
Windows[3].Show = true;
Windows[3].TimeToWait = 1.0; // If you wish to delay the Fade execution, set this value to the UI time when it should execute, eg: Time.time +_2.0;
Windows[3].Speed = 2.0;


function OnGUI ()
{
	GUI.skin = NightmareSkin;
	
	// Do the windows
	DoWindow(0, DoWindow0);
	DoWindow(1, DoWindow1);
	DoWindow(2, DoWindow2);
	DoWindow(3, DoWindow3);
	
	//now adjust to the group. (0,0) is the topleft corner of the group.
	GUI.BeginGroup(Rect(0,0,100,100));
	// End the group we started above. This is very important to remember!
	GUI.EndGroup ();
}

/*
*	Window 0 
*/

// The window content call
function DoWindow0 (windowID : int) 
{
	GUI.color.a = Windows[windowID].UIAlpha;
	
	// Adds skull to the given window
	DoFrameSkull(windowID);
	
	// Do the window title
	DoWindowTitle(windowID, "WINDOW TITLE");

	// Do a text with the first style
	DoTextStyle1(Rect(66, 147, 332, 86), "Pellentesque consectetur purus id dui convallis, in aliquet elit bibendum. Integer at lacus vel nibh suscipit tempor nec eget turpis. Suspendisse eu ante velit. Curabitur nec feugiat sem.");
	
	// Do an image
	if (Image1)
		DoImage(Vector2(47, 223), Image1);
	
	// Do a separator
	DoSeparator(Vector2(57, 368));
	
	// Do some toggles
	Windows[3].Show = DoToggle(Vector2(67, 409), Windows[3].Show, "Display the login window?");
	Windows[1].Show = DoToggle(Vector2(67, 446), Windows[1].Show, "Display the second window?");
	Windows[2].Show = DoToggle(Vector2(67, 486), Windows[2].Show, "Display the thrid window?");
	
	// Do a fliped separator
	DoSeparator(Vector2(57, 523));
	
	// Do a text with the second style
	DoTextStyle2(Rect(66, 567, 326, 100), "Aliquam semper facilisis tellus sit amet tincidunt. Phasellus eu sodales leo, quis porta nisl. Vivamus imperdiet rhoncus odio, eget vestibulum ligula dictum at.");

	// Make the windows be draggable.
	GUI.DragWindow (Rect (0,0,10000,10000));
}

/* 
*	Window 1 
*/

// Text Field content
private var textFieldStr : String = "Click to edit this text input field";
// Text Area content
private var textAreaStr : String = "FSuspendisse potenti. Cras eleifend nisi sit amet molestie pellentesque. Fusce vehicula eros neque, a suscipit tortor tristique id. Nam ullamcorper luctus tempus. Sed posuere volutpat dolor. Nunc nibh lacus, congue eu scelerisque non, euismod non libero. ";
// The selected radio toggle value
private var radioSelected : int = 0;

// The window content call
function DoWindow1 (windowID : int) 
{
	GUI.color.a = Windows[windowID].UIAlpha;
	
	// Do the window title
	DoWindowTitle(windowID, "SECOND WINDOW");

	// Do a button
	DoButton(Rect(105, 126, 245, 87), "BUTTON");
	
	// Do a text area
	//textAreaStr = GUI.TextArea(Rect(62, 233, 338, 187), textAreaStr);
	
	// Do a text container
	GUI.BeginGroup(Rect(62, 233, 338, 187), GUIStyle("textContainer"));
	DoTextContainerTitle(Rect(24, 19, 293, 20), "Text Container");
	DoTextContainerText(Rect(24, 53, 299, 71), "Duis commodo sagittis magna ut imperdiet. Sed sit amet elit justo. Ut non diam in diam pharetra sagittis in interdum elit. Morbi ultricies est vitae ipsum placerat pellentesque non sed lorem. Duis sagittis eu quam id vestibulum.");
	GUI.EndGroup();
	
	// Do a text field
	textFieldStr = GUI.TextField(Rect(62, 441, 339, 58), textFieldStr);
	
	var radios : String[] = new String[3];
	radios[0] = "Semper facilisis tellus ?";
	radios[1] = "Phasellus eu sodales leo!";
	radios[2] = "Aliquam semper facilisis tellus...";
	
	// Do a group of radio style toggles
	radioSelected = ToggleList(Rect(69, 522, 324, 105), radioSelected, radios);
	
	// Make the windows be draggable.
	GUI.DragWindow (Rect (0,0,10000,10000));
}

/*
*	Window 2
*/

// Scroll View variables
private var scrollPosition : Vector2 = Vector2.zero;
private var scrollViewText : String = "Fusce ac justo ornare, tempor purus eu, sagittis diam. Donec eu erat eget odio ullamcorper iaculis. Proin placerat tincidunt velit, id pharetra dolor tempor vitae.Donec eu erat eget odio ullamcorper iaculis. Fusce ac justo ornare, tempor purus eu, sagittis diam. Donec eu erat eget odio ullamcorper iaculis. Fusce ac justo ornare, tempor purus eu, sagittis diam. Donec eu erat eget odio ullamcorper iaculis. Proin placerat tincidunt velit, id pharetra dolor tempor vitae.Donec eu erat eget odio ullamcorper iaculis.";
// Text Field content
private var textFieldStr1 : String = "Click to edit this text input field";

// The window content call
function DoWindow2 (windowID : int) 
{
	GUI.color.a = Windows[windowID].UIAlpha;
	
	// Adds skull to the given window
	DoFrameSkull(windowID);
	
	// Do the window title
	DoWindowTitle(windowID, "THIRD WINDOW");
	
	// Do a scroll view
	scrollPosition = DoScrollView(Rect(62, 154, 338, 187), Rect(0, 0, 380, 240), scrollPosition, ScrollView0);
	
	// Do a horizontal slider
	LA1PUT = GUI.HorizontalSlider(Rect(67, 361, 331, 10), LA1PUT, 0.0, 0.2);
	
	// Do a vertical slider
	LoadingAnimation1FPS = GUI.VerticalSlider(Rect(67, 400, 10, 164), LoadingAnimation1FPS, 20.0, 40.0);
	
	// Do the loading animation
	if (LoadingAnimation1)
		DoAnimation1(Vector2(153, 404));
	
	// Do a label
	DoLabel(Rect(190, 581, 77, 19), "Text Label");
	
	// Do a text field
	textFieldStr1 = GUI.TextField(Rect(62, 599, 339, 58), textFieldStr1);

	// Make the windows be draggable.
	GUI.DragWindow (Rect (0,0,10000,10000));
}

function ScrollView0 (position : Vector2, contentRect : Rect)
{
	// Do a text with the first style
	DoTextStyle2(Rect(0, 0, contentRect.width, contentRect.height), scrollViewText, TextAnchor.UpperLeft);
}

/*
*	Login Window 3
*/

// Toggle boolean
private var rememberme = false;
// Text Fields content
private var textFieldStr2 : String = "Please enter username";
private var textFieldStr3 : String = "Please enter password";

function DoWindow3 (windowID : int) 
{
	GUI.color.a = Windows[windowID].UIAlpha;
	
	// Do a label
	DoLabel(Rect(152, 58, 77, 19), "Username");
	
	// Do a text field
	textFieldStr2 = GUI.TextField(Rect(56, 76, 274, 58), textFieldStr2);
	
	// Do a label
	DoLabel(Rect(154, 148, 71, 19), "Password");
	
	// Do a text field
	textFieldStr3 = GUI.TextField(Rect(56, 166, 274, 58), textFieldStr3);
	
	// Do a toggle
	rememberme = DoToggle(Vector2(106, 246), rememberme, "Remember me?");
	
	// Do a button
	DoButton(Rect(70, 287, 245, 87), "LOGIN");
	
	// Make the windows be draggable.
	GUI.DragWindow (Rect (0,0,10000,10000));
}

// Some variables for the loading animation
private var LoadingAnimation1TexOffset : Vector2 = Vector2(0, 0);
private var LoadingAnimation1TexSize : Vector2 = Vector2(1.0 / LoadingAnimation1TileX, 1.0 / LoadingAnimation1TileY);
private var LoadingAnimation1Percentage : float = 0.0;
private var LA1NPUT : float = 0.0;

function Update()
{
	// Window Animations
	// Loop trough our windows
	for (var i : int = 0; i < Windows.Length; i++)
	{
		// Check if delay is set
		if (Time.time >= Windows[i].TimeToWait)
		{
			var newAlpha : float;
			
			// Determine wether to fadeIn or fadeOut
			if (Windows[i].Show)
			{
				// FadeIn
				if (Windows[i].Alpha < 1.0)
		    	{
		    		newAlpha = Windows[i].Alpha + (Time.deltaTime * Windows[i].Speed);
					Windows[i].Alpha = newAlpha;
					Windows[i].UIAlpha = newAlpha;
				}
				else
				{
					Windows[i].Alpha = 1.0; // Accounts for Time.deltaTime variance
					Windows[i].UIAlpha = 1.0;
				}
			}
			else
			{
				// FadeOut
				if (Windows[i].Alpha > 0.0)
		    	{
		    		newAlpha = Windows[i].Alpha - (Time.deltaTime * Windows[i].Speed);
					Windows[i].Alpha = newAlpha;
					Windows[i].UIAlpha = newAlpha - (Time.deltaTime * Windows[i].Speed) * 2; // On FadeOut we must increase the UI fading speed abit
				}
				else
				{
					Windows[i].Alpha = 0.0; // Accounts for Time.deltaTime variance
					Windows[i].UIAlpha = 0.0;
				}
			}
		}
	}
    
    // Loading Animation 1
    if (LoadingAnimation1Start && LoadingAnimation1)
    {
	    // Calculate index
		var index : int = Time.time * LoadingAnimation1FPS;
		// repeat when exhausting all frames
		index = index % (LoadingAnimation1TileX * LoadingAnimation1TileY);
	 
		// Size of every tile
		LoadingAnimation1TexSize = Vector2 (1.0 / LoadingAnimation1TileX, 1.0 / LoadingAnimation1TileY);
	 
		// split into horizontal and vertical index
		var uIndex = index % LoadingAnimation1TileX;
		var vIndex = index / LoadingAnimation1TileX;
	 	
		// build offset
		// v coordinate is the bottom of the image in opengl so we need to invert.
		LoadingAnimation1TexOffset = Vector2(uIndex * LoadingAnimation1TexSize.x, 1.0 - LoadingAnimation1TexSize.y - vIndex * LoadingAnimation1TexSize.y);
		
		// Calculate the percentage
		var totalFrames : int = LoadingAnimation1TileX * LoadingAnimation1TileY;
		var percentage  : float;
		percentage = (1.0 * index) / (1.0 * totalFrames);
		percentage = percentage * 100;
		
		// Set the percentage for usage outside of this functions scope
		if (Time.time >= LA1NPUT)
		{
			LoadingAnimation1Percentage = Mathf.Round(percentage);
			LA1NPUT += LA1PUT;
		}
	}
}

/*
	Layout functions
	
		- DoWindow (windowID : int, func : GUI.WindowFunction)
		- DoFrameSkull(windowID : int)
		- DoWindowTitle(windowID : int, text : String)
		- DoScrollView(rect : Rect, contentRect : Rect, position : Vector2, callback : Function) : Vector2
		- DoLabel(r : Rect, text : String)
		- DoLabel(r : Rect, text : String, leftImage : boolean, rightImage : boolean)
		- DoImage(offset : Vector2, imageTexture : Texture2D)
		- DoTextWithShadow(rect : Rect, content : GUIContent, style : GUIStyle, txtColor : Color, shadowColor : Color, direction : Vector2)
		- DoTextStyle1(r : Rect, text : String)
		- DoTextStyle1(r : Rect, text : String, alignment : TextAnchor)
		- DoTextStyle2(r : Rect, text : String)
		- DoTextStyle2(r : Rect, text : String, alignment : TextAnchor)
		- DoSeparator(offset : Vector2)
		- DoToggle(offset : Vector2, toggle : boolean, text : String) : boolean
		- ToggleList(offset : Rect, selected : int, items : String[]) : int
		- DoTextContainerTitle(r : Rect, text : String)
		- DoTextContainerText(r : Rect, text : String)
		- DoButton(r : Rect, content : String) : boolean
		- DoAnimation1(offset : Vector2)
*/

function DoWindow (windowID : int, func : GUI.WindowFunction)
{
	// Do the windows
	// The alpha is set to enable fading animations
	GUI.color.a = Windows[windowID].Alpha;
	
	var style : GUIStyle = GUI.skin.GetStyle("window");
	var newStyle : GUIStyle = new GUIStyle(style);
	
	// In case the window is drawn with a skull
	if (Windows[windowID].Skull)
	{
		// Add top overflow to the window
		newStyle.overflow.top = -28;
		
		if (!Windows[windowID].AddedOverflow)
		{
			// Add the overflow to the window height
			Windows[windowID].rect.height = Windows[windowID].rect.height + 28;
			Windows[windowID].AddedOverflow = true;
		}
	}
	
	// Draw the actual window now
	Windows[windowID].rect = GUI.Window(windowID, Windows[windowID].rect, func, "", newStyle);
}

function DoFrameSkull(windowID : int) 
{
	var offset : Vector2 = Vector2(0, 0);
	// Determine the width and height of the title background
	var width : float = 370;
	var height : float = 136;
	
	// Calculate the offset in the middle of the frame
	offset.x = (Windows[windowID].rect.width - width) / 2;
	
	// Draw the skull
	GUI.Label(Rect(offset.x, offset.y, width, height), "", "windowSkull");
	
	// This tells the window to draw with additional overflow
	Windows[windowID].Skull = true;
}

function DoWindowTitle(windowID : int, text : String)
{
	var titleLeft : float = 30;
	var titleRight : float = 30;
	// Different offsets if there is a skull and if there is not
	var bgOffset : Vector2 = Vector2(titleLeft, (Windows[windowID].AddedOverflow ? 67 : 39));
	
	// Determine the width and height of the title background
	var bgWidth : float = Windows[windowID].rect.width - (titleLeft + titleRight);
	var bgHeight : float = 90;
	var windowTitleBGRect = Rect(bgOffset.x, bgOffset.y, bgWidth, bgHeight);
	
	// Lay the title background
	GUI.Label(windowTitleBGRect, "", "windowTitleBackground");
	
	// If we have a skull
	if (Windows[windowID].Skull)
	{
		// Calculate the offset for the teeth
		var teethOffset : Vector2 = Vector2(((Windows[windowID].rect.width - 50) / 2) + 1, (Windows[windowID].AddedOverflow ? 67 : 39));
		var teethRect : Rect = Rect(teethOffset.x, teethOffset.y, 49, 14);
		
		// Lay the skull teeth
		GUI.Label(teethRect, "", "windowTitleTeeth");
	}
	
	var titleStyle : GUIStyle = GUI.skin.GetStyle("windowTitle");
	var titleShadowStyle : GUIStyle = GUI.skin.GetStyle("windowTitleShadow");
	var titleRect : Rect = Rect(0, (Windows[windowID].AddedOverflow ? 81 : 53), Windows[windowID].rect.width, 25);
	
	// Draw the title
	DoTextWithShadow(titleRect, GUIContent(text), titleStyle, titleStyle.normal.textColor, titleShadowStyle.normal.textColor, Vector2(1, 2));
}

function DoScrollView(rect : Rect, contentRect : Rect, position : Vector2, callback : Function) : Vector2
{
	var style : GUIStyle = GUI.skin.GetStyle("scrollview");
	
	// Update the scroll view rect, we have added overflow which extends the size and we should reduce it
	var newRect : Rect = new Rect(
		(rect.x + style.overflow.left), // Add the left overflow as left offset
		(rect.y + style.overflow.top), // Add the top overflow as top offset
		(rect.width - style.overflow.left - style.overflow.right), // Exclude the left and right overflow from the scroll view size
		(rect.height - style.overflow.top - style.overflow.bottom) // Exclude the top and bottom overflow from the scroll view size
	);
	
	// begin the scroll view
	position = GUI.BeginScrollView(newRect, position, contentRect);
	
	// Call the user function that renders the content
	callback(position, contentRect);
	
	// End the scroll view that we began above.
	GUI.EndScrollView();
	
	return position;
}

function DoLabel(r : Rect, text : String)
{
	DoLabel(r, text, true, true);
}

function DoLabel(r : Rect, text : String, leftImage : boolean, rightImage : boolean)
{
	var LabelStyle : GUIStyle = GUI.skin.GetStyle("label");
	var LabelShadowStyle : GUIStyle = GUI.skin.GetStyle("labelTextShadow");
	
	if (leftImage)
		GUI.Label(Rect((r.x - 3 - 67), (r.y + 6), 0, 0), "", "labelLeft");
	
	if (rightImage)
		GUI.Label(Rect((r.x + 5 + r.width), (r.y + 6), 0, 0), "", "labelRight");
	
	DoTextWithShadow(r, GUIContent(text), LabelStyle, LabelStyle.normal.textColor, LabelShadowStyle.normal.textColor, Vector2(1.0, 1.0));
}

function DoImage(offset : Vector2, imageTexture : Texture2D)
{
	var frameSize : Vector2 = Vector2(imageTexture.width + 58, imageTexture.height + 58);
	
	GUI.BeginGroup(Rect(offset.x, offset.y, frameSize.x, frameSize.y));
	GUI.DrawTexture(Rect(29, 30, imageTexture.width, imageTexture.height), imageTexture);
	GUI.Label(Rect(0, 0, frameSize.x, frameSize.y), "", "imageFrame");
	GUI.EndGroup();
}

function DoTextWithShadow(rect : Rect, content : GUIContent, style : GUIStyle, txtColor : Color, shadowColor : Color, direction : Vector2)
{
    var backupStyle : GUIStyle = new GUIStyle(style);

    style.normal.textColor = shadowColor;
    rect.x += direction.x;
    rect.y += direction.y;
    GUI.Label(rect, content, style);

    style.normal.textColor = txtColor;
    rect.x -= direction.x;
    rect.y -= direction.y;
    GUI.Label(rect, content, style);

    style = backupStyle;
}

function DoTextStyle1(r : Rect, text : String)
{
	DoTextStyle1(r, text, TextAnchor.UpperLeft);
}

function DoTextStyle1(r : Rect, text : String, alignment : TextAnchor)
{
	var TextStyle : GUIStyle = GUI.skin.GetStyle("textStyle1");
	var TextStyleShadow : GUIStyle = GUI.skin.GetStyle("textStyle1Shadow");
	
	// We will create a new style so we can edit the text anchor
	var newStyle : GUIStyle = new GUIStyle(TextStyle);
	// Apply the text anchor
	newStyle.alignment = alignment;
	
	DoTextWithShadow(r, GUIContent(text), newStyle, newStyle.normal.textColor, TextStyleShadow.normal.textColor, Vector2(1.0, 1.0));
}

function DoTextStyle2(r : Rect, text : String)
{
	DoTextStyle2(r, text, TextAnchor.UpperCenter);
}

function DoTextStyle2(r : Rect, text : String, alignment : TextAnchor)
{
	var TextStyle : GUIStyle = GUI.skin.GetStyle("textStyle2");
	var TextStyleShadow : GUIStyle = GUI.skin.GetStyle("textStyle2Shadow");
	
	// We will create a new style so we can edit the text anchor
	var newStyle : GUIStyle = new GUIStyle(TextStyle);
	// Apply the text anchor
	newStyle.alignment = alignment;
	
	DoTextWithShadow(r, GUIContent(text), newStyle, newStyle.normal.textColor, TextStyleShadow.normal.textColor, Vector2(1.0, 1.0));
}


function DoSeparator(offset : Vector2)
{
	GUI.Label(Rect(offset.x, offset.y, 356, 39), "", "separator");
}

function DoToggle(offset : Vector2, toggle : boolean, text : String) : boolean
{
	var ToggleTextStyle : GUIStyle = GUI.skin.GetStyle("toggleText");
	var ToggleTextShadowStyle : GUIStyle = GUI.skin.GetStyle("toggleTextShadow");
	
	GUI.BeginGroup(Rect(offset.x, offset.y, 322, 29));
	toggle = GUI.Toggle(Rect(0, 0, 33, 29), toggle, "");
	DoTextWithShadow(Rect(40, 4, 290, 29), GUIContent(text), ToggleTextStyle, ToggleTextStyle.normal.textColor, ToggleTextShadowStyle.normal.textColor, Vector2(1.0, 1.0));
	GUI.EndGroup();
	
	return toggle;
}

// Displays a vertical list of toggles and returns the index of the selected item.
function ToggleList(offset : Rect, selected : int, items : String[]) : int
{
    // Keep the selected index within the bounds of the items array
    selected = (selected < 0) ? 0 : (selected >= items.Length ? items.Length - 1 : selected);
	
	// Get the radio toggles style
	var radioStyle : GUIStyle = GUI.skin.GetStyle("radioToggle");
	var ToggleTextStyle : GUIStyle = GUI.skin.GetStyle("toggleText");
	var ToggleTextShadowStyle : GUIStyle = GUI.skin.GetStyle("toggleTextShadow");
	
	// Get the toggles height
	var height : int = radioStyle.fixedHeight;
	var width : int = radioStyle.fixedWidth;
	
	GUI.BeginGroup(Rect(offset.x, offset.y, offset.width, (height * items.Length) + height));
    GUILayout.BeginVertical();
    
    var offsetY : float = 0;
    var textOffsetX : float = 37;
    
    for (var i : int = 0; i < items.Length; i++)
    {
        // Display toggle. Get if toggle changed.
        var change : boolean = GUI.Toggle(Rect(0, offsetY, width, height), selected == i, "", radioStyle);
		DoTextWithShadow(Rect(textOffsetX, (offsetY + 4), (offset.width - textOffsetX), height), GUIContent(items[i]), ToggleTextStyle, ToggleTextStyle.normal.textColor, ToggleTextShadowStyle.normal.textColor, Vector2(1.0, 1.0));
		
        // If changed, set selected to current index.
        if (change)
            selected = i;
            
        // Increase the offset for the next toggle
        offsetY = offsetY + (height + 10);
    }

    GUILayout.EndVertical();
	GUI.EndGroup();
	
    // Return the currently selected item's index
    return selected;
}

function DoTextContainerTitle(r : Rect, text : String)
{
	var TextStyle : GUIStyle = GUI.skin.GetStyle("textContainerTitle");
	
	DoTextWithShadow(r, GUIContent(text), TextStyle, TextStyle.normal.textColor, TextStyle.hover.textColor, Vector2(1.0, 1.0));
}

function DoTextContainerText(r : Rect, text : String)
{
	var TextStyle : GUIStyle = GUI.skin.GetStyle("textContainerText");
	
	DoTextWithShadow(r, GUIContent(text), TextStyle, TextStyle.normal.textColor, TextStyle.hover.textColor, Vector2(1.0, 1.0));
}

function DoButton(r : Rect, content : String) : boolean
{
	var buttonStyle : GUIStyle = GUI.skin.GetStyle("button");
	var ButtonTextStyle : GUIStyle = GUI.skin.GetStyle("buttonText");
	var backupStyle : GUIStyle = new GUIStyle(ButtonTextStyle);
	var ShadowStyle : GUIStyle = GUI.skin.GetStyle("buttonTextShadow");
	
	var size : Rect = Rect(0, 0, r.width, r.height);
	var buttonRect : Rect = Rect(buttonStyle.overflow.left, buttonStyle.overflow.top, (r.width - buttonStyle.overflow.left - buttonStyle.overflow.right), (r.height - buttonStyle.overflow.top - buttonStyle.overflow.bottom));
	
	GUI.BeginGroup(r);
	
	// Do the button, exclude the overflow from the size
    var result : boolean = GUI.Button(buttonRect, "");
    
	// Get the colors for diferrent scenarios
    var color : Color = (buttonRect.Contains(Event.current.mousePosition) && Input.GetMouseButton(0)) ? ButtonTextStyle.active.textColor : (buttonRect.Contains(Event.current.mousePosition) ? ButtonTextStyle.hover.textColor : ButtonTextStyle.normal.textColor);
	var colorShadow : Color = (buttonRect.Contains(Event.current.mousePosition) && Input.GetMouseButton(0)) ? ShadowStyle.active.textColor : (buttonRect.Contains(Event.current.mousePosition) ? ShadowStyle.hover.textColor : ShadowStyle.normal.textColor);
	var direction : Vector2 = Vector2(0.0, 1.0);
	
	// Do the text
    DoTextWithShadow(size, GUIContent(content), ButtonTextStyle, color, colorShadow, direction);
	
	GUI.EndGroup();
	
	// Restore the color
	ButtonTextStyle.normal.textColor = backupStyle.normal.textColor;
	
    return result;
}

function DoAnimation1(offset : Vector2)
{
	GUI.BeginGroup(Rect(offset.x, offset.y, 153, 147));
	
	// Set the background
	GUI.Label(Rect(0, 0, 153, 147), "", "animationBackground");
	
	// Draw the texture
	var position : Rect = new Rect(29, 23, 100, 102);
	var texCoords : Rect = new Rect(LoadingAnimation1TexOffset.x, LoadingAnimation1TexOffset.y, LoadingAnimation1TexSize.x, LoadingAnimation1TexSize.y);
	var alpha : boolean = true;
	
	GUI.DrawTextureWithTexCoords(position, LoadingAnimation1, texCoords, alpha);
	
	// Do the percentage
	var PercentageStyle : GUIStyle = GUI.skin.GetStyle("animationPercentage");
	var TextStyle : GUIStyle = GUI.skin.GetStyle("animationText");
	var TextShadowStyle : GUIStyle = GUI.skin.GetStyle("animationTextShadow");

	DoTextWithShadow(Rect(46, 54, 65, 25), GUIContent(LoadingAnimation1Percentage + "%"), PercentageStyle, PercentageStyle.normal.textColor, PercentageStyle.hover.textColor, Vector2(1.0, 1.0));
	DoTextWithShadow(Rect(59, 80, 59, 15), GUIContent("loading"), TextStyle, TextStyle.normal.textColor, TextShadowStyle.normal.textColor, Vector2(1.0, 1.0));
	
	GUI.EndGroup();
}

class NMWindowInfo extends System.ValueType
{
	var rect : Rect;
	var Alpha : float;
	var UIAlpha : float;
	var Show : boolean;
	var TimeToWait : float;
	var Speed : float;
	var Skull : boolean;
	var AddedOverflow : boolean;
	
	public function NMWindowInfo(rect : Rect, alpha : float, uialpha : float, show : boolean, TimeToWait : int, speed : float, skull : boolean)
	{
		this.rect = rect;
		this.Alpha = alpha;
		this.UIAlpha = uialpha;
		this.Show = show;
		this.TimeToWait = TimeToWait;
		this.Speed = speed;
		this.Skull = skull;
	}
}