//
//  SiriRemote.cs
//  tvRemote
//
//  Created by Kevin Mullins on 10/22/15.
//  Copyright (c) 2015 Xamarin. All rights reserved.
//
//  Generated by PaintCode (www.paintcodeapp.com)
//



using System;
using System.Drawing;
using Foundation;
using UIKit;
using CoreGraphics;

// Fix to allow tvOS to consume iOS Core Graphics
#if __TVOS__
using UIColor = global::UIKit.TVColor;
using UIFont = global::UIKit.TVFont;
#endif

namespace tvRemote
{
    [Register ("SiriRemote")]
    public class SiriRemote : NSObject
    {

        //// Initialization

        static SiriRemote()
        {
        }

        //// Drawing Methods

        public static void DrawSiriRemote(string pressed, string arrow)
        {
            //// General Declarations
            var colorSpace = CGColorSpace.CreateDeviceRGB();
            var context = UIGraphics.GetCurrentContext();

            //// Color Declarations
            var gradientColor = UIColor.FromRGBA(1.000f, 1.000f, 1.000f, 1.000f);
            var gradientColor2 = UIColor.FromRGBA(0.000f, 0.000f, 0.000f, 1.000f);
            var gradientColor3 = UIColor.FromRGBA(0.368f, 0.368f, 0.368f, 1.000f);
            var gradientColor4 = UIColor.FromRGBA(0.147f, 0.147f, 0.147f, 1.000f);
            var strokeColor = UIColor.FromRGBA(0.521f, 0.521f, 0.521f, 1.000f);
            var strokeColor2 = UIColor.FromRGBA(0.264f, 0.260f, 0.260f, 1.000f);
            var fillColor = UIColor.FromRGBA(0.000f, 0.000f, 0.000f, 1.000f);
            var textForeground = UIColor.FromRGBA(1.000f, 1.000f, 1.000f, 1.000f);
            var strokeColor3 = UIColor.FromRGBA(1.000f, 1.000f, 1.000f, 1.000f);
            var fillColor2 = UIColor.FromRGBA(1.000f, 1.000f, 1.000f, 1.000f);
            var pressedColor = UIColor.FromRGBA(0.847f, 0.187f, 0.187f, 1.000f);
            var gradientColor5 = UIColor.FromRGBA(0.401f, 0.015f, 0.015f, 1.000f);

            //// Gradient Declarations
            var radialGradient1Colors = new CGColor [] {gradientColor.CGColor, gradientColor2.CGColor};
            var radialGradient1Locations = new nfloat [] {0.0f, 1.0f};
            var radialGradient1 = new CGGradient(colorSpace, radialGradient1Colors, radialGradient1Locations);
            var touchGradientColors = new CGColor [] {gradientColor3.CGColor, gradientColor4.CGColor};
            var touchGradientLocations = new nfloat [] {0.0f, 1.0f};
            var touchGradient = new CGGradient(colorSpace, touchGradientColors, touchGradientLocations);
            var pressedGradientColors = new CGColor [] {pressedColor.CGColor, gradientColor5.CGColor};
            var pressedGradientLocations = new nfloat [] {0.0f, 1.0f};
            var pressedGradient = new CGGradient(colorSpace, pressedGradientColors, pressedGradientLocations);

            //// Variable Declarations
            var menuPressed = pressed == "Menu" ? pressedColor : fillColor;
            var homePressed = pressed == "Home" ? pressedColor : fillColor;
            var siriPressed = pressed == "Siri" ? pressedColor : fillColor;
            var volumePressed = pressed == "Volume" ? pressedColor : fillColor;
            var playPausePressed = pressed == "PlayPause" ? pressedColor : fillColor;
            var touchSurfacePressed = pressed == "Touch" ? pressedGradient : touchGradient;
            var upArrow = arrow == "Up" ? true : false;
            var downArrow = arrow == "Down" ? true : false;
            var leftArrow = arrow == "Left" ? true : false;
            var rightArrow = arrow == "Right" ? true : false;

            //// Page-1
            {
                //// Intro01
                {
                    //// Siri-Remote-Render
                    {
                        //// Rectangle-4 Drawing
                        var rectangle4Path = UIBezierPath.FromRoundedRect(new CGRect(1.0f, 0.0f, 253.0f, 747.0f), 40.0f);
                        context.SaveState();
                        rectangle4Path.AddClip();
                        context.DrawRadialGradient(radialGradient1,
                            new CGPoint(8.62f, 234.62f), 0.0f,
                            new CGPoint(8.62f, 234.62f), 567.36f,
                            CGGradientDrawingOptions.DrawsBeforeStartLocation | CGGradientDrawingOptions.DrawsAfterEndLocation);
                        context.RestoreState();
                        strokeColor.SetStroke();
                        rectangle4Path.LineWidth = 3.0f;
                        rectangle4Path.Stroke();


                        //// Rectangle-4-Copy Drawing
                        UIBezierPath rectangle4CopyPath = new UIBezierPath();
                        rectangle4CopyPath.MoveTo(new CGPoint(254.0f, 312.0f));
                        rectangle4CopyPath.AddLineTo(new CGPoint(254.0f, 40.0f));
                        rectangle4CopyPath.AddCurveToPoint(new CGPoint(214.0f, 0.0f), new CGPoint(254.0f, 17.91f), new CGPoint(236.09f, 0.0f));
                        rectangle4CopyPath.AddLineTo(new CGPoint(41.0f, 0.0f));
                        rectangle4CopyPath.AddCurveToPoint(new CGPoint(1.0f, 40.0f), new CGPoint(18.92f, 0.0f), new CGPoint(1.0f, 17.91f));
                        rectangle4CopyPath.AddLineTo(new CGPoint(1.0f, 312.0f));
                        rectangle4CopyPath.AddLineTo(new CGPoint(254.0f, 312.0f));
                        rectangle4CopyPath.ClosePath();
                        rectangle4CopyPath.MiterLimit = 4.0f;

                        rectangle4CopyPath.UsesEvenOddFillRule = true;

                        context.SaveState();
                        rectangle4CopyPath.AddClip();
                        context.DrawLinearGradient(touchSurfacePressed,
                            new CGPoint(127.5f, 0.0f),
                            new CGPoint(127.5f, 312.0f),
                            CGGradientDrawingOptions.DrawsBeforeStartLocation | CGGradientDrawingOptions.DrawsAfterEndLocation);
                        context.RestoreState();
                        strokeColor2.SetStroke();
                        rectangle4CopyPath.LineWidth = 3.0f;
                        rectangle4CopyPath.Stroke();


                        //// Menu-Button
                        {
                            //// Oval-1 Drawing
                            var oval1Path = UIBezierPath.FromOval(new CGRect(18.0f, 214.0f, 87.0f, 87.0f));
                            menuPressed.SetFill();
                            oval1Path.Fill();


                            //// Label Drawing
                            CGRect labelRect = new CGRect(31.42f, 243.0f, 71.58f, 30.0f);
                            textForeground.SetFill();
                            new NSString("MENU").DrawString(labelRect, UIFont.BoldSystemFontOfSize(20.0f), UILineBreakMode.WordWrap, UITextAlignment.Left);


                            if (upArrow)
                            {
                                //// Bezier Drawing
                                UIBezierPath bezierPath = new UIBezierPath();
                                bezierPath.MoveTo(new CGPoint(105.5f, 74.5f));
                                bezierPath.AddLineTo(new CGPoint(149.5f, 74.5f));
                                bezierPath.AddLineTo(new CGPoint(127.5f, 44.5f));
                                bezierPath.AddLineTo(new CGPoint(105.5f, 74.5f));
                                pressedColor.SetFill();
                                bezierPath.Fill();
                            }


                            if (downArrow)
                            {
                                //// Bezier 2 Drawing
                                UIBezierPath bezier2Path = new UIBezierPath();
                                bezier2Path.MoveTo(new CGPoint(106.0f, 180.0f));
                                bezier2Path.AddLineTo(new CGPoint(150.0f, 180.0f));
                                bezier2Path.AddLineTo(new CGPoint(128.0f, 210.0f));
                                bezier2Path.AddLineTo(new CGPoint(106.0f, 180.0f));
                                pressedColor.SetFill();
                                bezier2Path.Fill();
                            }


                            if (rightArrow)
                            {
                                //// Bezier 3 Drawing
                                context.SaveState();
                                context.TranslateCTM(212.0f, 129.0f);
                                context.RotateCTM(90.0f * NMath.PI / 180.0f);

                                UIBezierPath bezier3Path = new UIBezierPath();
                                bezier3Path.MoveTo(new CGPoint(-22.0f, 15.0f));
                                bezier3Path.AddLineTo(new CGPoint(22.0f, 15.0f));
                                bezier3Path.AddLineTo(new CGPoint(0.0f, -15.0f));
                                bezier3Path.AddLineTo(new CGPoint(-22.0f, 15.0f));
                                pressedColor.SetFill();
                                bezier3Path.Fill();

                                context.RestoreState();
                            }


                            if (leftArrow)
                            {
                                //// Bezier 4 Drawing
                                context.SaveState();
                                context.TranslateCTM(38.0f, 129.0f);
                                context.RotateCTM(-90.0f * NMath.PI / 180.0f);

                                UIBezierPath bezier4Path = new UIBezierPath();
                                bezier4Path.MoveTo(new CGPoint(-22.0f, 15.0f));
                                bezier4Path.AddLineTo(new CGPoint(22.0f, 15.0f));
                                bezier4Path.AddLineTo(new CGPoint(0.0f, -15.0f));
                                bezier4Path.AddLineTo(new CGPoint(-22.0f, 15.0f));
                                pressedColor.SetFill();
                                bezier4Path.Fill();

                                context.RestoreState();
                            }
                        }


                        //// Home-Button
                        {
                            //// Oval-1-Copy Drawing
                            var oval1CopyPath = UIBezierPath.FromOval(new CGRect(147.0f, 214.0f, 87.0f, 87.0f));
                            homePressed.SetFill();
                            oval1CopyPath.Fill();


                            //// Rectangle-1-+-Line
                            {
                                //// Rectangle-1 Drawing
                                var rectangle1Path = UIBezierPath.FromRect(new CGRect(166.0f, 239.0f, 49.0f, 32.0f));
                                strokeColor3.SetStroke();
                                rectangle1Path.LineWidth = 2.0f;
                                rectangle1Path.Stroke();


                                //// Line Drawing
                                UIBezierPath linePath = new UIBezierPath();
                                linePath.MoveTo(new CGPoint(174.5f, 276.0f));
                                linePath.AddLineTo(new CGPoint(205.56f, 276.0f));
                                linePath.MiterLimit = 4.0f;

                                linePath.LineCapStyle = CGLineCap.Square;

                                linePath.UsesEvenOddFillRule = true;

                                strokeColor3.SetStroke();
                                linePath.LineWidth = 2.0f;
                                linePath.Stroke();
                            }
                        }


                        //// Volume-Button
                        {
                            //// Rectangle- 6 Drawing
                            var rectangle6Path = UIBezierPath.FromRoundedRect(new CGRect(147.0f, 321.0f, 87.0f, 197.0f), 40.0f);
                            volumePressed.SetFill();
                            rectangle6Path.Fill();


                            //// Label 2 Drawing
                            CGRect label2Rect = new CGRect(174.96f, 329.0f, 31.08f, 71.0f);
                            textForeground.SetFill();
                            new NSString("+\n").DrawString(label2Rect, UIFont.BoldSystemFontOfSize(48.0f), UILineBreakMode.WordWrap, UITextAlignment.Left);


                            //// Label 3 Drawing
                            CGRect label3Rect = new CGRect(179.89f, 436.0f, 21.21f, 71.0f);
                            textForeground.SetFill();
                            new NSString("-").DrawString(label3Rect, UIFont.BoldSystemFontOfSize(48.0f), UILineBreakMode.WordWrap, UITextAlignment.Left);
                        }


                        //// Siri-Button
                        {
                            //// Oval-1-Copy-2 Drawing
                            var oval1Copy2Path = UIBezierPath.FromOval(new CGRect(18.0f, 321.0f, 87.0f, 87.0f));
                            siriPressed.SetFill();
                            oval1Copy2Path.Fill();


                            //// Group 11
                            {
                                //// Rectangle- 10 Drawing
                                var rectangle10Path = UIBezierPath.FromRoundedRect(new CGRect(49.52f, 338.0f, 22.55f, 38.57f), 11.27f);
                                fillColor2.SetFill();
                                rectangle10Path.Fill();


                                //// Path-2 Drawing
                                UIBezierPath path2Path = new UIBezierPath();
                                path2Path.MoveTo(new CGPoint(46.0f, 363.63f));
                                path2Path.AddCurveToPoint(new CGPoint(61.24f, 381.48f), new CGPoint(46.0f, 363.63f), new CGPoint(45.67f, 381.58f));
                                path2Path.AddCurveToPoint(new CGPoint(76.81f, 363.25f), new CGPoint(76.81f, 381.38f), new CGPoint(76.81f, 363.25f));
                                path2Path.MiterLimit = 4.0f;

                                path2Path.UsesEvenOddFillRule = true;

                                strokeColor3.SetStroke();
                                path2Path.LineWidth = 4.0f;
                                path2Path.Stroke();


                                //// Line 2 Drawing
                                UIBezierPath line2Path = new UIBezierPath();
                                line2Path.MoveTo(new CGPoint(61.5f, 381.83f));
                                line2Path.AddLineTo(new CGPoint(61.5f, 389.55f));
                                line2Path.MiterLimit = 4.0f;

                                line2Path.LineCapStyle = CGLineCap.Square;

                                line2Path.UsesEvenOddFillRule = true;

                                strokeColor3.SetStroke();
                                line2Path.LineWidth = 4.0f;
                                line2Path.Stroke();


                                //// Line 3 Drawing
                                UIBezierPath line3Path = new UIBezierPath();
                                line3Path.MoveTo(new CGPoint(49.88f, 390.6f));
                                line3Path.AddLineTo(new CGPoint(72.46f, 390.6f));
                                line3Path.MiterLimit = 4.0f;

                                line3Path.LineCapStyle = CGLineCap.Square;

                                line3Path.UsesEvenOddFillRule = true;

                                strokeColor3.SetStroke();
                                line3Path.LineWidth = 4.0f;
                                line3Path.Stroke();
                            }
                        }


                        //// Play/Pause-Button
                        {
                            //// Oval-1-Copy-3 Drawing
                            var oval1Copy3Path = UIBezierPath.FromOval(new CGRect(18.0f, 428.0f, 87.0f, 87.0f));
                            playPausePressed.SetFill();
                            oval1Copy3Path.Fill();


                            //// Path-5-+-Line-+-Line-Copy
                            {
                                //// Path-5 Drawing
                                UIBezierPath path5Path = new UIBezierPath();
                                path5Path.MoveTo(new CGPoint(40.98f, 457.24f));
                                path5Path.AddLineTo(new CGPoint(40.98f, 485.25f));
                                path5Path.AddLineTo(new CGPoint(59.77f, 471.25f));
                                path5Path.AddLineTo(new CGPoint(40.98f, 457.24f));
                                path5Path.ClosePath();
                                path5Path.MiterLimit = 4.0f;

                                path5Path.UsesEvenOddFillRule = true;

                                fillColor2.SetFill();
                                path5Path.Fill();


                                //// Line 4 Drawing
                                UIBezierPath line4Path = new UIBezierPath();
                                line4Path.MoveTo(new CGPoint(69.18f, 457.72f));
                                line4Path.AddLineTo(new CGPoint(69.18f, 484.8f));
                                line4Path.MiterLimit = 4.0f;

                                line4Path.LineCapStyle = CGLineCap.Square;

                                line4Path.UsesEvenOddFillRule = true;

                                strokeColor3.SetStroke();
                                line4Path.LineWidth = 4.0f;
                                line4Path.Stroke();


                                //// Line-Copy Drawing
                                UIBezierPath lineCopyPath = new UIBezierPath();
                                lineCopyPath.MoveTo(new CGPoint(79.61f, 457.72f));
                                lineCopyPath.AddLineTo(new CGPoint(79.61f, 484.8f));
                                lineCopyPath.MiterLimit = 4.0f;

                                lineCopyPath.LineCapStyle = CGLineCap.Square;

                                lineCopyPath.UsesEvenOddFillRule = true;

                                strokeColor3.SetStroke();
                                lineCopyPath.LineWidth = 4.0f;
                                lineCopyPath.Stroke();
                            }
                        }


                        //// Rectangle- 12 Drawing
                        var rectangle12Path = UIBezierPath.FromRoundedRect(new CGRect(110.0f, 13.0f, 34.0f, 13.0f), 6.5f);
                        fillColor.SetFill();
                        rectangle12Path.Fill();
                        strokeColor.SetStroke();
                        rectangle12Path.LineWidth = 1.0f;
                        rectangle12Path.Stroke();
                    }
                }
            }
        }

    }
}