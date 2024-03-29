import random
from abc import ABC, abstractmethod


class Producer(ABC):
    def __init__(self, name):
        self._name = name

    @abstractmethod
    def create_food_source_in(self, location):
        pass

    @abstractmethod
    def harvest(self, product):
        pass

    @abstractmethod
    def send(self, product):
        pass


class Farmer(Producer):
    def __init__(self, name):
        super().__init__(name)

    def create_food_source_in(self, location):
        print(f"{self._name} plants a field in {location}.")

    def harvest(self, product):
        print(f"{self._name} harvests {product} from field.")

    def send(self, product):
        print(f"{self._name} sends {product} to the factory.")


class Gardener(Producer):
    def __init__(self, name):
        super().__init__(name)

    def create_food_source_in(self, location):
        print(f"{self._name} plants a garden in {location}.")

    def harvest(self, product):
        print(f"{self._name} harvests {product} from garden.")

    def send(self, product):
        print(f"{self._name} sends {product} to the market.")


class FarmLand:
    def __init__(self, location):
        self._location = location

    @abstractmethod
    def create_producer(self):
        pass

    def grow_food(self, product):
        producer = self.create_producer()
        producer.create_food_source_in(self._location)
        producer.harvest(product)
        producer.send(product)


class Field(FarmLand):
    def __init__(self, location):
        super().__init__(location)
        self._farmers = [Farmer("Anna"), Farmer("Bea"), Farmer("Chloe")]

    def create_producer(self):
        return random.choice(self._farmers)


class Garden(FarmLand):
    def __init__(self, location):
        super().__init__(location)
        self._gardeners = [Gardener("Dan"), Gardener("Eddie"), Gardener("Finn")]

    def create_producer(self):
        return random.choice(self._gardeners)
