namespace AvaloniaAppTemplate.Namespace

open Avalonia.Controls.Primitives

type NewTemplatedControl () = 
    inherit TemplatedControl ()
        override StyleKeyOverride
            with get() = typedefof<NewTemplatedControl>
