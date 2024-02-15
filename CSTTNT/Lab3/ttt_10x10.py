from math import inf as infinity
from random import choice
import os
import time

HUMAN = -1
COMP = +1
board = [
    [0] * 10 for _ in range(10)
]

def evaluate(state):
    if wins(state, COMP):
        score = +1
    elif wins(state, HUMAN):
        score = -1
    else:
        score = 0

    return score

def wins(state, player):
    for i in range(10):
        for j in range(6):
            if all(state[i][j + k] == player for k in range(5)):
                return True
    for i in range(10):
        for j in range(6):
            if all(state[j + k][i] == player for k in range(5)):
                return True
    for i in range(6):
        for j in range(6):
            if all(state[i + k][j + k] == player for k in range(5)):
                return True
            if all(state[i + k][9 - j - k] == player for k in range(5)):
                return True
    return False

def game_over(state):
    return wins(state, HUMAN) or wins(state, COMP)

def empty_cells(state):
    cells = []
    for x, row in enumerate(state):
        for y, cell in enumerate(row):
            if cell == 0:
                cells.append([x, y])
    return cells

def valid_move(x, y):
    return [x, y] in empty_cells(board)

def set_move(x, y, player):
    if valid_move(x, y):
        board[x][y] = player
        return True
    return False

def iterative_deepening_ab(state, player, max_depth):
    best_move = [-1, -1, -infinity]
    for depth in range(1, max_depth + 1):
        move = alpha_beta(state, player, depth, -infinity, infinity)
        best_move = max(best_move, move, key=lambda x: x[2])
    return best_move

def alpha_beta(state, player, depth, alpha, beta):
    if depth == 0 or game_over(state):
        return [-1, -1, evaluate(state)]

    moves = empty_cells(state)
    if player == COMP:
        v = -infinity
        for move in moves:
            x, y = move[0], move[1]
            state[x][y] = COMP
            score = alpha_beta(state, HUMAN, depth - 1, alpha, beta)
            state[x][y] = 0
            v = max(v, score[2])
            alpha = max(alpha, v)
            if beta <= alpha:
                break
        return [x, y, v]
    else:
        v = infinity
        for move in moves:
            x, y = move[0], move[1]
            state[x][y] = HUMAN
            score = alpha_beta(state, COMP, depth - 1, alpha, beta)
            state[x][y] = 0
            v = min(v, score[2])
            beta = min(beta, v)
            if beta <= alpha:
                break
        return [x, y, v]

def clean():
    os.system('cls' if os.name == 'nt' else 'clear')

def render(state, c_choice, h_choice):
    chars = {
        -1: h_choice,
        +1: c_choice,
        0: ' '
    }
    str_line = '-' * 64
    print('\n' + str_line)
    for row in state:
        for cell in row:
            symbol = chars[cell]
            print(f'| {symbol} ', end='')
        print('|\n' + str_line)

def ai_turn(c_choice, h_choice):
    depth = len(empty_cells(board))
    if depth == 0 or game_over(board):
        return

    clean()
    print('Computer turn [%s]' % c_choice)
    render(board, c_choice, h_choice)

    if depth == 100:
        x = choice(range(10))
        y = choice(range(10))
    else:
        start_time = time.time()
        move = iterative_deepening_ab(board, COMP, depth)
        end_time = time.time()
        print(f"Time taken for AI's turn: {end_time - start_time} seconds")
        x, y = move[0], move[1]

    set_move(x, y, COMP)
    time.sleep(1)

def human_turn(c_choice, h_choice):
    depth = len(empty_cells(board))
    if depth == 0 or game_over(board):
        return

    move = -1
    moves = {
        i + 1: [i // 10, i % 10] for i in range(100)
    }

    clean()
    print(f'Human turn [%s]' % h_choice)
    render(board, c_choice, h_choice)

    while move < 1 or move > 100:
        try:
            move = int(input('Use numpad (1..100): '))
            if move < 1 or move > 100:
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
