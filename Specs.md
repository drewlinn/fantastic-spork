| Behavior                                           | Input                        | Output                                |
|====================================================|==============================|=======================================|
| Player can input a word; it is returned by the app | "Zoo"                        | "Zoo"                                 |
| Letters in word have scores                        | A, E, I, O, U, L, N, R, S, T | 1                                     |
|                                                    | D, G                         | 2                                     |
|                                                    | B, C, M, P                   | 3                                     |
|                                                    | F, H, V, W, Y                | 4                                     |
|                                                    | K                            | 5                                     |
|                                                    | J, X                         | 8                                     |
|                                                    | Q, Z                         | 10                                    |
| Letters in input are scored like so:               | "Beard"                      | "Your word has a scrabble score of 8" |
| Does not accept input that is not a Letter/string  | "$510"                       | "Please enter a word!"                |
