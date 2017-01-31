let xs=[1..10]

let s1=xs |> List.rev |> List.tail |> List.head

let s3=xs |> List.rev |> List.item 1

let rec s4 xs=
    match xs with
    | []-> failwith "empty"
    | [x;x1]->x
    | _::tail -> s4 tail 

let result=s4 xs

