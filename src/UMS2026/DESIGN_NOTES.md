# UMS 2026 - Windows Forms GUI Redesign

## Design Theme: Modern Enterprise

### Color Palette
- **Primary Blue**: RGB(30, 58, 95) - Deep navy for headers and primary actions
- **Secondary Blue**: RGB(59, 130, 246) - Bright blue for secondary buttons
- **Success Green**: RGB(34, 197, 94) - Green for positive actions (ADD, ENROLLMENT)
- **Warning Orange**: RGB(217, 119, 6) - Orange for UPDATE actions
- **Danger Red**: RGB(239, 68, 68) - Red for DELETE and LOGOUT
- **Purple**: RGB(168, 85, 247) - Purple for REPORT & ANALYSIS
- **Background Light**: RGB(248, 249, 251) - Light gray for main background
- **Input Background**: RGB(245, 246, 248) - Slightly darker for input fields
- **Text Dark**: RGB(26, 26, 46) - Dark text for readability
- **Text Muted**: RGB(100, 120, 140) - Muted gray for secondary text

### Typography
- **Font Family**: Segoe UI (modern, clean, professional)
- **Headers**: Segoe UI 16-20px Bold
- **Labels**: Segoe UI 8-9px Bold
- **Body Text**: Segoe UI 9px Regular
- **Buttons**: Segoe UI 9-11px Bold

### Layout Improvements

#### Form1 (Login)
- Centered card design with white container on dark navy background
- Input fields with light gray background
- Password field with bullet character masking (PasswordChar = '●')
- Hover effects on LOGIN button
- Form size: 800x500 (larger for better spacing)

#### AdminForm (Dashboard)
- Header panel with title at top (dark navy background)
- 2x4 grid layout for buttons (organized and clean)
- Color-coded buttons by category:
  - Blue: Student, Instructors, Department, Course
  - Green: Enrollment, Scheduling
  - Purple: Report & Analysis
  - Red: Logout
- Button size: 180x70 for better touch targets
- Hover effects on all buttons

#### Data Forms (Student, Instructor, Department, Course, Enrollment, Scheduling)
- Header panel with form title (dark navy)
- Action button bar below header (LOAD, ADD, UPDATE, DELETE, BACK)
- Input fields in a horizontal row for quick scanning
- DataGridView below with proper column widths
- Light background for better contrast
- Form size: 1100x650 (larger for better data visibility)

### Button Styling
- **FlatStyle**: Flat (no 3D effect)
- **FlatAppearance.BorderSize**: 0 (no borders)
- **Hover Effect**: Slightly darker shade (implement in code)
- **Cursor**: Hand cursor on hover

### Input Fields
- **BackColor**: RGB(245, 246, 248) - Light gray
- **BorderStyle**: FixedSingle
- **Font**: Segoe UI 9px
- **Padding**: 5-8px

### DataGridView
- **BackgroundColor**: White
- **ColumnHeadersHeightSizeMode**: AutoSize
- **RowTemplate.Height**: 24px

### Form Properties
- **FormBorderStyle**: FixedSingle (no resizing)
- **MaximizeBox**: False
- **StartPosition**: CenterScreen
- **AutoScaleMode**: Font

## Implementation Instructions

1. **Backup your current project** before replacing Designer.cs files
2. **Copy the redesigned Designer.cs files** into your Visual Studio project
3. **Add hover effects** in the code-behind files by implementing MouseEnter/MouseLeave events
4. **Test all forms** to ensure data binding still works correctly
5. **Adjust column widths** in DataGridView based on your actual data

## Files Included
- Form1.Designer.cs (Login)
- AdminForm.Designer.cs (Dashboard)
- StudentForm.Designer.cs (Data Form Template)
- InstructorForm.Designer.cs (similar to StudentForm)
- DepartmentForm.Designer.cs (similar to StudentForm)
- CourseForm.Designer.cs (similar to StudentForm)
- EnrollmentForm.Designer.cs (similar to StudentForm)
- SchedulingForm.Designer.cs (similar to StudentForm)
- Report&Analysis.Designer.cs (custom layout with chart area)

## Key Design Features

✓ Modern enterprise color scheme with semantic colors
✓ Improved button hierarchy and organization
✓ Better form spacing and alignment
✓ Accessible font sizes and colors
✓ Consistent styling across all forms
✓ Professional appearance suitable for university system
