# template-selector-accordion-xamarin

This sample demonstrates how to use a DataTemplateSelector with Syncfusion's SfAccordion control in a Xamarin.Forms project. The sample shows how to provide different visual templates for accordion items by using a custom `AccordionTemplateSelector` and binding the accordion to an items collection via `BindableLayout.ItemsSource`.

For detailed guidance on the SfAccordion control and getting started with Syncfusion Accordion for Xamarin, see the official user guide:

- [Getting Started with Xamarin Accordion (SfAccordion)](https://help.syncfusion.com/xamarin/accordion/getting-started)

KB Link: [How to use TemplateSelector in Xamarin.Forms Accordion (SfAccordion)](https://www.syncfusion.com/kb/12189/how-to-use-templateselector-in-xamarin-forms-accordion-sfaccordion)

## Overview

This repository contains a small Xamarin.Forms solution named `AccordionXamarin` which demonstrates two important techniques:

- Using a custom DataTemplateSelector (`AccordionTemplateSelector`) to return different `DataTemplate`s for items in an `SfAccordion`.
- Binding the accordion to a view model collection (`ItemInfoRepository`) using `BindableLayout.ItemsSource` and assigning the template selector with `BindableLayout.ItemTemplateSelector`.

The pattern is useful whenever you want conditional visuals for list-like controls — for example, showing a highlighted header for certain items while keeping a default appearance for others.

## XAML

The following XAML demonstrates how the `AccordionTemplateSelector` is declared in `ContentPage.Resources`, how custom and default templates are defined, and how the `SfAccordion` applies the selector.

```
<ContentPage.BindingContext>
	<local:ItemInfoRepository/>
</ContentPage.BindingContext>
   
<ContentPage.Resources>
	<ResourceDictionary>
		<local:AccordionTemplateSelector x:Key="accordionTemplateSelector">
			<local:AccordionTemplateSelector.CustomTemplate>
				<DataTemplate>
					<accordion:AccordionItem HeaderBackgroundColor="#949cdf">
						<accordion:AccordionItem.Header>
							<Grid Padding="10,0,0,0">
								<Grid.ColumnDefinitions>
									<ColumnDefinition Width="60"/>
									<ColumnDefinition Width="*"/>
								</Grid.ColumnDefinitions>
								<Button Text="--" FontAttributes="Bold" CornerRadius="5" BackgroundColor="Transparent" HorizontalOptions="Start" VerticalOptions="CenterAndExpand"/>
								<Label TextColor="#495F6E" Text="{Binding Name}" Grid.Column="1" VerticalOptions="Center" HorizontalOptions="StartAndExpand" HeightRequest="50" VerticalTextAlignment="Center"/>
							</Grid>
						</accordion:AccordionItem.Header>
						<accordion:AccordionItem.Content>
							<Grid BackgroundColor="#e8e8e8" Padding="5,0,0,0">
								<Label Text="{Binding Description}" VerticalOptions="Center"/>
							</Grid>
						</accordion:AccordionItem.Content>
					</accordion:AccordionItem>
				</DataTemplate>
			</local:AccordionTemplateSelector.CustomTemplate>
			<local:AccordionTemplateSelector.DefaultTemplate>
				<DataTemplate>
					<accordion:AccordionItem >
						<accordion:AccordionItem.Header>
							<Grid>
								<Label TextColor="#495F6E" Text="{Binding Name}" VerticalOptions="Center" HorizontalOptions="Center" HeightRequest="50" VerticalTextAlignment="Center"/>
							</Grid>
						</accordion:AccordionItem.Header>
						<accordion:AccordionItem.Content>
							<Grid BackgroundColor="#e8e8e8" Padding="5,0,0,0">
								<Label Text="{Binding Description}" VerticalOptions="Center"/>
							</Grid>
						</accordion:AccordionItem.Content>
					</accordion:AccordionItem>
				</DataTemplate>
			</local:AccordionTemplateSelector.DefaultTemplate>
		</local:AccordionTemplateSelector>
	</ResourceDictionary>
</ContentPage.Resources>
<ContentPage.Content>
	<accordion:SfAccordion x:Name="accordion" BindableLayout.ItemsSource="{Binding Info}" BindableLayout.ItemTemplateSelector="{StaticResource accordionTemplateSelector}" ExpandMode="SingleOrNone">
	</accordion:SfAccordion>
</ContentPage.Content>
```

## How it works

- AccordionTemplateSelector: A custom template selector class (`AccordionTemplateSelector.cs`) inspects each bound item and chooses either the `CustomTemplate` or the `DefaultTemplate` depending on item properties (for example, a flag or a specific type). The selector is declared as a resource and passed to the SfAccordion via `BindableLayout.ItemTemplateSelector`.
- Bindable layout: `SfAccordion` is bound to the view model's `Info` collection using `BindableLayout.ItemsSource`. Each item in the collection is presented using the chosen template.
- Templates: `CustomTemplate` can be used to add extra UI elements (a button, special background, or different layout). `DefaultTemplate` provides the standard look.

##### Conclusion
I hope you enjoyed learning about how to use TemplateSelector in Xamarin.Forms Accordion (SfAccordion).

You can refer to our  [Xamarin.Forms Accordion feature tour](https://www.syncfusion.com/xamarin-ui-controls/xamarin-accordion) page to know about its other groundbreaking feature representations and [documentation](https://help.syncfusion.com/xamarin/accordion/getting-started), and how to quickly get started for configuration specifications. You can also explore our [Xamarin.Forms Accordion example](https://www.syncfusion.com/demos/xamarin) to understand how to create and manipulate data.

For current customers, you can check out our Document Processing Libraries from the [License and Downloads](https://www.syncfusion.com/account/login) page. If you are new to Syncfusion, you can try our 30-day [free trial](https://www.syncfusion.com/downloads) to check out our controls.

If you have any queries or require clarifications, please let us know in the comments section below. You can also contact us through our [support forums](https://www.syncfusion.com/forums) or [Direct-trac](https://support.syncfusion.com/create). We are always happy to assist you!
