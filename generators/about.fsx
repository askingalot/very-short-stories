#r "../_lib/Fornax.Core.dll"
#load "layout.fsx"

open Html

let about =
    """
Hi, I'm Andy Collins.
<br/>
<br/>
The writings found here are original fiction written by me and are inspired by the prompts found in 
<a target="_blank" href='https://www.billweissauthor.com/books/4000-writing-prompts/'>4,000 Creative Writing Prompts</a>
by <a target="_blank" href="https://www.billweissauthor.com/about-the-author-4/">Bill Weiss</a>.
<br/>
<br/>
I have chosen not to include the prompts themselves, because they are not my intellectual property,
but a fairly large selection of them can be found in sample pages provided by Amazon or other book sellers.
<br/>
<br/>
If you enjoy these stories (or even if you don't) you might want to check out my very old 
(and very much no longer maintained) blog <a target="_blank" href="https://harboringmuch.blogspot.com/">Harboring Much - Asking a Lot</a>.
"""

let generate' (ctx: SiteContents) (_: string) =
    let siteInfo = ctx.TryGetValue<Globalloader.SiteInfo>()

    let desc =
        siteInfo |> Option.map (fun si -> si.description) |> Option.defaultValue ""


    Layout.layout
        ctx
        "About"
        [ section
              [ Class "hero is-info is-medium is-bold" ]
              [ div
                    [ Class "hero-body" ]
                    [ div [ Class "container has-text-centered" ] [ h1 [ Class "title" ] [ !!desc ] ] ] ]
          div
              [ Class "container" ]
              [ section
                    [ Class "articles" ]
                    [ div
                          [ Class "column is-8 is-offset-2" ]
                          [ div
                                [ Class "card article" ]
                                [ div [ Class "card-content" ] [ div [ Class "content article-body" ] [ !!about ] ] ] ] ] ] ]

let generate (ctx: SiteContents) (projectRoot: string) (page: string) = generate' ctx page |> Layout.render ctx
