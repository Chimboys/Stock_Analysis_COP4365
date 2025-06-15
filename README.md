# Stock-Wave Analyzer (Project 3)

Final Project — COP4365: Software System Development in C#

## Overview

**Stock-Wave Analyzer** is a Windows Forms application developed in C# that enables users to analyze stock performance through candlestick chart visualization and technical pattern recognition. This project builds upon the functionality introduced in Project 1 and Project 2, gradually extending the system to support pattern-based recognition using object-oriented techniques such as class inheritance, abstract classes, and polymorphism.

This project was completed as part of the final assignment for COP4365 and adheres to all requirements and specifications outlined throughout the course, including strong software design, data binding, UI responsiveness, and class architecture.

---

## Features

### Core Functionalities

- Load OHLC (Open, High, Low, Close) stock data from CSV files (Daily, Weekly, Monthly) using Yahoo Finance exports.
- Display stock price as candlestick charts and volume data as bar plots.
- Normalize Y-axis dynamically to utilize full chart range.
- Support for multiple stock displays simultaneously—each stock is visualized in a separate form.

### Pattern Recognition

Users can detect and highlight candlestick patterns using annotations in the chart. Pattern types include:

**Single-Candlestick Patterns:**
- Bullish
- Bearish
- Neutral
- Doji
- Dragonfly Doji
- Gravestone Doji
- Marubozu
- Hammer

**Double-Candlestick Patterns:**
- Bullish Engulfing
- Bearish Engulfing
- Bullish Harami
- Bearish Harami

**Triple-Candlestick Patterns:**
- Peak
- Valley

Each pattern is selected via a dynamically populated ComboBox, and corresponding candlesticks are visually annotated using `RectangleAnnotation`, `ArrowAnnotation`, or `LineAnnotation` elements from the .NET Charting library.

---

## Architecture

The final project refactors the pattern recognition logic into a cleaner and more scalable architecture using object-oriented principles:

### Class Structure

- `Candlestick`: Base class holding OHLC and volume data.
- `SmartCandlestick` (inherits `Candlestick`): Adds derived metrics such as body range, tails, and pattern indicators.
- `Recognizer` (abstract): Base class for all pattern recognizers. Implements `recognizeAll()` to process all smart candlesticks.
- `Recognizer_Bullish`, `Recognizer_Peak`, etc.: Specialized recognizer classes for individual patterns. Each class overrides `Recognize()`.

Each `Recognizer_xxx.cs` file is responsible for evaluating a specific candlestick pattern, promoting separation of concerns and modularity.

### Pattern Evaluation Flow

1. On file load:
   - Candlestick data is parsed.
   - `SmartCandlestick` list is created and bound to the chart.
2. On ComboBox selection:
   - The selected pattern’s recognizer is invoked.
   - All candlesticks are passed through `recognizeAll()`.
   - Matching indices are annotated on the chart.

---

## User Interface

- Users can specify:
  - Stock file (via `OpenFileDialog`)
  - Start and end dates for analysis
  - Period (Daily, Weekly, Monthly)
  - Candlestick pattern to detect

- Charts:
  - Legend hidden for space efficiency
  - Weekends and holidays skipped in daily mode
  - Auto-adjusted Y-axis using a `normalize()` method
  - Pattern highlights using chart annotations

---

## Project Evolution

This final version builds upon two prior milestones:

### Project 1
- Load and display stock data as candlestick and volume plots.
- UI elements for stock selection and period configuration.
- Used data binding and structured commenting.

### Project 2
- Support for multiple stocks in multiple forms.
- Introduction of `SmartCandlestick` class with calculated features.
- Recognition and annotation of 8 single-candlestick patterns.
- Pattern dictionary stored in each candlestick (now deprecated in Project 3).

### Project 3 (Final)
- Refactored pattern detection into modular recognizer classes.
- Support for 14 patterns, including 2-candle and 3-candle types.
- Use of `Recognizer::recognizeAll()` as a reusable helper in the abstract base class.

---

## Requirements Met

- Implemented as a **Windows Forms Application** using C#.
- Code compiles and runs without errors.
- UI components are named using proper `controlType_name` convention (e.g., `button_LoadData`).
- All user inputs and configurations handled within the application.
- Data binding implemented throughout the chart and data flow.
- Function-level XML documentation (`///`) and inline comments are present across all student-written code.

---

## Getting Started

To run the application:

1. Ensure all stock CSV files are located in a directory named `Stock Data` at the project root.
2. Open the solution file (`.sln`) in Visual Studio.
3. Build and run the application.
4. Load one or more stock files using the UI and experiment with different patterns via the ComboBox.

---

## Dependencies

- .NET Windows Forms
- System.Windows.Forms.DataVisualization.Charting
- Yahoo Finance CSV data

---

## License & Academic Integrity

© 2025 **Akmal Kurbanov**. All rights reserved.

This repository is shared **solely for learning and personal experimentation.**

- **Do not clone, copy, or submit any part of this project as coursework** or graded assignments. Doing so violates academic integrity policies and the author’s explicit prohibition against plagiarism and cheating.
- You may study the code, draw inspiration, and create your own original implementation—provided you follow your institution’s honor code.

---
