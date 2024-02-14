from math import inf as infinity
from random import choice
import platform
import time
import os

HUMAN = -1
COMP = +1
#Cai dat ban co 4x4
board = [
    [0, 0, 0, 0],
    [0, 0, 0, 0],
    [0, 0, 0, 0],
    [0, 0, 0, 0]
]

#Ham danh gia
def evaluate(state):
    if wins(state, COMP):
        score = +1
    elif wins(state, HUMAN):
        score = -1
    else:
        score = 0

    return score

#Ham kiem tra thang thua
def wins(state, player):
    win_state = [
        # Rows
        [state[0][0], state[0][1], state[0][2]],
        [state[1][0], state[1][1], state[1][2]],
        [state[2][0], state[2][1], state[2][2]],
        [state[3][0], state[3][1], state[3][2]],
        [state[0][1], state[0][2], state[0][3]],
        [state[1][1], state[1][2], state[1][3]],
        [state[2][1], state[2][2], state[2][3]],
        [state[3][1], state[3][2], state[3][3]],

        # Columns
        [state[0][0], state[1][0], state[2][0]],
        [state[0][1], state[1][1], state[2][1]],
        [state[0][2], state[1][2], state[2][2]],
        [state[0][3], state[1][3], state[2][3]],
        [state[1][0], state[2][0], state[3][0]],
        [state[1][1], state[2][1], state[3][1]],
        [state[1][2], state[2][2], state[3][2]],
        [state[1][3], state[2][3], state[3][3]],

        # Diagonals
        [state[0][0], state[1][1], state[2][2]],
        [state[1][1], state[2][2], state[3][3]],
        [state[0][3], state[1][2], state[2][1]],
        [state[1][2], state[2][1], state[3][0]],
        [state[1][0], state[2][1], state[3][2]],


    ]
    if [player, player, player] in win_state:
        return True
    else:
        return False

#Ham kiem tra het nuoc di
def game_over(state):
    return wins(state, HUMAN) or wins(state, COMP)

#Ham tra ve cac o trong
def empty_cells(state):
    cells = []
    for x, row in enumerate(state):
        for y, cell in enumerate(row):
            if cell == 0:
                cells.append([x, y])
    return cells

#Ham kiem tra nuoc di hop le
def valid_move(x, y):
    if [x, y] in empty_cells(board):
        return True
    else:
        return False

#Ham danh co
def set_move(x, y, player):
    if valid_move(x, y):
        board[x][y] = player
        return True
    else:
        return False

#Ham Minimax
def minimax(state, depth, player, alpha, beta):
   
    if player == COMP:
        best = [-1, -1, -infinity]
    else:
        best = [-1, -1, +infinity]

    if depth == 0 or game_over(state):
        score = evaluate(state)
        return [-1, -1, score]

    for cell in empty_cells(state):
        x, y = cell[0], cell[1]
        state[x][y] = player
    #Su dung alpha-beta cat tia de giam thoi gian chay
        score = minimax(state, depth - 1, -player, alpha, beta)
        state[x][y] = 0
        score[0], score[1] = x, y

        if player == COMP:
            if score[2] > best[2]:
                best = score
    #Cap nhat alpha
            alpha = max(alpha, best[2])
        else:
            if score[2] < best[2]:
                best = score
    #Cap nhat beta
            beta = min(beta, best[2])
    #Thuc hien cat tia neu alpha >= beta thi thoat
        if beta <= alpha:
            break
    return best


def clean():
    os.system('cls' if os.name == 'nt' else 'clear')

#Ham in ban co
def render(state, c_choice, h_choice):
    chars = {
        -1: h_choice,
        +1: c_choice,
        0: ' '
    }
    str_line = '-----------------'
    print('\n' + str_line)
    for row in state:
        for cell in row:
            symbol = chars[cell]
            print(f'| {symbol} ', end='')
        print('|\n' + str_line)

#Ham may danh
def ai_turn(c_choice, h_choice):
    depth = len(empty_cells(board))
    if depth == 0 or game_over(board):
        return

    clean()
    print('Computer turn [%s]' % c_choice)
    render(board, c_choice, h_choice)

    if depth == 16:
        x = choice([0, 1, 2, 3])
        y = choice([0, 1, 2, 3])
    else:
        move = minimax(board, depth, COMP, -infinity, infinity)
        x, y = move[0], move[1]

    set_move(x, y, COMP)
    time.sleep(1)

#Ham nguoi choi danh
def human_turn(c_choice, h_choice):
    depth = len(empty_cells(board))
    if depth == 0 or game_over(board):
        return

    move = -1
    moves = {
        1: [0, 0], 2: [0, 1], 3: [0, 2], 4: [0, 3],
        5: [1, 0], 6: [1, 1], 7: [1, 2], 8: [1, 3],
        9: [2, 0], 10: [2, 1], 11: [2, 2], 12: [2, 3],
        13: [3, 0], 14: [3, 1], 15: [3, 2], 16: [3, 3]
    }

    clean()
    print(f'Human turn [%s]' % h_choice)
    render(board, c_choice, h_choice)

    while move < 1 or move > 16:
        try:
            move = int(input('Use numpad (1..16): '))
            if move < 1 or move > 16:
                print('Bad move')
            else:
                coord = moves[move]
                if set_move(coord[0], coord[1], HUMAN):
                    time.sleep(1)
                else:
                    print("Invalid move. Try again.")
                    move = -1
        except (EOFError, KeyboardInterrupt):
            print('Bye')
            exit()
        except (KeyError, ValueError):
            print('Bad choice')

#Ham chinh              
def main():
    
    clean()
    h_choice = ''  
    c_choice = ''  
    first = ''  

    while h_choice != 'O' and h_choice != 'X':
        try:
            h_choice = input('Choose X or O\nChosen: ').upper()
        except (EOFError, KeyboardInterrupt):
            print('Bye')
            exit()
        except (KeyError, ValueError):
            print('Bad choice')

    if h_choice == 'X':
        c_choice = 'O'
    else:
        c_choice = 'X'

    clean()
    while first != 'Y' and first != 'N':
        try:
            first = input('First to start?[y/n]: ').upper()
        except (EOFError, KeyboardInterrupt):
            print('Bye')
            exit()
        except (KeyError, ValueError):
            print('Bad choice')

    while len(empty_cells(board)) > 0 and not game_over(board):
        if first == 'N':
            ai_turn(c_choice, h_choice)
            first = ''

        human_turn(c_choice, h_choice)
        ai_turn(c_choice, h_choice)
    

    if wins(board, HUMAN):
        clean()
        print(f'Human turn [%s]' % h_choice)
        render(board, c_choice, h_choice)
        print('YOU WIN!')
    elif wins(board, COMP):
        clean()
        print(f'Computer turn [%s]' % c_choice)
        render(board, c_choice, h_choice)
        print('YOU LOSE!')
    else:
        clean()
        render(board, c_choice, h_choice)
        print('DRAW!')

    exit()


if __name__ == '__main__':
    main()
    
    
