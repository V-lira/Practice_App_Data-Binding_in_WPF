# Practice_App_Data-Binding_in_WPF

What I Created:
-------------------------------------------------------
I built a WPF application with two separate tasks
<img width="890" height="513" alt="image" src="https://github.com/user-attachments/assets/b04fa400-166a-4a8d-a3ec-2292116c22e9" />

---------------Task №1: Rectangle Calculator-----------
-------------------------------------------------------
What it does:

Two text boxes for entering {Width} and {Height}
Automatic area calculation in real-time
Area updates immediately when you type in {width} or {height}


<img width="494" height="519" alt="image" src="https://github.com/user-attachments/assets/46054aff-c79f-4929-84fa-c345c941feeb" />


How it works:
Uses INotifyPropertyChanged for data binding
Area property is read-only (only get method)
When Width or Height changes, Area automatically recalculates
No buttons needed - everything works automatically

Task №2: Color Picker
-------------------------------------------------------
What it does:
Dropdown list (ComboBox) with color names: red, green, blue, yellow, purple
When you select a color, the color changes immediately
Shows both color name and colored background

<img width="477" height="504" alt="image" src="https://github.com/user-attachments/assets/565b7bcd-ed50-4354-a4af-7b174ac32a5e" />

<img width="484" height="508" alt="image" src="https://github.com/user-attachments/assets/ceddec75-9a8e-42be-9b79-6faf115ee997" />


How it works:
SelectedItem binding connects ComboBox to ViewModel
Color names are stored in ObservableCollection
Each color has name and Brush value
Border background binds to selected color's Brush


Result
Both tasks work perfectly! The rectangle area calculates automatically while typing, and color picker changes background color instantly when selecting from dropdown.
