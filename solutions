let xs=['a';'b';'c']

let s1=xs |> List.rev |> List.head

let s2=xs |> List.last

let s3=xs |> List.reduce (fun x1 x2->x2)

let rec s4 xs=
    match xs with
    | []-> failwith "empty"
    | [x]->x
    | _::tail -> s4 tail 

let result=s4 xs
