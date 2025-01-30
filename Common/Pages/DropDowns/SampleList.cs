#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorDemos;
namespace BlazorDemos
{
    internal partial class SampleConfig
    {
        public List<Sample> DropDownList { get; set; } = new List<Sample> {
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Dropdown List",
                Directory = "DropDowns/DropDownList",
                Url = "DropDown-List/Default-Functionalities",
                FileName = "DefaultFunctionalities.razor",
                Type = SampleType.None,

            },
            new Sample
            {
                Name = "Data Binding",
                Category = "Dropdown List",
                Directory = "DropDowns/DropDownList",
                Url = "DropDown-List/Data-Binding",
                FileName = "DataBinding.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Disabled Items",
                Category = "Dropdown List",
                Directory = "DropDowns/DropDownList",
                Url = "DropDown-List/DisabledItems",
                FileName = "DisabledItems.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Filtering",
                Category = "Dropdown List",
                Directory = "DropDowns/DropDownList",
                Url = "DropDown-List/Filtering",
                FileName = "Filtering.razor",
                Type = SampleType.Updated,
                NotificationDescription = new string[]{ "This demo demonstrates the debounce delay feature in filtering for the DropDownList. You can set a custom delay in milliseconds, which reduces the frequency of data filtering as you type, enhancing performance and responsiveness." }
            },
            new Sample
            {
                Name = "Cascading",
                Category = "Dropdown List",
                Directory = "DropDowns/DropDownList",
                Url = "DropDown-List/Cascading",
                FileName = "Cascading.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Grouping and Icon",
                Category = "Dropdown List",
                Directory = "DropDowns/DropDownList",
                Url = "DropDown-List/Grouping-Icon",
                FileName = "GroupingIcon.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Inline",
                Category = "Dropdown List",
                Directory = "DropDowns/DropDownList",
                Url = "DropDown-List/Inline",
                FileName = "Inline.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Template",
                Category = "Dropdown List",
                Directory = "DropDowns/DropDownList",
                Url = "DropDown-List/Template",
                FileName = "Template.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Popup Resize",
                Category = "Dropdown List",
                Directory = "DropDowns/DropDownList",
                Url = "DropDown-List/Resize",
                FileName = "Resize.razor",
                Type = SampleType.New,
                NotificationDescription = new string[]{ "This demo showcases the custom resizing functionality of the DropDownList. You can adjust the popup size to suit your preferences, providing enhanced control over its appearance." }

            },
            new Sample
            {
                Name = "Virtualization",
                Category = "Dropdown List",
                Directory = "DropDowns/DropDownList",
                Url = "DropDown-List/Virtualization",
                FileName = "Virtualization.razor",
                Type = SampleType.None,
            },
            new Sample
            {
                Name = "Validation",
                Category = "Dropdown List",
                Directory = "DropDowns/DropDownList",
                Url = "DropDown-List/Forms-Validation",
                FileName = "FormsValidation.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Keyboard Navigation",
                Category = "Dropdown List",
                Directory = "DropDowns/DropDownList",
                Url = "DropDown-List/Keyboard-Navigation",
                FileName = "KeyboardNavigation.razor",
                Type = SampleType.None
            }
        };

        public List<Sample> DropDownTree { get; set; } = new List<Sample> {
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Dropdown Tree",
                Directory = "DropDowns/DropDownTree",
                Url = "dropdown-tree/Default-Functionalities",
                FileName = "DefaultFunctionalities.razor"
            },
            new Sample
            {
                Name = "Customization",
                Category = "Dropdown Tree",
                Directory = "DropDowns/DropDownTree",
                Url = "dropdown-tree/customization",
                FileName = "Customization.razor"
            },
            new Sample
            {
                Name = "Selection",
                Category = "Dropdown Tree",
                Directory = "DropDowns/DropDownTree",
                Url = "dropdown-tree/selection",
                FileName = "Selection.razor"
            },
            new Sample
            {
                Name = "Filtering",
                Category = "Dropdown Tree",
                Directory = "DropDowns/DropDownTree",
                Url = "dropdown-tree/Filtering",
                FileName = "Filtering.razor"
            },
            new Sample
            {
                Name = "Validation",
                Category = "Dropdown Tree",
                Directory = "DropDowns/DropDownTree",
                Url = "dropdown-tree/validation",
                FileName = "Validation.razor"
            }
        };

        public List<Sample> ComboBox { get; set; } = new List<Sample> {
            new Sample
            {
                Name = "Default Functionalities",
                Category = "ComboBox",
                Directory = "DropDowns/ComboBox",
                Url = "ComboBox/Default-Functionalities",
                FileName = "DefaultFunctionalities.razor",
                Type = SampleType.None
            },
              new Sample
            {
                Name = "Data Binding",
                Category = "ComboBox",
                Directory = "DropDowns/ComboBox",
                Url = "ComboBox/Data-Binding",
                FileName = "DataBinding.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Disabled Items",
                Category = "ComboBox",
                Directory = "DropDowns/ComboBox",
                Url = "ComboBox/DisabledItems",
                FileName = "DisabledItems.razor",
                Type = SampleType.None
            },
           new Sample
            {
                Name = "Cascading",
                Category = "ComboBox",
                Directory = "DropDowns/ComboBox",
                Url = "ComboBox/Cascading",
                FileName = "Cascading.razor",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Filtering",
                Category = "ComboBox",
                Directory = "DropDowns/ComboBox",
                Url = "ComboBox/Filtering",
                FileName = "Filtering.razor",
                Type = SampleType.Updated,
                NotificationDescription = new string[]{ "This demo demonstrates the debounce delay feature in filtering for the ComboBox. You can set a custom delay in milliseconds, which reduces the frequency of data filtering as you type, enhancing performance and responsiveness." }

            },
            new Sample
            {
                Name = "Custom Value",
                Category = "ComboBox",
                Directory = "DropDowns/ComboBox",
                Url = "ComboBox/Custom-Value",
                FileName = "CustomValue.razor",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Grouping and Icon",
                Category = "ComboBox",
                Directory = "DropDowns/ComboBox",
                Url = "ComboBox/Grouping-Icon",
                FileName = "GroupingIcon.razor",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Template",
                Category = "ComboBox",
                Directory = "DropDowns/ComboBox",
                Url = "ComboBox/Template",
                FileName = "Template.razor",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Popup Resize",
                Category = "ComboBox",
                Directory = "DropDowns/ComboBox",
                Url = "ComboBox/Resize",
                FileName = "Resize.razor",
                Type = SampleType.New,
                NotificationDescription = new string[]{ "This demo showcases the custom resizing functionality of the ComboBox. You can adjust the popup size to suit your preferences, providing enhanced control over its appearance." }

            },
             new Sample
            {
                Name = "Multi Column",
                Category = "ComboBox",
                Directory = "DropDowns/ComboBox",
                Url = "ComboBox/Multi-Column",
                FileName = "MultiColumn.razor",
                Type = SampleType.None,
            },
             new Sample
            {
                Name = "Virtualization",
                Category = "ComboBox",
                Directory = "DropDowns/ComboBox",
                Url = "ComboBox/Virtualization",
                FileName = "Virtualization.razor",
                Type = SampleType.None,
            },
             new Sample
            {
                Name = "Validation",
                Category = "ComboBox",
                Directory = "DropDowns/ComboBox",
                Url = "ComboBox/Forms-Validation",
                FileName = "FormsValidation.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Keyboard Navigation",
                Category = "ComboBox",
                Directory = "DropDowns/ComboBox",
                Url = "ComboBox/Keyboard-Navigation",
                FileName = "KeyboardNavigation.razor",
                Type = SampleType.None
            }
           
        };

        public List<Sample> AutoComplete { get; set; } = new List<Sample> {
            new Sample
            {
                Name = "Default Functionalities",
                Category = "AutoComplete",
                Directory = "DropDowns/AutoComplete",
                Url = "AutoComplete/Default-Functionalities",
                FileName = "DefaultFunctionalities.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Data Binding",
                Category = "AutoComplete",
                Directory = "DropDowns/AutoComplete",
                Url = "AutoComplete/Data-Binding",
                FileName = "DataBinding.razor",
                Type = SampleType.None,
            },
            new Sample
            {
                Name = "Disabled Items",
                Category = "AutoComplete",
                Directory = "DropDowns/AutoComplete",
                Url = "AutoComplete/DisabledItems",
                FileName = "DisabledItems.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Grouping and Icon",
                Category = "AutoComplete",
                Directory = "DropDowns/AutoComplete",
                Url = "AutoComplete/Grouping-Icon",
                FileName = "GroupingIcon.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Template",
                Category = "AutoComplete",
                Directory = "DropDowns/AutoComplete",
                Url = "AutoComplete/Template",
                FileName = "Template.razor",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Popup Resize",
                Category = "AutoComplete",
                Directory = "DropDowns/AutoComplete",
                Url = "AutoComplete/Resize",
                FileName = "Resize.razor",
                Type = SampleType.New,
                NotificationDescription = new string[]{ "This demo showcases the custom resizing functionality of the AutoComplete. You can adjust the popup size to suit your preferences, providing enhanced control over its appearance." }

            },
            new Sample
            {
                Name = "Highlight",
                Category = "AutoComplete",
                Directory = "DropDowns/AutoComplete",
                Url = "AutoComplete/Highlight",
                FileName = "Highlight.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Virtualization",
                Category = "AutoComplete",
                Directory = "DropDowns/AutoComplete",
                Url = "AutoComplete/Virtualization",
                FileName = "Virtualization.razor",
                Type = SampleType.None,
            },
             new Sample
            {
                Name = "Custom Filtering",
                Category = "AutoComplete",
                Directory = "DropDowns/AutoComplete",
                Url = "AutoComplete/Custom-Filtering",
                FileName = "CustomFiltering.razor",
                Type = SampleType.Updated,
                NotificationDescription = new string[]{ "This demo demonstrates the debounce delay feature in filtering for the AutoComplete. You can set a custom delay in milliseconds, which reduces the frequency of data filtering as you type, enhancing performance and responsiveness." }

            },
            new Sample
            {
                Name = "Validation",
                Category = "AutoComplete",
                Directory = "DropDowns/AutoComplete",
                Url = "AutoComplete/Forms-Validation",
                FileName = "FormsValidation.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Keyboard Navigation",
                Category = "AutoComplete",
                Directory = "DropDowns/AutoComplete",
                Url = "AutoComplete/Keyboard-Navigation",
                FileName = "KeyboardNavigation.razor",
                Type = SampleType.None
            }
        };

        public List<Sample> MultiSelectDropdown { get; set; } = new List<Sample> {
            new Sample
            {
                Name = "Default Functionalities",
                Category = "MultiSelect Dropdown",
                Directory = "DropDowns/MultiSelect",
                Url = "MultiSelect-Dropdown/Default-Functionalities",
                FileName = "DefaultFunctionalities.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Data Binding",
                Category = "MultiSelect Dropdown",
                Directory = "DropDowns/MultiSelect",
                Url = "MultiSelect-Dropdown/Data-Binding",
                FileName = "DataBinding.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Disabled Items",
                Category = "MultiSelect Dropdown",
                Directory = "DropDowns/MultiSelect",
                Url = "MultiSelect-Dropdown/DisabledItems",
                FileName = "DisabledItems.razor",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Filtering",
                Category = "MultiSelect Dropdown",
                Directory = "DropDowns/MultiSelect",
                Url = "MultiSelect-Dropdown/Filtering",
                FileName = "Filtering.razor",
                Type = SampleType.Updated,
                NotificationDescription = new string[]{ "This demo demonstrates the debounce delay feature in filtering for the MultiSelect Dropdown. You can set a custom delay in milliseconds, which reduces the frequency of data filtering as you type, enhancing performance and responsiveness." }

            },
            new Sample
            {
                Name = "CheckBox",
                Category = "MultiSelect Dropdown",
                Directory = "DropDowns/MultiSelect",
                Url = "MultiSelect-Dropdown/CheckBox",
                FileName = "CheckBox.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Custom Value",
                Category = "MultiSelect Dropdown",
                Directory = "DropDowns/MultiSelect",
                Url = "MultiSelect-Dropdown/Custom-Value",
                FileName = "CustomValue.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Chip Customization",
                Category = "MultiSelect Dropdown",
                Directory = "DropDowns/MultiSelect",
                Url = "MultiSelect-Dropdown/Chip-Customization",
                FileName = "ChipCustomization.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Grouping",
                Category = "MultiSelect Dropdown",
                Directory = "DropDowns/MultiSelect",
                Url = "MultiSelect-Dropdown/Grouping",
                FileName = "Grouping.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Selection Limit",
                Category = "MultiSelect Dropdown",
                Directory = "DropDowns/MultiSelect",
                Url = "MultiSelect-Dropdown/Selection-Limit",
                FileName = "SelectionLimit.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Template",
                Category = "MultiSelect Dropdown",
                Directory = "DropDowns/MultiSelect",
                Url = "MultiSelect-Dropdown/Template",
                FileName = "Template.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Virtualization",
                Category = "MultiSelect Dropdown",
                Directory = "DropDowns/MultiSelect",
                Url = "MultiSelect-Dropdown/Virtualization",
                FileName = "Virtualization.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Validation",
                Category = "MultiSelect Dropdown",
                Directory = "DropDowns/MultiSelect",
                Url = "MultiSelect-Dropdown/Forms-Validation",
                FileName = "FormsValidation.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Keyboard Navigation",
                Category = "MultiSelect Dropdown",
                Directory = "DropDowns/MultiSelect",
                Url = "MultiSelect-Dropdown/Keyboard-Navigation",
                FileName = "KeyboardNavigation.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Popup Resize",
                Category = "MultiSelect Dropdown",
                Directory = "DropDowns/MultiSelect",
                Url = "MultiSelect-Dropdown/Resize",
                FileName = "Resize.razor",
                Type = SampleType.New,
                NotificationDescription = new string[]{ "This demo showcases the custom resizing functionality of the MultiSelect Dropdown. You can adjust the popup size to suit your preferences, providing enhanced control over its appearance." }

            }
        };

        public List<Sample> MultiColumnComboBox { get; set; } = new List<Sample> {
            new Sample
            {
                Name = "Default Functionalities",
                Category = "MultiColumn ComboBox",
                Directory = "DropDowns/MultiColumnComboBox",
                Url = "MultiColumn-ComboBox/Default-Functionalities",
                FileName = "DefaultFunctionalities.razor",
                Type = SampleType.None,
            },
            new Sample
            {
                Name = "Remote Data Binding",
                Category = "MultiColumn ComboBox",
                Directory = "DropDowns/MultiColumnComboBox",
                Url = "MultiColumn-ComboBox/Remote-Data-Binding",
                FileName = "RemoteDataBinding.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Paging",
                Category = "MultiColumn ComboBox",
                Directory = "DropDowns/MultiColumnComboBox",
                Url = "MultiColumn-ComboBox/Paging",
                FileName = "Paging.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Filtering",
                Category = "MultiColumn ComboBox",
                Directory = "DropDowns/MultiColumnComboBox",
                Url = "MultiColumn-ComboBox/Filtering",
                FileName = "Filtering.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Virtualization",
                Category = "MultiColumn ComboBox",
                Directory = "DropDowns/MultiColumnComboBox",
                Url = "MultiColumn-ComboBox/Virtualization",
                FileName = "Virtualization.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Grouping and Sorting",
                Category = "MultiColumn ComboBox",
                Directory = "DropDowns/MultiColumnComboBox",
                Url = "MultiColumn-ComboBox/Grouping-Sorting",
                FileName = "Grouping.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Template",
                Category = "MultiColumn ComboBox",
                Directory = "DropDowns/MultiColumnComboBox",
                Url = "MultiColumn-ComboBox/Template",
                FileName = "Template.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Keyboard Navigation",
                Category = "MultiColumn ComboBox",
                Directory = "DropDowns/MultiColumnComboBox",
                Url = "MultiColumn-ComboBox/Keyboard-Navigation",
                FileName = "KeyboardNavigation.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Row Style",
                Category = "MultiColumn ComboBox",
                Directory = "DropDowns/MultiColumnComboBox",
                Url = "MultiColumn-ComboBox/RowStyle",
                FileName = "RowStyle.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Form Support",
                Category = "MultiColumn ComboBox",
                Directory = "DropDowns/MultiColumnComboBox",
                Url = "MultiColumn-ComboBox/FormSupport",
                FileName = "FormSupport.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Text Wrap",
                Category = "MultiColumn ComboBox",
                Directory = "DropDowns/MultiColumnComboBox",
                Url = "MultiColumn-ComboBox/TextWrap",
                FileName = "TextWrap.razor",
                Type = SampleType.New,
                NotificationDescription = new string[]{ "This demo showcases the TextWrap feature of the Blazor MultiColumn ComboBox, which controls how text wraps within content and headers. This feature ensures that words break properly at the end of a line, improving readability based on the selected wrapping options." }


            }
        };

        public List<Sample> ListBox { get; set; } = new List<Sample> {
            new Sample
            {
                Name = "Default Functionalities",
                Category = "ListBox",
                Directory = "DropDowns/ListBox",
                Url = "listbox/default-functionalities",
                FileName = "DefaultFunctionalities.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Dual ListBox",
                Category = "ListBox",
                Directory = "DropDowns/ListBox",
                Url = "listbox/dual-listbox",
                FileName = "DualListBox.razor"
            },
            new Sample
            {
                Name = "Drag and Drop",
                Category = "ListBox",
                Directory = "DropDowns/ListBox",
                Url = "listbox/drag-and-drop",
                FileName = "DragDrop.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Checkbox",
                Category = "ListBox",
                Directory = "DropDowns/ListBox",
                Url = "listbox/checkbox",
                FileName = "Checkbox.razor",
                Type = SampleType.None
            },
            new Sample
            {
               Name = "Template",
               Category = "ListBox",
               Directory = "DropDowns/ListBox",
               Url = "listbox/template",
               FileName = "Template.razor",
               Type = SampleType.None
            },
            new Sample
            {
               Name = "API",
               Category = "ListBox",
               Directory = "DropDowns/ListBox",
               Url = "listbox/api",
               FileName = "Api.razor",
               Type = SampleType.None
            },
            new Sample
            {
                Name = "Keyboard Navigation",
                Category = "ListBox",
                Directory = "DropDowns/ListBox",
                Url = "listbox/keyboard-navigation",
                FileName = "KeyboardNavigation.razor"
            }
        };

        public List<Sample> Mention { get; set; } = new List<Sample> {
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Mention",
                Directory = "DropDowns/Mention",
                Url = "Mention/Default-Functionalities",
                FileName = "DefaultFunctionalities.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Multiple List",
                Category = "Mention",
                Directory = "DropDowns/Mention",
                Url = "Mention/Multiple-List",
                FileName = "MultipleList.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Template",
                Category = "Mention",
                Directory = "DropDowns/Mention",
                Url = "Mention/Template",
                FileName = "Templates.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Disabled Items",
                Category = "Mention",
                Directory = "DropDowns/Mention",
                Url = "Mention/DisabledItems",
                FileName = "DisabledItems.razor",
                Type = SampleType.None,
            }
        };
    }
}
